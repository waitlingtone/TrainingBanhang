using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TrainingAccounting.View;
using TrainingAccounting.Model.BusinessObject;
using TrainingAccounting.Presenter;
using DevExpress.XtraReports.UI;
using TrainingAccounting.Report;

namespace TrainingAccounting.Form
{
    public partial class BangluongChuyenKhoanForm : DevExpress.XtraEditors.XtraForm, IBangluongChuyenKhoanView
    {
        BangluongChuyenKhoanPresenter _presenter;
        private PhieubaoLuongNhanvienModel _phieubao;
        private int _tmpThang;
        private List<PhieubaoLuongNhanvienModel> _phieubaoItems;
        public BangluongChuyenKhoanForm()
        {
            InitializeComponent();
            NamspinEdit.Value = DateTime.Now.Year;
            _tmpThang = DateTime.Now.Month;
        }
        public BangluongChuyenKhoanForm(PhieubaoLuongNhanvienModel phieubao, int thang, int nam)
        {
            InitializeComponent();
            _phieubao = phieubao;
            Nam = nam;
            _tmpThang = thang;
        }
        public BangluongChuyenKhoanForm(List<PhieubaoLuongNhanvienModel> phieubaoItems, int thang, int nam)
        {
            InitializeComponent();
            _phieubaoItems = phieubaoItems;
            Nam = nam;
            _tmpThang = thang;
        }
        private void BangluongChuyenKhoanForm_Load(object sender, EventArgs e)
        {
            _presenter = new BangluongChuyenKhoanPresenter(this);
            _presenter.LoadData();
            Thang = _tmpThang;
            _presenter.GetBangChuyenkhoan();
            if (_phieubao != null)
            {
                _presenter.AddNew();
            }
            else if (_phieubaoItems != null)
                _presenter.AddNewList();
        }

        public List<ThangModel> ThangItems
        {
            set { thangModelBindingSource.DataSource = value; }
        }

        public int Thang
        {
            get
            {
                return (int)ThangcomboBox.SelectedValue;
            }
            set
            {
                ThangcomboBox.SelectedValue = value;
            }
        }

        public int Nam
        {
            get
            {
                return (int)NamspinEdit.Value;
            }
            set
            {
                NamspinEdit.Value = value;
            }
        }

        public List<NhanvienModel> NhanvienItems
        {
            set { nhanvienModelBindingSource.DataSource = value; }
        }

        public PhieubaoLuongNhanvienModel PhieubaoLuong
        {
            get
            {
                return _phieubao ;
            }
            set
            {
                _phieubao = value;
            }
        }

        public List<BangluongChuyenkhoanModel> BangchuyenKhoanItems
        {
            get
            {
                return bangluongChuyenkhoanModelBindingSource.DataSource as List<BangluongChuyenkhoanModel>;
            }
            set
            {
                bangluongChuyenkhoanModelBindingSource.DataSource = value;
            }
        }

        public BangluongChuyenkhoanModel BangchuyenKhoanCurrent
        {
            get { return bangluongChuyenkhoanModelBindingSource.Current as BangluongChuyenkhoanModel; }
        }

        public void RefreshData()
        {
            bangluongChuyenkhoanModelGridControl.RefreshDataSource();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _presenter.Delete();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _presenter.Save();
        }

        private void TailaiButton_Click(object sender, EventArgs e)
        {
            _presenter.GetBangChuyenkhoan();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            using (var f = new BangluongChuyenkhoanReport(Thang, Nam))
            {
                f.ShowPreviewDialog();
            }
        }


        public List<PhieubaoLuongNhanvienModel> PhieubaoLuongItems
        {
            get
            {
                return _phieubaoItems;
            }
            set
            {
                _phieubaoItems = value;
            }
        }
    }
}