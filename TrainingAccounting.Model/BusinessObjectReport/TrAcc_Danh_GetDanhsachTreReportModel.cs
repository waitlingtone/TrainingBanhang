using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObjectReport
{
    public partial class TrAcc_Danh_GetDanhsachTreReportModel : Bus
    {
 		public TrAcc_Danh_GetDanhsachTreReportModel()
        {
        }
        public TrAcc_Danh_GetDanhsachTreReportModel(AutoObject value)
        {
            DataFromAutoObject(value);
        }
        
        [DisplayName("STT")]
        public Nullable<Int64> STT{get;set;}
        
        
        [DisplayName("TenNhom")]
        public String TenNhom{get;set;}
        
        
        [DisplayName("TreId")]
        public Guid TreId{get;set;}
        
        
        [DisplayName("NhomTreId")]
        public Nullable<Guid> NhomTreId{get;set;}
        
        
        [DisplayName("Mavach")]
        public String Mavach{get;set;}
        
        
        [DisplayName("Hodem")]
        public String Hodem{get;set;}
        
        
        [DisplayName("Ten")]
        public String Ten{get;set;}
        
        
        [DisplayName("TenThuonggoi")]
        public String TenThuonggoi{get;set;}
        
        
        [DisplayName("Gioitinh")]
        public Nullable<Boolean> Gioitinh{get;set;}
        
        
        [DisplayName("Ngaysinh")]
        public Nullable<DateTime> Ngaysinh{get;set;}
        
        
        [DisplayName("Ghichu")]
        public String Ghichu{get;set;}
        
        
        [DisplayName("Conhoc")]
        public Nullable<Boolean> Conhoc{get;set;}
        
        
        [DisplayName("Diachi")]
        public String Diachi{get;set;}
        
        
        [DisplayName("TinhthanhId")]
        public Nullable<Guid> TinhthanhId{get;set;}
        
        
        [DisplayName("QuanhuyenId")]
        public Nullable<Guid> QuanhuyenId{get;set;}
        
        
        [DisplayName("DantocId")]
        public Nullable<Guid> DantocId{get;set;}
        
        
        [DisplayName("TongiaoId")]
        public Nullable<Guid> TongiaoId{get;set;}
        
        
        [DisplayName("Image")]
        public Byte[] Image{get;set;}
        
        
        [DisplayName("Step")]
        public Nullable<Int32> Step{get;set;}
        
        
        [DisplayName("Version")]
        public Byte[] Version{get;set;}
        
        
        [DisplayName("TenGioitinh")]
        public String TenGioitinh{get;set;}
        
        
        [DisplayName("Phuhuynh")]
        public String Phuhuynh{get;set;}
        
        
        [DisplayName("TenTinh")]
        public String TenTinh{get;set;}

        [DisplayName("Quanhuyen")]
        public String Quanhuyen { get; set; }

        [DisplayName("Dantoc")]
        public String Dantoc { get; set; }

        [DisplayName("Tongiao")]
        public String Tongiao { get; set; }

        public String StringNgaysinh { get { return Ngaysinh.Value.ToShortDateString(); } }
        
        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "STT", Value = STT, SqlType = SqlDbType.BigInt});
            Items.Add(new AutoItem {Name = "TenNhom", Value = TenNhom, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TreId", Value = TreId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhomTreId", Value = NhomTreId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Mavach", Value = Mavach, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Hodem", Value = Hodem, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Ten", Value = Ten, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TenThuonggoi", Value = TenThuonggoi, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Gioitinh", Value = Gioitinh, SqlType = SqlDbType.Bit});
            Items.Add(new AutoItem {Name = "Ngaysinh", Value = Ngaysinh, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Conhoc", Value = Conhoc, SqlType = SqlDbType.Bit});
            Items.Add(new AutoItem {Name = "Diachi", Value = Diachi, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TinhthanhId", Value = TinhthanhId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "QuanhuyenId", Value = QuanhuyenId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "DantocId", Value = DantocId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "TongiaoId", Value = TongiaoId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Image", Value = Image, SqlType = SqlDbType.Image});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "TenGioitinh", Value = TenGioitinh, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Phuhuynh", Value = Phuhuynh, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TenTinh", Value = TenTinh, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem { Name = "Quanhuyen", Value = Quanhuyen, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "Dantoc", Value = Dantoc, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "Tongiao", Value = Tongiao, SqlType = SqlDbType.NVarChar });

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            return "TrAcc_Danh_GetDanhsachTreReport";
        }
    }
}