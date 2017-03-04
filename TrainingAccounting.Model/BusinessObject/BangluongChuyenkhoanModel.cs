using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "BangluongChuyenkhoan",
        spSelect = "sys_BangluongChuyenkhoanSelect",
        spInsert = "sys_BangluongChuyenkhoanInsert",
        spUpdate = "sys_BangluongChuyenkhoanUpdate",
        spDelete = "sys_BangluongChuyenkhoanDelete")]
    public partial class BangluongChuyenkhoanModel : Bus
    {
        private Guid _BangluongChuyenkhoanId;
        private Nullable<Guid> _NhanvienId;
        private Nullable<Int32> _Thang;
        private Nullable<Int32> _Nam;
        private Nullable<Double> _Sotien;
        private String _Noidung;
        private String _SoTaikhoan;
        private String _TenNganhang;
        private String _ChinhanhNganhang;
        private String _Diachi;

        public BangluongChuyenkhoanModel()
        {
			OnCreating();
            BangluongChuyenkhoanId = ModelCore.GetGuidId();
			OnCreated();
        }

        public BangluongChuyenkhoanModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("BangluongChuyenkhoanId")]
	    [Column(Name="BangluongChuyenkhoanId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid BangluongChuyenkhoanId
        {
            get
			{
				Guid vGet = _BangluongChuyenkhoanId;
				OnBangluongChuyenkhoanIdGetting(ref _BangluongChuyenkhoanId, ref vGet);
				return vGet;
			}
            set
            {
                OnBangluongChuyenkhoanIdChanging(value);
                SetProperty(ref _BangluongChuyenkhoanId, value);
                OnBangluongChuyenkhoanIdChanged();
            }
        }
        
        
        [DisplayName("NhanvienId")]
	    [Column(Name="NhanvienId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> NhanvienId
        {
            get
			{
				Nullable<Guid> vGet = _NhanvienId;
				OnNhanvienIdGetting(ref _NhanvienId, ref vGet);
				return vGet;
			}
            set
            {
                OnNhanvienIdChanging(value);
                SetProperty(ref _NhanvienId, value);
                OnNhanvienIdChanged();
            }
        }
        
        
        [DisplayName("Thang")]
	    [Column(Name="Thang",SqlType=SqlDbType.Int)]
        public Nullable<Int32> Thang
        {
            get
			{
				Nullable<Int32> vGet = _Thang;
				OnThangGetting(ref _Thang, ref vGet);
				return vGet;
			}
            set
            {
                OnThangChanging(value);
                SetProperty(ref _Thang, value);
                OnThangChanged();
            }
        }
        
        
        [DisplayName("Nam")]
	    [Column(Name="Nam",SqlType=SqlDbType.Int)]
        public Nullable<Int32> Nam
        {
            get
			{
				Nullable<Int32> vGet = _Nam;
				OnNamGetting(ref _Nam, ref vGet);
				return vGet;
			}
            set
            {
                OnNamChanging(value);
                SetProperty(ref _Nam, value);
                OnNamChanged();
            }
        }
        
        
        [DisplayName("Sotien")]
	    [Column(Name="Sotien",SqlType=SqlDbType.Float)]
        public Nullable<Double> Sotien
        {
            get
			{
				Nullable<Double> vGet = _Sotien;
				OnSotienGetting(ref _Sotien, ref vGet);
				return vGet;
			}
            set
            {
                OnSotienChanging(value);
                SetProperty(ref _Sotien, value);
                OnSotienChanged();
            }
        }
        
        
        [DisplayName("Noidung")]
	    [Column(Name="Noidung",SqlType=SqlDbType.NVarChar)]
        public String Noidung
        {
            get
			{
				String vGet = _Noidung;
				OnNoidungGetting(ref _Noidung, ref vGet);
				return vGet;
			}
            set
            {
                OnNoidungChanging(value);
                SetProperty(ref _Noidung, value);
                OnNoidungChanged();
            }
        }
        
        
        [DisplayName("SoTaikhoan")]
	    [Column(Name="SoTaikhoan",SqlType=SqlDbType.NVarChar)]
        public String SoTaikhoan
        {
            get
			{
				String vGet = _SoTaikhoan;
				OnSoTaikhoanGetting(ref _SoTaikhoan, ref vGet);
				return vGet;
			}
            set
            {
                OnSoTaikhoanChanging(value);
                SetProperty(ref _SoTaikhoan, value);
                OnSoTaikhoanChanged();
            }
        }
        
        
        [DisplayName("TenNganhang")]
	    [Column(Name="TenNganhang",SqlType=SqlDbType.NVarChar)]
        public String TenNganhang
        {
            get
			{
				String vGet = _TenNganhang;
				OnTenNganhangGetting(ref _TenNganhang, ref vGet);
				return vGet;
			}
            set
            {
                OnTenNganhangChanging(value);
                SetProperty(ref _TenNganhang, value);
                OnTenNganhangChanged();
            }
        }
        
        
        [DisplayName("ChinhanhNganhang")]
	    [Column(Name="ChinhanhNganhang",SqlType=SqlDbType.NVarChar)]
        public String ChinhanhNganhang
        {
            get
			{
				String vGet = _ChinhanhNganhang;
				OnChinhanhNganhangGetting(ref _ChinhanhNganhang, ref vGet);
				return vGet;
			}
            set
            {
                OnChinhanhNganhangChanging(value);
                SetProperty(ref _ChinhanhNganhang, value);
                OnChinhanhNganhangChanged();
            }
        }
        
        
        [DisplayName("Diachi")]
	    [Column(Name="Diachi",SqlType=SqlDbType.NVarChar)]
        public String Diachi
        {
            get
			{
				String vGet = _Diachi;
				OnDiachiGetting(ref _Diachi, ref vGet);
				return vGet;
			}
            set
            {
                OnDiachiChanging(value);
                SetProperty(ref _Diachi, value);
                OnDiachiChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnBangluongChuyenkhoanIdChanging(Guid value);
        partial void OnBangluongChuyenkhoanIdChanged();
		partial void OnBangluongChuyenkhoanIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnNhanvienIdChanging(Nullable<Guid> value);
        partial void OnNhanvienIdChanged();
		partial void OnNhanvienIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnThangChanging(Nullable<Int32> value);
        partial void OnThangChanged();
		partial void OnThangGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNamChanging(Nullable<Int32> value);
        partial void OnNamChanged();
		partial void OnNamGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnSotienChanging(Nullable<Double> value);
        partial void OnSotienChanged();
		partial void OnSotienGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnNoidungChanging(String value);
        partial void OnNoidungChanged();
		partial void OnNoidungGetting(ref String value, ref String vGet);
        
        
        partial void OnSoTaikhoanChanging(String value);
        partial void OnSoTaikhoanChanged();
		partial void OnSoTaikhoanGetting(ref String value, ref String vGet);
        
        
        partial void OnTenNganhangChanging(String value);
        partial void OnTenNganhangChanged();
		partial void OnTenNganhangGetting(ref String value, ref String vGet);
        
        
        partial void OnChinhanhNganhangChanging(String value);
        partial void OnChinhanhNganhangChanged();
		partial void OnChinhanhNganhangGetting(ref String value, ref String vGet);
        
        
        partial void OnDiachiChanging(String value);
        partial void OnDiachiChanged();
		partial void OnDiachiGetting(ref String value, ref String vGet);
        
    }
}