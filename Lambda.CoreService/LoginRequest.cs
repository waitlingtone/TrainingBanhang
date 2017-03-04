using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.CoreService
{
    [DataContract]
    public class LoginRequest : Request
    {
        /// <summary>
        /// User Name credential.
        /// </summary>
        [DataMember]
        public string Username = "";

        /// <summary>
        /// Password credential.
        /// </summary>
        [DataMember]
        public string Password = "";

    }
}
