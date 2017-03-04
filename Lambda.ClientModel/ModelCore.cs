//using Lambda.AutoService;
using Lambda.BusinessObject;
using Lambda.CoreService;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.ClientModel
{
    public class ModelCore
    {
        static int _Count;

        public static int Count
        {
            get { return ModelCore._Count; }
            internal set { ModelCore._Count = value; }
        }
        static IDataService _Proxy;
        private static readonly object syncRoot = new Object();
        public static IDataService Proxy
        {
            get
            {
                lock (syncRoot)
                {
                    //if ((_Proxy == null) || (_Proxy != null && typeof(Lambda.AutoService.DataService) != _Proxy.GetType() && ((IClientChannel)_Proxy).State == CommunicationState.Faulted))
                    if ((_Proxy == null) || (_Proxy != null && typeof(IDataService) != _Proxy.GetType().GetInterface("IDataService") && ((IClientChannel)_Proxy).State == CommunicationState.Faulted))
                    {
                        _Proxy = Factories.Proxy;
                        return _Proxy;
                    }
                    return _Proxy;
                }
            }
        }

        internal static void MakeToken(IDataService proxy)
        {
            var response = proxy.GetToken(new TokenRequest
            {
                Serial = ConfigService.Instance.Serial,
                AppCSName = ConfigService.Instance.AppCSName
            });
            AccessToken = response.AccessToken;
            IsLogin = false;
            ConfigService.Instance.IsEncrypt = response.IsEncrypt;
            ConfigService.Instance.IsCheckSum = response.IsChecksum;
        }
        static string AccessToken { get; set; }

        static ConfigService ConfigServiceInstance
        {
            get
            {
                return ConfigService.Instance;
            }
        }

        public static void SetDefaultLocalConfig()
        {
            _Proxy = null;
            ConfigServiceInstance.SelectModelType = ModelType.Local;
            ConfigServiceInstance.IsCheck = false;
            ConfigServiceInstance.IsEncrypt = false;
            ConfigServiceInstance.IsCheckSum = false;
            MakeToken(Proxy);
        }
        public static void SetDefaultServiceConfig()
        {
            _Proxy = null;
            ConfigServiceInstance.SelectModelType = ModelType.Service;
            MakeToken(Proxy);
        }

        #region Login
        protected LoginRequest LoginRequestInfo
        {
            get
            {
                var u = username;
                var p = password;
                if (u == null && p == null)
                {
                    u = ConfigServiceInstance.Username;
                    p = ConfigServiceInstance.Password;
                }
                var user = Lambda.Framework.AutoEncrypt.MD5Hash(u);
                var pass = Lambda.Framework.AutoEncrypt.MD5Hash(p);
                LoginRequest request = new LoginRequest();
                EncryptRSALogin(user, pass, request);
                return request;
            }
        }
        static protected LoginResponse LoginResult;
        public static object UserId
        {
            get { return LoginResult.UserId; }
        }

        static bool _IsLogin = false;
        public static bool IsLogin
        {
            get { return _IsLogin; }
            private set { _IsLogin = value; }
        }
        public void Login(string username, string password)
        {
            var u = ConfigServiceInstance.Username;
            var p = ConfigServiceInstance.Password;
            try
            {
                ConfigServiceInstance.Username = username;
                ConfigServiceInstance.Password = password;
                LogoutOneTimes();
                IsLogin = false;
                Login();
            }
            catch (Exception ex)
            {
                ConfigServiceInstance.Username = u;
                ConfigServiceInstance.Password = p;
                throw ex;
            }
        }
        public void Logout()
        {
            IsLogin = false;
            ConfigServiceInstance.Username = null;
            ConfigServiceInstance.Password = null;
        }
        
        string username;
        string password;
        public void LoginOneTimes(string username, string password)
        {
            this.username = username;
            this.password = password;
            var response = Login(LoginRequestInfo);
            if (response.Acknowledge == AcknowledgeType.Failure)
            {
                this.LogoutOneTimes();
                throw new Exception(response.Message);
            }
        }
        public void LogoutOneTimes()
        {
            this.username = null;
            this.password = null;
        }
        void Login()
        {
            var response = Login(LoginRequestInfo);
            if (response.Acknowledge == AcknowledgeType.Failure)
            {
                throw new Exception(response.Message);
            }
            
            LoginResult = response;
            _IsLogin = true;
        }
        void EncryptRSALogin(string username, string password, LoginRequest request)
        {
            if (ConfigServiceInstance.IsEncrypt == false)
            {
                request.Username = username;
                request.Password = password;
                return;
            }
            string RSAusername = Lambda.Framework.AutoEncrypt.RSAEncrypt(username, ConfigServiceInstance.PublicKey);
            string RSApassword = Lambda.Framework.AutoEncrypt.RSAEncrypt(password, ConfigServiceInstance.PublicKey);
            request.Username = RSAusername;
            request.Password = RSApassword;
        }
        void MakeChecksum(Request request)
        {
            if (ConfigServiceInstance.IsCheckSum == true)
                request.Checksum = CheckSum.MakeChecksum(request.DataItems, request.AccessToken);
        }
        #endregion

        #region Set, Get
        //public static List<T> CreateListBus<T>(List<AutoObject> items) where T : Bus
        //{
        //    List<T> listBus = new List<T>();
        //    for (int i = 0; i < items.Count; i++)
        //    {
        //        T x = (T)Activator.CreateInstance(typeof(T), items[i]);
        //        x.MakeUnchange();
        //        listBus.Add(x);
        //    }
        //    return listBus;
        //}
        //public static List<AutoObject> CreateListAuto<T>(List<T> listBus) where T : Bus
        //{
        //    var listAuto = new List<AutoObject>();
        //    for (int i = 0; i < listBus.Count; i++)
        //    {
        //        listAuto.Add(listBus[i].DataToAutoObject());
        //    }
        //    return listAuto;
        //}
        //public static List<T> GetListWithState<T>(List<T> listBus, RowState state) where T : Bus
        //{
        //    var result = new List<T>();
        //    for (int i = 0; i < listBus.Count; i++)
        //        if ((listBus[i].State & state) == listBus[i].State)
        //            result.Add(listBus[i]);
        //    return result;
        //}
        //static List<AutoObject> CreateListAutoParams<T>(params List<T>[] arraylistBus) where T : Bus
        //{
        //    var result = new List<AutoObject>();
        //    for (int i = 0; i < arraylistBus.Length; i++)
        //    {
        //        //result.AddRange(CreateListAuto(GetListWithState(arraylistBus[i],RowState.Insert | RowState.Update | RowState.Delete)));
        //        var tmp = BusinessAction.GetBusinessObjectWithState(arraylistBus[i], RowState.Insert | RowState.Update | RowState.Delete);
        //        result.AddRange(BusinessAction.ToAutoObject(tmp));
        //    }
        //    return result;
        //}
        #region Get
        public List<T> Get<T>(AutoObject item, bool? isCache = null, long? MinuteToCache = null) where T : Bus
        {
            //return CreateListBus<T>(GetInvoke(item,isCache,MinuteToCache));
            var result = GetInvoke(item, isCache, MinuteToCache);
            return BusinessAction.ToBusinessObject<T>(result);
        }
        public List<T> Get<T>(string SpName, bool? isCache = null, long? MinuteToCache = null) where T : Bus
        {
            return Get<T>(new AutoObject { SpName = SpName },isCache,MinuteToCache);
        }
        public List<AutoObject> GetAutoObject(AutoObject item, bool? isCache = null, long? MinuteToCache = null)
        {
            return GetInvoke(item, isCache, MinuteToCache);
        }
        public List<AutoObject> GetAutoObject(string SpName, bool? isCache = null, long? MinuteToCache = null)
        {
            return GetInvoke(new AutoObject { SpName = SpName }, isCache, MinuteToCache);
        }
        #endregion

        #region Set
        protected Response SetInvoke(AutoObject item, string KeyService = null)
        {
            return SetInvoke(new List<AutoObject> { item }, KeyService);
        }
        public int SetAutoObject(AutoObject item, string KeyService = null)
        {
            var response = SetInvoke(item, KeyService);
            return response.RowsAffected;
        }
        public int SetAutoObject(List<AutoObject> items, string KeyService = null)
        {
            var response = SetInvoke(items, KeyService);
            return response.RowsAffected;
        }
        public int Set<T>(T item, string KeyService = null) where T : Bus
        {
            return Set<T>(new List<T> { item }, KeyService);
        }
        public int Set<T>(List<T> listBus, string KeyService = null) where T : Bus
        {
            var listSet = BusinessAction.GetBusinessObjectWithState<T>(listBus, RowState.Insert | RowState.Update | RowState.Delete);
            var listSetAuto = BusinessAction.ToAutoObject(listSet);//var listSetAuto = CreateListAuto(listSet);

            var listDelete = BusinessAction.GetBusinessObjectWithState<T>(listSet, RowState.Delete);
            var listIU = BusinessAction.GetBusinessObjectWithState<T>(listSet, RowState.Insert | RowState.Update);
            var response = SetInvoke(listSetAuto, KeyService);

            for (int i = 0; i < listDelete.Count; i++)
            {
                listBus.Remove(listDelete[i]);
            }

            for (int i = 0; i < listIU.Count; i++)
            {
                listIU[i].DataFromAutoObject(response.DataItems[i]);
                listIU[i].MakeUnchange();
            }

            return response.RowsAffected;
        }
        public int SetTransaction(AutoObjectTransaction item, string KeyService = null)
        {
            var response = SetInvoke(item.ListAuto, KeyService);
            item.Clear();
            return response.RowsAffected;
        }
        #endregion

        #region Get DataTable
        public DataTable GetDataTable(string spName, bool? isCache = null, long? MinuteToCache = null)
        {
            return GetDataTable(new AutoObject {SpName = spName },isCache,MinuteToCache);
        }
        public DataTable GetDataTable(AutoObject item, bool? isCache = null, long? MinuteToCache = null)
        {
            return DataTableFromAutoObject(GetInvoke(item), item.SpName);
        }
        DataTable DataTableFromAutoObject(List<AutoObject> items, string tableName)
        {
            if (items == null || items.Count == 0)
                return null;
            // Create the output table.
            DataTable result = new DataTable(tableName);
            var item = items[0].Items;
            for (int i = 0; i < item.Count; i++)
            {
                result.Columns.Add(item[i].Name, Type.GetType(item[i].CSharpType));
            }
            for (int i = 0; i < items.Count; i++)
                result.Rows.Add();
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < items[i].Items.Count; j++)
                {
                    var value = items[i].Items[j].Value;
                    if (value != null)
                        result.Rows[i][j] = items[i].Items[j].Value;
                    else
                        result.Rows[i][j] = System.DBNull.Value;
                }
            }
            result.AcceptChanges();
            return result;
        }
        #endregion

        #endregion

        #region Vitual method must overide, use Proxy (Proxy)
        protected virtual void PreRequest(Request request, bool? isCache = null, long? MinuteToCache = null)
        {
            if (ConfigServiceInstance.Username == null || ConfigServiceInstance.Password == null)
            {
                throw new Exception("Cần phải login");
            }
            if (!(request is LoginRequest) && IsLogin == false)
            {
                Login();
            }
            if (isCache == null)
            {
                isCache = ConfigServiceInstance.IsCache;
                // BMIConfig.Instance.IsCache;// false;
            }
            if (MinuteToCache == null)
            {
                MinuteToCache = ConfigServiceInstance.MinuteToCache;
                // BMIConfig.Instance.MinuteToCache;// 60;
            }
            request.Serial = ConfigServiceInstance.Serial;
            request.AppCSName = ConfigServiceInstance.AppCSName;
            //request.LoginInfo = LoginRequestInfo;
            request.Caching = isCache.Value;
            request.MinuteToCache = MinuteToCache.Value;
            request.RequestId = Guid.NewGuid().ToString();
            request.AccessToken = AccessToken;
            
        }
        protected virtual Response SetInvoke(List<AutoObject> items, string KeyService = null)
        {
            var p = Proxy;
            Request request = new Request();
            request.DataItems = items;
            request.DataItem = new AutoObject { KeyService = KeyService };
            PreRequest(request);
            MakeChecksum(request);
            var response = p.SetData(request);
            if (response.Acknowledge == AcknowledgeType.Failure)
            {
                throw new Exception(response.Message);
            }
            if (request.RequestId != response.CorrelationId)
            {
                throw new Exception(string.Format("ReservationId:{0}", response.ReservationId));
            }
            return response;
        }
        protected virtual List<AutoObject> GetInvoke(AutoObject item, bool? isCache = null, long? MinuteToCache = null)
        {
            var p = Proxy;
            Request request = new Request();
            request.DataItem = item;
            PreRequest(request,isCache,MinuteToCache);
            var response = p.GetData(request);
            if (response.Acknowledge == AcknowledgeType.Failure)
            {
                throw new Exception(response.Message);
            }
            if (request.RequestId != response.CorrelationId)
            {
                throw new Exception(string.Format("ReservationId:{0}", response.ReservationId));
            }
            return response.DataItems;
        }
        protected virtual LoginResponse Login(LoginRequest request)
        {
            var p = Proxy;
            PreRequest(request);
            return p.Login(request);
        }

        public static DateTime GetDateTime()
        {
            var data = Proxy.GetDateTime();
            return data;
        }
        public static long GetLongId()
        {
            var data = Proxy.GetLongId();
            return data;
        }
        public static Guid GetGuidId()
        {
            var data = Proxy.GetGuidId();
            return data;
        }
        #endregion
    }
}
