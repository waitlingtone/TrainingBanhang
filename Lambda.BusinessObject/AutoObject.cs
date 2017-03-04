using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.BusinessObject
{
    [DataContract]
    public class AutoObject
    {
        [DataMember]
        public RowState State;// = RowState.Insert;
        [DataMember]
        public string KeyService;

        [DataMember]
        public string TypeName;
        [DataMember]
        public string SpName;
        [DataMember]
        public List<AutoItem> Items;
    }
}
