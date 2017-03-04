using Lambda.BusinessObject;
using Lambda.ClientModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAccounting.Model.BusinessObject
{
    [Table(Schema = "dbo", Name = "Hoadon",
         spSelect = "sys_HoadonSelect",
         spInsert = "sys_HoadonInsert",
         spUpdate = "sys_HoadonUpdate",
         spDelete = "sys_HoadonDelete")]
    public partial class HoadonModel : Bus
    {
        private Guid _HoadonId;

        private Nullable<DateTime> _Ngaylap;
        private Nullable<Decimal> _Trigia;
        private Byte[] _Version;



        public HoadonModel()
        {
            OnCreating();
            HoadonId = ModelCore.GetGuidId();
            OnCreated();
        }

        public HoadonModel(AutoObject value)
        {
            OnCreating();
            DataFromAutoObject(value);
            OnCreated();
        }

        [DisplayName("HoadonId")]
        [Column(Name = "HoadonId", SqlType = SqlDbType.UniqueIdentifier)]
        public Guid HoadonId
        {
            get
            {
                Guid vGet = _HoadonId;
                OnHoadonIdGetting(ref _HoadonId, ref vGet);
                return vGet;
            }
            set
            {
                OnHoadonIdChanging(value);
                SetProperty(ref _HoadonId, value);
                OnHoadonIdChanged();
            }
        }


        [DisplayName("Ngaylap")]
        [Column(Name = "Ngaylap", SqlType = SqlDbType.DateTime)]
        public Nullable<DateTime> Ngaylap
        {
            get
            {
                Nullable<DateTime> vGet = _Ngaylap;
                OnNgaylapGetting(ref _Ngaylap, ref vGet);
                return vGet;
            }
            set
            {
                OnNgaylapChanging(value);
                SetProperty(ref _Ngaylap, value);
                OnNgaylapChanged();
            }
        }


        [DisplayName("Trigia")]
        [Column(Name = "Trigia", SqlType = SqlDbType.Decimal)]
        public Nullable<Decimal> Trigia
        {
            get
            {
                Nullable<Decimal> vGet = _Trigia;
                OnTrigiaGetting(ref _Trigia, ref vGet);
                return vGet;
            }
            set
            {
                OnTrigiaChanging(value);
                SetProperty(ref _Trigia, value);
                OnTrigiaChanged();
            }
        }


        [DisplayName("Version")]
        [Column(Name = "Version", SqlType = SqlDbType.Timestamp)]
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


        partial void OnCreating();
        partial void OnCreated();

        partial void OnHoadonIdChanging(Guid value);
        partial void OnHoadonIdChanged();
        partial void OnHoadonIdGetting(ref Guid value, ref Guid vGet);




        partial void OnNgaylapChanging(Nullable<DateTime> value);
        partial void OnNgaylapChanged();
        partial void OnNgaylapGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);


        partial void OnTrigiaChanging(Nullable<Decimal> value);
        partial void OnTrigiaChanged();
        partial void OnTrigiaGetting(ref Nullable<Decimal> value, ref Nullable<Decimal> vGet);


        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
        partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);


    }
}
