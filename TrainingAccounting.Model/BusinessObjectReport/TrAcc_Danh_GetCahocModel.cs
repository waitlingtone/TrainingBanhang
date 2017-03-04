using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObjectReport
{
    public partial class TrAcc_Danh_GetCahocModel : Bus
    {
 		public TrAcc_Danh_GetCahocModel()
        {
        }
        public TrAcc_Danh_GetCahocModel(AutoObject value)
        {
            DataFromAutoObject(value);
        }
        
        [DisplayName("TenCa")]
        public String TenCa{get;set;}
        
        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "TenCa", Value = TenCa, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            return "TrAcc_Danh_GetCahoc";
        }
    }
}