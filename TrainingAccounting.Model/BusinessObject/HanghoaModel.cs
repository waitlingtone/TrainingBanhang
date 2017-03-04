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
    [Table(Schema = "dbo", Name = "Hanghoa",
        spSelect = "sys_HanghoaSelect",
        spInsert = "sys_HanghoaInsert",
        spUpdate = "sys_HanghoaUpdate",
        spDelete = "sys_HanghoaDelete")]
    public partial class HanghoaModel : Bus
    {
        private Guid _HanghoaId;
        private String _Tenhanghoa;
        private String _Mota;
        private Guid _NhomhanghoaId;
        private Guid _NhasanxuatId;
        private Nullable<Decimal> _Giaban;
        private Byte[] _Version;
        private String _Donvitinh;
        private Byte[] _Hinhanh;

        public HanghoaModel()
        {
            OnCreating();
            HanghoaId = ModelCore.GetGuidId();
            OnCreated();
        }
        public HanghoaModel(AutoObject value)
        {
            OnCreating();
            DataFromAutoObject(value);
            OnCreated();
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

        [DisplayName("Tenhanghoa")]
        [Column(Name = "Tenhanghoa", SqlType = SqlDbType.NVarChar)]
        public String Tenhanghoa
        {
            get
            {
                String vGet = _Tenhanghoa;
                OnTenhanghoaGetting(ref _Tenhanghoa, ref vGet);
                return vGet;
            }
            set
            {
                OnTenhanghoaChanging(value);
                SetProperty(ref _Tenhanghoa, value);
                OnTenhanghoaChanged();
            }
        }

        [DisplayName("Giaban")]
        [Column(Name = "Giaban", SqlType = SqlDbType.Decimal)]
        public Nullable<Decimal> Giaban
        {
            get
            {
                Nullable<Decimal> vGet = _Giaban;
                OnGiabanGetting(ref _Giaban, ref vGet);
                return vGet;
            }
            set
            {
                OnGiabanChanging(value);
                SetProperty(ref _Giaban, value);
                OnGiabanChanged();
            }
        }

        [DisplayName("Mota")]
        [Column(Name = "Mota", SqlType = SqlDbType.NVarChar)]
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

        [DisplayName("NhomhanghoaId")]
        [Column(Name = "NhomhanghoaId", SqlType = SqlDbType.UniqueIdentifier)]
        public Guid NhomhanghoaId
        {
            get
            {
                Guid vGet = _NhomhanghoaId;
                OnNhomhanghoaIdGetting(ref _NhomhanghoaId, ref vGet);
                return vGet;
            }
            set
            {
                OnNhomhanghoaIdChanging(value);
                SetProperty(ref _NhomhanghoaId, value);
                OnNhomhanghoaIdChanged();
            }
        }

        [DisplayName("NhasanxuatId")]
        [Column(Name = "NhasanxuatId", SqlType = SqlDbType.UniqueIdentifier)]
        public Guid NhasanxuatId
        {
            get
            {
                Guid vGet = _NhasanxuatId;
                OnNhasanxuatIdGetting(ref _NhasanxuatId, ref vGet);
                return vGet;
            }
            set
            {
                OnNhasanxuatIdChanging(value);
                SetProperty(ref _NhasanxuatId, value);
                OnNhasanxuatIdChanged();
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

        [DisplayName("Donvitinh")]
        [Column(Name = "Donvitinh", SqlType = SqlDbType.NVarChar)]
        public String Donvitinh
        {
            get
            {
                String vGet = _Donvitinh;
                OnDonvitinhGetting(ref _Donvitinh, ref vGet);
                return vGet;
            }
            set
            {
                OnDonvitinhChanging(value);
                SetProperty(ref _Mota, value);
                OnDonvitinhChanged();
            }
        }

        [DisplayName("Hinhanh")]
        [Column(Name = "Hinhanh", SqlType = SqlDbType.VarBinary)]
        public Byte[] Hinhanh
        {
            get
            {
                Byte[] vGet = _Hinhanh;
                OnHinhanhGetting(ref _Hinhanh, ref vGet);
                return vGet;
            }
            set
            {
                OnHinhanhChanging(value);
                SetProperty(ref _Hinhanh, value);
                OnHinhanhChanged();
            }
        }
        partial void OnCreating();
        partial void OnCreated();

        partial void OnHanghoaIdChanging(Guid value);
        partial void OnHanghoaIdChanged();
        partial void OnHanghoaIdGetting(ref Guid value, ref Guid vGet);

        partial void OnTenhanghoaChanging(String value);
        partial void OnTenhanghoaChanged();
        partial void OnTenhanghoaGetting(ref String value, ref String vGet);

        partial void OnMotaChanging(String value);
        partial void OnMotaChanged();
        partial void OnMotaGetting(ref String valuue, ref String vGet);


        partial void OnGiabanChanging(Nullable<Decimal> value);
        partial void OnGiabanChanged();
        partial void OnGiabanGetting(ref Nullable<Decimal> value, ref Nullable<Decimal> vGet);


        partial void OnNhomhanghoaIdChanging(Guid value);
        partial void OnNhomhanghoaIdChanged();
        partial void OnNhomhanghoaIdGetting(ref Guid value, ref Guid vGet);

        partial void OnNhasanxuatIdChanging(Guid value);
        partial void OnNhasanxuatIdChanged();
        partial void OnNhasanxuatIdGetting(ref Guid value, ref Guid vGet);

        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
        partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);

        partial void OnDonvitinhChanging(String value);
        partial void OnDonvitinhChanged();
        partial void OnDonvitinhGetting(ref String value, ref String vGet);

        partial void OnHinhanhChanging(Byte[] value);
        partial void OnHinhanhChanged();
        partial void OnHinhanhGetting(ref Byte[] value, ref Byte[] vGet);
    }
}
