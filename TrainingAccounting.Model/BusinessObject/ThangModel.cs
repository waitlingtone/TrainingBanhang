using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Thang",
        spSelect = "sys_ThangSelect",
        spInsert = "sys_ThangInsert",
        spUpdate = "sys_ThangUpdate",
        spDelete = "sys_ThangDelete")]
    public partial class ThangModel : Bus
    {
        private Guid _ThangId;
        private Nullable<Int32> _Thang;
        private String _Tenthang;

        public ThangModel()
        {
			OnCreating();
            ThangId = ModelCore.GetGuidId();
			OnCreated();
        }

        public ThangModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("ThangId")]
	    [Column(Name="ThangId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid ThangId
        {
            get
			{
				Guid vGet = _ThangId;
				OnThangIdGetting(ref _ThangId, ref vGet);
				return vGet;
			}
            set
            {
                OnThangIdChanging(value);
                SetProperty(ref _ThangId, value);
                OnThangIdChanged();
            }
        }
        
        
        [DisplayName("Thang")]
	    [Column(Name="Thang",SqlType=SqlDbType.Int)]
        public Nullable<Int32> Thang
        {
            get
			{
				Nullable<Int32> vGet = _Thang;
				OnThangGetting(ref _Thang, ref vGet);
				return vGet;
			}
            set
            {
                OnThangChanging(value);
                SetProperty(ref _Thang, value);
                OnThangChanged();
            }
        }
        
        
        [DisplayName("Tenthang")]
	    [Column(Name="Tenthang",SqlType=SqlDbType.NVarChar)]
        public String Tenthang
        {
            get
			{
				String vGet = _Tenthang;
				OnTenthangGetting(ref _Tenthang, ref vGet);
				return vGet;
			}
            set
            {
                OnTenthangChanging(value);
                SetProperty(ref _Tenthang, value);
                OnTenthangChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnThangIdChanging(Guid value);
        partial void OnThangIdChanged();
		partial void OnThangIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnThangChanging(Nullable<Int32> value);
        partial void OnThangChanged();
		partial void OnThangGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnTenthangChanging(String value);
        partial void OnTenthangChanged();
		partial void OnTenthangGetting(ref String value, ref String vGet);
        
    }
}