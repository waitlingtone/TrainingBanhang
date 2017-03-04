using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace Phanquyen.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Item",
        spSelect = "sys_ItemSelect",
        spInsert = "sys_ItemInsert",
        spUpdate = "sys_ItemUpdate",
        spDelete = "sys_ItemDelete")]
    public partial class Item : Bus
    {
        private Byte[] _Image;
        private Byte[] _LargeImage;
        private Guid _ItemId;
        private Nullable<Guid> _ItemChaId;
        private Nullable<Guid> _GroupItemId;
        private Nullable<Int32> _Width;
        private Int32 _Cap;
        private Nullable<Boolean> _IsLarge;
        private Nullable<Boolean> _ShowImage;
        private Nullable<Boolean> _ShowFormAsTab;
        private Nullable<Boolean> _Enable;
        private Nullable<Boolean> _Visible;
        private Nullable<Boolean> _Lock;
        private Boolean _Allow;
        private Boolean _BeginGroup;
        private String _Thutu;
        private String _TypeName;
        private String _ObjectTypeName;
        private String _Name;
        private String _Text;
        private String _TenForm;
        private String _TenFileDLL;

        public Item()
        {
			OnCreating();
            ItemId = ModelCore.GetGuidId();
			OnCreated();
        }

        public Item(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("Image")]
	    [Column(Name="Image",SqlType=SqlDbType.Image)]
        public Byte[] Image
        {
            get
			{
				Byte[] vGet = _Image;
				OnImageGetting(ref _Image, ref vGet);
				return vGet;
			}
            set
            {
                OnImageChanging(value);
                SetProperty(ref _Image, value);
                OnImageChanged();
            }
        }
        
        
        [DisplayName("LargeImage")]
	    [Column(Name="LargeImage",SqlType=SqlDbType.Image)]
        public Byte[] LargeImage
        {
            get
			{
				Byte[] vGet = _LargeImage;
				OnLargeImageGetting(ref _LargeImage, ref vGet);
				return vGet;
			}
            set
            {
                OnLargeImageChanging(value);
                SetProperty(ref _LargeImage, value);
                OnLargeImageChanged();
            }
        }
        
        
        [DisplayName("ItemId")]
	    [Column(Name="ItemId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid ItemId
        {
            get
			{
				Guid vGet = _ItemId;
				OnItemIdGetting(ref _ItemId, ref vGet);
				return vGet;
			}
            set
            {
                OnItemIdChanging(value);
                SetProperty(ref _ItemId, value);
                OnItemIdChanged();
            }
        }
        
        
        [DisplayName("ItemChaId")]
	    [Column(Name="ItemChaId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> ItemChaId
        {
            get
			{
				Nullable<Guid> vGet = _ItemChaId;
				OnItemChaIdGetting(ref _ItemChaId, ref vGet);
				return vGet;
			}
            set
            {
                OnItemChaIdChanging(value);
                SetProperty(ref _ItemChaId, value);
                OnItemChaIdChanged();
            }
        }
        
        
        [DisplayName("GroupItemId")]
	    [Column(Name="GroupItemId",SqlType=SqlDbType.UniqueIdentifier)]
        public Nullable<Guid> GroupItemId
        {
            get
			{
				Nullable<Guid> vGet = _GroupItemId;
				OnGroupItemIdGetting(ref _GroupItemId, ref vGet);
				return vGet;
			}
            set
            {
                OnGroupItemIdChanging(value);
                SetProperty(ref _GroupItemId, value);
                OnGroupItemIdChanged();
            }
        }
        
        
        [DisplayName("Width")]
	    [Column(Name="Width",SqlType=SqlDbType.Int)]
        public Nullable<Int32> Width
        {
            get
			{
				Nullable<Int32> vGet = _Width;
				OnWidthGetting(ref _Width, ref vGet);
				return vGet;
			}
            set
            {
                OnWidthChanging(value);
                SetProperty(ref _Width, value);
                OnWidthChanged();
            }
        }
        
        
        [DisplayName("Cap")]
	    [Column(Name="Cap",SqlType=SqlDbType.Int)]
        public Int32 Cap
        {
            get
			{
				Int32 vGet = _Cap;
				OnCapGetting(ref _Cap, ref vGet);
				return vGet;
			}
            set
            {
                OnCapChanging(value);
                SetProperty(ref _Cap, value);
                OnCapChanged();
            }
        }
        
        
        [DisplayName("IsLarge")]
	    [Column(Name="IsLarge",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> IsLarge
        {
            get
			{
				Nullable<Boolean> vGet = _IsLarge;
				OnIsLargeGetting(ref _IsLarge, ref vGet);
				return vGet;
			}
            set
            {
                OnIsLargeChanging(value);
                SetProperty(ref _IsLarge, value);
                OnIsLargeChanged();
            }
        }
        
        
        [DisplayName("ShowImage")]
	    [Column(Name="ShowImage",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> ShowImage
        {
            get
			{
				Nullable<Boolean> vGet = _ShowImage;
				OnShowImageGetting(ref _ShowImage, ref vGet);
				return vGet;
			}
            set
            {
                OnShowImageChanging(value);
                SetProperty(ref _ShowImage, value);
                OnShowImageChanged();
            }
        }
        
        
        [DisplayName("ShowFormAsTab")]
	    [Column(Name="ShowFormAsTab",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> ShowFormAsTab
        {
            get
			{
				Nullable<Boolean> vGet = _ShowFormAsTab;
				OnShowFormAsTabGetting(ref _ShowFormAsTab, ref vGet);
				return vGet;
			}
            set
            {
                OnShowFormAsTabChanging(value);
                SetProperty(ref _ShowFormAsTab, value);
                OnShowFormAsTabChanged();
            }
        }
        
        
        [DisplayName("Enable")]
	    [Column(Name="Enable",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> Enable
        {
            get
			{
				Nullable<Boolean> vGet = _Enable;
				OnEnableGetting(ref _Enable, ref vGet);
				return vGet;
			}
            set
            {
                OnEnableChanging(value);
                SetProperty(ref _Enable, value);
                OnEnableChanged();
            }
        }
        
        
        [DisplayName("Visible")]
	    [Column(Name="Visible",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> Visible
        {
            get
			{
				Nullable<Boolean> vGet = _Visible;
				OnVisibleGetting(ref _Visible, ref vGet);
				return vGet;
			}
            set
            {
                OnVisibleChanging(value);
                SetProperty(ref _Visible, value);
                OnVisibleChanged();
            }
        }
        
        
        [DisplayName("Lock")]
	    [Column(Name="Lock",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> Lock
        {
            get
			{
				Nullable<Boolean> vGet = _Lock;
				OnLockGetting(ref _Lock, ref vGet);
				return vGet;
			}
            set
            {
                OnLockChanging(value);
                SetProperty(ref _Lock, value);
                OnLockChanged();
            }
        }
        
        
        [DisplayName("Allow")]
	    [Column(Name="Allow",SqlType=SqlDbType.Bit)]
        public Boolean Allow
        {
            get
			{
				Boolean vGet = _Allow;
				OnAllowGetting(ref _Allow, ref vGet);
				return vGet;
			}
            set
            {
                OnAllowChanging(value);
                SetProperty(ref _Allow, value);
                OnAllowChanged();
            }
        }
        
        
        [DisplayName("BeginGroup")]
	    [Column(Name="BeginGroup",SqlType=SqlDbType.Bit)]
        public Boolean BeginGroup
        {
            get
			{
				Boolean vGet = _BeginGroup;
				OnBeginGroupGetting(ref _BeginGroup, ref vGet);
				return vGet;
			}
            set
            {
                OnBeginGroupChanging(value);
                SetProperty(ref _BeginGroup, value);
                OnBeginGroupChanged();
            }
        }
        
        
        [DisplayName("Thutu")]
	    [Column(Name="Thutu",SqlType=SqlDbType.NVarChar)]
        public String Thutu
        {
            get
			{
				String vGet = _Thutu;
				OnThutuGetting(ref _Thutu, ref vGet);
				return vGet;
			}
            set
            {
                OnThutuChanging(value);
                SetProperty(ref _Thutu, value);
                OnThutuChanged();
            }
        }
        
        
        [DisplayName("TypeName")]
	    [Column(Name="TypeName",SqlType=SqlDbType.NVarChar)]
        public String TypeName
        {
            get
			{
				String vGet = _TypeName;
				OnTypeNameGetting(ref _TypeName, ref vGet);
				return vGet;
			}
            set
            {
                OnTypeNameChanging(value);
                SetProperty(ref _TypeName, value);
                OnTypeNameChanged();
            }
        }
        
        
        [DisplayName("ObjectTypeName")]
	    [Column(Name="ObjectTypeName",SqlType=SqlDbType.NVarChar)]
        public String ObjectTypeName
        {
            get
			{
				String vGet = _ObjectTypeName;
				OnObjectTypeNameGetting(ref _ObjectTypeName, ref vGet);
				return vGet;
			}
            set
            {
                OnObjectTypeNameChanging(value);
                SetProperty(ref _ObjectTypeName, value);
                OnObjectTypeNameChanged();
            }
        }
        
        
        [DisplayName("Name")]
	    [Column(Name="Name",SqlType=SqlDbType.NVarChar)]
        public String Name
        {
            get
			{
				String vGet = _Name;
				OnNameGetting(ref _Name, ref vGet);
				return vGet;
			}
            set
            {
                OnNameChanging(value);
                SetProperty(ref _Name, value);
                OnNameChanged();
            }
        }
        
        
        [DisplayName("Text")]
	    [Column(Name="Text",SqlType=SqlDbType.NVarChar)]
        public String Text
        {
            get
			{
				String vGet = _Text;
				OnTextGetting(ref _Text, ref vGet);
				return vGet;
			}
            set
            {
                OnTextChanging(value);
                SetProperty(ref _Text, value);
                OnTextChanged();
            }
        }
        
        
        [DisplayName("TenForm")]
	    [Column(Name="TenForm",SqlType=SqlDbType.NVarChar)]
        public String TenForm
        {
            get
			{
				String vGet = _TenForm;
				OnTenFormGetting(ref _TenForm, ref vGet);
				return vGet;
			}
            set
            {
                OnTenFormChanging(value);
                SetProperty(ref _TenForm, value);
                OnTenFormChanged();
            }
        }
        
        
        [DisplayName("TenFileDLL")]
	    [Column(Name="TenFileDLL",SqlType=SqlDbType.NVarChar)]
        public String TenFileDLL
        {
            get
			{
				String vGet = _TenFileDLL;
				OnTenFileDLLGetting(ref _TenFileDLL, ref vGet);
				return vGet;
			}
            set
            {
                OnTenFileDLLChanging(value);
                SetProperty(ref _TenFileDLL, value);
                OnTenFileDLLChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnImageChanging(Byte[] value);
        partial void OnImageChanged();
		partial void OnImageGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnLargeImageChanging(Byte[] value);
        partial void OnLargeImageChanged();
		partial void OnLargeImageGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnItemIdChanging(Guid value);
        partial void OnItemIdChanged();
		partial void OnItemIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnItemChaIdChanging(Nullable<Guid> value);
        partial void OnItemChaIdChanged();
		partial void OnItemChaIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnGroupItemIdChanging(Nullable<Guid> value);
        partial void OnGroupItemIdChanged();
		partial void OnGroupItemIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnWidthChanging(Nullable<Int32> value);
        partial void OnWidthChanged();
		partial void OnWidthGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnCapChanging(Int32 value);
        partial void OnCapChanged();
		partial void OnCapGetting(ref Int32 value, ref Int32 vGet);
        
        
        partial void OnIsLargeChanging(Nullable<Boolean> value);
        partial void OnIsLargeChanged();
		partial void OnIsLargeGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnShowImageChanging(Nullable<Boolean> value);
        partial void OnShowImageChanged();
		partial void OnShowImageGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnShowFormAsTabChanging(Nullable<Boolean> value);
        partial void OnShowFormAsTabChanged();
		partial void OnShowFormAsTabGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnEnableChanging(Nullable<Boolean> value);
        partial void OnEnableChanged();
		partial void OnEnableGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVisibleChanging(Nullable<Boolean> value);
        partial void OnVisibleChanged();
		partial void OnVisibleGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnLockChanging(Nullable<Boolean> value);
        partial void OnLockChanged();
		partial void OnLockGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnAllowChanging(Boolean value);
        partial void OnAllowChanged();
		partial void OnAllowGetting(ref Boolean value, ref Boolean vGet);
        
        
        partial void OnBeginGroupChanging(Boolean value);
        partial void OnBeginGroupChanged();
		partial void OnBeginGroupGetting(ref Boolean value, ref Boolean vGet);
        
        
        partial void OnThutuChanging(String value);
        partial void OnThutuChanged();
		partial void OnThutuGetting(ref String value, ref String vGet);
        
        
        partial void OnTypeNameChanging(String value);
        partial void OnTypeNameChanged();
		partial void OnTypeNameGetting(ref String value, ref String vGet);
        
        
        partial void OnObjectTypeNameChanging(String value);
        partial void OnObjectTypeNameChanged();
		partial void OnObjectTypeNameGetting(ref String value, ref String vGet);
        
        
        partial void OnNameChanging(String value);
        partial void OnNameChanged();
		partial void OnNameGetting(ref String value, ref String vGet);
        
        
        partial void OnTextChanging(String value);
        partial void OnTextChanged();
		partial void OnTextGetting(ref String value, ref String vGet);
        
        
        partial void OnTenFormChanging(String value);
        partial void OnTenFormChanged();
		partial void OnTenFormGetting(ref String value, ref String vGet);
        
        
        partial void OnTenFileDLLChanging(String value);
        partial void OnTenFileDLLChanged();
		partial void OnTenFileDLLGetting(ref String value, ref String vGet);
        
    }
}