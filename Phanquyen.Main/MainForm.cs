using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using Phanquyen.Forms;


namespace Phanquyen.Main
{
    public partial class MainForm : RibbonForm
    {
        private Lambda.ClientModel.ModelCore model;
        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
            model = new Lambda.ClientModel.ModelCore();
            Lambda.ClientModel.ModelCore.SetDefaultLocalConfig();
            model.Login("admin", "admin");
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void VaitrobarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new VaitroForm();
            f.MdiParent = this;
            f.Show();
        }

        private void ItemsbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new ChucnangForm();
            f.MdiParent = this;
            f.Show();
        }

        private void TaikhoanbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new TaikhoanForm();
            f.MdiParent = this;
            f.Show();
        }

        private void PhanquyenChucnangVaitrobarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new PhanquyenChucnangChoVaitroForm();
            f.MdiParent = this;
            f.Show();
        }

        private void PhanquyenbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new PhanquyenNguoidungForm();
            f.MdiParent = this;
            f.Show();
        }

        private void NhomChucnangbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new NhomChucnangForm();
            f.MdiParent = this;
            f.Show();
        }

    }
}