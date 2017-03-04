using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;
using TrainingAccounting.Model.BusinessObject;

namespace TrainingAccounting.Model.BusinessObjectReport
{
    public partial class TrAcc_Danh_GetPhieubaoHocphiByThangNamModel : Bus
    {
 		public TrAcc_Danh_GetPhieubaoHocphiByThangNamModel()
        {
        }
        public TrAcc_Danh_GetPhieubaoHocphiByThangNamModel(AutoObject value)
        {
            DataFromAutoObject(value);
        }
        
        [DisplayName("PhieubaoHocphiId")]
        public Guid PhieubaoHocphiId{get;set;}
        
        
        [DisplayName("TreId")]
        public Nullable<Guid> TreId{get;set;}
        
        
        [DisplayName("Thang")]
        public Nullable<Int32> Thang{get;set;}
        
        
        [DisplayName("Nam")]
        public Nullable<Int32> Nam{get;set;}
        
        
        [DisplayName("Sotien")]
        public Nullable<Double> Sotien{get;set;}
        
        
        [DisplayName("NgayGhino")]
        public Nullable<DateTime> NgayGhino{get;set;}
        
        
        [DisplayName("DaThanhtoan")]
        public Nullable<Boolean> DaThanhtoan{get;set;}
        
        
        [DisplayName("Step")]
        public Nullable<Int32> Step{get;set;}
        
        
        [DisplayName("Version")]
        public Byte[] Version{get;set;}
        
        
        [DisplayName("Hodem")]
        public String Hodem{get;set;}

        [DisplayName("Ten")]
        public String Ten { get; set; }
        
        
        [DisplayName("Ngaysinh")]
        public Nullable<DateTime> Ngaysinh{get;set;}
        
        
        [DisplayName("Phuhuynh")]
        public String Phuhuynh{get;set;}

        public String Hoten { get { return String.Format("{0} {1}", Hodem, Ten); } }
        public List<PhieubaoHocphi> PhieubaoHocphiItems { get; set; }

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "PhieubaoHocphiId", Value = PhieubaoHocphiId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "TreId", Value = TreId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Thang", Value = Thang, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Nam", Value = Nam, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Sotien", Value = Sotien, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "NgayGhino", Value = NgayGhino, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "DaThanhtoan", Value = DaThanhtoan, SqlType = SqlDbType.Bit});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "Hodem", Value = Hodem, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem { Name = "Ten", Value = Ten, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem {Name = "Ngaysinh", Value = Ngaysinh, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "Phuhuynh", Value = Phuhuynh, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            return "TrAcc_Danh_GetPhieubaoHocphiByThangNam";
        }
    }
}