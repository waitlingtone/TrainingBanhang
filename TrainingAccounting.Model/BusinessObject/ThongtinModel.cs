using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Lambda.ClientModel;
using Lambda.BusinessObject;

namespace TrainingAccounting.Model.BusinessObject
{
	
	[Table(Schema = "dbo", Name = "Thongtin",
        spSelect = "sys_ThongtinSelect",
        spInsert = "sys_ThongtinInsert",
        spUpdate = "sys_ThongtinUpdate",
        spDelete = "sys_ThongtinDelete")]
    public partial class ThongtinModel : Bus
    {
        private Byte[] _Logo;
        private Guid _ThongtinId;
        private Nullable<Boolean> _PrintName;
        private Nullable<Boolean> _PrintAddress;
        private Nullable<Boolean> _PrintPhone;
        private Nullable<Boolean> _PrintLogo;
        private Nullable<Boolean> _PrintText;
        private String _TenDonvi;
        private String _Diachi;
        private String _SoDienthoai;
        private String _TextPhieubao;

        public ThongtinModel()
        {
			OnCreating();
            ThongtinId = ModelCore.GetGuidId();
			OnCreated();
        }

        public ThongtinModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }
        
        [DisplayName("Logo")]
	    [Column(Name="Logo",SqlType=SqlDbType.Image)]
        public Byte[] Logo
        {
            get
			{
				Byte[] vGet = _Logo;
				OnLogoGetting(ref _Logo, ref vGet);
				return vGet;
			}
            set
            {
                OnLogoChanging(value);
                SetProperty(ref _Logo, value);
                OnLogoChanged();
            }
        }
        
        
        [DisplayName("ThongtinId")]
	    [Column(Name="ThongtinId",SqlType=SqlDbType.UniqueIdentifier)]
        public Guid ThongtinId
        {
            get
			{
				Guid vGet = _ThongtinId;
				OnThongtinIdGetting(ref _ThongtinId, ref vGet);
				return vGet;
			}
            set
            {
                OnThongtinIdChanging(value);
                SetProperty(ref _ThongtinId, value);
                OnThongtinIdChanged();
            }
        }
        
        
        [DisplayName("PrintName")]
	    [Column(Name="PrintName",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> PrintName
        {
            get
			{
				Nullable<Boolean> vGet = _PrintName;
				OnPrintNameGetting(ref _PrintName, ref vGet);
				return vGet;
			}
            set
            {
                OnPrintNameChanging(value);
                SetProperty(ref _PrintName, value);
                OnPrintNameChanged();
            }
        }
        
        
        [DisplayName("PrintAddress")]
	    [Column(Name="PrintAddress",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> PrintAddress
        {
            get
			{
				Nullable<Boolean> vGet = _PrintAddress;
				OnPrintAddressGetting(ref _PrintAddress, ref vGet);
				return vGet;
			}
            set
            {
                OnPrintAddressChanging(value);
                SetProperty(ref _PrintAddress, value);
                OnPrintAddressChanged();
            }
        }
        
        
        [DisplayName("PrintPhone")]
	    [Column(Name="PrintPhone",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> PrintPhone
        {
            get
			{
				Nullable<Boolean> vGet = _PrintPhone;
				OnPrintPhoneGetting(ref _PrintPhone, ref vGet);
				return vGet;
			}
            set
            {
                OnPrintPhoneChanging(value);
                SetProperty(ref _PrintPhone, value);
                OnPrintPhoneChanged();
            }
        }
        
        
        [DisplayName("PrintLogo")]
	    [Column(Name="PrintLogo",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> PrintLogo
        {
            get
			{
				Nullable<Boolean> vGet = _PrintLogo;
				OnPrintLogoGetting(ref _PrintLogo, ref vGet);
				return vGet;
			}
            set
            {
                OnPrintLogoChanging(value);
                SetProperty(ref _PrintLogo, value);
                OnPrintLogoChanged();
            }
        }
        
        
        [DisplayName("PrintText")]
	    [Column(Name="PrintText",SqlType=SqlDbType.Bit)]
        public Nullable<Boolean> PrintText
        {
            get
			{
				Nullable<Boolean> vGet = _PrintText;
				OnPrintTextGetting(ref _PrintText, ref vGet);
				return vGet;
			}
            set
            {
                OnPrintTextChanging(value);
                SetProperty(ref _PrintText, value);
                OnPrintTextChanged();
            }
        }
        
        
        [DisplayName("TenDonvi")]
	    [Column(Name="TenDonvi",SqlType=SqlDbType.NVarChar)]
        public String TenDonvi
        {
            get
			{
				String vGet = _TenDonvi;
				OnTenDonviGetting(ref _TenDonvi, ref vGet);
				return vGet;
			}
            set
            {
                OnTenDonviChanging(value);
                SetProperty(ref _TenDonvi, value);
                OnTenDonviChanged();
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
        
        
        [DisplayName("SoDienthoai")]
	    [Column(Name="SoDienthoai",SqlType=SqlDbType.NVarChar)]
        public String SoDienthoai
        {
            get
			{
				String vGet = _SoDienthoai;
				OnSoDienthoaiGetting(ref _SoDienthoai, ref vGet);
				return vGet;
			}
            set
            {
                OnSoDienthoaiChanging(value);
                SetProperty(ref _SoDienthoai, value);
                OnSoDienthoaiChanged();
            }
        }
        
        
        [DisplayName("TextPhieubao")]
	    [Column(Name="TextPhieubao",SqlType=SqlDbType.NVarChar)]
        public String TextPhieubao
        {
            get
			{
				String vGet = _TextPhieubao;
				OnTextPhieubaoGetting(ref _TextPhieubao, ref vGet);
				return vGet;
			}
            set
            {
                OnTextPhieubaoChanging(value);
                SetProperty(ref _TextPhieubao, value);
                OnTextPhieubaoChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnLogoChanging(Byte[] value);
        partial void OnLogoChanged();
		partial void OnLogoGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnThongtinIdChanging(Guid value);
        partial void OnThongtinIdChanged();
		partial void OnThongtinIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnPrintNameChanging(Nullable<Boolean> value);
        partial void OnPrintNameChanged();
		partial void OnPrintNameGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnPrintAddressChanging(Nullable<Boolean> value);
        partial void OnPrintAddressChanged();
		partial void OnPrintAddressGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnPrintPhoneChanging(Nullable<Boolean> value);
        partial void OnPrintPhoneChanged();
		partial void OnPrintPhoneGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnPrintLogoChanging(Nullable<Boolean> value);
        partial void OnPrintLogoChanged();
		partial void OnPrintLogoGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnPrintTextChanging(Nullable<Boolean> value);
        partial void OnPrintTextChanged();
		partial void OnPrintTextGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnTenDonviChanging(String value);
        partial void OnTenDonviChanged();
		partial void OnTenDonviGetting(ref String value, ref String vGet);
        
        
        partial void OnDiachiChanging(String value);
        partial void OnDiachiChanged();
		partial void OnDiachiGetting(ref String value, ref String vGet);
        
        
        partial void OnSoDienthoaiChanging(String value);
        partial void OnSoDienthoaiChanged();
		partial void OnSoDienthoaiGetting(ref String value, ref String vGet);
        
        
        partial void OnTextPhieubaoChanging(String value);
        partial void OnTextPhieubaoChanged();
		partial void OnTextPhieubaoGetting(ref String value, ref String vGet);
        
    }
}