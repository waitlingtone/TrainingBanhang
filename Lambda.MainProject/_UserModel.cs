using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace Lambda.MainProject
{
	
	[Table(Schema = "dbo", Name = "_User",
        spSelect = "sys__UserSelect",
        spInsert = "sys__UserInsert",
        spUpdate = "sys__UserUpdate",
        spDelete = "sys__UserDelete")]
    public partial class _UserModel : Bus
    {
        private Guid __UserId;
        private Nullable<Guid> _NguoidungId;
        private Nullable<Int32> _Step;
        private Nullable<Boolean> _Enable;
        private Byte[] _Version;
        private String __Username;
        private String __Password;

        public _UserModel()
        {
			OnCreating();
            _UserId = ModelCore.GetGuidId();
			OnCreated();
        }

        public _UserModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("_UserId")]
	    [Column(Name="_UserId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid _UserId
        {
            get
			{
				Guid vGet = __UserId;
				On_UserIdGetting(ref __UserId, ref vGet);
				return vGet;
			}
            set
            {
                On_UserIdChanging(value);
                SetProperty(ref __UserId, value);
                On_UserIdChanged();
            }
        }
        
        
        [DisplayName("NguoidungId")]
	    [Column(Name="NguoidungId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> NguoidungId
        {
            get
			{
				Nullable<Guid> vGet = _NguoidungId;
				OnNguoidungIdGetting(ref _NguoidungId, ref vGet);
				return vGet;
			}
            set
            {
                OnNguoidungIdChanging(value);
                SetProperty(ref _NguoidungId, value);
                OnNguoidungIdChanged();
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
        
        
        [DisplayName("Enable")]
	    [Column(Name="Enable",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> Enable
        {
            get
			{
				Nullable<Boolean> vGet = _Enable;
				OnEnableGetting(ref _Enable, ref vGet);
				return vGet;
			}
            set
            {
                OnEnableChanging(value);
                SetProperty(ref _Enable, value);
                OnEnableChanged();
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
        
        
        [DisplayName("_Username")]
	    [Column(Name="_Username",SqlType=SqlDbType.NVarChar)]
        public String _Username
        {
            get
			{
				String vGet = __Username;
				On_UsernameGetting(ref __Username, ref vGet);
				return vGet;
			}
            set
            {
                On_UsernameChanging(value);
                SetProperty(ref __Username, value);
                On_UsernameChanged();
            }
        }
        
        
        [DisplayName("_Password")]
	    [Column(Name="_Password",SqlType=SqlDbType.NVarChar)]
        public String _Password
        {
            get
			{
				String vGet = __Password;
				On_PasswordGetting(ref __Password, ref vGet);
				return vGet;
			}
            set
            {
                On_PasswordChanging(value);
                SetProperty(ref __Password, value);
                On_PasswordChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void On_UserIdChanging(Guid value);
        partial void On_UserIdChanged();
		partial void On_UserIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnNguoidungIdChanging(Nullable<Guid> value);
        partial void OnNguoidungIdChanged();
		partial void OnNguoidungIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnEnableChanging(Nullable<Boolean> value);
        partial void OnEnableChanged();
		partial void OnEnableGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void On_UsernameChanging(String value);
        partial void On_UsernameChanged();
		partial void On_UsernameGetting(ref String value, ref String vGet);
        
        
        partial void On_PasswordChanging(String value);
        partial void On_PasswordChanged();
		partial void On_PasswordGetting(ref String value, ref String vGet);
        
    }
}