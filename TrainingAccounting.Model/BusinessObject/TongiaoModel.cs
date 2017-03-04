using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Tongiao",
        spSelect = "sys_TongiaoSelect",
        spInsert = "sys_TongiaoInsert",
        spUpdate = "sys_TongiaoUpdate",
        spDelete = "sys_TongiaoDelete")]
    public partial class TongiaoModel : Bus
    {
        private Guid _TongiaoId;
        private Nullable<Int32> _Step;
        private String _MaTongiao;
        private Byte[] _Version;
        private String _TenTongiao;

        public TongiaoModel()
        {
			OnCreating();
            TongiaoId = ModelCore.GetGuidId();
			OnCreated();
        }

        public TongiaoModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("TongiaoId")]
	    [Column(Name="TongiaoId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid TongiaoId
        {
            get
			{
				Guid vGet = _TongiaoId;
				OnTongiaoIdGetting(ref _TongiaoId, ref vGet);
				return vGet;
			}
            set
            {
                OnTongiaoIdChanging(value);
                SetProperty(ref _TongiaoId, value);
                OnTongiaoIdChanged();
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
        
        
        [DisplayName("MaTongiao")]
	    [Column(Name="MaTongiao",SqlType=SqlDbType.VarChar)]
        public String MaTongiao
        {
            get
			{
				String vGet = _MaTongiao;
				OnMaTongiaoGetting(ref _MaTongiao, ref vGet);
				return vGet;
			}
            set
            {
                OnMaTongiaoChanging(value);
                SetProperty(ref _MaTongiao, value);
                OnMaTongiaoChanged();
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
        
        
        [DisplayName("TenTongiao")]
	    [Column(Name="TenTongiao",SqlType=SqlDbType.NVarChar)]
        public String TenTongiao
        {
            get
			{
				String vGet = _TenTongiao;
				OnTenTongiaoGetting(ref _TenTongiao, ref vGet);
				return vGet;
			}
            set
            {
                OnTenTongiaoChanging(value);
                SetProperty(ref _TenTongiao, value);
                OnTenTongiaoChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnTongiaoIdChanging(Guid value);
        partial void OnTongiaoIdChanged();
		partial void OnTongiaoIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnMaTongiaoChanging(String value);
        partial void OnMaTongiaoChanged();
		partial void OnMaTongiaoGetting(ref String value, ref String vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnTenTongiaoChanging(String value);
        partial void OnTenTongiaoChanged();
		partial void OnTenTongiaoGetting(ref String value, ref String vGet);
        
    }
}