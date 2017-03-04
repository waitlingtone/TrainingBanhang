using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Thu",
        spSelect = "sys_ThuSelect",
        spInsert = "sys_ThuInsert",
        spUpdate = "sys_ThuUpdate",
        spDelete = "sys_ThuDelete")]
    public partial class ThuModel : Bus
    {
        private Guid _ThuId;
        private Nullable<Int32> _STT;
        private Nullable<Boolean> _Sudung;
        private String _Thu;

        public ThuModel()
        {
			OnCreating();
            ThuId = ModelCore.GetGuidId();
			OnCreated();
        }

        public ThuModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("ThuId")]
	    [Column(Name="ThuId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid ThuId
        {
            get
			{
				Guid vGet = _ThuId;
				OnThuIdGetting(ref _ThuId, ref vGet);
				return vGet;
			}
            set
            {
                OnThuIdChanging(value);
                SetProperty(ref _ThuId, value);
                OnThuIdChanged();
            }
        }
        
        
        [DisplayName("STT")]
	    [Column(Name="STT",SqlType=SqlDbType.Int)]
        public Nullable<Int32> STT
        {
            get
			{
				Nullable<Int32> vGet = _STT;
				OnSTTGetting(ref _STT, ref vGet);
				return vGet;
			}
            set
            {
                OnSTTChanging(value);
                SetProperty(ref _STT, value);
                OnSTTChanged();
            }
        }
        
        
        [DisplayName("Sudung")]
	    [Column(Name="Sudung",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> Sudung
        {
            get
			{
				Nullable<Boolean> vGet = _Sudung;
				OnSudungGetting(ref _Sudung, ref vGet);
				return vGet;
			}
            set
            {
                OnSudungChanging(value);
                SetProperty(ref _Sudung, value);
                OnSudungChanged();
            }
        }
        
        
        [DisplayName("Thu")]
	    [Column(Name="Thu",SqlType=SqlDbType.NVarChar)]
        public String Thu
        {
            get
			{
				String vGet = _Thu;
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
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnThuIdChanging(Guid value);
        partial void OnThuIdChanged();
		partial void OnThuIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnSTTChanging(Nullable<Int32> value);
        partial void OnSTTChanged();
		partial void OnSTTGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnSudungChanging(Nullable<Boolean> value);
        partial void OnSudungChanged();
		partial void OnSudungGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnThuChanging(String value);
        partial void OnThuChanged();
		partial void OnThuGetting(ref String value, ref String vGet);
        
    }
}