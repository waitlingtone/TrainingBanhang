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

namespace Lambda.MainProject
{
    public partial class MainForm : RibbonForm, ItemView
    {
        Timer timer = new Timer();
        ItemPresenter presenter;
        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
            
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            var thoigianDateTime = DateTime.Now;
            if (thoigianDateTime.Second % 8 == 0)
            {
                System.GC.Collect();
            }
        }
        MenuObject menu = new MenuObject();
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);

            menu.CaptionButtonClick += new RibbonPageGroupEventHandler(RibbonPageGroup_CaptionButtonClick);
            menu.ItemClick += new ItemClickEventHandler(ItemClick);
            menu.SetPages(this.Ribbon.Pages);

        }

        private void RibbonPageGroup_CaptionButtonClick(object sender, RibbonPageGroupEventArgs e)
        {
            var item = e.PageGroup.Tag as Item;

            if (item == null)
            {
                item = new Item { Name = e.PageGroup.Name, Text = e.PageGroup.Text };
                e.PageGroup.Tag = item;
            }
            MessageBox.Show(item.Text);
        }

        private void ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = e.Item.Tag as Item;

            if (item == null)
            {
                item = new Item { Name = e.Item.Name, Text = e.Item.Caption };
                e.Item.Tag = item;
            }

            //DynamicLoad.DynaInvoke.SetProperty(this, "Text", item.TenFileDLL);

            //DynamicLoad.DynaInvoke.CallMethod(item.TenFileDLL, item.TenForm, "ShowDialog", false, new Object[] { this });

            var type = DynamicLoad.DynaInvoke.GetType(item.TenForm, item.TenFileDLL);
            if (type == null)
                return;
            if (item.ShowFormAsTab == null || item.ShowFormAsTab == false)
                using (var f = Activator.CreateInstance(type) as DevExpress.XtraEditors.XtraForm)
                {
                    f.ShowDialog(this);
                }
            else if (item.ShowFormAsTab.Value)
            {
                var formPages = xtraTabbedMdiManager1.Pages;
                for (int i = 0; i < formPages.Count; i++)
                {
                    
                    if (formPages[i].MdiChild.GetType().FullName == type.FullName)
                    {   
                        return;
                    }
                }
                var f = Activator.CreateInstance(type) as DevExpress.XtraEditors.XtraForm;
                f.MdiParent = this;
                f.Show();
            }
            //MessageBox.Show(item.Text);
        }

        //private void ribbonControl_DoubleClick(object sender, EventArgs e)
        //{
        //    var item = this.Ribbon.SelectedPage.Tag as Item;

        //    if (item == null)
        //    {
        //        item = new Item { Name = Ribbon.SelectedPage.Name, Text = Ribbon.SelectedPage.Text };
        //        this.Ribbon.SelectedPage.Tag = item;
        //    }
        //    MessageBox.Show(item.Text);

        //}
        public void RefreshData()
        {
            //ItemTreeList.RefreshDataSource();
        }

        public List<Item> Items
        {
            get
            {
                return itemBindingSource.DataSource as List<Item>;
            }
            set
            {
                itemBindingSource.DataSource = value;
            }
        }

        public Item CurrentItem
        {
            get { return itemBindingSource.Current as Item; }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //ribbonControl.Pages.Clear();
            //ribbonControl.Items.Clear();
            presenter = new ItemPresenter(this);
            presenter.Display();
            menu.AddItem(this.Items);
            menu.SetRibbonEvent();
            Info.Info.CreateImage();
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void DangnhaplaibarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Restart();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //groupControl.Location = new Point(this.Width / 2 - groupControl.Width / 2, this.Height * 6 / 10 - groupControl.Height / 2);
        
        }

        private void DoiMatkhaubarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new DoiMatkhauForm())
            {
                f.ShowDialog();
            }
        }
    }
}