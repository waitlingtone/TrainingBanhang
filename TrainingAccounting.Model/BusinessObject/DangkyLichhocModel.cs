using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "DangkyLichhoc",
        spSelect = "sys_DangkyLichhocSelect",
        spInsert = "sys_DangkyLichhocInsert",
        spUpdate = "sys_DangkyLichhocUpdate",
        spDelete = "sys_DangkyLichhocDelete")]
    public partial class DangkyLichhocModel : Bus
    {
        private Guid _DangkyLichhocId;
        private Nullable<Guid> _TreId;
        private Nullable<Guid> _CahocId;
        private Nullable<Int32> _Thu;
        private String _GioBatdau;
        private String _GioKetthuc;

        public DangkyLichhocModel()
        {
			OnCreating();
            DangkyLichhocId = ModelCore.GetGuidId();
			OnCreated();
        }

        public DangkyLichhocModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("DangkyLichhocId")]
	    [Column(Name="DangkyLichhocId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid DangkyLichhocId
        {
            get
			{
				Guid vGet = _DangkyLichhocId;
				OnDangkyLichhocIdGetting(ref _DangkyLichhocId, ref vGet);
				return vGet;
			}
            set
            {
                OnDangkyLichhocIdChanging(value);
                SetProperty(ref _DangkyLichhocId, value);
                OnDangkyLichhocIdChanged();
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
		
        
        partial void OnDangkyLichhocIdChanging(Guid value);
        partial void OnDangkyLichhocIdChanged();
		partial void OnDangkyLichhocIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnTreIdChanging(Nullable<Guid> value);
        partial void OnTreIdChanged();
		partial void OnTreIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
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