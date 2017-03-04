using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Cahoc",
        spSelect = "sys_CahocSelect",
        spInsert = "sys_CahocInsert",
        spUpdate = "sys_CahocUpdate",
        spDelete = "sys_CahocDelete")]
    public partial class CahocModel : Bus
    {
        private Guid _CahocId;
        private Nullable<Int32> _Step;
        private Nullable<Boolean> _Sudung;
        private String _GioBatdau;
        private String _GioKetthuc;
        private Byte[] _Version;
        private String _MaCa;
        private String _TenCa;

        public CahocModel()
        {
			OnCreating();
            CahocId = ModelCore.GetGuidId();
			OnCreated();
        }

        public CahocModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("CahocId")]
	    [Column(Name="CahocId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid CahocId
        {
            get
			{
				Guid vGet = _CahocId;
				OnCahocIdGetting(ref _CahocId, ref vGet);
				return vGet;
			}
            set
            {
                OnCahocIdChanging(value);
                SetProperty(ref _CahocId, value);
                OnCahocIdChanged();
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
        
        
        [DisplayName("Sudung")]
	    [Column(Name="Sudung",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> Sudung
        {
            get
			{
				Nullable<Boolean> vGet = _Sudung;
				OnSudungGetting(ref _Sudung, ref vGet);
				return vGet;
			}
            set
            {
                OnSudungChanging(value);
                SetProperty(ref _Sudung, value);
                OnSudungChanged();
            }
        }
        
        
        [DisplayName("GioBatdau")]
	    [Column(Name="GioBatdau",SqlType=SqlDbType.VarChar)]
        public String GioBatdau
        {
            get
			{
				String vGet = _GioBatdau;
				OnGioBatdauGetting(ref _GioBatdau, ref vGet);
				return vGet;
			}
            set
            {
                OnGioBatdauChanging(value);
                SetProperty(ref _GioBatdau, value);
                OnGioBatdauChanged();
            }
        }
        
        
        [DisplayName("GioKetthuc")]
	    [Column(Name="GioKetthuc",SqlType=SqlDbType.VarChar)]
        public String GioKetthuc
        {
            get
			{
				String vGet = _GioKetthuc;
				OnGioKetthucGetting(ref _GioKetthuc, ref vGet);
				return vGet;
			}
            set
            {
                OnGioKetthucChanging(value);
                SetProperty(ref _GioKetthuc, value);
                OnGioKetthucChanged();
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
        
        
        [DisplayName("MaCa")]
	    [Column(Name="MaCa",SqlType=SqlDbType.NVarChar)]
        public String MaCa
        {
            get
			{
				String vGet = _MaCa;
				OnMaCaGetting(ref _MaCa, ref vGet);
				return vGet;
			}
            set
            {
                OnMaCaChanging(value);
                SetProperty(ref _MaCa, value);
                OnMaCaChanged();
            }
        }
        
        
        [DisplayName("TenCa")]
	    [Column(Name="TenCa",SqlType=SqlDbType.NVarChar)]
        public String TenCa
        {
            get
			{
				String vGet = _TenCa;
				OnTenCaGetting(ref _TenCa, ref vGet);
				return vGet;
			}
            set
            {
                OnTenCaChanging(value);
                SetProperty(ref _TenCa, value);
                OnTenCaChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnCahocIdChanging(Guid value);
        partial void OnCahocIdChanged();
		partial void OnCahocIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnSudungChanging(Nullable<Boolean> value);
        partial void OnSudungChanged();
		partial void OnSudungGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnGioBatdauChanging(String value);
        partial void OnGioBatdauChanged();
		partial void OnGioBatdauGetting(ref String value, ref String vGet);
        
        
        partial void OnGioKetthucChanging(String value);
        partial void OnGioKetthucChanged();
		partial void OnGioKetthucGetting(ref String value, ref String vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnMaCaChanging(String value);
        partial void OnMaCaChanged();
		partial void OnMaCaGetting(ref String value, ref String vGet);
        
        
        partial void OnTenCaChanging(String value);
        partial void OnTenCaChanged();
		partial void OnTenCaGetting(ref String value, ref String vGet);
        
    }
}