using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace Phanquyen.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Nguoidung",
        spSelect = "sys_NguoidungSelect",
        spInsert = "sys_NguoidungInsert",
        spUpdate = "sys_NguoidungUpdate",
        spDelete = "sys_NguoidungDelete")]
    public partial class NguoidungModel : Bus
    {
        private Guid _NguoidungId;
        private String _TenNguoidung;

        public NguoidungModel()
        {
			OnCreating();
            NguoidungId = ModelCore.GetGuidId();
			OnCreated();
        }

        public NguoidungModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("NguoidungId")]
	    [Column(Name="NguoidungId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid NguoidungId
        {
            get
			{
				Guid vGet = _NguoidungId;
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
        
        
        [DisplayName("TenNguoidung")]
	    [Column(Name="TenNguoidung",SqlType=SqlDbType.NVarChar)]
        public String TenNguoidung
        {
            get
			{
				String vGet = _TenNguoidung;
				OnTenNguoidungGetting(ref _TenNguoidung, ref vGet);
				return vGet;
			}
            set
            {
                OnTenNguoidungChanging(value);
                SetProperty(ref _TenNguoidung, value);
                OnTenNguoidungChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnNguoidungIdChanging(Guid value);
        partial void OnNguoidungIdChanged();
		partial void OnNguoidungIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnTenNguoidungChanging(String value);
        partial void OnTenNguoidungChanged();
		partial void OnTenNguoidungGetting(ref String value, ref String vGet);
        
    }
}