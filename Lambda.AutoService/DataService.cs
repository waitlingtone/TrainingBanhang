using Lambda.CoreService;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.AutoService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public partial class DataService : IDataService
    {
        //String id;
        static List<String> _list;
        public static List<String> list
        {
            get
            {
                if(_list == null)
                    _list= new List<String>();
                return _list;
            }
        }
        /// <summary>
        /// coi chừng Local không có tham số
        /// </summary>
        public DataService()
        {
            //id = OperationContext.Current.SessionId;
            //list.Add(id);
        }

        public class ConfigParam
        {
            public static bool IsCheck = ConfigService.Instance.IsCheck;// false;
            public static bool IsEncrypt = ConfigService.Instance.IsEncrypt;
            public static bool IsChecksum = ConfigService.Instance.IsCheckSum;

            /// <summary>
            /// String Sql Function
            /// </summary>
            public static string spCheckLogin = "dbo.CheckLogin";
            public static string spGetKey = "dbo.GetKey";
            public static string spCheckSerial = "dbo.CheckSerial";
            public static string spCheckPermission = "dbo.CheckPermission";

        }
        string _AccessTokenCurrent;

        public string AccessTokenCurrent
        {
            get
            {
                if (string.IsNullOrEmpty(_AccessTokenCurrent))
                    _AccessTokenCurrent = Guid.NewGuid().ToString();
                return _AccessTokenCurrent;
            }
        }
        
        public long GetLongId()
        {
            return SimpleData.Instance.GetLongId();
        }

        public Guid GetGuidId()
        {
            return SimpleData.Instance.GetGuidId();
        }
        
        public DateTime GetDateTime()
        {
            return SimpleData.Instance.GetDateTime();
        }

        public TokenResponse GetToken(TokenRequest request)
        {
            _AccessTokenCurrent = null;
            var response = new TokenResponse(request.RequestId);
            if (!ValidRequest(request, response, Validate.Serial))
                return response;
            response.AccessToken = AccessTokenCurrent;
            response.IsEncrypt = ConfigParam.IsEncrypt;
            response.IsChecksum = ConfigParam.IsChecksum;
            return response;
        }
        public LoginResponse Login(LoginRequest request)
        {
            var response = new LoginResponse(request.RequestId);
            ValidRequest(request, response, Validate.Serial | Validate.AccessToken | Validate.UserCredentials);
            return response;
        }
        private void DecryptLogin(LoginRequest request)
        {
            if (ConfigParam.IsEncrypt == false)
                return;
            object privatekey = Lambda.DataObject.AutoDao.ExeFunction(request.AppCSName,ConfigParam.spGetKey, request.Serial);
            request.Username = Lambda.Framework.AutoEncrypt.RSADecrypt(request.Username, privatekey.ToString());
            request.Password = Lambda.Framework.AutoEncrypt.RSADecrypt(request.Password, privatekey.ToString());
        }
        #region ---
        partial void OnGetting(Request request, Response response);
        partial void OnGetted(Request request, Response response);
        #endregion
        public Response GetData(Request request)
        {
            Response response = new Response(request.RequestId);
            #region OnGetting
            OnGetting(request, response);
            if (response.Acknowledge == AcknowledgeType.Failure)
            {
                return response;
            }
            if (!ValidRequest(request, response, Validate.Serial | Validate.AccessToken | Validate.UserCredentials))
                return response;
            #endregion  
            try
            {
                //var result = Lambda.DataObject.AutoDao.ExecuteQuery(request.AppCSName,request.DataItem,request.Caching,request.MinuteToCache);
                if (request.DataItem != null)
                {
                    var result = Lambda.DataObject.AutoExecute.ExecuteGetData(request);
                    response.DataItems = result;
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Acknowledge = AcknowledgeType.Failure;
            }
            OnGetted(request, response);
            return response;
        }
        #region ---
        partial void OnSetting(Request request, Response response);
        partial void OnSetted(Request request, Response response);
        #endregion
        public Response SetData(Request request)
        {
            Response response = new Response(request.RequestId);
            #region OnSetting
            OnSetting(request, response);
            if (response.Acknowledge == AcknowledgeType.Failure)
            {
                return response;
            }
            if (!ValidRequest(request, response, Validate.All))
                return response;
            #endregion
            try
            {
                int rowAff = 0;
                if (request.DataItems != null && request.DataItems.Count > 0)
                {
                    //rowAff = Lambda.DataObject.AutoDao.ExeNonQuery(request.AppCSName, request.DataItems);
                    rowAff = Lambda.DataObject.AutoExecute.ExecuteSetData(request);
                }
                response.RowsAffected = rowAff;
                response.DataItems = request.DataItems;//Chuyển dữ liệu đã được cập nhật Version
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Acknowledge = AcknowledgeType.Failure;
                return response;
            }
            OnSetted(request, response);
            return response;
        }
        #region System Validate
        protected bool ValidRequest(Request request, Response response, Validate validate)
        {
            #region Validate user credentials
            if ((Validate.UserCredentials & validate) == Validate.UserCredentials)
            {
                if (request is LoginRequest)
                {
                    var result = UserCredentials(request as LoginRequest, response);
                    if (result == false)
                        return false;
                }
                else
                {
                    var result = UserCredentials(request);
                    if (result == false)
                        return false;
                }
            }
            //if ((Validate.UserCredentials & validate) == Validate.UserCredentials)
            //{
            //    LoginRequest loginPara = request.LoginInfo;
            //    if (request is LoginRequest)
            //        loginPara = request as LoginRequest;
            //    loginPara.AppCSName = request.AppCSName;
            //    var result = UserCredentials(loginPara, response);
            //    if (result == false)
            //        return false;
            //}
            #endregion

            #region Vailidate AccessToken
            if ((Validate.AccessToken & validate) == Validate.AccessToken)
            {
                if (string.IsNullOrEmpty(request.AccessToken) || request.AccessToken != AccessTokenCurrent)
                {
                    response.Acknowledge = AcknowledgeType.Failure;
                    response.Message = "Invalid or expired AccessToken. Call GetToken()";
                    return false;
                }
            }
            #endregion
            ///---------------------
            if (ConfigParam.IsCheck == false)
                return true;

            #region  Validate clientTAg
            if ((Validate.Serial & validate) == Validate.Serial)
            {
                var result = CheckSerial(request, response);
                if (result == false)
                    return false;
            }
            #endregion
            
            #region Vaildate Checksum
            if ((Validate.Checksum & validate) == Validate.Checksum)
            {
                var result = Checksum(request, response);
                if (result == false)
                    return false;
            }
            #endregion 

            #region Validate permission
            if ((Validate.Permission & validate) == Validate.Permission)
            {
                var result = CheckPermission(request, response);
                if (result == false)
                    return false;
            }
            #endregion

            return true;
        }

        private bool CheckPermission(Request request, Response response)
        {
            try
            {
                foreach (var item in request.DataItems)
                {
                    object s = Lambda.DataObject.AutoDao.ExeFunction(request.AppCSName,ConfigParam.spCheckPermission, /*request.LoginInfo.*/Username, item.SpName);
                    if (Convert.ToBoolean(s) == false)
                    {
                        response.Acknowledge = AcknowledgeType.Failure;
                        response.Message = "Bạn không có quyền hạn thực thi";
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = string.Format("Exception Permission: {0}", ex.Message);
                return false;
            }
        }
        string Username;
        string Password;
        private bool UserCredentials(Request request)
        {
            object UserId = Lambda.DataObject.AutoDao.ExeFunction(request.AppCSName, ConfigParam.spCheckLogin, Username, Password);
            if (UserId == null || string.IsNullOrEmpty(UserId.ToString()))
            {
                return false;
            }
            return true;
        }
        private bool UserCredentials(LoginRequest request, Response response)
        {
            try
            {
                if (request != null)
                {
                    DecryptLogin(request);
                    if (string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
                    {
                        response.Acknowledge = AcknowledgeType.Failure;
                        response.Message = "Login Fail";
                        return false;
                    }
                    object UserId = Lambda.DataObject.AutoDao.ExeFunction(request.AppCSName, ConfigParam.spCheckLogin, request.Username, request.Password);
                    if (UserId == null || string.IsNullOrEmpty(UserId.ToString().Trim()))
                    {
                        response.Acknowledge = AcknowledgeType.Failure;
                        response.Message = "Login Fail";
                        return false;
                    }
                    if (response is LoginResponse)
                    {
                        var loginResponse = response as LoginResponse;
                        loginResponse.UserId = UserId;
                    }
                }
                else
                {
                    response.Acknowledge = AcknowledgeType.Failure;
                    response.Message = "Login Fail";
                    return false;
                }
                Username = request.Username;
                Password = request.Password;
                return true;
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = string.Format("Exception UserCredentials: {0}", ex.Message);
                return false;
            }
        }
        private bool Checksum(Request request, Response response)
        {
            try
            {
                if (string.IsNullOrEmpty(request.Checksum))
                {
                    response.Acknowledge = AcknowledgeType.Failure;
                    response.Message = "Checksum Fail";
                    return false;
                }
                var checksumcalc = Lambda.BusinessObject.CheckSum.MakeChecksum(request.DataItems, request.AccessToken);
                if (checksumcalc != request.Checksum)
                {
                    response.Acknowledge = AcknowledgeType.Failure;
                    response.Message = "Checksum Fail. ";
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = string.Format("Exception Checksum: {0}", ex.Message);
                return false;
            }
        }
        private bool CheckSerial(Request request, Response response)
        {
            try
            {
                if (!string.IsNullOrEmpty(request.Serial))
                {
                    object s = Lambda.DataObject.AutoDao.ExeFunction(request.AppCSName, ConfigParam.spCheckSerial, request.Serial);
                    if (Convert.ToBoolean(s) == false)
                    {
                        response.Acknowledge = AcknowledgeType.Failure;
                        response.Message = "Unknow Serial, Contact me at 09xxxx";
                        return false;
                    }
                    return true;
                }
                else
                {
                    response.Acknowledge = AcknowledgeType.Failure;
                    response.Message = "Unknow Serial, Contact me at 09xxxx";
                    return false;
                }
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = string.Format("Exception Serial Check: {0}", ex.Message);
                return false;
            }
        }
        #endregion
        [Flags]
        protected enum Validate
        {
            Serial = 1,
            AccessToken = 2,
            UserCredentials = 4,
            Checksum = 8,
            Permission = 16,
            IP = 32,
            All = Serial | AccessToken | UserCredentials | Checksum | Permission | IP
        }
    }
}
