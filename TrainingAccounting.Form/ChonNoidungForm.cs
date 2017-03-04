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

namespace TrainingAccounting.Form
{
    public partial class ChonNoidungForm : DevExpress.XtraEditors.XtraForm, IChonNoidungView
    {
        ChonNoidungPresenter _presenter;
        private Guid _lichhocDayhocId;
        public List<NDGiangdayModel> _nDGiangdaySelected;
        public ChonNoidungForm(Guid LichhocDayhocId)
        {
            InitializeComponent();
            _lichhocDayhocId = LichhocDayhocId;
        }

        private void ChonNoidungForm_Load(object sender, EventArgs e)
        {
            _presenter = new ChonNoidungPresenter(this);
            _presenter.LoadData();
        }

        public List<NDGiangdayModel> NDGiangdayItems
        {
            get
            {
                return nDGiangdayModelBindingSource.DataSource as List<NDGiangdayModel>;
            }
            set
            {
                nDGiangdayModelBindingSource.DataSource = value;
            }
        }

        public Guid LichhocDayhocId
        {
            get { return _lichhocDayhocId; }
        }

        public void RefreshData()
        {
            throw new NotImplementedException();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            _nDGiangdaySelected = new List<NDGiangdayModel>();
            foreach (var i in NDGiangdayItems)
            {
                if (i.Selected)
                    _nDGiangdaySelected.Add(i);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}