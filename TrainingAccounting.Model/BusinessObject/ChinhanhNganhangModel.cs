using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "ChinhanhNganhang",
        spSelect = "sys_ChinhanhNganhangSelect",
        spInsert = "sys_ChinhanhNganhangInsert",
        spUpdate = "sys_ChinhanhNganhangUpdate",
        spDelete = "sys_ChinhanhNganhangDelete")]
    public partial class ChinhanhNganhangModel : Bus
    {
        private Guid _ChinhanhNganhangId;
        private Nullable<Guid> _NganhangId;
        private String _TenChinhanh;
        private String _Diachi;

        public ChinhanhNganhangModel()
        {
			OnCreating();
            ChinhanhNganhangId = ModelCore.GetGuidId();
			OnCreated();
        }

        public ChinhanhNganhangModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("ChinhanhNganhangId")]
	    [Column(Name="ChinhanhNganhangId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid ChinhanhNganhangId
        {
            get
			{
				Guid vGet = _ChinhanhNganhangId;
				OnChinhanhNganhangIdGetting(ref _ChinhanhNganhangId, ref vGet);
				return vGet;
			}
            set
            {
                OnChinhanhNganhangIdChanging(value);
                SetProperty(ref _ChinhanhNganhangId, value);
                OnChinhanhNganhangIdChanged();
            }
        }
        
        
        [DisplayName("NganhangId")]
	    [Column(Name="NganhangId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> NganhangId
        {
            get
			{
				Nullable<Guid> vGet = _NganhangId;
				OnNganhangIdGetting(ref _NganhangId, ref vGet);
				return vGet;
			}
            set
            {
                OnNganhangIdChanging(value);
                SetProperty(ref _NganhangId, value);
                OnNganhangIdChanged();
            }
        }
        
        
        [DisplayName("TenChinhanh")]
	    [Column(Name="TenChinhanh",SqlType=SqlDbType.NVarChar)]
        public String TenChinhanh
        {
            get
			{
				String vGet = _TenChinhanh;
				OnTenChinhanhGetting(ref _TenChinhanh, ref vGet);
				return vGet;
			}
            set
            {
                OnTenChinhanhChanging(value);
                SetProperty(ref _TenChinhanh, value);
                OnTenChinhanhChanged();
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
		
        
        partial void OnChinhanhNganhangIdChanging(Guid value);
        partial void OnChinhanhNganhangIdChanged();
		partial void OnChinhanhNganhangIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnNganhangIdChanging(Nullable<Guid> value);
        partial void OnNganhangIdChanged();
		partial void OnNganhangIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnTenChinhanhChanging(String value);
        partial void OnTenChinhanhChanged();
		partial void OnTenChinhanhGetting(ref String value, ref String vGet);
        
        
        partial void OnDiachiChanging(String value);
        partial void OnDiachiChanged();
		partial void OnDiachiGetting(ref String value, ref String vGet);
        
    }
}