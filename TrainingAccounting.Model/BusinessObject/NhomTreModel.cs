using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "NhomTre",
        spSelect = "sys_NhomTreSelect",
        spInsert = "sys_NhomTreInsert",
        spUpdate = "sys_NhomTreUpdate",
        spDelete = "sys_NhomTreDelete")]
    public partial class NhomTreModel : Bus
    {
        private Guid _NhomTreId;
        private Nullable<Int32> _Step;
        private Byte[] _Version;
        private String _MaNhom;
        private String _TenNhom;

        public NhomTreModel()
        {
			OnCreating();
            NhomTreId = ModelCore.GetGuidId();
			OnCreated();
        }

        public NhomTreModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("NhomTreId")]
	    [Column(Name="NhomTreId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid NhomTreId
        {
            get
			{
				Guid vGet = _NhomTreId;
				OnNhomTreIdGetting(ref _NhomTreId, ref vGet);
				return vGet;
			}
            set
            {
                OnNhomTreIdChanging(value);
                SetProperty(ref _NhomTreId, value);
                OnNhomTreIdChanged();
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
        
        
        [DisplayName("MaNhom")]
	    [Column(Name="MaNhom",SqlType=SqlDbType.NVarChar)]
        public String MaNhom
        {
            get
			{
				String vGet = _MaNhom;
				OnMaNhomGetting(ref _MaNhom, ref vGet);
				return vGet;
			}
            set
            {
                OnMaNhomChanging(value);
                SetProperty(ref _MaNhom, value);
                OnMaNhomChanged();
            }
        }
        
        
        [DisplayName("TenNhom")]
	    [Column(Name="TenNhom",SqlType=SqlDbType.NVarChar)]
        public String TenNhom
        {
            get
			{
				String vGet = _TenNhom;
				OnTenNhomGetting(ref _TenNhom, ref vGet);
				return vGet;
			}
            set
            {
                OnTenNhomChanging(value);
                SetProperty(ref _TenNhom, value);
                OnTenNhomChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnNhomTreIdChanging(Guid value);
        partial void OnNhomTreIdChanged();
		partial void OnNhomTreIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnMaNhomChanging(String value);
        partial void OnMaNhomChanged();
		partial void OnMaNhomGetting(ref String value, ref String vGet);
        
        
        partial void OnTenNhomChanging(String value);
        partial void OnTenNhomChanged();
		partial void OnTenNhomGetting(ref String value, ref String vGet);
        
    }
}