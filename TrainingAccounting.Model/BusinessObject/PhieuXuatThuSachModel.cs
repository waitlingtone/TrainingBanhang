using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "PhieuXuatThuSach",
        spSelect = "sys_PhieuXuatThuSachSelect",
        spInsert = "sys_PhieuXuatThuSachInsert",
        spUpdate = "sys_PhieuXuatThuSachUpdate",
        spDelete = "sys_PhieuXuatThuSachDelete")]
    public partial class PhieuXuatThuSachModel : Bus
    {
        private Guid _PhieuXuatThuSachId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _Ngay;
        private Nullable<DateTime> _Ngaythuve;
        private Nullable<Double> _Tongtien;
        private Nullable<Boolean> _Trangthai;
        private Nullable<Boolean> _IsXuat;
        private Byte[] _Version;
        private String _DonviNhan;

        public PhieuXuatThuSachModel()
        {
			OnCreating();
            PhieuXuatThuSachId = ModelCore.GetGuidId();
			OnCreated();
        }

        public PhieuXuatThuSachModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("PhieuXuatThuSachId")]
	    [Column(Name="PhieuXuatThuSachId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid PhieuXuatThuSachId
        {
            get
			{
				Guid vGet = _PhieuXuatThuSachId;
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
        
        
        [DisplayName("Ngay")]
	    [Column(Name="Ngay",SqlType=SqlDbType.DateTime)]
        public Nullable<DateTime> Ngay
        {
            get
			{
				Nullable<DateTime> vGet = _Ngay;
				OnNgayGetting(ref _Ngay, ref vGet);
				return vGet;
			}
            set
            {
                OnNgayChanging(value);
                SetProperty(ref _Ngay, value);
                OnNgayChanged();
            }
        }
        
        
        [DisplayName("Ngaythuve")]
	    [Column(Name="Ngaythuve",SqlType=SqlDbType.DateTime)]
        public Nullable<DateTime> Ngaythuve
        {
            get
			{
				Nullable<DateTime> vGet = _Ngaythuve;
				OnNgaythuveGetting(ref _Ngaythuve, ref vGet);
				return vGet;
			}
            set
            {
                OnNgaythuveChanging(value);
                SetProperty(ref _Ngaythuve, value);
                OnNgaythuveChanged();
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
        
        
        [DisplayName("Trangthai")]
	    [Column(Name="Trangthai",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> Trangthai
        {
            get
			{
				Nullable<Boolean> vGet = _Trangthai;
				OnTrangthaiGetting(ref _Trangthai, ref vGet);
				return vGet;
			}
            set
            {
                OnTrangthaiChanging(value);
                SetProperty(ref _Trangthai, value);
                OnTrangthaiChanged();
            }
        }
        
        
        [DisplayName("IsXuat")]
	    [Column(Name="IsXuat",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> IsXuat
        {
            get
			{
				Nullable<Boolean> vGet = _IsXuat;
				OnIsXuatGetting(ref _IsXuat, ref vGet);
				return vGet;
			}
            set
            {
                OnIsXuatChanging(value);
                SetProperty(ref _IsXuat, value);
                OnIsXuatChanged();
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
        
        
        [DisplayName("DonviNhan")]
	    [Column(Name="DonviNhan",SqlType=SqlDbType.NVarChar)]
        public String DonviNhan
        {
            get
			{
				String vGet = _DonviNhan;
				OnDonviNhanGetting(ref _DonviNhan, ref vGet);
				return vGet;
			}
            set
            {
                OnDonviNhanChanging(value);
                SetProperty(ref _DonviNhan, value);
                OnDonviNhanChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnPhieuXuatThuSachIdChanging(Guid value);
        partial void OnPhieuXuatThuSachIdChanged();
		partial void OnPhieuXuatThuSachIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgayChanging(Nullable<DateTime> value);
        partial void OnNgayChanged();
		partial void OnNgayGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnNgaythuveChanging(Nullable<DateTime> value);
        partial void OnNgaythuveChanged();
		partial void OnNgaythuveGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnTongtienChanging(Nullable<Double> value);
        partial void OnTongtienChanged();
		partial void OnTongtienGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnTrangthaiChanging(Nullable<Boolean> value);
        partial void OnTrangthaiChanged();
		partial void OnTrangthaiGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnIsXuatChanging(Nullable<Boolean> value);
        partial void OnIsXuatChanged();
		partial void OnIsXuatGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnDonviNhanChanging(String value);
        partial void OnDonviNhanChanged();
		partial void OnDonviNhanGetting(ref String value, ref String vGet);
        
    }
}