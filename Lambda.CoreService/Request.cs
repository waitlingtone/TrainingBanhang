using Lambda.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.CoreService
{
    [DataContract]
    public class Request
    {
        [DataMember]
        public string AppCSName;
        [DataMember]
        public string Serial = "";

        [DataMember]
        public string AccessToken = "";
        //[DataMember]
        //public LoginRequest LoginInfo;
        [DataMember]
        public string RequestId = "";
        
        /// <summary>
        /// This property is used for setter,
        /// The list run in a transaction
        /// </summary>
        [DataMember]
        public AutoObject DataItem;//Parameter for Sp
        [DataMember]
        public long MinuteToCache=60;
        [DataMember]
        public bool Caching = false;
        [DataMember]
        public List<AutoObject> DataItems;
        
        [DataMember]
        public string Checksum;
    }
}
