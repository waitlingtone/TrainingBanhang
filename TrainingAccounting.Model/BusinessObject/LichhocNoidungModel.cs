using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "LichhocNoidung",
        spSelect = "sys_LichhocNoidungSelect",
        spInsert = "sys_LichhocNoidungInsert",
        spUpdate = "sys_LichhocNoidungUpdate",
        spDelete = "sys_LichhocNoidungDelete")]
    public partial class LichhocNoidungModel : Bus
    {
        private Guid _LichhocNoidungId;
        private Nullable<Guid> _LichhocDayhocId;
        private Nullable<Guid> _NDGiangdayId;
        private String _Noidung;

        public LichhocNoidungModel()
        {
			OnCreating();
            LichhocNoidungId = ModelCore.GetGuidId();
			OnCreated();
        }

        public LichhocNoidungModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("LichhocNoidungId")]
	    [Column(Name="LichhocNoidungId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid LichhocNoidungId
        {
            get
			{
				Guid vGet = _LichhocNoidungId;
				OnLichhocNoidungIdGetting(ref _LichhocNoidungId, ref vGet);
				return vGet;
			}
            set
            {
                OnLichhocNoidungIdChanging(value);
                SetProperty(ref _LichhocNoidungId, value);
                OnLichhocNoidungIdChanged();
            }
        }
        
        
        [DisplayName("LichhocDayhocId")]
	    [Column(Name="LichhocDayhocId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> LichhocDayhocId
        {
            get
			{
				Nullable<Guid> vGet = _LichhocDayhocId;
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
        
        
        [DisplayName("NDGiangdayId")]
	    [Column(Name="NDGiangdayId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> NDGiangdayId
        {
            get
			{
				Nullable<Guid> vGet = _NDGiangdayId;
				OnNDGiangdayIdGetting(ref _NDGiangdayId, ref vGet);
				return vGet;
			}
            set
            {
                OnNDGiangdayIdChanging(value);
                SetProperty(ref _NDGiangdayId, value);
                OnNDGiangdayIdChanged();
            }
        }
        
        
        [DisplayName("Noidung")]
	    [Column(Name="Noidung",SqlType=SqlDbType.NVarChar)]
        public String Noidung
        {
            get
			{
				String vGet = _Noidung;
				OnNoidungGetting(ref _Noidung, ref vGet);
				return vGet;
			}
            set
            {
                OnNoidungChanging(value);
                SetProperty(ref _Noidung, value);
                OnNoidungChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnLichhocNoidungIdChanging(Guid value);
        partial void OnLichhocNoidungIdChanged();
		partial void OnLichhocNoidungIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnLichhocDayhocIdChanging(Nullable<Guid> value);
        partial void OnLichhocDayhocIdChanged();
		partial void OnLichhocDayhocIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNDGiangdayIdChanging(Nullable<Guid> value);
        partial void OnNDGiangdayIdChanged();
		partial void OnNDGiangdayIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNoidungChanging(String value);
        partial void OnNoidungChanged();
		partial void OnNoidungGetting(ref String value, ref String vGet);
        
    }
}