using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObjectReport
{
    public partial class TrAcc_Danh_GetBangLuongchuyenkhoanByThangNamV2Model : Bus
    {
 		public TrAcc_Danh_GetBangLuongchuyenkhoanByThangNamV2Model()
        {
        }
        public TrAcc_Danh_GetBangLuongchuyenkhoanByThangNamV2Model(AutoObject value)
        {
            DataFromAutoObject(value);
        }
        
        [DisplayName("STT")]
        public Nullable<Int64> STT{get;set;}
        
        
        [DisplayName("TenNhanvien")]
        public String TenNhanvien{get;set;}
        
        
        [DisplayName("BangluongChuyenkhoanId")]
        public Guid BangluongChuyenkhoanId{get;set;}
        
        
        [DisplayName("NhanvienId")]
        public Nullable<Guid> NhanvienId{get;set;}
        
        
        [DisplayName("Thang")]
        public Nullable<Int32> Thang{get;set;}
        
        
        [DisplayName("Nam")]
        public Nullable<Int32> Nam{get;set;}
        
        
        [DisplayName("Sotien")]
        public Nullable<Double> Sotien{get;set;}
        
        
        [DisplayName("Noidung")]
        public String Noidung{get;set;}
        
        
        [DisplayName("SoTaikhoan")]
        public String SoTaikhoan{get;set;}
        
        
        [DisplayName("TenNganhang")]
        public String TenNganhang{get;set;}
        
        
        [DisplayName("ChinhanhNganhang")]
        public String ChinhanhNganhang{get;set;}
        
        
        [DisplayName("Diachi")]
        public String Diachi{get;set;}
        
        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "STT", Value = STT, SqlType = SqlDbType.BigInt});
            Items.Add(new AutoItem {Name = "TenNhanvien", Value = TenNhanvien, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "BangluongChuyenkhoanId", Value = BangluongChuyenkhoanId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhanvienId", Value = NhanvienId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Thang", Value = Thang, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Nam", Value = Nam, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Sotien", Value = Sotien, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Noidung", Value = Noidung, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "SoTaikhoan", Value = SoTaikhoan, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TenNganhang", Value = TenNganhang, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "ChinhanhNganhang", Value = ChinhanhNganhang, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Diachi", Value = Diachi, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            return "TrAcc_Danh_GetBangLuongchuyenkhoanByThangNamV2";
        }
    }
}