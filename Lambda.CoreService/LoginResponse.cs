using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.CoreService
{
    [DataContract]
    public class LoginResponse : Response
    {
        public LoginResponse() { }

        /// <summary>
        /// Overloaded Constructor for LoginResponse. Sets CorrelationId.
        /// </summary>
        /// <param Name="correlationId"></param>
        public LoginResponse(string correlationId) : base(correlationId) { }

        [DataMember]
        public object UserId;
        [DataMember]
        public string SessionId;
    }
}
