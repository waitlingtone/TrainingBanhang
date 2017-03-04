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
using TrainingAccounting.Form;


namespace TrainingAccounting.Solution
{
    public partial class MainForm : RibbonForm
    {
        Lambda.ClientModel.ModelCore model;
        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
            model = new Lambda.ClientModel.ModelCore();
            Lambda.ClientModel.ModelCore.SetDefaultLocalConfig();
            model.Login("admin", "admin");
            Info.Info.CreateImage();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void TinhthanhbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new TinhthanhForm())
            {
                f.ShowDialog();
            }
        }

        private void QuanhuyenbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new QuanhuyenForm())
            {
                f.ShowDialog();
            }
        }

        private void DantocbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new DantocForm())
            {
                f.ShowDialog();
            }
        }

        private void TongiaobarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new TongiaoForm())
            {
                f.ShowDialog();
            }
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void CahocbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new CahocForm())
            {
                f.ShowDialog();
            }
        }

        private void NhomTrebarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new NhomtreForm())
            {
                f.ShowDialog();
            }
        }

        private void LylichGiaovienbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new NhanvienForm();
            f.MdiParent = this;
            f.Show();
        }

        private void DanhsachTrebarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new TreForm();
            f.MdiParent = this;
            f.Show();
        }

        private void DongiaHocphibarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new DongiaHocphiForm())
            {
                f.ShowDialog();
            }
        }

        private void DKLichhocbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new DangkyLichhocForm();
            f.MdiParent = this;
            f.Show();
        }

        private void DKLichdaybarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new DangkyLichdayForm();
            f.MdiParent = this;
            f.Show();
        }

        private void TKBTrebarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new ThoikhoabieuTreForm();
            f.MdiParent = this;
            f.Show();
        }

        private void DiemdanhbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new DiemdanhTrongngayForm();
            f.MdiParent = this;
            f.Show();
        }

        private void PhieubaoHocphibarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new PhieubaoHocphiForm();
            f.MdiParent = this;
            f.Show();
        }

        private void DanhmucTraluongNhanvienbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new DanhmucTraluongNhanvienForm())
            {
                f.ShowDialog();
            }
        }

        private void BangluongbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new PhieubaoLuongNhanvienForm();
            f.MdiParent = this;
            f.Show();
        }

        private void TKBDaybarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new ThoikhoabieuGiaovienForm();
            f.MdiParent = this;
            f.Show();
        }

        private void DanhmucThuchibarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new DanhmucThuchiForm())
            {
                f.ShowDialog();
            }
        }

        private void HesoTinhLuongbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new HesoNgaytinhluongForm())
            {
                f.ShowDialog();
            }
        }

        private void NganhangbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new NganhangForm())
            {
                f.ShowDialog();
            }
        }

        private void ChuyenkhoanbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new BangluongChuyenKhoanForm();
            f.MdiParent = this;
            f.Show();
        }

        private void ThuChiButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new ThuChiForm())
            {
                f.ShowDialog();
            }
        }

        private void PhieuThuchibarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new CacPhieuThuChiForm();
            f.MdiParent = this;
            f.Show();
        }

        private void TonghopTreDKHocbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new TonghopDanhsachTreDangkyHocForm();
            f.MdiParent = this;
            f.Show();
        }

        private void LuongCanbanbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new LuongCanbanForm())
            {
                f.ShowDialog();
            }
        }

        private void DanhmucSachbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new DanhmucSachForm();
            f.MdiParent = this;
            f.Show();
        }

        private void PhieuxuatbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new PhieuXuatSachForm();
            f.MdiParent = this;
            f.Show();
        }

        private void PhieuthuSachbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new PhieuThuSachForm();
            f.MdiParent = this;
            f.Show();
        }

        private void ThongtinbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new ThongtinForm())
            {
                f.ShowDialog();
            }
        }

        private void BackupInfobarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new BackupInfoForm())
            {
                f.ShowDialog();
            }
        }

        private void NDGiangdaybarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new NDGiangdayForm())
            {
                f.ShowDialog();
            }
        }

        private void BanhangbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new BanhangForm())
            {
                f.ShowDialog();
            }
        }
   

    }
}