using Lambda.CoreService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;


namespace Lambda.CoreService
{
    //[ServiceContract(SessionMode = SessionMode.Required)]
    [ServiceContract]
    public partial interface IDataService
    {
        [OperationContract]
        long GetLongId();
        [OperationContract]
        Guid GetGuidId();
        [OperationContract]
        [WebGet]
        DateTime GetDateTime();

        [OperationContract]
        LoginResponse Login(LoginRequest request);
        [OperationContract]
        TokenResponse GetToken(TokenRequest request);

        [OperationContract]
        Response GetData(Request request);
        [OperationContract]
        Response SetData(Request request);

    }
}
