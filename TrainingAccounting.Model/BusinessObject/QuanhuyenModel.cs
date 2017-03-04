using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Quanhuyen",
        spSelect = "sys_QuanhuyenSelect",
        spInsert = "sys_QuanhuyenInsert",
        spUpdate = "sys_QuanhuyenUpdate",
        spDelete = "sys_QuanhuyenDelete")]
    public partial class QuanhuyenModel : Bus
    {
        private Guid _QuanhuyenId;
        private Nullable<Guid> _TinhthanhId;
        private Nullable<Int32> _Step;
        private String _MaQuanhuyen;
        private Byte[] _Version;
        private String _TenQuanhuyen;

        public QuanhuyenModel()
        {
			OnCreating();
            QuanhuyenId = ModelCore.GetGuidId();
			OnCreated();
        }

        public QuanhuyenModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("QuanhuyenId")]
	    [Column(Name="QuanhuyenId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid QuanhuyenId
        {
            get
			{
				Guid vGet = _QuanhuyenId;
				OnQuanhuyenIdGetting(ref _QuanhuyenId, ref vGet);
				return vGet;
			}
            set
            {
                OnQuanhuyenIdChanging(value);
                SetProperty(ref _QuanhuyenId, value);
                OnQuanhuyenIdChanged();
            }
        }
        
        
        [DisplayName("TinhthanhId")]
	    [Column(Name="TinhthanhId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> TinhthanhId
        {
            get
			{
				Nullable<Guid> vGet = _TinhthanhId;
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
        
        
        [DisplayName("MaQuanhuyen")]
	    [Column(Name="MaQuanhuyen",SqlType=SqlDbType.VarChar)]
        public String MaQuanhuyen
        {
            get
			{
				String vGet = _MaQuanhuyen;
				OnMaQuanhuyenGetting(ref _MaQuanhuyen, ref vGet);
				return vGet;
			}
            set
            {
                OnMaQuanhuyenChanging(value);
                SetProperty(ref _MaQuanhuyen, value);
                OnMaQuanhuyenChanged();
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
        
        
        [DisplayName("TenQuanhuyen")]
	    [Column(Name="TenQuanhuyen",SqlType=SqlDbType.NVarChar)]
        public String TenQuanhuyen
        {
            get
			{
				String vGet = _TenQuanhuyen;
				OnTenQuanhuyenGetting(ref _TenQuanhuyen, ref vGet);
				return vGet;
			}
            set
            {
                OnTenQuanhuyenChanging(value);
                SetProperty(ref _TenQuanhuyen, value);
                OnTenQuanhuyenChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnQuanhuyenIdChanging(Guid value);
        partial void OnQuanhuyenIdChanged();
		partial void OnQuanhuyenIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnTinhthanhIdChanging(Nullable<Guid> value);
        partial void OnTinhthanhIdChanged();
		partial void OnTinhthanhIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnMaQuanhuyenChanging(String value);
        partial void OnMaQuanhuyenChanged();
		partial void OnMaQuanhuyenGetting(ref String value, ref String vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnTenQuanhuyenChanging(String value);
        partial void OnTenQuanhuyenChanged();
		partial void OnTenQuanhuyenGetting(ref String value, ref String vGet);
        
    }
}