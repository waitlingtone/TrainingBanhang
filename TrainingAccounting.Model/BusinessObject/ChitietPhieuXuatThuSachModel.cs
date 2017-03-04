using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "ChitietPhieuXuatThuSach",
        spSelect = "sys_ChitietPhieuXuatThuSachSelect",
        spInsert = "sys_ChitietPhieuXuatThuSachInsert",
        spUpdate = "sys_ChitietPhieuXuatThuSachUpdate",
        spDelete = "sys_ChitietPhieuXuatThuSachDelete")]
    public partial class ChitietPhieuXuatThuSachModel : Bus
    {
        private Guid _ChitietPhieuXuatThuSachId;
        private Nullable<Guid> _PhieuXuatThuSachId;
        private Nullable<Guid> _SachId;
        private Nullable<Int32> _Soluong;
        private Nullable<Int32> _Step;
        private Nullable<Double> _Dongia;
        private Nullable<Double> _Thanhtien;
        private Byte[] _Version;

        public ChitietPhieuXuatThuSachModel()
        {
			OnCreating();
            ChitietPhieuXuatThuSachId = ModelCore.GetGuidId();
			OnCreated();
        }

        public ChitietPhieuXuatThuSachModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("ChitietPhieuXuatThuSachId")]
	    [Column(Name="ChitietPhieuXuatThuSachId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid ChitietPhieuXuatThuSachId
        {
            get
			{
				Guid vGet = _ChitietPhieuXuatThuSachId;
				OnChitietPhieuXuatThuSachIdGetting(ref _ChitietPhieuXuatThuSachId, ref vGet);
				return vGet;
			}
            set
            {
                OnChitietPhieuXuatThuSachIdChanging(value);
                SetProperty(ref _ChitietPhieuXuatThuSachId, value);
                OnChitietPhieuXuatThuSachIdChanged();
            }
        }
        
        
        [DisplayName("PhieuXuatThuSachId")]
	    [Column(Name="PhieuXuatThuSachId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> PhieuXuatThuSachId
        {
            get
			{
				Nullable<Guid> vGet = _PhieuXuatThuSachId;
				OnPhieuXuatThuSachIdGetting(ref _PhieuXuatThuSachId, ref vGet);
				return vGet;
			}
            set
            {
                OnPhieuXuatThuSachIdChanging(value);
                SetProperty(ref _PhieuXuatThuSachId, value);
                OnPhieuXuatThuSachIdChanged();
            }
        }
        
        
        [DisplayName("SachId")]
	    [Column(Name="SachId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> SachId
        {
            get
			{
				Nullable<Guid> vGet = _SachId;
				OnSachIdGetting(ref _SachId, ref vGet);
				return vGet;
			}
            set
            {
                OnSachIdChanging(value);
                SetProperty(ref _SachId, value);
                OnSachIdChanged();
            }
        }
        
        
        [DisplayName("Soluong")]
	    [Column(Name="Soluong",SqlType=SqlDbType.Int)]
        public Nullable<Int32> Soluong
        {
            get
			{
				Nullable<Int32> vGet = _Soluong;
				OnSoluongGetting(ref _Soluong, ref vGet);
				return vGet;
			}
            set
            {
                OnSoluongChanging(value);
                SetProperty(ref _Soluong, value);
                OnSoluongChanged();
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
        
        
        [DisplayName("Dongia")]
	    [Column(Name="Dongia",SqlType=SqlDbType.Float)]
        public Nullable<Double> Dongia
        {
            get
			{
				Nullable<Double> vGet = _Dongia;
				OnDongiaGetting(ref _Dongia, ref vGet);
				return vGet;
			}
            set
            {
                OnDongiaChanging(value);
                SetProperty(ref _Dongia, value);
                OnDongiaChanged();
            }
        }
        
        
        [DisplayName("Thanhtien")]
	    [Column(Name="Thanhtien",SqlType=SqlDbType.Float)]
        public Nullable<Double> Thanhtien
        {
            get
			{
				Nullable<Double> vGet = _Thanhtien;
				OnThanhtienGetting(ref _Thanhtien, ref vGet);
				return vGet;
			}
            set
            {
                OnThanhtienChanging(value);
                SetProperty(ref _Thanhtien, value);
                OnThanhtienChanged();
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
		
        
        partial void OnChitietPhieuXuatThuSachIdChanging(Guid value);
        partial void OnChitietPhieuXuatThuSachIdChanged();
		partial void OnChitietPhieuXuatThuSachIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnPhieuXuatThuSachIdChanging(Nullable<Guid> value);
        partial void OnPhieuXuatThuSachIdChanged();
		partial void OnPhieuXuatThuSachIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnSachIdChanging(Nullable<Guid> value);
        partial void OnSachIdChanged();
		partial void OnSachIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnSoluongChanging(Nullable<Int32> value);
        partial void OnSoluongChanged();
		partial void OnSoluongGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnDongiaChanging(Nullable<Double> value);
        partial void OnDongiaChanged();
		partial void OnDongiaGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnThanhtienChanging(Nullable<Double> value);
        partial void OnThanhtienChanged();
		partial void OnThanhtienGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
    }
}