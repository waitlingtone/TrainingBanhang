using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "GiaSach",
        spSelect = "sys_GiaSachSelect",
        spInsert = "sys_GiaSachInsert",
        spUpdate = "sys_GiaSachUpdate",
        spDelete = "sys_GiaSachDelete")]
    public partial class GiaSachModel : Bus
    {
        private Guid _GiaSachId;
        private Nullable<Guid> _SachId;
        private Nullable<DateTime> _NgayApdung;
        private Nullable<Double> _Dongia;

        public GiaSachModel()
        {
			OnCreating();
            GiaSachId = ModelCore.GetGuidId();
			OnCreated();
        }

        public GiaSachModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("GiaSachId")]
	    [Column(Name="GiaSachId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid GiaSachId
        {
            get
			{
				Guid vGet = _GiaSachId;
				OnGiaSachIdGetting(ref _GiaSachId, ref vGet);
				return vGet;
			}
            set
            {
                OnGiaSachIdChanging(value);
                SetProperty(ref _GiaSachId, value);
                OnGiaSachIdChanged();
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
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnGiaSachIdChanging(Guid value);
        partial void OnGiaSachIdChanged();
		partial void OnGiaSachIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnSachIdChanging(Nullable<Guid> value);
        partial void OnSachIdChanged();
		partial void OnSachIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNgayApdungChanging(Nullable<DateTime> value);
        partial void OnNgayApdungChanged();
		partial void OnNgayApdungGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnDongiaChanging(Nullable<Double> value);
        partial void OnDongiaChanged();
		partial void OnDongiaGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
    }
}