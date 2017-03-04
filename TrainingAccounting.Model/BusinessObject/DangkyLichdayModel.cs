using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "DangkyLichday",
        spSelect = "sys_DangkyLichdaySelect",
        spInsert = "sys_DangkyLichdayInsert",
        spUpdate = "sys_DangkyLichdayUpdate",
        spDelete = "sys_DangkyLichdayDelete")]
    public partial class DangkyLichdayModel : Bus
    {
        private Guid _DangkyLichdayId;
        private Nullable<Guid> _NhanvienId;
        private Nullable<Guid> _CahocId;
        private Nullable<Int32> _Thu;
        private String _GioBatdau;
        private String _GioKetthuc;

        public DangkyLichdayModel()
        {
			OnCreating();
            DangkyLichdayId = ModelCore.GetGuidId();
			OnCreated();
        }

        public DangkyLichdayModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("DangkyLichdayId")]
	    [Column(Name="DangkyLichdayId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid DangkyLichdayId
        {
            get
			{
				Guid vGet = _DangkyLichdayId;
				OnDangkyLichdayIdGetting(ref _DangkyLichdayId, ref vGet);
				return vGet;
			}
            set
            {
                OnDangkyLichdayIdChanging(value);
                SetProperty(ref _DangkyLichdayId, value);
                OnDangkyLichdayIdChanged();
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
        
        
        [DisplayName("CahocId")]
	    [Column(Name="CahocId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> CahocId
        {
            get
			{
				Nullable<Guid> vGet = _CahocId;
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
        
        
        [DisplayName("Thu")]
	    [Column(Name="Thu",SqlType=SqlDbType.Int)]
        public Nullable<Int32> Thu
        {
            get
			{
				Nullable<Int32> vGet = _Thu;
				OnThuGetting(ref _Thu, ref vGet);
				return vGet;
			}
            set
            {
                OnThuChanging(value);
                SetProperty(ref _Thu, value);
                OnThuChanged();
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
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnDangkyLichdayIdChanging(Guid value);
        partial void OnDangkyLichdayIdChanged();
		partial void OnDangkyLichdayIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnNhanvienIdChanging(Nullable<Guid> value);
        partial void OnNhanvienIdChanged();
		partial void OnNhanvienIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnCahocIdChanging(Nullable<Guid> value);
        partial void OnCahocIdChanged();
		partial void OnCahocIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnThuChanging(Nullable<Int32> value);
        partial void OnThuChanged();
		partial void OnThuGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnGioBatdauChanging(String value);
        partial void OnGioBatdauChanged();
		partial void OnGioBatdauGetting(ref String value, ref String vGet);
        
        
        partial void OnGioKetthucChanging(String value);
        partial void OnGioKetthucChanged();
		partial void OnGioKetthucGetting(ref String value, ref String vGet);
        
    }
}