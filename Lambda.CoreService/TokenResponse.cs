using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.CoreService
{
    public class TokenResponse : Response
    {
        /// <summary>
        /// Default Constructor for TokenResponse.
        /// </summary>
        public TokenResponse() { }

        /// <summary>
        /// Overloaded Constructor for TokenResponse. Sets CorrelationId.
        /// </summary>
        /// <param Name="correlationId"></param>
        public TokenResponse(string correlationId) : base(correlationId) { }

        /// <summary>
        /// Security token returned to the consumer
        /// </summary>
        [DataMember]
        public string AccessToken;
        [DataMember]
        public bool IsEncrypt;
        [DataMember]
        public bool IsChecksum;
    }
}
