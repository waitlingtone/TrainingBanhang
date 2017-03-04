using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{

    [Table(Schema = "dbo", Name = "BackupInfo",
        spSelect = "sys_BackupInfoSelect",
        spInsert = "sys_BackupInfoInsert",
        spUpdate = "sys_BackupInfoUpdate",
        spDelete = "sys_BackupInfoDelete")]
    public partial class BackupInfoModel : Bus
    {
        private Guid _BackupInfoId;
        private Nullable<Guid> _NguoidungId;
        private Nullable<DateTime> _Time;
        private String _TenFile;
        private String _Path;

        public BackupInfoModel()
        {
            OnCreating();
            BackupInfoId = ModelCore.GetGuidId();
            OnCreated();
        }

        public BackupInfoModel(AutoObject value)
        {
            OnCreating();
            DataFromAutoObject(value);
            OnCreated();
        }

        [DisplayName("BackupInfoId")]
        [Column(Name = "BackupInfoId", SqlType = SqlDbType.UniqueIdentifier)]
        public Guid BackupInfoId
        {
            get
            {
                Guid vGet = _BackupInfoId;
                OnBackupInfoIdGetting(ref _BackupInfoId, ref vGet);
                return vGet;
            }
            set
            {
                OnBackupInfoIdChanging(value);
                SetProperty(ref _BackupInfoId, value);
                OnBackupInfoIdChanged();
            }
        }


        [DisplayName("NguoidungId")]
        [Column(Name = "NguoidungId", SqlType = SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> NguoidungId
        {
            get
            {
                Nullable<Guid> vGet = _NguoidungId;
                OnNguoidungIdGetting(ref _NguoidungId, ref vGet);
                return vGet;
            }
            set
            {
                OnNguoidungIdChanging(value);
                SetProperty(ref _NguoidungId, value);
                OnNguoidungIdChanged();
            }
        }


        [DisplayName("Time")]
        [Column(Name = "Time", SqlType = SqlDbType.DateTime)]
        public Nullable<DateTime> Time
        {
            get
            {
                Nullable<DateTime> vGet = _Time;
                OnTimeGetting(ref _Time, ref vGet);
                return vGet;
            }
            set
            {
                OnTimeChanging(value);
                SetProperty(ref _Time, value);
                OnTimeChanged();
            }
        }


        [DisplayName("TenFile")]
        [Column(Name = "TenFile", SqlType = SqlDbType.NVarChar)]
        public String TenFile
        {
            get
            {
                String vGet = _TenFile;
                OnTenFileGetting(ref _TenFile, ref vGet);
                return vGet;
            }
            set
            {
                OnTenFileChanging(value);
                SetProperty(ref _TenFile, value);
                OnTenFileChanged();
            }
        }


        [DisplayName("Path")]
        [Column(Name = "Path", SqlType = SqlDbType.NVarChar)]
        public String Path
        {
            get
            {
                String vGet = _Path;
                OnPathGetting(ref _Path, ref vGet);
                return vGet;
            }
            set
            {
                OnPathChanging(value);
                SetProperty(ref _Path, value);
                OnPathChanged();
            }
        }


        partial void OnCreating();
        partial void OnCreated();


        partial void OnBackupInfoIdChanging(Guid value);
        partial void OnBackupInfoIdChanged();
        partial void OnBackupInfoIdGetting(ref Guid value, ref Guid vGet);


        partial void OnNguoidungIdChanging(Nullable<Guid> value);
        partial void OnNguoidungIdChanged();
        partial void OnNguoidungIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);


        partial void OnTimeChanging(Nullable<DateTime> value);
        partial void OnTimeChanged();
        partial void OnTimeGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);


        partial void OnTenFileChanging(String value);
        partial void OnTenFileChanged();
        partial void OnTenFileGetting(ref String value, ref String vGet);


        partial void OnPathChanging(String value);
        partial void OnPathChanged();
        partial void OnPathGetting(ref String value, ref String vGet);

    }
}