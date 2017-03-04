using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "NDGiangday",
        spSelect = "sys_NDGiangdaySelect",
        spInsert = "sys_NDGiangdayInsert",
        spUpdate = "sys_NDGiangdayUpdate",
        spDelete = "sys_NDGiangdayDelete")]
    public partial class NDGiangdayModel : Bus
    {
        private Guid _NDGiangdayId;
        private String _Noidung;

        public NDGiangdayModel()
        {
			OnCreating();
            NDGiangdayId = ModelCore.GetGuidId();
			OnCreated();
        }

        public NDGiangdayModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("NDGiangdayId")]
	    [Column(Name="NDGiangdayId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid NDGiangdayId
        {
            get
			{
				Guid vGet = _NDGiangdayId;
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
		
        
        partial void OnNDGiangdayIdChanging(Guid value);
        partial void OnNDGiangdayIdChanged();
		partial void OnNDGiangdayIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnNoidungChanging(String value);
        partial void OnNoidungChanged();
		partial void OnNoidungGetting(ref String value, ref String vGet);
        
    }
}