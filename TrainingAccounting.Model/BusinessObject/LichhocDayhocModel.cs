using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "LichhocDayhoc",
        spSelect = "sys_LichhocDayhocSelect",
        spInsert = "sys_LichhocDayhocInsert",
        spUpdate = "sys_LichhocDayhocUpdate",
        spDelete = "sys_LichhocDayhocDelete")]
    public partial class LichhocDayhocModel : Bus
    {
        private Guid _LichhocDayhocId;
        private Nullable<Guid> _PhieubaoHocphiId;
        private Nullable<Guid> _NhanvienId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _GioBatdau;
        private Nullable<DateTime> _GioKetthuc;
        private Nullable<Double> _Dongia;
        private Nullable<Boolean> _DangkyHoc;
        private Nullable<Boolean> _DiemdanhTre;
        private Nullable<Boolean> _DiemdanhNhanvien;
        private Nullable<Boolean> _VangHople;
        private Nullable<Boolean> _DaTinhtien;
        private Nullable<Boolean> _Bosung;
        private Nullable<Boolean> _IsCaghep;
        private Byte[] _Version;
        private String _LidoVang;
        private String _Ghichu;

        public LichhocDayhocModel()
        {
			OnCreating();
            LichhocDayhocId = ModelCore.GetGuidId();
			OnCreated();
        }

        public LichhocDayhocModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("LichhocDayhocId")]
	    [Column(Name="LichhocDayhocId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid LichhocDayhocId
        {
            get
			{
				Guid vGet = _LichhocDayhocId;
				OnLichhocDayhocIdGetting(ref _LichhocDayhocId, ref vGet);
				return vGet;
			}
            set
            {
                OnLichhocDayhocIdChanging(value);
                SetProperty(ref _LichhocDayhocId, value);
                OnLichhocDayhocIdChanged();
            }
        }
        
        
        [DisplayName("PhieubaoHocphiId")]
	    [Column(Name="PhieubaoHocphiId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> PhieubaoHocphiId
        {
            get
			{
				Nullable<Guid> vGet = _PhieubaoHocphiId;
				OnPhieubaoHocphiIdGetting(ref _PhieubaoHocphiId, ref vGet);
				return vGet;
			}
            set
            {
                OnPhieubaoHocphiIdChanging(value);
                SetProperty(ref _PhieubaoHocphiId, value);
                OnPhieubaoHocphiIdChanged();
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
        
        
        [DisplayName("GioBatdau")]
	    [Column(Name="GioBatdau",SqlType=SqlDbType.DateTime)]
        public Nullable<DateTime> GioBatdau
        {
            get
			{
				Nullable<DateTime> vGet = _GioBatdau;
				OnGioBatdauGetting(ref _GioBatdau, ref vGet);
				return vGet;
			}
            set
            {
                OnGioBatdauChanging(value);
                SetProperty(ref _GioBatdau, value);
                OnGioBatdauChanged();
            }
        }
        
        
        [DisplayName("GioKetthuc")]
	    [Column(Name="GioKetthuc",SqlType=SqlDbType.DateTime)]
        public Nullable<DateTime> GioKetthuc
        {
            get
			{
				Nullable<DateTime> vGet = _GioKetthuc;
				OnGioKetthucGetting(ref _GioKetthuc, ref vGet);
				return vGet;
			}
            set
            {
                OnGioKetthucChanging(value);
                SetProperty(ref _GioKetthuc, value);
                OnGioKetthucChanged();
            }
        }
        
        
        [DisplayName("Dongia")]
	    [Column(Name="Dongia",SqlType=SqlDbType.Float)]
        public Nullable<Double> Dongia
        {
            get
			{
				Nullable<Double> vGet = _Dongia;
				OnDongiaGetting(ref _Dongia, ref vGet);
				return vGet;
			}
            set
            {
                OnDongiaChanging(value);
                SetProperty(ref _Dongia, value);
                OnDongiaChanged();
            }
        }
        
        
        [DisplayName("DangkyHoc")]
	    [Column(Name="DangkyHoc",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> DangkyHoc
        {
            get
			{
				Nullable<Boolean> vGet = _DangkyHoc;
				OnDangkyHocGetting(ref _DangkyHoc, ref vGet);
				return vGet;
			}
            set
            {
                OnDangkyHocChanging(value);
                SetProperty(ref _DangkyHoc, value);
                OnDangkyHocChanged();
            }
        }
        
        
        [DisplayName("DiemdanhTre")]
	    [Column(Name="DiemdanhTre",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> DiemdanhTre
        {
            get
			{
				Nullable<Boolean> vGet = _DiemdanhTre;
				OnDiemdanhTreGetting(ref _DiemdanhTre, ref vGet);
				return vGet;
			}
            set
            {
                OnDiemdanhTreChanging(value);
                SetProperty(ref _DiemdanhTre, value);
                OnDiemdanhTreChanged();
            }
        }
        
        
        [DisplayName("DiemdanhNhanvien")]
	    [Column(Name="DiemdanhNhanvien",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> DiemdanhNhanvien
        {
            get
			{
				Nullable<Boolean> vGet = _DiemdanhNhanvien;
				OnDiemdanhNhanvienGetting(ref _DiemdanhNhanvien, ref vGet);
				return vGet;
			}
            set
            {
                OnDiemdanhNhanvienChanging(value);
                SetProperty(ref _DiemdanhNhanvien, value);
                OnDiemdanhNhanvienChanged();
            }
        }
        
        
        [DisplayName("VangHople")]
	    [Column(Name="VangHople",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> VangHople
        {
            get
			{
				Nullable<Boolean> vGet = _VangHople;
				OnVangHopleGetting(ref _VangHople, ref vGet);
				return vGet;
			}
            set
            {
                OnVangHopleChanging(value);
                SetProperty(ref _VangHople, value);
                OnVangHopleChanged();
            }
        }
        
        
        [DisplayName("DaTinhtien")]
	    [Column(Name="DaTinhtien",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> DaTinhtien
        {
            get
			{
				Nullable<Boolean> vGet = _DaTinhtien;
				OnDaTinhtienGetting(ref _DaTinhtien, ref vGet);
				return vGet;
			}
            set
            {
                OnDaTinhtienChanging(value);
                SetProperty(ref _DaTinhtien, value);
                OnDaTinhtienChanged();
            }
        }
        
        
        [DisplayName("Bosung")]
	    [Column(Name="Bosung",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> Bosung
        {
            get
			{
				Nullable<Boolean> vGet = _Bosung;
				OnBosungGetting(ref _Bosung, ref vGet);
				return vGet;
			}
            set
            {
                OnBosungChanging(value);
                SetProperty(ref _Bosung, value);
                OnBosungChanged();
            }
        }
        
        
        [DisplayName("IsCaghep")]
	    [Column(Name="IsCaghep",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> IsCaghep
        {
            get
			{
				Nullable<Boolean> vGet = _IsCaghep;
				OnIsCaghepGetting(ref _IsCaghep, ref vGet);
				return vGet;
			}
            set
            {
                OnIsCaghepChanging(value);
                SetProperty(ref _IsCaghep, value);
                OnIsCaghepChanged();
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
        
        
        [DisplayName("LidoVang")]
	    [Column(Name="LidoVang",SqlType=SqlDbType.NVarChar)]
        public String LidoVang
        {
            get
			{
				String vGet = _LidoVang;
				OnLidoVangGetting(ref _LidoVang, ref vGet);
				return vGet;
			}
            set
            {
                OnLidoVangChanging(value);
                SetProperty(ref _LidoVang, value);
                OnLidoVangChanged();
            }
        }
        
        
        [DisplayName("Ghichu")]
	    [Column(Name="Ghichu",SqlType=SqlDbType.NVarChar)]
        public String Ghichu
        {
            get
			{
				String vGet = _Ghichu;
				OnGhichuGetting(ref _Ghichu, ref vGet);
				return vGet;
			}
            set
            {
                OnGhichuChanging(value);
                SetProperty(ref _Ghichu, value);
                OnGhichuChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnLichhocDayhocIdChanging(Guid value);
        partial void OnLichhocDayhocIdChanged();
		partial void OnLichhocDayhocIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnPhieubaoHocphiIdChanging(Nullable<Guid> value);
        partial void OnPhieubaoHocphiIdChanged();
		partial void OnPhieubaoHocphiIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNhanvienIdChanging(Nullable<Guid> value);
        partial void OnNhanvienIdChanged();
		partial void OnNhanvienIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnGioBatdauChanging(Nullable<DateTime> value);
        partial void OnGioBatdauChanged();
		partial void OnGioBatdauGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnGioKetthucChanging(Nullable<DateTime> value);
        partial void OnGioKetthucChanged();
		partial void OnGioKetthucGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnDongiaChanging(Nullable<Double> value);
        partial void OnDongiaChanged();
		partial void OnDongiaGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnDangkyHocChanging(Nullable<Boolean> value);
        partial void OnDangkyHocChanged();
		partial void OnDangkyHocGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnDiemdanhTreChanging(Nullable<Boolean> value);
        partial void OnDiemdanhTreChanged();
		partial void OnDiemdanhTreGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnDiemdanhNhanvienChanging(Nullable<Boolean> value);
        partial void OnDiemdanhNhanvienChanged();
		partial void OnDiemdanhNhanvienGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVangHopleChanging(Nullable<Boolean> value);
        partial void OnVangHopleChanged();
		partial void OnVangHopleGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnDaTinhtienChanging(Nullable<Boolean> value);
        partial void OnDaTinhtienChanged();
		partial void OnDaTinhtienGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnBosungChanging(Nullable<Boolean> value);
        partial void OnBosungChanged();
		partial void OnBosungGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnIsCaghepChanging(Nullable<Boolean> value);
        partial void OnIsCaghepChanged();
		partial void OnIsCaghepGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnLidoVangChanging(String value);
        partial void OnLidoVangChanged();
		partial void OnLidoVangGetting(ref String value, ref String vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        
    }
}