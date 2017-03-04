using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Thannhan",
        spSelect = "sys_ThannhanSelect",
        spInsert = "sys_ThannhanInsert",
        spUpdate = "sys_ThannhanUpdate",
        spDelete = "sys_ThannhanDelete")]
    public partial class ThannhanModel : Bus
    {
        private Guid _ThannhanId;
        private Nullable<Guid> _TreId;
        private Nullable<Int32> _Namsinh;
        private Nullable<Int32> _Step;
        private Nullable<Boolean> _LaDaidienChinh;
        private String _SoDT;
        private Byte[] _Version;
        private String _Hoten;
        private String _Quanhe;
        private String _Nghenghiep;
        private String _Diachi;

        public ThannhanModel()
        {
			OnCreating();
            ThannhanId = ModelCore.GetGuidId();
			OnCreated();
        }

        public ThannhanModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("ThannhanId")]
	    [Column(Name="ThannhanId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid ThannhanId
        {
            get
			{
				Guid vGet = _ThannhanId;
				OnThannhanIdGetting(ref _ThannhanId, ref vGet);
				return vGet;
			}
            set
            {
                OnThannhanIdChanging(value);
                SetProperty(ref _ThannhanId, value);
                OnThannhanIdChanged();
            }
        }
        
        
        [DisplayName("TreId")]
	    [Column(Name="TreId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> TreId
        {
            get
			{
				Nullable<Guid> vGet = _TreId;
				OnTreIdGetting(ref _TreId, ref vGet);
				return vGet;
			}
            set
            {
                OnTreIdChanging(value);
                SetProperty(ref _TreId, value);
                OnTreIdChanged();
            }
        }
        
        
        [DisplayName("Namsinh")]
	    [Column(Name="Namsinh",SqlType=SqlDbType.Int)]
        public Nullable<Int32> Namsinh
        {
            get
			{
				Nullable<Int32> vGet = _Namsinh;
				OnNamsinhGetting(ref _Namsinh, ref vGet);
				return vGet;
			}
            set
            {
                OnNamsinhChanging(value);
                SetProperty(ref _Namsinh, value);
                OnNamsinhChanged();
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
        
        
        [DisplayName("LaDaidienChinh")]
	    [Column(Name="LaDaidienChinh",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> LaDaidienChinh
        {
            get
			{
				Nullable<Boolean> vGet = _LaDaidienChinh;
				OnLaDaidienChinhGetting(ref _LaDaidienChinh, ref vGet);
				return vGet;
			}
            set
            {
                OnLaDaidienChinhChanging(value);
                SetProperty(ref _LaDaidienChinh, value);
                OnLaDaidienChinhChanged();
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
        
        
        [DisplayName("Hoten")]
	    [Column(Name="Hoten",SqlType=SqlDbType.NVarChar)]
        public String Hoten
        {
            get
			{
				String vGet = _Hoten;
				OnHotenGetting(ref _Hoten, ref vGet);
				return vGet;
			}
            set
            {
                OnHotenChanging(value);
                SetProperty(ref _Hoten, value);
                OnHotenChanged();
            }
        }
        
        
        [DisplayName("Quanhe")]
	    [Column(Name="Quanhe",SqlType=SqlDbType.NVarChar)]
        public String Quanhe
        {
            get
			{
				String vGet = _Quanhe;
				OnQuanheGetting(ref _Quanhe, ref vGet);
				return vGet;
			}
            set
            {
                OnQuanheChanging(value);
                SetProperty(ref _Quanhe, value);
                OnQuanheChanged();
            }
        }
        
        
        [DisplayName("Nghenghiep")]
	    [Column(Name="Nghenghiep",SqlType=SqlDbType.NVarChar)]
        public String Nghenghiep
        {
            get
			{
				String vGet = _Nghenghiep;
				OnNghenghiepGetting(ref _Nghenghiep, ref vGet);
				return vGet;
			}
            set
            {
                OnNghenghiepChanging(value);
                SetProperty(ref _Nghenghiep, value);
                OnNghenghiepChanged();
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
		
        
        partial void OnThannhanIdChanging(Guid value);
        partial void OnThannhanIdChanged();
		partial void OnThannhanIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnTreIdChanging(Nullable<Guid> value);
        partial void OnTreIdChanged();
		partial void OnTreIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNamsinhChanging(Nullable<Int32> value);
        partial void OnNamsinhChanged();
		partial void OnNamsinhGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnLaDaidienChinhChanging(Nullable<Boolean> value);
        partial void OnLaDaidienChinhChanged();
		partial void OnLaDaidienChinhGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnSoDTChanging(String value);
        partial void OnSoDTChanged();
		partial void OnSoDTGetting(ref String value, ref String vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnHotenChanging(String value);
        partial void OnHotenChanged();
		partial void OnHotenGetting(ref String value, ref String vGet);
        
        
        partial void OnQuanheChanging(String value);
        partial void OnQuanheChanged();
		partial void OnQuanheGetting(ref String value, ref String vGet);
        
        
        partial void OnNghenghiepChanging(String value);
        partial void OnNghenghiepChanged();
		partial void OnNghenghiepGetting(ref String value, ref String vGet);
        
        
        partial void OnDiachiChanging(String value);
        partial void OnDiachiChanged();
		partial void OnDiachiGetting(ref String value, ref String vGet);
        
    }
}