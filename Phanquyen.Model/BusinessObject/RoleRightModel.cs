using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace Phanquyen.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "RoleRight",
        spSelect = "sys_RoleRightSelect",
        spInsert = "sys_RoleRightInsert",
        spUpdate = "sys_RoleRightUpdate",
        spDelete = "sys_RoleRightDelete")]
    public partial class RoleRightModel : Bus
    {
        private Guid _RoleRightId;
        private Nullable<Guid> _RoleId;
        private Nullable<Guid> _ItemId;
        private Nullable<Guid> _ItemChaId;
        private Nullable<Guid> _AssemblyFileId;
        private Nullable<Guid> _ServiceItemId;
        private Nullable<Guid> _DatabaseItemId;
        private Nullable<Int32> _Enable;

        public RoleRightModel()
        {
			OnCreating();
            RoleRightId = ModelCore.GetGuidId();
			OnCreated();
        }

        public RoleRightModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("RoleRightId")]
	    [Column(Name="RoleRightId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid RoleRightId
        {
            get
			{
				Guid vGet = _RoleRightId;
				OnRoleRightIdGetting(ref _RoleRightId, ref vGet);
				return vGet;
			}
            set
            {
                OnRoleRightIdChanging(value);
                SetProperty(ref _RoleRightId, value);
                OnRoleRightIdChanged();
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
        
        
        [DisplayName("ItemId")]
	    [Column(Name="ItemId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> ItemId
        {
            get
			{
				Nullable<Guid> vGet = _ItemId;
				OnItemIdGetting(ref _ItemId, ref vGet);
				return vGet;
			}
            set
            {
                OnItemIdChanging(value);
                SetProperty(ref _ItemId, value);
                OnItemIdChanged();
            }
        }
        
        
        [DisplayName("ItemChaId")]
	    [Column(Name="ItemChaId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> ItemChaId
        {
            get
			{
				Nullable<Guid> vGet = _ItemChaId;
				OnItemChaIdGetting(ref _ItemChaId, ref vGet);
				return vGet;
			}
            set
            {
                OnItemChaIdChanging(value);
                SetProperty(ref _ItemChaId, value);
                OnItemChaIdChanged();
            }
        }
        
        
        [DisplayName("AssemblyFileId")]
	    [Column(Name="AssemblyFileId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> AssemblyFileId
        {
            get
			{
				Nullable<Guid> vGet = _AssemblyFileId;
				OnAssemblyFileIdGetting(ref _AssemblyFileId, ref vGet);
				return vGet;
			}
            set
            {
                OnAssemblyFileIdChanging(value);
                SetProperty(ref _AssemblyFileId, value);
                OnAssemblyFileIdChanged();
            }
        }
        
        
        [DisplayName("ServiceItemId")]
	    [Column(Name="ServiceItemId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> ServiceItemId
        {
            get
			{
				Nullable<Guid> vGet = _ServiceItemId;
				OnServiceItemIdGetting(ref _ServiceItemId, ref vGet);
				return vGet;
			}
            set
            {
                OnServiceItemIdChanging(value);
                SetProperty(ref _ServiceItemId, value);
                OnServiceItemIdChanged();
            }
        }
        
        
        [DisplayName("DatabaseItemId")]
	    [Column(Name="DatabaseItemId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> DatabaseItemId
        {
            get
			{
				Nullable<Guid> vGet = _DatabaseItemId;
				OnDatabaseItemIdGetting(ref _DatabaseItemId, ref vGet);
				return vGet;
			}
            set
            {
                OnDatabaseItemIdChanging(value);
                SetProperty(ref _DatabaseItemId, value);
                OnDatabaseItemIdChanged();
            }
        }
        
        
        [DisplayName("Enable")]
	    [Column(Name="Enable",SqlType=SqlDbType.Int)]
        public Nullable<Int32> Enable
        {
            get
			{
				Nullable<Int32> vGet = _Enable;
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
		
        
        partial void OnRoleRightIdChanging(Guid value);
        partial void OnRoleRightIdChanged();
		partial void OnRoleRightIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnRoleIdChanging(Nullable<Guid> value);
        partial void OnRoleIdChanged();
		partial void OnRoleIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnItemIdChanging(Nullable<Guid> value);
        partial void OnItemIdChanged();
		partial void OnItemIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnItemChaIdChanging(Nullable<Guid> value);
        partial void OnItemChaIdChanged();
		partial void OnItemChaIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnAssemblyFileIdChanging(Nullable<Guid> value);
        partial void OnAssemblyFileIdChanged();
		partial void OnAssemblyFileIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnServiceItemIdChanging(Nullable<Guid> value);
        partial void OnServiceItemIdChanged();
		partial void OnServiceItemIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnDatabaseItemIdChanging(Nullable<Guid> value);
        partial void OnDatabaseItemIdChanged();
		partial void OnDatabaseItemIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnEnableChanging(Nullable<Int32> value);
        partial void OnEnableChanged();
		partial void OnEnableGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
    }
}