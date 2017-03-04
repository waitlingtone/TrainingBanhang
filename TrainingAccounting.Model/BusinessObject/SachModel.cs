using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Sach",
        spSelect = "sys_SachSelect",
        spInsert = "sys_SachInsert",
        spUpdate = "sys_SachUpdate",
        spDelete = "sys_SachDelete")]
    public partial class SachModel : Bus
    {
        private Guid _SachId;
        private Nullable<Int32> _Soluong;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _NgayXuatban;
        private Byte[] _Version;
        private String _TenSach;
        private String _Tacgia;

        public SachModel()
        {
			OnCreating();
            SachId = ModelCore.GetGuidId();
			OnCreated();
        }

        public SachModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("SachId")]
	    [Column(Name="SachId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid SachId
        {
            get
			{
				Guid vGet = _SachId;
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
        
        
        [DisplayName("NgayXuatban")]
	    [Column(Name="NgayXuatban",SqlType=SqlDbType.DateTime)]
        public Nullable<DateTime> NgayXuatban
        {
            get
			{
				Nullable<DateTime> vGet = _NgayXuatban;
				OnNgayXuatbanGetting(ref _NgayXuatban, ref vGet);
				return vGet;
			}
            set
            {
                OnNgayXuatbanChanging(value);
                SetProperty(ref _NgayXuatban, value);
                OnNgayXuatbanChanged();
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
        
        
        [DisplayName("TenSach")]
	    [Column(Name="TenSach",SqlType=SqlDbType.NVarChar)]
        public String TenSach
        {
            get
			{
				String vGet = _TenSach;
				OnTenSachGetting(ref _TenSach, ref vGet);
				return vGet;
			}
            set
            {
                OnTenSachChanging(value);
                SetProperty(ref _TenSach, value);
                OnTenSachChanged();
            }
        }
        
        
        [DisplayName("Tacgia")]
	    [Column(Name="Tacgia",SqlType=SqlDbType.NVarChar)]
        public String Tacgia
        {
            get
			{
				String vGet = _Tacgia;
				OnTacgiaGetting(ref _Tacgia, ref vGet);
				return vGet;
			}
            set
            {
                OnTacgiaChanging(value);
                SetProperty(ref _Tacgia, value);
                OnTacgiaChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnSachIdChanging(Guid value);
        partial void OnSachIdChanged();
		partial void OnSachIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnSoluongChanging(Nullable<Int32> value);
        partial void OnSoluongChanged();
		partial void OnSoluongGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgayXuatbanChanging(Nullable<DateTime> value);
        partial void OnNgayXuatbanChanged();
		partial void OnNgayXuatbanGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnTenSachChanging(String value);
        partial void OnTenSachChanged();
		partial void OnTenSachGetting(ref String value, ref String vGet);
        
        
        partial void OnTacgiaChanging(String value);
        partial void OnTacgiaChanged();
		partial void OnTacgiaGetting(ref String value, ref String vGet);
        
    }
}