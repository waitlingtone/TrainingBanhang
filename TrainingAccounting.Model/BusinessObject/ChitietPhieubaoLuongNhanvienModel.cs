using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "ChitietPhieubaoLuongNhanvien",
        spSelect = "sys_ChitietPhieubaoLuongNhanvienSelect",
        spInsert = "sys_ChitietPhieubaoLuongNhanvienInsert",
        spUpdate = "sys_ChitietPhieubaoLuongNhanvienUpdate",
        spDelete = "sys_ChitietPhieubaoLuongNhanvienDelete")]
    public partial class ChitietPhieubaoLuongNhanvienModel : Bus
    {
        private Guid _ChitietPhieubaoLuongNhanvienId;
        private Nullable<Guid> _PhieubaoLuongNhanvienId;
        private Nullable<Int32> _Heso;
        private Nullable<Int32> _Step;
        private Nullable<Double> _SoTien;
        private String _Ma;
        private Byte[] _Version;
        private String _DanhmucTraluongNhanvien;
        private String _Mota;

        public ChitietPhieubaoLuongNhanvienModel()
        {
			OnCreating();
            ChitietPhieubaoLuongNhanvienId = ModelCore.GetGuidId();
			OnCreated();
        }

        public ChitietPhieubaoLuongNhanvienModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("ChitietPhieubaoLuongNhanvienId")]
	    [Column(Name="ChitietPhieubaoLuongNhanvienId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid ChitietPhieubaoLuongNhanvienId
        {
            get
			{
				Guid vGet = _ChitietPhieubaoLuongNhanvienId;
				OnChitietPhieubaoLuongNhanvienIdGetting(ref _ChitietPhieubaoLuongNhanvienId, ref vGet);
				return vGet;
			}
            set
            {
                OnChitietPhieubaoLuongNhanvienIdChanging(value);
                SetProperty(ref _ChitietPhieubaoLuongNhanvienId, value);
                OnChitietPhieubaoLuongNhanvienIdChanged();
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
        
        
        [DisplayName("Heso")]
	    [Column(Name="Heso",SqlType=SqlDbType.Int)]
        public Nullable<Int32> Heso
        {
            get
			{
				Nullable<Int32> vGet = _Heso;
				OnHesoGetting(ref _Heso, ref vGet);
				return vGet;
			}
            set
            {
                OnHesoChanging(value);
                SetProperty(ref _Heso, value);
                OnHesoChanged();
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
        
        
        [DisplayName("DanhmucTraluongNhanvien")]
	    [Column(Name="DanhmucTraluongNhanvien",SqlType=SqlDbType.NVarChar)]
        public String DanhmucTraluongNhanvien
        {
            get
			{
				String vGet = _DanhmucTraluongNhanvien;
				OnDanhmucTraluongNhanvienGetting(ref _DanhmucTraluongNhanvien, ref vGet);
				return vGet;
			}
            set
            {
                OnDanhmucTraluongNhanvienChanging(value);
                SetProperty(ref _DanhmucTraluongNhanvien, value);
                OnDanhmucTraluongNhanvienChanged();
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
		
        
        partial void OnChitietPhieubaoLuongNhanvienIdChanging(Guid value);
        partial void OnChitietPhieubaoLuongNhanvienIdChanged();
		partial void OnChitietPhieubaoLuongNhanvienIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnPhieubaoLuongNhanvienIdChanging(Nullable<Guid> value);
        partial void OnPhieubaoLuongNhanvienIdChanged();
		partial void OnPhieubaoLuongNhanvienIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnHesoChanging(Nullable<Int32> value);
        partial void OnHesoChanged();
		partial void OnHesoGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnSoTienChanging(Nullable<Double> value);
        partial void OnSoTienChanged();
		partial void OnSoTienGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnMaChanging(String value);
        partial void OnMaChanged();
		partial void OnMaGetting(ref String value, ref String vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnDanhmucTraluongNhanvienChanging(String value);
        partial void OnDanhmucTraluongNhanvienChanged();
		partial void OnDanhmucTraluongNhanvienGetting(ref String value, ref String vGet);
        
        
        partial void OnMotaChanging(String value);
        partial void OnMotaChanged();
		partial void OnMotaGetting(ref String value, ref String vGet);
        
    }
}