using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Tinhthanh",
        spSelect = "sys_TinhthanhSelect",
        spInsert = "sys_TinhthanhInsert",
        spUpdate = "sys_TinhthanhUpdate",
        spDelete = "sys_TinhthanhDelete")]
    public partial class TinhthanhModel : Bus
    {
        private Guid _TinhthanhId;
        private Nullable<Int32> _Step;
        private Byte[] _Version;
        private String _MaTinh;
        private String _TenTinh;

        public TinhthanhModel()
        {
			OnCreating();
            TinhthanhId = ModelCore.GetGuidId();
			OnCreated();
        }

        public TinhthanhModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("TinhthanhId")]
	    [Column(Name="TinhthanhId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid TinhthanhId
        {
            get
			{
				Guid vGet = _TinhthanhId;
				OnTinhthanhIdGetting(ref _TinhthanhId, ref vGet);
				return vGet;
			}
            set
            {
                OnTinhthanhIdChanging(value);
                SetProperty(ref _TinhthanhId, value);
                OnTinhthanhIdChanged();
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
        
        
        [DisplayName("MaTinh")]
	    [Column(Name="MaTinh",SqlType=SqlDbType.NVarChar)]
        public String MaTinh
        {
            get
			{
				String vGet = _MaTinh;
				OnMaTinhGetting(ref _MaTinh, ref vGet);
				return vGet;
			}
            set
            {
                OnMaTinhChanging(value);
                SetProperty(ref _MaTinh, value);
                OnMaTinhChanged();
            }
        }
        
        
        [DisplayName("TenTinh")]
	    [Column(Name="TenTinh",SqlType=SqlDbType.NVarChar)]
        public String TenTinh
        {
            get
			{
				String vGet = _TenTinh;
				OnTenTinhGetting(ref _TenTinh, ref vGet);
				return vGet;
			}
            set
            {
                OnTenTinhChanging(value);
                SetProperty(ref _TenTinh, value);
                OnTenTinhChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnTinhthanhIdChanging(Guid value);
        partial void OnTinhthanhIdChanged();
		partial void OnTinhthanhIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnMaTinhChanging(String value);
        partial void OnMaTinhChanged();
		partial void OnMaTinhGetting(ref String value, ref String vGet);
        
        
        partial void OnTenTinhChanging(String value);
        partial void OnTenTinhChanged();
		partial void OnTenTinhGetting(ref String value, ref String vGet);
        
    }
}