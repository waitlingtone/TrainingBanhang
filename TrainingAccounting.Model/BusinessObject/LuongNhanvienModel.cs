using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "LuongNhanvien",
        spSelect = "sys_LuongNhanvienSelect",
        spInsert = "sys_LuongNhanvienInsert",
        spUpdate = "sys_LuongNhanvienUpdate",
        spDelete = "sys_LuongNhanvienDelete")]
    public partial class LuongNhanvienModel : Bus
    {
        private Guid _LuongNhanvienId;
        private Nullable<Guid> _NhanvienId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _NgayApdung;
        private Nullable<Double> _Mucluong;
        private Byte[] _Version;

        public LuongNhanvienModel()
        {
			OnCreating();
            LuongNhanvienId = ModelCore.GetGuidId();
			OnCreated();
        }

        public LuongNhanvienModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("LuongNhanvienId")]
	    [Column(Name="LuongNhanvienId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid LuongNhanvienId
        {
            get
			{
				Guid vGet = _LuongNhanvienId;
				OnLuongNhanvienIdGetting(ref _LuongNhanvienId, ref vGet);
				return vGet;
			}
            set
            {
                OnLuongNhanvienIdChanging(value);
                SetProperty(ref _LuongNhanvienId, value);
                OnLuongNhanvienIdChanged();
            }
        }
        
        
        [DisplayName("NhanvienId")]
	    [Column(Name="NhanvienId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> NhanvienId
        {
            get
			{
				Nullable<Guid> vGet = _NhanvienId;
				OnNhanvienIdGetting(ref _NhanvienId, ref vGet);
				return vGet;
			}
            set
            {
                OnNhanvienIdChanging(value);
                SetProperty(ref _NhanvienId, value);
                OnNhanvienIdChanged();
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
        
        
        [DisplayName("Mucluong")]
	    [Column(Name="Mucluong",SqlType=SqlDbType.Float)]
        public Nullable<Double> Mucluong
        {
            get
			{
				Nullable<Double> vGet = _Mucluong;
				OnMucluongGetting(ref _Mucluong, ref vGet);
				return vGet;
			}
            set
            {
                OnMucluongChanging(value);
                SetProperty(ref _Mucluong, value);
                OnMucluongChanged();
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
		
        
        partial void OnLuongNhanvienIdChanging(Guid value);
        partial void OnLuongNhanvienIdChanged();
		partial void OnLuongNhanvienIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnNhanvienIdChanging(Nullable<Guid> value);
        partial void OnNhanvienIdChanged();
		partial void OnNhanvienIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgayApdungChanging(Nullable<DateTime> value);
        partial void OnNgayApdungChanged();
		partial void OnNgayApdungGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnMucluongChanging(Nullable<Double> value);
        partial void OnMucluongChanged();
		partial void OnMucluongGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
    }
}