using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "PhieubaoLuongNhanvien",
        spSelect = "sys_PhieubaoLuongNhanvienSelect",
        spInsert = "sys_PhieubaoLuongNhanvienInsert",
        spUpdate = "sys_PhieubaoLuongNhanvienUpdate",
        spDelete = "sys_PhieubaoLuongNhanvienDelete")]
    public partial class PhieubaoLuongNhanvienModel : Bus
    {
        private Guid _PhieubaoLuongNhanvienId;
        private Nullable<Guid> _NhanvienId;
        private Nullable<Int32> _Thang;
        private Nullable<Int32> _Nam;
        private Nullable<Int32> _Heso;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _NgayThanhtoan;
        private Nullable<Double> _Tongtien;
        private Nullable<Boolean> _DaThanhtoan;
        private Byte[] _Version;

        public PhieubaoLuongNhanvienModel()
        {
			OnCreating();
            PhieubaoLuongNhanvienId = ModelCore.GetGuidId();
			OnCreated();
        }

        public PhieubaoLuongNhanvienModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("PhieubaoLuongNhanvienId")]
	    [Column(Name="PhieubaoLuongNhanvienId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid PhieubaoLuongNhanvienId
        {
            get
			{
				Guid vGet = _PhieubaoLuongNhanvienId;
				OnPhieubaoLuongNhanvienIdGetting(ref _PhieubaoLuongNhanvienId, ref vGet);
				return vGet;
			}
            set
            {
                OnPhieubaoLuongNhanvienIdChanging(value);
                SetProperty(ref _PhieubaoLuongNhanvienId, value);
                OnPhieubaoLuongNhanvienIdChanged();
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
        
        
        [DisplayName("Thang")]
	    [Column(Name="Thang",SqlType=SqlDbType.Int)]
        public Nullable<Int32> Thang
        {
            get
			{
				Nullable<Int32> vGet = _Thang;
				OnThangGetting(ref _Thang, ref vGet);
				return vGet;
			}
            set
            {
                OnThangChanging(value);
                SetProperty(ref _Thang, value);
                OnThangChanged();
            }
        }
        
        
        [DisplayName("Nam")]
	    [Column(Name="Nam",SqlType=SqlDbType.Int)]
        public Nullable<Int32> Nam
        {
            get
			{
				Nullable<Int32> vGet = _Nam;
				OnNamGetting(ref _Nam, ref vGet);
				return vGet;
			}
            set
            {
                OnNamChanging(value);
                SetProperty(ref _Nam, value);
                OnNamChanged();
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
        
        
        [DisplayName("NgayThanhtoan")]
	    [Column(Name="NgayThanhtoan",SqlType=SqlDbType.DateTime)]
        public Nullable<DateTime> NgayThanhtoan
        {
            get
			{
				Nullable<DateTime> vGet = _NgayThanhtoan;
				OnNgayThanhtoanGetting(ref _NgayThanhtoan, ref vGet);
				return vGet;
			}
            set
            {
                OnNgayThanhtoanChanging(value);
                SetProperty(ref _NgayThanhtoan, value);
                OnNgayThanhtoanChanged();
            }
        }
        
        
        [DisplayName("Tongtien")]
	    [Column(Name="Tongtien",SqlType=SqlDbType.Float)]
        public Nullable<Double> Tongtien
        {
            get
			{
				Nullable<Double> vGet = _Tongtien;
				OnTongtienGetting(ref _Tongtien, ref vGet);
				return vGet;
			}
            set
            {
                OnTongtienChanging(value);
                SetProperty(ref _Tongtien, value);
                OnTongtienChanged();
            }
        }
        
        
        [DisplayName("DaThanhtoan")]
	    [Column(Name="DaThanhtoan",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> DaThanhtoan
        {
            get
			{
				Nullable<Boolean> vGet = _DaThanhtoan;
				OnDaThanhtoanGetting(ref _DaThanhtoan, ref vGet);
				return vGet;
			}
            set
            {
                OnDaThanhtoanChanging(value);
                SetProperty(ref _DaThanhtoan, value);
                OnDaThanhtoanChanged();
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
		
        
        partial void OnPhieubaoLuongNhanvienIdChanging(Guid value);
        partial void OnPhieubaoLuongNhanvienIdChanged();
		partial void OnPhieubaoLuongNhanvienIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnNhanvienIdChanging(Nullable<Guid> value);
        partial void OnNhanvienIdChanged();
		partial void OnNhanvienIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnThangChanging(Nullable<Int32> value);
        partial void OnThangChanged();
		partial void OnThangGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNamChanging(Nullable<Int32> value);
        partial void OnNamChanged();
		partial void OnNamGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnHesoChanging(Nullable<Int32> value);
        partial void OnHesoChanged();
		partial void OnHesoGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgayThanhtoanChanging(Nullable<DateTime> value);
        partial void OnNgayThanhtoanChanged();
		partial void OnNgayThanhtoanGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnTongtienChanging(Nullable<Double> value);
        partial void OnTongtienChanged();
		partial void OnTongtienGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnDaThanhtoanChanging(Nullable<Boolean> value);
        partial void OnDaThanhtoanChanged();
		partial void OnDaThanhtoanGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
    }
}