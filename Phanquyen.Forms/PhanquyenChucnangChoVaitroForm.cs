using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Phanquyen.View;
using Phanquyen.Presenter;
using Phanquyen.Model.BusinessObject;
using DevExpress.XtraTreeList.Nodes.Operations;
using DevExpress.XtraTreeList.Nodes;

namespace Phanquyen.Forms
{
    public partial class PhanquyenChucnangChoVaitroForm : DevExpress.XtraEditors.XtraForm, IPhanquyenChucnangChoVaitroView
    {
        PhanquyenChucnangChoVaitroPresenter _presenter;
        private List<RoleRightModel> _vaitroChucnangItems;
        public PhanquyenChucnangChoVaitroForm()
        {
            InitializeComponent();
        }

        private void PhanquyenChucnangChoVaitroForm_Load(object sender, EventArgs e)
        {
            _presenter = new PhanquyenChucnangChoVaitroPresenter(this);
            _presenter.LoadData();
            roleModelBindingSource_PositionChanged(new object(), new EventArgs());
        }

        public List<RoleModel> VaitroItems
        {
            set { roleModelBindingSource.DataSource = value; }
        }

        public RoleModel VaitroCurrent
        {
            get { return roleModelBindingSource.Current as RoleModel; }
        }

        public void RefreshData()
        {
            ItemtreeList.RefreshDataSource();
        }


        public List<Item> ChucnangItems
        {
            get
            {
                return itemModelBindingSource.DataSource as List<Item>;
            }
            set
            {
                itemModelBindingSource.DataSource = value;
            }
        }
        class GetCheckedNodesOperation : TreeListOperation
        {
            public List<TreeListNode> CheckedNodes = new List<TreeListNode>();
            public GetCheckedNodesOperation() : base() { }
            public override void Execute(TreeListNode node)
            {
                if (node.CheckState == CheckState.Checked || node.CheckState == CheckState.Indeterminate)
                    CheckedNodes.Add(node);
            }
        }

        public List<Guid?> ItemIds
        {
            get
            {
                GetCheckedNodesOperation op = new GetCheckedNodesOperation();
                ItemtreeList.NodesIterator.DoOperation(op);
                List<Guid?> lst = new List<Guid?>();
                foreach (var i in op.CheckedNodes)
                {
                    lst.Add(i.GetValue(i.TreeList.KeyFieldName) as Guid?);
                }
                return lst;
            } 
        }
        class GetAllNodesOperation : TreeListOperation
        {
            public List<TreeListNode> AllNodes = new List<TreeListNode>();
            public GetAllNodesOperation() : base() { }
            public override void Execute(TreeListNode node)
            {
                AllNodes.Add(node);
            }
        }
        private void roleModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            GetAllNodesOperation op = new GetAllNodesOperation();
            ItemtreeList.NodesIterator.DoOperation(op);
            foreach (var i in op.AllNodes)
            {
                i.CheckState = CheckState.Unchecked;
            }
            _presenter.GetChucnangByVaitro();
            foreach (var node in op.AllNodes)
            {
                foreach (var i in _vaitroChucnangItems)
                {
                    if ((node.GetValue(node.TreeList.KeyFieldName) as Guid?).Value.CompareTo(i.ItemId.Value) == 0)
                        node.CheckState = CheckState.Checked;
                    //else
                        //node.CheckState = CheckState.Unchecked;
                }
            }
            RefreshData();
        }


        public List<RoleRightModel> VaitroChucnangItems
        {
            get
            {
                return _vaitroChucnangItems;
            }
            set
            {
                _vaitroChucnangItems = value;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _presenter.Save();
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void TailaiButton_Click(object sender, EventArgs e)
        {
            _presenter.GetVaitro();
        }


        public List<GroupItemModel> NhomChucnangItems
        {
            set { groupItemModelBindingSource.DataSource = value; }
        }

        public Guid? NhomChucnangId
        {
            get { return NhomChucnangcomboBox.SelectedValue as Guid?; }
        }

        private void NhomChucnangcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (NhomChucnangId == null)
                return;
            _presenter.GetChucnangByNhomChucnang();
            GetAllNodesOperation op = new GetAllNodesOperation();
            ItemtreeList.NodesIterator.DoOperation(op);
            foreach (var i in op.AllNodes)
            {
                i.CheckState = CheckState.Unchecked;
            }
            foreach (var node in op.AllNodes)
            {
                foreach (var i in _vaitroChucnangItems)
                {
                    if ((node.GetValue(node.TreeList.KeyFieldName) as Guid?).Value.CompareTo(i.ItemId.Value) == 0)
                        node.CheckState = CheckState.Checked;
                    //else
                    //node.CheckState = CheckState.Unchecked;
                }
            }
            RefreshData();
        }
    }
}