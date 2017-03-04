using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TrainingAccounting.View;
using TrainingAccounting.Presenter;
using TrainingAccounting.Model.BusinessObject;
using TrainingAccounting.Report;
using DevExpress.XtraReports.UI;

namespace TrainingAccounting.Form
{
    public partial class ChitietPhieubaoHocphiForm : DevExpress.XtraEditors.XtraForm, IChitietPhieubaoHocphiView
    {
        ChitietPhieubaoHocphiPresenter _presenter;
        private PhieubaoHocphiModel _treCurrent;
        private int _thang;
        private int _nam;

        public ChitietPhieubaoHocphiForm(PhieubaoHocphiModel TreCurrent, int Thang, int Nam)
        {
            InitializeComponent();
            if (TreCurrent == null)
                return;
            this._treCurrent = TreCurrent;
            this._thang = Thang;
            this._nam = Nam;
            HotentextEdit.Text = String.Format("{0} {1}", TreCurrent.Hodem, TreCurrent.Ten);
            ThangtextEdit.Text = Thang.ToString();
            NamtextEdit.Text = Nam.ToString();
        }

        private void ChitietPhieubaoHocphiForm_Load(object sender, EventArgs e)
        {
            _presenter = new ChitietPhieubaoHocphiPresenter(this);
            _presenter.LoadData();
            gridView1.ExpandAllGroups();
        }

        public void RefreshData()
        {
            chitietPhieubaoHocphiGridControl.RefreshDataSource();
        }

        public PhieubaoHocphiModel TreCurrent
        {
            get { return this._treCurrent; }
        }

        public int Thang
        {
            get { return this._thang; }
        }

        public int Nam
        {
            get { return this._nam; }
        }

        public List<ChitietPhieubaoHocphi> ChitietPhieubaoItems
        {
            set { chitietPhieubaoHocphiBindingSource.DataSource = value; }
        }

        private void InButton_Click(object sender, EventArgs e)
        {
            using (var f = new ChitietPhieubaoHocphiReport(TreCurrent, Thang, Nam))
            {
                f.ShowPreviewDialog();
            }
        }

    }
}