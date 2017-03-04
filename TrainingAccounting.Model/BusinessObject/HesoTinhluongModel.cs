using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "HesoTinhluong",
        spSelect = "sys_HesoTinhluongSelect",
        spInsert = "sys_HesoTinhluongInsert",
        spUpdate = "sys_HesoTinhluongUpdate",
        spDelete = "sys_HesoTinhluongDelete")]
    public partial class HesoTinhluongModel : Bus
    {
        private Guid _HesoTinhluongId;
        private Nullable<Int32> _Heso;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _NgayApdung;
        private Nullable<Boolean> _Sudung;
        private Byte[] _Version;

        public HesoTinhluongModel()
        {
			OnCreating();
            HesoTinhluongId = ModelCore.GetGuidId();
			OnCreated();
        }

        public HesoTinhluongModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("HesoTinhluongId")]
	    [Column(Name="HesoTinhluongId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid HesoTinhluongId
        {
            get
			{
				Guid vGet = _HesoTinhluongId;
				OnHesoTinhluongIdGetting(ref _HesoTinhluongId, ref vGet);
				return vGet;
			}
            set
            {
                OnHesoTinhluongIdChanging(value);
                SetProperty(ref _HesoTinhluongId, value);
                OnHesoTinhluongIdChanged();
            }
        }
        
        
        [DisplayName("Heso")]
	    [Column(Name="Heso",SqlType=SqlDbType.Int)]
        public Nullable<Int32> Heso
        {
            get
			{
				Nullable<Int32> vGet = _Heso;
				OnHesoGetting(ref _Heso, ref vGet);
				return vGet;
			}
            set
            {
                OnHesoChanging(value);
                SetProperty(ref _Heso, value);
                OnHesoChanged();
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
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnHesoTinhluongIdChanging(Guid value);
        partial void OnHesoTinhluongIdChanged();
		partial void OnHesoTinhluongIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnHesoChanging(Nullable<Int32> value);
        partial void OnHesoChanged();
		partial void OnHesoGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgayApdungChanging(Nullable<DateTime> value);
        partial void OnNgayApdungChanged();
		partial void OnNgayApdungGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnSudungChanging(Nullable<Boolean> value);
        partial void OnSudungChanged();
		partial void OnSudungGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
    }
}