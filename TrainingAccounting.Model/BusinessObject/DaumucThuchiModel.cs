using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "DaumucThuchi",
        spSelect = "sys_DaumucThuchiSelect",
        spInsert = "sys_DaumucThuchiInsert",
        spUpdate = "sys_DaumucThuchiUpdate",
        spDelete = "sys_DaumucThuchiDelete")]
    public partial class DaumucThuchiModel : Bus
    {
        private Guid _DaumucThuchiId;
        private Nullable<Boolean> _IsThu;
        private String _TenDaumuc;

        public DaumucThuchiModel()
        {
			OnCreating();
            DaumucThuchiId = ModelCore.GetGuidId();
			OnCreated();
        }

        public DaumucThuchiModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("DaumucThuchiId")]
	    [Column(Name="DaumucThuchiId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid DaumucThuchiId
        {
            get
			{
				Guid vGet = _DaumucThuchiId;
				OnDaumucThuchiIdGetting(ref _DaumucThuchiId, ref vGet);
				return vGet;
			}
            set
            {
                OnDaumucThuchiIdChanging(value);
                SetProperty(ref _DaumucThuchiId, value);
                OnDaumucThuchiIdChanged();
            }
        }
        
        
        [DisplayName("IsThu")]
	    [Column(Name="IsThu",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> IsThu
        {
            get
			{
				Nullable<Boolean> vGet = _IsThu;
				OnIsThuGetting(ref _IsThu, ref vGet);
				return vGet;
			}
            set
            {
                OnIsThuChanging(value);
                SetProperty(ref _IsThu, value);
                OnIsThuChanged();
            }
        }
        
        
        [DisplayName("TenDaumuc")]
	    [Column(Name="TenDaumuc",SqlType=SqlDbType.NVarChar)]
        public String TenDaumuc
        {
            get
			{
				String vGet = _TenDaumuc;
				OnTenDaumucGetting(ref _TenDaumuc, ref vGet);
				return vGet;
			}
            set
            {
                OnTenDaumucChanging(value);
                SetProperty(ref _TenDaumuc, value);
                OnTenDaumucChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnDaumucThuchiIdChanging(Guid value);
        partial void OnDaumucThuchiIdChanged();
		partial void OnDaumucThuchiIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnIsThuChanging(Nullable<Boolean> value);
        partial void OnIsThuChanged();
		partial void OnIsThuGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnTenDaumucChanging(String value);
        partial void OnTenDaumucChanged();
		partial void OnTenDaumucGetting(ref String value, ref String vGet);
        
    }
}