using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "DanhmucTraluongNhanvien",
        spSelect = "sys_DanhmucTraluongNhanvienSelect",
        spInsert = "sys_DanhmucTraluongNhanvienInsert",
        spUpdate = "sys_DanhmucTraluongNhanvienUpdate",
        spDelete = "sys_DanhmucTraluongNhanvienDelete")]
    public partial class DanhmucTraluongNhanvienModel : Bus
    {
        private Guid _DanhmucTraluongNhanvienId;
        private Nullable<Int32> _Step;
        private Nullable<Double> _SoTien;
        private Nullable<Boolean> _IsTru;
        private Nullable<Boolean> _TinhLuong;
        private String _Ma;
        private Byte[] _Version;
        private String _Ten;
        private String _Mota;

        public DanhmucTraluongNhanvienModel()
        {
			OnCreating();
            DanhmucTraluongNhanvienId = ModelCore.GetGuidId();
			OnCreated();
        }

        public DanhmucTraluongNhanvienModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("DanhmucTraluongNhanvienId")]
	    [Column(Name="DanhmucTraluongNhanvienId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid DanhmucTraluongNhanvienId
        {
            get
			{
				Guid vGet = _DanhmucTraluongNhanvienId;
				OnDanhmucTraluongNhanvienIdGetting(ref _DanhmucTraluongNhanvienId, ref vGet);
				return vGet;
			}
            set
            {
                OnDanhmucTraluongNhanvienIdChanging(value);
                SetProperty(ref _DanhmucTraluongNhanvienId, value);
                OnDanhmucTraluongNhanvienIdChanged();
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
        
        
        [DisplayName("IsTru")]
	    [Column(Name="IsTru",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> IsTru
        {
            get
			{
				Nullable<Boolean> vGet = _IsTru;
				OnIsTruGetting(ref _IsTru, ref vGet);
				return vGet;
			}
            set
            {
                OnIsTruChanging(value);
                SetProperty(ref _IsTru, value);
                OnIsTruChanged();
            }
        }
        
        
        [DisplayName("TinhLuong")]
	    [Column(Name="TinhLuong",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> TinhLuong
        {
            get
			{
				Nullable<Boolean> vGet = _TinhLuong;
				OnTinhLuongGetting(ref _TinhLuong, ref vGet);
				return vGet;
			}
            set
            {
                OnTinhLuongChanging(value);
                SetProperty(ref _TinhLuong, value);
                OnTinhLuongChanged();
            }
        }
        
        
        [DisplayName("Ma")]
	    [Column(Name="Ma",SqlType=SqlDbType.VarChar)]
        public String Ma
        {
            get
			{
				String vGet = _Ma;
				OnMaGetting(ref _Ma, ref vGet);
				return vGet;
			}
            set
            {
                OnMaChanging(value);
                SetProperty(ref _Ma, value);
                OnMaChanged();
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
        
        
        [DisplayName("Mota")]
	    [Column(Name="Mota",SqlType=SqlDbType.NVarChar)]
        public String Mota
        {
            get
			{
				String vGet = _Mota;
				OnMotaGetting(ref _Mota, ref vGet);
				return vGet;
			}
            set
            {
                OnMotaChanging(value);
                SetProperty(ref _Mota, value);
                OnMotaChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnDanhmucTraluongNhanvienIdChanging(Guid value);
        partial void OnDanhmucTraluongNhanvienIdChanged();
		partial void OnDanhmucTraluongNhanvienIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnSoTienChanging(Nullable<Double> value);
        partial void OnSoTienChanged();
		partial void OnSoTienGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnIsTruChanging(Nullable<Boolean> value);
        partial void OnIsTruChanged();
		partial void OnIsTruGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnTinhLuongChanging(Nullable<Boolean> value);
        partial void OnTinhLuongChanged();
		partial void OnTinhLuongGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnMaChanging(String value);
        partial void OnMaChanged();
		partial void OnMaGetting(ref String value, ref String vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnTenChanging(String value);
        partial void OnTenChanged();
		partial void OnTenGetting(ref String value, ref String vGet);
        
        
        partial void OnMotaChanging(String value);
        partial void OnMotaChanged();
		partial void OnMotaGetting(ref String value, ref String vGet);
        
    }
}