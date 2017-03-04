using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "PhieubaoHocphi",
        spSelect = "sys_PhieubaoHocphiSelect",
        spInsert = "sys_PhieubaoHocphiInsert",
        spUpdate = "sys_PhieubaoHocphiUpdate",
        spDelete = "sys_PhieubaoHocphiDelete")]
    public partial class PhieubaoHocphiModel : Bus
    {
        private Guid _PhieubaoHocphiId;
        private Nullable<Guid> _TreId;
        private Nullable<Int32> _Thang;
        private Nullable<Int32> _Nam;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _NgayGhino;
        private Nullable<Double> _Sotien;
        private Nullable<Boolean> _DaThanhtoan;
        private Byte[] _Version;

        public PhieubaoHocphiModel()
        {
			OnCreating();
            PhieubaoHocphiId = ModelCore.GetGuidId();
			OnCreated();
        }

        public PhieubaoHocphiModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("PhieubaoHocphiId")]
	    [Column(Name="PhieubaoHocphiId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid PhieubaoHocphiId
        {
            get
			{
				Guid vGet = _PhieubaoHocphiId;
				OnPhieubaoHocphiIdGetting(ref _PhieubaoHocphiId, ref vGet);
				return vGet;
			}
            set
            {
                OnPhieubaoHocphiIdChanging(value);
                SetProperty(ref _PhieubaoHocphiId, value);
                OnPhieubaoHocphiIdChanged();
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
        
        
        [DisplayName("NgayGhino")]
	    [Column(Name="NgayGhino",SqlType=SqlDbType.DateTime)]
        public Nullable<DateTime> NgayGhino
        {
            get
			{
				Nullable<DateTime> vGet = _NgayGhino;
				OnNgayGhinoGetting(ref _NgayGhino, ref vGet);
				return vGet;
			}
            set
            {
                OnNgayGhinoChanging(value);
                SetProperty(ref _NgayGhino, value);
                OnNgayGhinoChanged();
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
		
        
        partial void OnPhieubaoHocphiIdChanging(Guid value);
        partial void OnPhieubaoHocphiIdChanged();
		partial void OnPhieubaoHocphiIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnTreIdChanging(Nullable<Guid> value);
        partial void OnTreIdChanged();
		partial void OnTreIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnThangChanging(Nullable<Int32> value);
        partial void OnThangChanged();
		partial void OnThangGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNamChanging(Nullable<Int32> value);
        partial void OnNamChanged();
		partial void OnNamGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgayGhinoChanging(Nullable<DateTime> value);
        partial void OnNgayGhinoChanged();
		partial void OnNgayGhinoGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnSotienChanging(Nullable<Double> value);
        partial void OnSotienChanged();
		partial void OnSotienGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnDaThanhtoanChanging(Nullable<Boolean> value);
        partial void OnDaThanhtoanChanged();
		partial void OnDaThanhtoanGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
    }
}