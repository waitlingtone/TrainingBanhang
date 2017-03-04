using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace Phanquyen.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "UserRole",
        spSelect = "sys_UserRoleSelect",
        spInsert = "sys_UserRoleInsert",
        spUpdate = "sys_UserRoleUpdate",
        spDelete = "sys_UserRoleDelete")]
    public partial class UserRoleModel : Bus
    {
        private Guid _UserRoleId;
        private Nullable<Guid> _UserId;
        private Nullable<Guid> _RoleId;
        private Nullable<Boolean> _Enable;

        public UserRoleModel()
        {
			OnCreating();
            UserRoleId = ModelCore.GetGuidId();
			OnCreated();
        }

        public UserRoleModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("UserRoleId")]
	    [Column(Name="UserRoleId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid UserRoleId
        {
            get
			{
				Guid vGet = _UserRoleId;
				OnUserRoleIdGetting(ref _UserRoleId, ref vGet);
				return vGet;
			}
            set
            {
                OnUserRoleIdChanging(value);
                SetProperty(ref _UserRoleId, value);
                OnUserRoleIdChanged();
            }
        }
        
        
        [DisplayName("UserId")]
	    [Column(Name="UserId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> UserId
        {
            get
			{
				Nullable<Guid> vGet = _UserId;
				OnUserIdGetting(ref _UserId, ref vGet);
				return vGet;
			}
            set
            {
                OnUserIdChanging(value);
                SetProperty(ref _UserId, value);
                OnUserIdChanged();
            }
        }
        
        
        [DisplayName("RoleId")]
	    [Column(Name="RoleId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> RoleId
        {
            get
			{
				Nullable<Guid> vGet = _RoleId;
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
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnUserRoleIdChanging(Guid value);
        partial void OnUserRoleIdChanged();
		partial void OnUserRoleIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnUserIdChanging(Nullable<Guid> value);
        partial void OnUserIdChanged();
		partial void OnUserIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnRoleIdChanging(Nullable<Guid> value);
        partial void OnRoleIdChanged();
		partial void OnRoleIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnEnableChanging(Nullable<Boolean> value);
        partial void OnEnableChanged();
		partial void OnEnableGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
    }
}