using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObjectReport
{
    public partial class TrAcc_Danh_GetColunmTinhLuongNhanvienModel : Bus
    {
 		public TrAcc_Danh_GetColunmTinhLuongNhanvienModel()
        {
        }
        public TrAcc_Danh_GetColunmTinhLuongNhanvienModel(AutoObject value)
        {
            DataFromAutoObject(value);
        }
        
        [DisplayName("Ma")]
        public String Ma{get;set;}
        
        
        [DisplayName("Ten")]
        public String Ten{get;set;}
        
        
        [DisplayName("Width")]
        public Int32 Width{get;set;}
        
        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "Ma", Value = Ma, SqlType = SqlDbType.VarChar});
            Items.Add(new AutoItem {Name = "Ten", Value = Ten, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Width", Value = Width, SqlType = SqlDbType.Int});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            return "TrAcc_Danh_GetColunmTinhLuongNhanvien";
        }
    }
}