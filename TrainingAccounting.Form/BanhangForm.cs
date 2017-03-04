using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TrainingAccounting.Presenter;
using TrainingAccounting.Model.BusinessObject;
using TrainingAccounting.View;

namespace TrainingAccounting.Form
{
    public partial class BanhangForm : DevExpress.XtraEditors.XtraForm,IHoadonView
    {
        HoadonPresenter _presenter;
        List<HanghoaModel> _HanghoaItems;
        public BanhangForm()
        {
            InitializeComponent();
        }

        private void repositoryItemLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit look = (LookUpEdit)sender;
            foreach(var i in _HanghoaItems)
            {
                if (i.HanghoaId == ChitietHoadonCurrent.HanghoaId)
                {
                    ChitietHoadonCurrent.Dongia = i.Giaban;
                    ChitietHoadonCurrent.Thanhtien = i.Giaban * ChitietHoadonCurrent.Soluong;
                    break;
                }
            }
            RefreshData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            _presenter.SaveChitietHoadon();
            _presenter.TongtienHD();
            _presenter.SaveHD();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _presenter.AddChitietHoadon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            _presenter.DeleteChitietHoadon();
        }


        private void BanhangForm_Load(object sender, EventArgs e)
        {
            _presenter = new HoadonPresenter(this);
            _presenter.LoadData();
        }

        public List<HoadonModel> HoadonItems
        {
            get
            {
                return hoadonModelBindingSource.DataSource as List<HoadonModel>;
            }
            set
            {
                hoadonModelBindingSource.DataSource = value;
            }
        }

        public HoadonModel HoadonCurrent
        {
            get { return hoadonModelBindingSource.Current as HoadonModel; }
        }

        public List<HanghoaModel> HanghoaItems
        {
            set
            {
                hanghoaModelBindingSource.DataSource = value; _HanghoaItems = value;
            }
        }

        public List<ChitietHoadonModel> ChitietHoadonItems
        {
            get
            {
                return chitietHoadonModelBindingSource.DataSource as List<ChitietHoadonModel>;
            }
            set
            {
                chitietHoadonModelBindingSource.DataSource = value;
            }
        }

        public ChitietHoadonModel ChitietHoadonCurrent
        {
            get { return chitietHoadonModelBindingSource.Current as ChitietHoadonModel; }

        }

        public void RefreshData()
        {
            gridControl2.RefreshDataSource();
        }

        private void hoadonModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            _presenter.LoadChitietHoadon();
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            _presenter.AddHD();
            
        }

        private void chitietHoadonModelBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (ChitietHoadonCurrent.Dongia == null)
                return;
            ChitietHoadonCurrent.Thanhtien = ChitietHoadonCurrent.Dongia * ChitietHoadonCurrent.Soluong;
        }




       
    }
}