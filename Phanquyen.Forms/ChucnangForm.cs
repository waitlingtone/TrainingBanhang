using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Phanquyen.View;
using Phanquyen.Model.BusinessObject;
using Phanquyen.Presenter;
using System.Reflection;

namespace Phanquyen.Forms
{
    public partial class ChucnangForm : DevExpress.XtraEditors.XtraForm, IChucnangView
    {
        ChucnangPresenter _presenter;
        public ChucnangForm()
        {
            InitializeComponent();
        }

        private void ChucnangForm_Load(object sender, EventArgs e)
        {
            _presenter = new ChucnangPresenter(this);
            _presenter.LoadData();
        }

        public List<Item> Items
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

        public Item CurrentItem
        {
            get { return itemModelBindingSource.Current as Item; }
        }

        public void RefreshData()
        {
            ItemstreeList.RefreshDataSource();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _presenter.AddNew();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _presenter.Delete();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _presenter.Save();
        }

        private void AddChildButton_Click(object sender, EventArgs e)
        {
            _presenter.AddChild();
        }

        private void NhomChucnangcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (NhomChucnangId == null)
                return;
            _presenter.GetChucnangByNhomChucnang();
        }


        public List<GroupItemModel> NhomChucnangItems
        {
            set { groupItemModelBindingSource.DataSource = value; }
        }

        public Guid? NhomChucnangId
        {
            get { return NhomChucnangcomboBox.SelectedValue as Guid?; }
        }

        private void BrownsbuttonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (var f = new OpenFileDialog())
            {
                var result = f.ShowDialog(this);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    BrownsbuttonEdit.Text = f.FileName;
                    var t = Assembly.LoadFrom(f.FileName).GetTypes();
                    var listClass = new List<String>();
                    foreach (var item in t)
                    {
                        listClass.Add(item.FullName);
                    }
                    ClasscomboBox.Items.Clear();
                    ClasscomboBox.Items.AddRange(listClass.ToArray());
                }
            }
        }

        private void GetItemButton_Click(object sender, EventArgs e)
        {
            var fileName = BrownsbuttonEdit.Text;
            if (String.IsNullOrEmpty(BrownsbuttonEdit.Text))
                return;
            Type type = Lambda.DynamicLoad.DynaInvoke.GetType(ClasscomboBox.Text, fileName);
            var obj = Activator.CreateInstance(type) as DevExpress.XtraBars.Ribbon.RibbonForm;
            MenuObject menu = new MenuObject();
            menu.SetPages(obj.Ribbon.Pages);
            var items = menu.GetItems(true);
            foreach (var i in items)
                i.GroupItemId = NhomChucnangId;
            itemModelBindingSource.DataSource = items;
        }
    }
}