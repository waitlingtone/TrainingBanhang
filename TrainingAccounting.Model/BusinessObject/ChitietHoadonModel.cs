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
    [Table(Schema = "dbo", Name = "ChitietHoadon",
         spSelect = "sys_ChitietHoadonSelect",
         spInsert = "sys_ChitietHoadonInsert",
         spUpdate = "sys_ChitietHoadonUpdate",
         spDelete = "sys_ChitietHoadonDelete")]

    public partial class ChitietHoadonModel : Bus
    {
        private Guid _ChitietHoadonId;
        private Guid _HoadonId;
        private Guid _HanghoaId;
        private Nullable<Int32> _Soluong;
        private Nullable<Decimal> _Dongia;
        private Nullable<Decimal> _Thanhtien;
        private Byte[] _Version;

        public ChitietHoadonModel()
        {
            OnCreating();
            ChitietHoadonId = ModelCore.GetGuidId();
            OnCreated();
        }

        public ChitietHoadonModel(AutoObject value)
        {
            OnCreating();
            DataFromAutoObject(value);
            OnCreated();
        }

        [DisplayName("ChitietHoadonId")]
        [Column(Name = "ChitietHoadonId", SqlType = SqlDbType.UniqueIdentifier)]
        public Guid ChitietHoadonId
        {
            get
            {
                Guid vGet = _ChitietHoadonId;
                OnChitietHoadonIdGetting(ref _ChitietHoadonId, ref vGet);
                return vGet;
            }
            set
            {
                OnChitietHoadonIdChanging(value);
                SetProperty(ref _ChitietHoadonId, value);
                OnChitietHoadonIdChanged();
            }
        }


        [DisplayName("HoadonId")]
        [Column(Name = "HoadonId", SqlType = SqlDbType.UniqueIdentifier)]
        public Guid HoadonId
        {
            get
            {
                Guid vGet = _HoadonId;
                OnChitietHoadonIdGetting(ref _HoadonId, ref vGet);
                return vGet;
            }
            set
            {
                OnChitietHoadonIdChanging(value);
                SetProperty(ref _HoadonId, value);
                OnHoadonIdChanged();
            }
        }


        [DisplayName("HanghoaId")]
        [Column(Name = "HanghoaId", SqlType = SqlDbType.UniqueIdentifier)]
        public Guid HanghoaId
        {
            get
            {
                Guid vGet = _HanghoaId;
                OnHanghoaIdGetting(ref _HanghoaId, ref vGet);
                return vGet;
            }
            set
            {
                OnHanghoaIdChanging(value);
                SetProperty(ref _HanghoaId, value);
                OnHanghoaIdChanged();
            }
        }


        [DisplayName("Soluong")]
        [Column(Name = "Soluong", SqlType = SqlDbType.Int)]
        public Nullable<Int32> Soluong
        {
            get
            {
                Nullable<Int32> vGet = _Soluong;
                OnSoluongGetting(ref _Soluong, ref vGet);
                return vGet;
            }
            set
            {
                OnSoluongChanging(value);
                SetProperty(ref _Soluong, value);
                OnSoluongChanged();
            }
        }


        [DisplayName("Dongia")]
        [Column(Name = "Dongia", SqlType = SqlDbType.Decimal)]
        public Nullable<Decimal> Dongia
        {
            get
            {
                Nullable<Decimal> vGet = _Dongia;
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

        [DisplayName("Thanhtien")]
        [Column(Name = "Thanhtien", SqlType = SqlDbType.Decimal)]
        public Nullable<Decimal> Thanhtien
        {
            get
            {
                Nullable<Decimal> vGet = _Thanhtien;
                OnThanhtienGetting(ref _Thanhtien, ref vGet);
                return vGet;
            }
            set
            {
                OnThanhtienChanging(value);
                SetProperty(ref _Thanhtien, value);
                OnThanhtienChanged();
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

        partial void OnChitietHoadonIdChanging(Guid value);
        partial void OnChitietHoadonIdChanged();
        partial void OnChitietHoadonIdGetting(ref Guid value, ref Guid vGet);


        partial void OnHoadonIdChanging(Guid value);
        partial void OnHoadonIdChanged();
        partial void OnHoadonIdGetting(ref Guid value, ref Guid vGet);


        partial void OnHanghoaIdChanging(Nullable<Guid> value);
        partial void OnHanghoaIdChanged();
        partial void OnHanghoaIdGetting(ref Guid value, ref Guid vGet);


        partial void OnSoluongChanging(Nullable<Int32> value);
        partial void OnSoluongChanged();
        partial void OnSoluongGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);


        partial void OnDongiaChanging(Nullable<Decimal> value);
        partial void OnDongiaChanged();
        partial void OnDongiaGetting(ref Nullable<Decimal> value, ref Nullable<Decimal> vGet);

        partial void OnThanhtienChanging(Nullable<Decimal> value);
        partial void OnThanhtienChanged();
        partial void OnThanhtienGetting(ref Nullable<Decimal> value, ref Nullable<Decimal> vGet);

        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
        partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);


    }
}
