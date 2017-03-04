using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace Phanquyen.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "GroupItem",
        spSelect = "sys_GroupItemSelect",
        spInsert = "sys_GroupItemInsert",
        spUpdate = "sys_GroupItemUpdate",
        spDelete = "sys_GroupItemDelete")]
    public partial class GroupItemModel : Bus
    {
        private Guid _GroupItemId;
        private String _Tennhom;
        private String _Mota;

        public GroupItemModel()
        {
			OnCreating();
            GroupItemId = ModelCore.GetGuidId();
			OnCreated();
        }

        public GroupItemModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("GroupItemId")]
	    [Column(Name="GroupItemId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid GroupItemId
        {
            get
			{
				Guid vGet = _GroupItemId;
				OnGroupItemIdGetting(ref _GroupItemId, ref vGet);
				return vGet;
			}
            set
            {
                OnGroupItemIdChanging(value);
                SetProperty(ref _GroupItemId, value);
                OnGroupItemIdChanged();
            }
        }
        
        
        [DisplayName("Tennhom")]
	    [Column(Name="Tennhom",SqlType=SqlDbType.NVarChar)]
        public String Tennhom
        {
            get
			{
				String vGet = _Tennhom;
				OnTennhomGetting(ref _Tennhom, ref vGet);
				return vGet;
			}
            set
            {
                OnTennhomChanging(value);
                SetProperty(ref _Tennhom, value);
                OnTennhomChanged();
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
		
        
        partial void OnGroupItemIdChanging(Guid value);
        partial void OnGroupItemIdChanged();
		partial void OnGroupItemIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnTennhomChanging(String value);
        partial void OnTennhomChanged();
		partial void OnTennhomGetting(ref String value, ref String vGet);
        
        
        partial void OnMotaChanging(String value);
        partial void OnMotaChanged();
		partial void OnMotaGetting(ref String value, ref String vGet);
        
    }
}