using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Tre",
        spSelect = "sys_TreSelect",
        spInsert = "sys_TreInsert",
        spUpdate = "sys_TreUpdate",
        spDelete = "sys_TreDelete")]
    public partial class TreModel : Bus
    {
        private Byte[] _Image;
        private Guid _TreId;
        private Nullable<Guid> _NhomTreId;
        private Nullable<Guid> _TinhthanhId;
        private Nullable<Guid> _QuanhuyenId;
        private Nullable<Guid> _DantocId;
        private Nullable<Guid> _TongiaoId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _Ngaysinh;
        private Nullable<Boolean> _Gioitinh;
        private Nullable<Boolean> _Conhoc;
        private Byte[] _Version;
        private String _Mavach;
        private String _Hodem;
        private String _Ten;
        private String _TenThuonggoi;
        private String _Ghichu;
        private String _Diachi;

        public TreModel()
        {
			OnCreating();
            TreId = ModelCore.GetGuidId();
			OnCreated();
        }

        public TreModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("Image")]
	    [Column(Name="Image",SqlType=SqlDbType.Image)]
        public Byte[] Image
        {
            get
			{
				Byte[] vGet = _Image;
				OnImageGetting(ref _Image, ref vGet);
				return vGet;
			}
            set
            {
                OnImageChanging(value);
                SetProperty(ref _Image, value);
                OnImageChanged();
            }
        }
        
        
        [DisplayName("TreId")]
	    [Column(Name="TreId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid TreId
        {
            get
			{
				Guid vGet = _TreId;
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
        
        
        [DisplayName("NhomTreId")]
	    [Column(Name="NhomTreId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> NhomTreId
        {
            get
			{
				Nullable<Guid> vGet = _NhomTreId;
				OnNhomTreIdGetting(ref _NhomTreId, ref vGet);
				return vGet;
			}
            set
            {
                OnNhomTreIdChanging(value);
                SetProperty(ref _NhomTreId, value);
                OnNhomTreIdChanged();
            }
        }
        
        
        [DisplayName("TinhthanhId")]
	    [Column(Name="TinhthanhId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> TinhthanhId
        {
            get
			{
				Nullable<Guid> vGet = _TinhthanhId;
				OnTinhthanhIdGetting(ref _TinhthanhId, ref vGet);
				return vGet;
			}
            set
            {
                OnTinhthanhIdChanging(value);
                SetProperty(ref _TinhthanhId, value);
                OnTinhthanhIdChanged();
            }
        }
        
        
        [DisplayName("QuanhuyenId")]
	    [Column(Name="QuanhuyenId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> QuanhuyenId
        {
            get
			{
				Nullable<Guid> vGet = _QuanhuyenId;
				OnQuanhuyenIdGetting(ref _QuanhuyenId, ref vGet);
				return vGet;
			}
            set
            {
                OnQuanhuyenIdChanging(value);
                SetProperty(ref _QuanhuyenId, value);
                OnQuanhuyenIdChanged();
            }
        }
        
        
        [DisplayName("DantocId")]
	    [Column(Name="DantocId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> DantocId
        {
            get
			{
				Nullable<Guid> vGet = _DantocId;
				OnDantocIdGetting(ref _DantocId, ref vGet);
				return vGet;
			}
            set
            {
                OnDantocIdChanging(value);
                SetProperty(ref _DantocId, value);
                OnDantocIdChanged();
            }
        }
        
        
        [DisplayName("TongiaoId")]
	    [Column(Name="TongiaoId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> TongiaoId
        {
            get
			{
				Nullable<Guid> vGet = _TongiaoId;
				OnTongiaoIdGetting(ref _TongiaoId, ref vGet);
				return vGet;
			}
            set
            {
                OnTongiaoIdChanging(value);
                SetProperty(ref _TongiaoId, value);
                OnTongiaoIdChanged();
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
        
        
        [DisplayName("Ngaysinh")]
	    [Column(Name="Ngaysinh",SqlType=SqlDbType.DateTime)]
        public Nullable<DateTime> Ngaysinh
        {
            get
			{
				Nullable<DateTime> vGet = _Ngaysinh;
				OnNgaysinhGetting(ref _Ngaysinh, ref vGet);
				return vGet;
			}
            set
            {
                OnNgaysinhChanging(value);
                SetProperty(ref _Ngaysinh, value);
                OnNgaysinhChanged();
            }
        }
        
        
        [DisplayName("Gioitinh")]
	    [Column(Name="Gioitinh",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> Gioitinh
        {
            get
			{
				Nullable<Boolean> vGet = _Gioitinh;
				OnGioitinhGetting(ref _Gioitinh, ref vGet);
				return vGet;
			}
            set
            {
                OnGioitinhChanging(value);
                SetProperty(ref _Gioitinh, value);
                OnGioitinhChanged();
            }
        }
        
        
        [DisplayName("Conhoc")]
	    [Column(Name="Conhoc",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> Conhoc
        {
            get
			{
				Nullable<Boolean> vGet = _Conhoc;
				OnConhocGetting(ref _Conhoc, ref vGet);
				return vGet;
			}
            set
            {
                OnConhocChanging(value);
                SetProperty(ref _Conhoc, value);
                OnConhocChanged();
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
        
        
        [DisplayName("Mavach")]
	    [Column(Name="Mavach",SqlType=SqlDbType.NVarChar)]
        public String Mavach
        {
            get
			{
				String vGet = _Mavach;
				OnMavachGetting(ref _Mavach, ref vGet);
				return vGet;
			}
            set
            {
                OnMavachChanging(value);
                SetProperty(ref _Mavach, value);
                OnMavachChanged();
            }
        }
        
        
        [DisplayName("Hodem")]
	    [Column(Name="Hodem",SqlType=SqlDbType.NVarChar)]
        public String Hodem
        {
            get
			{
				String vGet = _Hodem;
				OnHodemGetting(ref _Hodem, ref vGet);
				return vGet;
			}
            set
            {
                OnHodemChanging(value);
                SetProperty(ref _Hodem, value);
                OnHodemChanged();
            }
        }
        
        
        [DisplayName("Ten")]
	    [Column(Name="Ten",SqlType=SqlDbType.NVarChar)]
        public String Ten
        {
            get
			{
				String vGet = _Ten;
				OnTenGetting(ref _Ten, ref vGet);
				return vGet;
			}
            set
            {
                OnTenChanging(value);
                SetProperty(ref _Ten, value);
                OnTenChanged();
            }
        }
        
        
        [DisplayName("TenThuonggoi")]
	    [Column(Name="TenThuonggoi",SqlType=SqlDbType.NVarChar)]
        public String TenThuonggoi
        {
            get
			{
				String vGet = _TenThuonggoi;
				OnTenThuonggoiGetting(ref _TenThuonggoi, ref vGet);
				return vGet;
			}
            set
            {
                OnTenThuonggoiChanging(value);
                SetProperty(ref _TenThuonggoi, value);
                OnTenThuonggoiChanged();
            }
        }
        
        
        [DisplayName("Ghichu")]
	    [Column(Name="Ghichu",SqlType=SqlDbType.NVarChar)]
        public String Ghichu
        {
            get
			{
				String vGet = _Ghichu;
				OnGhichuGetting(ref _Ghichu, ref vGet);
				return vGet;
			}
            set
            {
                OnGhichuChanging(value);
                SetProperty(ref _Ghichu, value);
                OnGhichuChanged();
            }
        }
        
        
        [DisplayName("Diachi")]
	    [Column(Name="Diachi",SqlType=SqlDbType.NVarChar)]
        public String Diachi
        {
            get
			{
				String vGet = _Diachi;
				OnDiachiGetting(ref _Diachi, ref vGet);
				return vGet;
			}
            set
            {
                OnDiachiChanging(value);
                SetProperty(ref _Diachi, value);
                OnDiachiChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnImageChanging(Byte[] value);
        partial void OnImageChanged();
		partial void OnImageGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnTreIdChanging(Guid value);
        partial void OnTreIdChanged();
		partial void OnTreIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnNhomTreIdChanging(Nullable<Guid> value);
        partial void OnNhomTreIdChanged();
		partial void OnNhomTreIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnTinhthanhIdChanging(Nullable<Guid> value);
        partial void OnTinhthanhIdChanged();
		partial void OnTinhthanhIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnQuanhuyenIdChanging(Nullable<Guid> value);
        partial void OnQuanhuyenIdChanged();
		partial void OnQuanhuyenIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnDantocIdChanging(Nullable<Guid> value);
        partial void OnDantocIdChanged();
		partial void OnDantocIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnTongiaoIdChanging(Nullable<Guid> value);
        partial void OnTongiaoIdChanged();
		partial void OnTongiaoIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgaysinhChanging(Nullable<DateTime> value);
        partial void OnNgaysinhChanged();
		partial void OnNgaysinhGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnGioitinhChanging(Nullable<Boolean> value);
        partial void OnGioitinhChanged();
		partial void OnGioitinhGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnConhocChanging(Nullable<Boolean> value);
        partial void OnConhocChanged();
		partial void OnConhocGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnMavachChanging(String value);
        partial void OnMavachChanged();
		partial void OnMavachGetting(ref String value, ref String vGet);
        
        
        partial void OnHodemChanging(String value);
        partial void OnHodemChanged();
		partial void OnHodemGetting(ref String value, ref String vGet);
        
        
        partial void OnTenChanging(String value);
        partial void OnTenChanged();
		partial void OnTenGetting(ref String value, ref String vGet);
        
        
        partial void OnTenThuonggoiChanging(String value);
        partial void OnTenThuonggoiChanged();
		partial void OnTenThuonggoiGetting(ref String value, ref String vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        
        
        partial void OnDiachiChanging(String value);
        partial void OnDiachiChanged();
		partial void OnDiachiGetting(ref String value, ref String vGet);
        
    }
}