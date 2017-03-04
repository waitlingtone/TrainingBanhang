using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace Phanquyen.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Canbo",
        spSelect = "sys_CanboSelect",
        spInsert = "sys_CanboInsert",
        spUpdate = "sys_CanboUpdate",
        spDelete = "sys_CanboDelete")]
    public partial class CanboModel : Bus
    {
        private Guid _CanboId;
        private Nullable<Guid> _DonviId;
        private Nullable<Guid> _DantocId;
        private Nullable<Guid> _TongiaoId;
        private Nullable<Guid> _HocviId;
        private Nullable<Guid> _TinhtrangCongtacId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _Ngaysinh;
        private Nullable<Boolean> _Gioitinh;
        private String _SDT;
        private String _Email;
        private String _CMND;
        private String _ImageUrl;
        private Byte[] _Version;
        private String _MaCanbo;
        private String _HoDem;
        private String _TenCanbo;
        private String _Diachi;
        private String _Noisinh;

        public CanboModel()
        {
			OnCreating();
            CanboId = ModelCore.GetGuidId();
			OnCreated();
        }

        public CanboModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("CanboId")]
	    [Column(Name="CanboId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid CanboId
        {
            get
			{
				Guid vGet = _CanboId;
				OnCanboIdGetting(ref _CanboId, ref vGet);
				return vGet;
			}
            set
            {
                OnCanboIdChanging(value);
                SetProperty(ref _CanboId, value);
                OnCanboIdChanged();
            }
        }
        
        
        [DisplayName("DonviId")]
	    [Column(Name="DonviId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> DonviId
        {
            get
			{
				Nullable<Guid> vGet = _DonviId;
				OnDonviIdGetting(ref _DonviId, ref vGet);
				return vGet;
			}
            set
            {
                OnDonviIdChanging(value);
                SetProperty(ref _DonviId, value);
                OnDonviIdChanged();
            }
        }
        
        
        [DisplayName("DantocId")]
	    [Column(Name="DantocId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> DantocId
        {
            get
			{
				Nullable<Guid> vGet = _DantocId;
				OnDantocIdGetting(ref _DantocId, ref vGet);
				return vGet;
			}
            set
            {
                OnDantocIdChanging(value);
                SetProperty(ref _DantocId, value);
                OnDantocIdChanged();
            }
        }
        
        
        [DisplayName("TongiaoId")]
	    [Column(Name="TongiaoId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> TongiaoId
        {
            get
			{
				Nullable<Guid> vGet = _TongiaoId;
				OnTongiaoIdGetting(ref _TongiaoId, ref vGet);
				return vGet;
			}
            set
            {
                OnTongiaoIdChanging(value);
                SetProperty(ref _TongiaoId, value);
                OnTongiaoIdChanged();
            }
        }
        
        
        [DisplayName("HocviId")]
	    [Column(Name="HocviId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> HocviId
        {
            get
			{
				Nullable<Guid> vGet = _HocviId;
				OnHocviIdGetting(ref _HocviId, ref vGet);
				return vGet;
			}
            set
            {
                OnHocviIdChanging(value);
                SetProperty(ref _HocviId, value);
                OnHocviIdChanged();
            }
        }
        
        
        [DisplayName("TinhtrangCongtacId")]
	    [Column(Name="TinhtrangCongtacId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> TinhtrangCongtacId
        {
            get
			{
				Nullable<Guid> vGet = _TinhtrangCongtacId;
				OnTinhtrangCongtacIdGetting(ref _TinhtrangCongtacId, ref vGet);
				return vGet;
			}
            set
            {
                OnTinhtrangCongtacIdChanging(value);
                SetProperty(ref _TinhtrangCongtacId, value);
                OnTinhtrangCongtacIdChanged();
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
        
        
        [DisplayName("SDT")]
	    [Column(Name="SDT",SqlType=SqlDbType.VarChar)]
        public String SDT
        {
            get
			{
				String vGet = _SDT;
				OnSDTGetting(ref _SDT, ref vGet);
				return vGet;
			}
            set
            {
                OnSDTChanging(value);
                SetProperty(ref _SDT, value);
                OnSDTChanged();
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
        
        
        [DisplayName("CMND")]
	    [Column(Name="CMND",SqlType=SqlDbType.VarChar)]
        public String CMND
        {
            get
			{
				String vGet = _CMND;
				OnCMNDGetting(ref _CMND, ref vGet);
				return vGet;
			}
            set
            {
                OnCMNDChanging(value);
                SetProperty(ref _CMND, value);
                OnCMNDChanged();
            }
        }
        
        
        [DisplayName("ImageUrl")]
	    [Column(Name="ImageUrl",SqlType=SqlDbType.VarChar)]
        public String ImageUrl
        {
            get
			{
				String vGet = _ImageUrl;
				OnImageUrlGetting(ref _ImageUrl, ref vGet);
				return vGet;
			}
            set
            {
                OnImageUrlChanging(value);
                SetProperty(ref _ImageUrl, value);
                OnImageUrlChanged();
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
        
        
        [DisplayName("MaCanbo")]
	    [Column(Name="MaCanbo",SqlType=SqlDbType.NVarChar)]
        public String MaCanbo
        {
            get
			{
				String vGet = _MaCanbo;
				OnMaCanboGetting(ref _MaCanbo, ref vGet);
				return vGet;
			}
            set
            {
                OnMaCanboChanging(value);
                SetProperty(ref _MaCanbo, value);
                OnMaCanboChanged();
            }
        }
        
        
        [DisplayName("HoDem")]
	    [Column(Name="HoDem",SqlType=SqlDbType.NVarChar)]
        public String HoDem
        {
            get
			{
				String vGet = _HoDem;
				OnHoDemGetting(ref _HoDem, ref vGet);
				return vGet;
			}
            set
            {
                OnHoDemChanging(value);
                SetProperty(ref _HoDem, value);
                OnHoDemChanged();
            }
        }
        
        
        [DisplayName("TenCanbo")]
	    [Column(Name="TenCanbo",SqlType=SqlDbType.NVarChar)]
        public String TenCanbo
        {
            get
			{
				String vGet = _TenCanbo;
				OnTenCanboGetting(ref _TenCanbo, ref vGet);
				return vGet;
			}
            set
            {
                OnTenCanboChanging(value);
                SetProperty(ref _TenCanbo, value);
                OnTenCanboChanged();
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
        
        
        [DisplayName("Noisinh")]
	    [Column(Name="Noisinh",SqlType=SqlDbType.NVarChar)]
        public String Noisinh
        {
            get
			{
				String vGet = _Noisinh;
				OnNoisinhGetting(ref _Noisinh, ref vGet);
				return vGet;
			}
            set
            {
                OnNoisinhChanging(value);
                SetProperty(ref _Noisinh, value);
                OnNoisinhChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnCanboIdChanging(Guid value);
        partial void OnCanboIdChanged();
		partial void OnCanboIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnDonviIdChanging(Nullable<Guid> value);
        partial void OnDonviIdChanged();
		partial void OnDonviIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnDantocIdChanging(Nullable<Guid> value);
        partial void OnDantocIdChanged();
		partial void OnDantocIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnTongiaoIdChanging(Nullable<Guid> value);
        partial void OnTongiaoIdChanged();
		partial void OnTongiaoIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnHocviIdChanging(Nullable<Guid> value);
        partial void OnHocviIdChanged();
		partial void OnHocviIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnTinhtrangCongtacIdChanging(Nullable<Guid> value);
        partial void OnTinhtrangCongtacIdChanged();
		partial void OnTinhtrangCongtacIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgaysinhChanging(Nullable<DateTime> value);
        partial void OnNgaysinhChanged();
		partial void OnNgaysinhGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnGioitinhChanging(Nullable<Boolean> value);
        partial void OnGioitinhChanged();
		partial void OnGioitinhGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnSDTChanging(String value);
        partial void OnSDTChanged();
		partial void OnSDTGetting(ref String value, ref String vGet);
        
        
        partial void OnEmailChanging(String value);
        partial void OnEmailChanged();
		partial void OnEmailGetting(ref String value, ref String vGet);
        
        
        partial void OnCMNDChanging(String value);
        partial void OnCMNDChanged();
		partial void OnCMNDGetting(ref String value, ref String vGet);
        
        
        partial void OnImageUrlChanging(String value);
        partial void OnImageUrlChanged();
		partial void OnImageUrlGetting(ref String value, ref String vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnMaCanboChanging(String value);
        partial void OnMaCanboChanged();
		partial void OnMaCanboGetting(ref String value, ref String vGet);
        
        
        partial void OnHoDemChanging(String value);
        partial void OnHoDemChanged();
		partial void OnHoDemGetting(ref String value, ref String vGet);
        
        
        partial void OnTenCanboChanging(String value);
        partial void OnTenCanboChanged();
		partial void OnTenCanboGetting(ref String value, ref String vGet);
        
        
        partial void OnDiachiChanging(String value);
        partial void OnDiachiChanged();
		partial void OnDiachiGetting(ref String value, ref String vGet);
        
        
        partial void OnNoisinhChanging(String value);
        partial void OnNoisinhChanged();
		partial void OnNoisinhGetting(ref String value, ref String vGet);
        
    }
}