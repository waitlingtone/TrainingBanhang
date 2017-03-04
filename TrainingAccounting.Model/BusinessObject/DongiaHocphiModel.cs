using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "DongiaHocphi",
        spSelect = "sys_DongiaHocphiSelect",
        spInsert = "sys_DongiaHocphiInsert",
        spUpdate = "sys_DongiaHocphiUpdate",
        spDelete = "sys_DongiaHocphiDelete")]
    public partial class DongiaHocphiModel : Bus
    {
        private Guid _DongiaHocphiId;
        private Nullable<Guid> _TreId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _NgayApdung;
        private Nullable<Double> _Sotien;
        private Nullable<Boolean> _Sudung;
        private Byte[] _Version;
        private String _Ghichu;

        public DongiaHocphiModel()
        {
			OnCreating();
            DongiaHocphiId = ModelCore.GetGuidId();
			OnCreated();
        }

        public DongiaHocphiModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("DongiaHocphiId")]
	    [Column(Name="DongiaHocphiId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid DongiaHocphiId
        {
            get
			{
				Guid vGet = _DongiaHocphiId;
				OnDongiaHocphiIdGetting(ref _DongiaHocphiId, ref vGet);
				return vGet;
			}
            set
            {
                OnDongiaHocphiIdChanging(value);
                SetProperty(ref _DongiaHocphiId, value);
                OnDongiaHocphiIdChanged();
            }
        }
        
        
        [DisplayName("TreId")]
	    [Column(Name="TreId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> TreId
        {
            get
			{
				Nullable<Guid> vGet = _TreId;
				OnTreIdGetting(ref _TreId, ref vGet);
				return vGet;
			}
            set
            {
                OnTreIdChanging(value);
                SetProperty(ref _TreId, value);
                OnTreIdChanged();
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
        
        
        [DisplayName("NgayApdung")]
	    [Column(Name="NgayApdung",SqlType=SqlDbType.DateTime)]
        public Nullable<DateTime> NgayApdung
        {
            get
			{
				Nullable<DateTime> vGet = _NgayApdung;
				OnNgayApdungGetting(ref _NgayApdung, ref vGet);
				return vGet;
			}
            set
            {
                OnNgayApdungChanging(value);
                SetProperty(ref _NgayApdung, value);
                OnNgayApdungChanged();
            }
        }
        
        
        [DisplayName("Sotien")]
	    [Column(Name="Sotien",SqlType=SqlDbType.Float)]
        public Nullable<Double> Sotien
        {
            get
			{
				Nullable<Double> vGet = _Sotien;
				OnSotienGetting(ref _Sotien, ref vGet);
				return vGet;
			}
            set
            {
                OnSotienChanging(value);
                SetProperty(ref _Sotien, value);
                OnSotienChanged();
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
		
        
        partial void OnDongiaHocphiIdChanging(Guid value);
        partial void OnDongiaHocphiIdChanged();
		partial void OnDongiaHocphiIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnTreIdChanging(Nullable<Guid> value);
        partial void OnTreIdChanged();
		partial void OnTreIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgayApdungChanging(Nullable<DateTime> value);
        partial void OnNgayApdungChanged();
		partial void OnNgayApdungGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnSotienChanging(Nullable<Double> value);
        partial void OnSotienChanged();
		partial void OnSotienGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnSudungChanging(Nullable<Boolean> value);
        partial void OnSudungChanged();
		partial void OnSudungGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        
    }
}