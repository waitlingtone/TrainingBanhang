using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Nhanvien",
        spSelect = "sys_NhanvienSelect",
        spInsert = "sys_NhanvienInsert",
        spUpdate = "sys_NhanvienUpdate",
        spDelete = "sys_NhanvienDelete")]
    public partial class NhanvienModel : Bus
    {
        private Byte[] _Image;
        private Guid _NhanvienId;
        private Nullable<Guid> _NganhangId;
        private Nullable<Guid> _ChinhanhNganhangiD;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _Ngaysinh;
        private Nullable<DateTime> _NgayBatdauLam;
        private Nullable<Boolean> _Gioitinh;
        private Nullable<Boolean> _ConHoatdong;
        private Nullable<Boolean> _LaGiaovien;
        private String _Email;
        private String _SoDT;
        private String _SoTaikhoan;
        private Byte[] _Version;
        private String _Mavach;
        private String _Hodem;
        private String _Ten;
        private String _Diachi;

        public NhanvienModel()
        {
			OnCreating();
            NhanvienId = ModelCore.GetGuidId();
			OnCreated();
        }

        public NhanvienModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("Image")]
	    [Column(Name="Image",SqlType=SqlDbType.Image)]
        public Byte[] Image
        {
            get
			{
				Byte[] vGet = _Image;
				OnImageGetting(ref _Image, ref vGet);
				return vGet;
			}
            set
            {
                OnImageChanging(value);
                SetProperty(ref _Image, value);
                OnImageChanged();
            }
        }
        
        
        [DisplayName("NhanvienId")]
	    [Column(Name="NhanvienId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid NhanvienId
        {
            get
			{
				Guid vGet = _NhanvienId;
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
        
        
        [DisplayName("NganhangId")]
	    [Column(Name="NganhangId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> NganhangId
        {
            get
			{
				Nullable<Guid> vGet = _NganhangId;
				OnNganhangIdGetting(ref _NganhangId, ref vGet);
				return vGet;
			}
            set
            {
                OnNganhangIdChanging(value);
                SetProperty(ref _NganhangId, value);
                OnNganhangIdChanged();
            }
        }
        
        
        [DisplayName("ChinhanhNganhangiD")]
	    [Column(Name="ChinhanhNganhangiD",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> ChinhanhNganhangiD
        {
            get
			{
				Nullable<Guid> vGet = _ChinhanhNganhangiD;
				OnChinhanhNganhangiDGetting(ref _ChinhanhNganhangiD, ref vGet);
				return vGet;
			}
            set
            {
                OnChinhanhNganhangiDChanging(value);
                SetProperty(ref _ChinhanhNganhangiD, value);
                OnChinhanhNganhangiDChanged();
            }
        }
        
        
        [DisplayName("Step")]
	    [Column(Name="Step",SqlType=SqlDbType.Int)]
        public Nullable<Int32> Step
        {
            get
			{
				Nullable<Int32> vGet = _Step;
				OnStepGetting(ref _Step, ref vGet);
				return vGet;
			}
            set
            {
                OnStepChanging(value);
                SetProperty(ref _Step, value);
                OnStepChanged();
            }
        }
        
        
        [DisplayName("Ngaysinh")]
	    [Column(Name="Ngaysinh",SqlType=SqlDbType.DateTime)]
        public Nullable<DateTime> Ngaysinh
        {
            get
			{
				Nullable<DateTime> vGet = _Ngaysinh;
				OnNgaysinhGetting(ref _Ngaysinh, ref vGet);
				return vGet;
			}
            set
            {
                OnNgaysinhChanging(value);
                SetProperty(ref _Ngaysinh, value);
                OnNgaysinhChanged();
            }
        }
        
        
        [DisplayName("NgayBatdauLam")]
	    [Column(Name="NgayBatdauLam",SqlType=SqlDbType.DateTime)]
        public Nullable<DateTime> NgayBatdauLam
        {
            get
			{
				Nullable<DateTime> vGet = _NgayBatdauLam;
				OnNgayBatdauLamGetting(ref _NgayBatdauLam, ref vGet);
				return vGet;
			}
            set
            {
                OnNgayBatdauLamChanging(value);
                SetProperty(ref _NgayBatdauLam, value);
                OnNgayBatdauLamChanged();
            }
        }
        
        
        [DisplayName("Gioitinh")]
	    [Column(Name="Gioitinh",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> Gioitinh
        {
            get
			{
				Nullable<Boolean> vGet = _Gioitinh;
				OnGioitinhGetting(ref _Gioitinh, ref vGet);
				return vGet;
			}
            set
            {
                OnGioitinhChanging(value);
                SetProperty(ref _Gioitinh, value);
                OnGioitinhChanged();
            }
        }
        
        
        [DisplayName("ConHoatdong")]
	    [Column(Name="ConHoatdong",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> ConHoatdong
        {
            get
			{
				Nullable<Boolean> vGet = _ConHoatdong;
				OnConHoatdongGetting(ref _ConHoatdong, ref vGet);
				return vGet;
			}
            set
            {
                OnConHoatdongChanging(value);
                SetProperty(ref _ConHoatdong, value);
                OnConHoatdongChanged();
            }
        }
        
        
        [DisplayName("LaGiaovien")]
	    [Column(Name="LaGiaovien",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> LaGiaovien
        {
            get
			{
				Nullable<Boolean> vGet = _LaGiaovien;
				OnLaGiaovienGetting(ref _LaGiaovien, ref vGet);
				return vGet;
			}
            set
            {
                OnLaGiaovienChanging(value);
                SetProperty(ref _LaGiaovien, value);
                OnLaGiaovienChanged();
            }
        }
        
        
        [DisplayName("Email")]
	    [Column(Name="Email",SqlType=SqlDbType.VarChar)]
        public String Email
        {
            get
			{
				String vGet = _Email;
				OnEmailGetting(ref _Email, ref vGet);
				return vGet;
			}
            set
            {
                OnEmailChanging(value);
                SetProperty(ref _Email, value);
                OnEmailChanged();
            }
        }
        
        
        [DisplayName("SoDT")]
	    [Column(Name="SoDT",SqlType=SqlDbType.VarChar)]
        public String SoDT
        {
            get
			{
				String vGet = _SoDT;
				OnSoDTGetting(ref _SoDT, ref vGet);
				return vGet;
			}
            set
            {
                OnSoDTChanging(value);
                SetProperty(ref _SoDT, value);
                OnSoDTChanged();
            }
        }
        
        
        [DisplayName("SoTaikhoan")]
	    [Column(Name="SoTaikhoan",SqlType=SqlDbType.VarChar)]
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
        
        
        [DisplayName("Version")]
	    [Column(Name="Version",SqlType=SqlDbType.Timestamp)]
        public Byte[] Version
        {
            get
			{
				Byte[] vGet = _Version;
				OnVersionGetting(ref _Version, ref vGet);
				return vGet;
			}
            set
            {
                OnVersionChanging(value);
                SetProperty(ref _Version, value);
                OnVersionChanged();
            }
        }
        
        
        [DisplayName("Mavach")]
	    [Column(Name="Mavach",SqlType=SqlDbType.NVarChar)]
        public String Mavach
        {
            get
			{
				String vGet = _Mavach;
				OnMavachGetting(ref _Mavach, ref vGet);
				return vGet;
			}
            set
            {
                OnMavachChanging(value);
                SetProperty(ref _Mavach, value);
                OnMavachChanged();
            }
        }
        
        
        [DisplayName("Hodem")]
	    [Column(Name="Hodem",SqlType=SqlDbType.NVarChar)]
        public String Hodem
        {
            get
			{
				String vGet = _Hodem;
				OnHodemGetting(ref _Hodem, ref vGet);
				return vGet;
			}
            set
            {
                OnHodemChanging(value);
                SetProperty(ref _Hodem, value);
                OnHodemChanged();
            }
        }
        
        
        [DisplayName("Ten")]
	    [Column(Name="Ten",SqlType=SqlDbType.NVarChar)]
        public String Ten
        {
            get
			{
				String vGet = _Ten;
				OnTenGetting(ref _Ten, ref vGet);
				return vGet;
			}
            set
            {
                OnTenChanging(value);
                SetProperty(ref _Ten, value);
                OnTenChanged();
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
		
        
        partial void OnImageChanging(Byte[] value);
        partial void OnImageChanged();
		partial void OnImageGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnNhanvienIdChanging(Guid value);
        partial void OnNhanvienIdChanged();
		partial void OnNhanvienIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnNganhangIdChanging(Nullable<Guid> value);
        partial void OnNganhangIdChanged();
		partial void OnNganhangIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnChinhanhNganhangiDChanging(Nullable<Guid> value);
        partial void OnChinhanhNganhangiDChanged();
		partial void OnChinhanhNganhangiDGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgaysinhChanging(Nullable<DateTime> value);
        partial void OnNgaysinhChanged();
		partial void OnNgaysinhGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnNgayBatdauLamChanging(Nullable<DateTime> value);
        partial void OnNgayBatdauLamChanged();
		partial void OnNgayBatdauLamGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnGioitinhChanging(Nullable<Boolean> value);
        partial void OnGioitinhChanged();
		partial void OnGioitinhGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnConHoatdongChanging(Nullable<Boolean> value);
        partial void OnConHoatdongChanged();
		partial void OnConHoatdongGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnLaGiaovienChanging(Nullable<Boolean> value);
        partial void OnLaGiaovienChanged();
		partial void OnLaGiaovienGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnEmailChanging(String value);
        partial void OnEmailChanged();
		partial void OnEmailGetting(ref String value, ref String vGet);
        
        
        partial void OnSoDTChanging(String value);
        partial void OnSoDTChanged();
		partial void OnSoDTGetting(ref String value, ref String vGet);
        
        
        partial void OnSoTaikhoanChanging(String value);
        partial void OnSoTaikhoanChanged();
		partial void OnSoTaikhoanGetting(ref String value, ref String vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnMavachChanging(String value);
        partial void OnMavachChanged();
		partial void OnMavachGetting(ref String value, ref String vGet);
        
        
        partial void OnHodemChanging(String value);
        partial void OnHodemChanged();
		partial void OnHodemGetting(ref String value, ref String vGet);
        
        
        partial void OnTenChanging(String value);
        partial void OnTenChanged();
		partial void OnTenGetting(ref String value, ref String vGet);
        
        
        partial void OnDiachiChanging(String value);
        partial void OnDiachiChanged();
		partial void OnDiachiGetting(ref String value, ref String vGet);
        
    }
}