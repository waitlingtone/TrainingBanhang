using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "LichsuHoc",
        spSelect = "sys_LichsuHocSelect",
        spInsert = "sys_LichsuHocInsert",
        spUpdate = "sys_LichsuHocUpdate",
        spDelete = "sys_LichsuHocDelete")]
    public partial class LichsuHocModel : Bus
    {
        private Guid _LichsuHocId;
        private Nullable<Guid> _TreId;
        private Nullable<DateTime> _NgayBatdau;
        private Nullable<DateTime> _NgayKetthuc;

        public LichsuHocModel()
        {
			OnCreating();
            LichsuHocId = ModelCore.GetGuidId();
			OnCreated();
        }

        public LichsuHocModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("LichsuHocId")]
	    [Column(Name="LichsuHocId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid LichsuHocId
        {
            get
			{
				Guid vGet = _LichsuHocId;
				OnLichsuHocIdGetting(ref _LichsuHocId, ref vGet);
				return vGet;
			}
            set
            {
                OnLichsuHocIdChanging(value);
                SetProperty(ref _LichsuHocId, value);
                OnLichsuHocIdChanged();
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
        
        
        [DisplayName("NgayBatdau")]
	    [Column(Name="NgayBatdau",SqlType=SqlDbType.DateTime)]
        public Nullable<DateTime> NgayBatdau
        {
            get
			{
				Nullable<DateTime> vGet = _NgayBatdau;
				OnNgayBatdauGetting(ref _NgayBatdau, ref vGet);
				return vGet;
			}
            set
            {
                OnNgayBatdauChanging(value);
                SetProperty(ref _NgayBatdau, value);
                OnNgayBatdauChanged();
            }
        }
        
        
        [DisplayName("NgayKetthuc")]
	    [Column(Name="NgayKetthuc",SqlType=SqlDbType.DateTime)]
        public Nullable<DateTime> NgayKetthuc
        {
            get
			{
				Nullable<DateTime> vGet = _NgayKetthuc;
				OnNgayKetthucGetting(ref _NgayKetthuc, ref vGet);
				return vGet;
			}
            set
            {
                OnNgayKetthucChanging(value);
                SetProperty(ref _NgayKetthuc, value);
                OnNgayKetthucChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnLichsuHocIdChanging(Guid value);
        partial void OnLichsuHocIdChanged();
		partial void OnLichsuHocIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnTreIdChanging(Nullable<Guid> value);
        partial void OnTreIdChanged();
		partial void OnTreIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNgayBatdauChanging(Nullable<DateTime> value);
        partial void OnNgayBatdauChanged();
		partial void OnNgayBatdauGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnNgayKetthucChanging(Nullable<DateTime> value);
        partial void OnNgayKetthucChanged();
		partial void OnNgayKetthucGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
    }
}