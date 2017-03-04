using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.BusinessObject
{
    [DataContract]
    public class AutoItem  
    {
        [DataMember]
        public string Name;
        [DataMember]
        public Object Value;
        [DataMember]
        public SqlDbType SqlType;
        [DataMember]
        public String CSharpType;
    }
}
