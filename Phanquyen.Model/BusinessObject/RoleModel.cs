using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace Phanquyen.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Role",
        spSelect = "sys_RoleSelect",
        spInsert = "sys_RoleInsert",
        spUpdate = "sys_RoleUpdate",
        spDelete = "sys_RoleDelete")]
    public partial class RoleModel : Bus
    {
        private Guid _RoleId;
        private Nullable<Boolean> _Enable;
        private String _Name;
        private String _Mota;

        public RoleModel()
        {
			OnCreating();
            RoleId = ModelCore.GetGuidId();
			OnCreated();
        }

        public RoleModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("RoleId")]
	    [Column(Name="RoleId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid RoleId
        {
            get
			{
				Guid vGet = _RoleId;
				OnRoleIdGetting(ref _RoleId, ref vGet);
				return vGet;
			}
            set
            {
                OnRoleIdChanging(value);
                SetProperty(ref _RoleId, value);
                OnRoleIdChanged();
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
        
        
        [DisplayName("Name")]
	    [Column(Name="Name",SqlType=SqlDbType.NVarChar)]
        public String Name
        {
            get
			{
				String vGet = _Name;
				OnNameGetting(ref _Name, ref vGet);
				return vGet;
			}
            set
            {
                OnNameChanging(value);
                SetProperty(ref _Name, value);
                OnNameChanged();
            }
        }
        
        
        [DisplayName("Mota")]
	    [Column(Name="Mota",SqlType=SqlDbType.NVarChar)]
        public String Mota
        {
            get
			{
				String vGet = _Mota;
				OnMotaGetting(ref _Mota, ref vGet);
				return vGet;
			}
            set
            {
                OnMotaChanging(value);
                SetProperty(ref _Mota, value);
                OnMotaChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnRoleIdChanging(Guid value);
        partial void OnRoleIdChanged();
		partial void OnRoleIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnEnableChanging(Nullable<Boolean> value);
        partial void OnEnableChanged();
		partial void OnEnableGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnNameChanging(String value);
        partial void OnNameChanged();
		partial void OnNameGetting(ref String value, ref String vGet);
        
        
        partial void OnMotaChanging(String value);
        partial void OnMotaChanged();
		partial void OnMotaGetting(ref String value, ref String vGet);
        
    }
}