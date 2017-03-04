using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Dantoc",
        spSelect = "sys_DantocSelect",
        spInsert = "sys_DantocInsert",
        spUpdate = "sys_DantocUpdate",
        spDelete = "sys_DantocDelete")]
    public partial class DantocModel : Bus
    {
        private Guid _DantocId;
        private Nullable<Int32> _Step;
        private String _MaDantoc;
        private Byte[] _Version;
        private String _TenDantoc;

        public DantocModel()
        {
			OnCreating();
            DantocId = ModelCore.GetGuidId();
			OnCreated();
        }

        public DantocModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("DantocId")]
	    [Column(Name="DantocId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid DantocId
        {
            get
			{
				Guid vGet = _DantocId;
				OnDantocIdGetting(ref _DantocId, ref vGet);
				return vGet;
			}
            set
            {
                OnDantocIdChanging(value);
                SetProperty(ref _DantocId, value);
                OnDantocIdChanged();
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
        
        
        [DisplayName("MaDantoc")]
	    [Column(Name="MaDantoc",SqlType=SqlDbType.VarChar)]
        public String MaDantoc
        {
            get
			{
				String vGet = _MaDantoc;
				OnMaDantocGetting(ref _MaDantoc, ref vGet);
				return vGet;
			}
            set
            {
                OnMaDantocChanging(value);
                SetProperty(ref _MaDantoc, value);
                OnMaDantocChanged();
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
        
        
        [DisplayName("TenDantoc")]
	    [Column(Name="TenDantoc",SqlType=SqlDbType.NVarChar)]
        public String TenDantoc
        {
            get
			{
				String vGet = _TenDantoc;
				OnTenDantocGetting(ref _TenDantoc, ref vGet);
				return vGet;
			}
            set
            {
                OnTenDantocChanging(value);
                SetProperty(ref _TenDantoc, value);
                OnTenDantocChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnDantocIdChanging(Guid value);
        partial void OnDantocIdChanged();
		partial void OnDantocIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnMaDantocChanging(String value);
        partial void OnMaDantocChanged();
		partial void OnMaDantocGetting(ref String value, ref String vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnTenDantocChanging(String value);
        partial void OnTenDantocChanged();
		partial void OnTenDantocGetting(ref String value, ref String vGet);
        
    }
}