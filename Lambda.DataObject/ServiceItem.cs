using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.BusinessObject;
using Lambda.CoreService;

namespace Lambda.DataObject
{

    [Table(Schema = "dbo", Name = "ServiceItem",
        spSelect = "sys_ServiceItemSelect",
        spInsert = "sys_ServiceItemInsert",
        spUpdate = "sys_ServiceItemUpdate",
        spDelete = "sys_ServiceItemDelete")]
    public partial class ServiceItem : Bus
    {
        private Guid _ServiceItemId;
        private Boolean _IsStatic;
        private String _KeyService;
        private String _AssemblyFile;
        private String _ClassName;
        private String _MethodName;

        public ServiceItem()
        {
            OnCreating();
            ServiceItemId = SimpleData.Instance.GetGuidId();
            OnCreated();
        }

        public ServiceItem(AutoObject value)
        {
            OnCreating();
            DataFromAutoObject(value);
            OnCreated();
        }

        [DisplayName("ServiceItemId")]
        [Column(Name = "ServiceItemId", SqlType = SqlDbType.UniqueIdentifier)]
        public Guid ServiceItemId
        {
            get
            {
                Guid vGet = _ServiceItemId;
                OnServiceItemIdGetting(ref _ServiceItemId, ref vGet);
                return vGet;
            }
            set
            {
                OnServiceItemIdChanging(value);
                SetProperty(ref _ServiceItemId, value);
                OnServiceItemIdChanged();
            }
        }


        [DisplayName("IsStatic")]
        [Column(Name = "IsStatic", SqlType = SqlDbType.Bit)]
        public Boolean IsStatic
        {
            get
            {
                Boolean vGet = _IsStatic;
                OnIsStaticGetting(ref _IsStatic, ref vGet);
                return vGet;
            }
            set
            {
                OnIsStaticChanging(value);
                SetProperty(ref _IsStatic, value);
                OnIsStaticChanged();
            }
        }


        [DisplayName("KeyService")]
        [Column(Name = "KeyService", SqlType = SqlDbType.NVarChar)]
        public String KeyService
        {
            get
            {
                String vGet = _KeyService;
                OnKeyServiceGetting(ref _KeyService, ref vGet);
                return vGet;
            }
            set
            {
                OnKeyServiceChanging(value);
                SetProperty(ref _KeyService, value);
                OnKeyServiceChanged();
            }
        }


        [DisplayName("AssemblyFile")]
        [Column(Name = "AssemblyFile", SqlType = SqlDbType.NVarChar)]
        public String AssemblyFile
        {
            get
            {
                String vGet = _AssemblyFile;
                OnAssemblyFileGetting(ref _AssemblyFile, ref vGet);
                return vGet;
            }
            set
            {
                OnAssemblyFileChanging(value);
                SetProperty(ref _AssemblyFile, value);
                OnAssemblyFileChanged();
            }
        }


        [DisplayName("ClassName")]
        [Column(Name = "ClassName", SqlType = SqlDbType.NVarChar)]
        public String ClassName
        {
            get
            {
                String vGet = _ClassName;
                OnClassNameGetting(ref _ClassName, ref vGet);
                return vGet;
            }
            set
            {
                OnClassNameChanging(value);
                SetProperty(ref _ClassName, value);
                OnClassNameChanged();
            }
        }


        [DisplayName("MethodName")]
        [Column(Name = "MethodName", SqlType = SqlDbType.NVarChar)]
        public String MethodName
        {
            get
            {
                String vGet = _MethodName;
                OnMethodNameGetting(ref _MethodName, ref vGet);
                return vGet;
            }
            set
            {
                OnMethodNameChanging(value);
                SetProperty(ref _MethodName, value);
                OnMethodNameChanged();
            }
        }


        partial void OnCreating();
        partial void OnCreated();


        partial void OnServiceItemIdChanging(Guid value);
        partial void OnServiceItemIdChanged();
        partial void OnServiceItemIdGetting(ref Guid value, ref Guid vGet);


        partial void OnIsStaticChanging(Boolean value);
        partial void OnIsStaticChanged();
        partial void OnIsStaticGetting(ref Boolean value, ref Boolean vGet);


        partial void OnKeyServiceChanging(String value);
        partial void OnKeyServiceChanged();
        partial void OnKeyServiceGetting(ref String value, ref String vGet);


        partial void OnAssemblyFileChanging(String value);
        partial void OnAssemblyFileChanged();
        partial void OnAssemblyFileGetting(ref String value, ref String vGet);


        partial void OnClassNameChanging(String value);
        partial void OnClassNameChanged();
        partial void OnClassNameGetting(ref String value, ref String vGet);


        partial void OnMethodNameChanging(String value);
        partial void OnMethodNameChanged();
        partial void OnMethodNameGetting(ref String value, ref String vGet);

    }
}