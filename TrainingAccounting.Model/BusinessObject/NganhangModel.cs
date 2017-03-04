using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Nganhang",
        spSelect = "sys_NganhangSelect",
        spInsert = "sys_NganhangInsert",
        spUpdate = "sys_NganhangUpdate",
        spDelete = "sys_NganhangDelete")]
    public partial class NganhangModel : Bus
    {
        private Guid _NganhangId;
        private String _TenNganhang;
        private String _Ghichu;

        public NganhangModel()
        {
			OnCreating();
            NganhangId = ModelCore.GetGuidId();
			OnCreated();
        }

        public NganhangModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("NganhangId")]
	    [Column(Name="NganhangId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid NganhangId
        {
            get
			{
				Guid vGet = _NganhangId;
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
        
        
        [DisplayName("TenNganhang")]
	    [Column(Name="TenNganhang",SqlType=SqlDbType.NVarChar)]
        public String TenNganhang
        {
            get
			{
				String vGet = _TenNganhang;
				OnTenNganhangGetting(ref _TenNganhang, ref vGet);
				return vGet;
			}
            set
            {
                OnTenNganhangChanging(value);
                SetProperty(ref _TenNganhang, value);
                OnTenNganhangChanged();
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
		
        
        partial void OnNganhangIdChanging(Guid value);
        partial void OnNganhangIdChanged();
		partial void OnNganhangIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnTenNganhangChanging(String value);
        partial void OnTenNganhangChanged();
		partial void OnTenNganhangGetting(ref String value, ref String vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        
    }
}