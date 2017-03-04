using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Thuchi",
        spSelect = "sys_ThuchiSelect",
        spInsert = "sys_ThuchiInsert",
        spUpdate = "sys_ThuchiUpdate",
        spDelete = "sys_ThuchiDelete")]
    public partial class ThuchiModel : Bus
    {
        private Guid _ThuchiId;
        private Nullable<Guid> _PhieubaoHocphiId;
        private Nullable<Guid> _PhieubaoLuongNhanvienId;
        private Nullable<Guid> _DaumucThuchiId;
        private Nullable<DateTime> _NgayThanhtoan;
        private Nullable<Double> _SoTien;
        private Nullable<Boolean> _IsThu;
        private String _TenDaumuc;

        public ThuchiModel()
        {
			OnCreating();
            ThuchiId = ModelCore.GetGuidId();
			OnCreated();
        }

        public ThuchiModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("ThuchiId")]
	    [Column(Name="ThuchiId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid ThuchiId
        {
            get
			{
				Guid vGet = _ThuchiId;
				OnThuchiIdGetting(ref _ThuchiId, ref vGet);
				return vGet;
			}
            set
            {
                OnThuchiIdChanging(value);
                SetProperty(ref _ThuchiId, value);
                OnThuchiIdChanged();
            }
        }
        
        
        [DisplayName("PhieubaoHocphiId")]
	    [Column(Name="PhieubaoHocphiId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> PhieubaoHocphiId
        {
            get
			{
				Nullable<Guid> vGet = _PhieubaoHocphiId;
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
        
        
        [DisplayName("PhieubaoLuongNhanvienId")]
	    [Column(Name="PhieubaoLuongNhanvienId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> PhieubaoLuongNhanvienId
        {
            get
			{
				Nullable<Guid> vGet = _PhieubaoLuongNhanvienId;
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
        
        
        [DisplayName("DaumucThuchiId")]
	    [Column(Name="DaumucThuchiId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> DaumucThuchiId
        {
            get
			{
				Nullable<Guid> vGet = _DaumucThuchiId;
				OnDaumucThuchiIdGetting(ref _DaumucThuchiId, ref vGet);
				return vGet;
			}
            set
            {
                OnDaumucThuchiIdChanging(value);
                SetProperty(ref _DaumucThuchiId, value);
                OnDaumucThuchiIdChanged();
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
        
        
        [DisplayName("SoTien")]
	    [Column(Name="SoTien",SqlType=SqlDbType.Float)]
        public Nullable<Double> SoTien
        {
            get
			{
				Nullable<Double> vGet = _SoTien;
				OnSoTienGetting(ref _SoTien, ref vGet);
				return vGet;
			}
            set
            {
                OnSoTienChanging(value);
                SetProperty(ref _SoTien, value);
                OnSoTienChanged();
            }
        }
        
        
        [DisplayName("IsThu")]
	    [Column(Name="IsThu",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> IsThu
        {
            get
			{
				Nullable<Boolean> vGet = _IsThu;
				OnIsThuGetting(ref _IsThu, ref vGet);
				return vGet;
			}
            set
            {
                OnIsThuChanging(value);
                SetProperty(ref _IsThu, value);
                OnIsThuChanged();
            }
        }
        
        
        [DisplayName("TenDaumuc")]
	    [Column(Name="TenDaumuc",SqlType=SqlDbType.NVarChar)]
        public String TenDaumuc
        {
            get
			{
				String vGet = _TenDaumuc;
				OnTenDaumucGetting(ref _TenDaumuc, ref vGet);
				return vGet;
			}
            set
            {
                OnTenDaumucChanging(value);
                SetProperty(ref _TenDaumuc, value);
                OnTenDaumucChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnThuchiIdChanging(Guid value);
        partial void OnThuchiIdChanged();
		partial void OnThuchiIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnPhieubaoHocphiIdChanging(Nullable<Guid> value);
        partial void OnPhieubaoHocphiIdChanged();
		partial void OnPhieubaoHocphiIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnPhieubaoLuongNhanvienIdChanging(Nullable<Guid> value);
        partial void OnPhieubaoLuongNhanvienIdChanged();
		partial void OnPhieubaoLuongNhanvienIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnDaumucThuchiIdChanging(Nullable<Guid> value);
        partial void OnDaumucThuchiIdChanged();
		partial void OnDaumucThuchiIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNgayThanhtoanChanging(Nullable<DateTime> value);
        partial void OnNgayThanhtoanChanged();
		partial void OnNgayThanhtoanGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnSoTienChanging(Nullable<Double> value);
        partial void OnSoTienChanged();
		partial void OnSoTienGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnIsThuChanging(Nullable<Boolean> value);
        partial void OnIsThuChanged();
		partial void OnIsThuGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnTenDaumucChanging(String value);
        partial void OnTenDaumucChanged();
		partial void OnTenDaumucGetting(ref String value, ref String vGet);
        
    }
}