namespace TrainingAccounting.Form
{
    partial class ThoikhoabieuGiaovienForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThoikhoabieuGiaovienForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.nhanvienModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.nhanvienModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHodem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.lichhocDayhocModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.NumspinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.InLichButton = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ReloadButton = new DevExpress.XtraEditors.SimpleButton();
            this.NamspinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ThangcomboBox = new System.Windows.Forms.ComboBox();
            this.thangModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.printingSystem = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichhocDayhocModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumspinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamspinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thangModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink.ImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.nhanvienModelGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.schedulerControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1006, 504);
            this.splitContainerControl1.SplitterPosition = 311;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // nhanvienModelGridControl
            // 
            this.nhanvienModelGridControl.DataSource = this.nhanvienModelBindingSource;
            this.nhanvienModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanvienModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.nhanvienModelGridControl.MainView = this.gridView1;
            this.nhanvienModelGridControl.Name = "nhanvienModelGridControl";
            this.nhanvienModelGridControl.Size = new System.Drawing.Size(311, 504);
            this.nhanvienModelGridControl.TabIndex = 0;
            this.nhanvienModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nhanvienModelBindingSource
            // 
            this.nhanvienModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.NhanvienModel);
            this.nhanvienModelBindingSource.PositionChanged += new System.EventHandler(this.nhanvienModelBindingSource_PositionChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colHodem,
            this.colTen});
            this.gridView1.GridControl = this.nhanvienModelGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSTT
            // 
            this.colSTT.AppearanceCell.Options.UseTextOptions = true;
            this.colSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            // 
            // colHodem
            // 
            this.colHodem.FieldName = "Hodem";
            this.colHodem.Name = "colHodem";
            this.colHodem.Visible = true;
            this.colHodem.VisibleIndex = 1;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 2;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 49);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.OptionsView.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.Monday;
            this.schedulerControl1.Size = new System.Drawing.Size(689, 406);
            this.schedulerControl1.Start = new System.DateTime(2014, 7, 14, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage1;
            this.schedulerControl1.TabIndex = 1;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.Enabled = false;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.GanttView.Enabled = false;
            this.schedulerControl1.Views.MonthView.AppointmentDisplayOptions.AppointmentAutoHeight = true;
            this.schedulerControl1.Views.MonthView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
            this.schedulerControl1.Views.MonthView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
            this.schedulerControl1.Views.MonthView.CompressWeekend = false;
            this.schedulerControl1.Views.TimelineView.Enabled = false;
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.InitAppointmentDisplayText += new DevExpress.XtraScheduler.AppointmentDisplayTextEventHandler(this.schedulerControl1_InitAppointmentDisplayText);
            // 
            // schedulerStorage1
            // 
            this.schedulerStorage1.Appointments.DataSource = this.lichhocDayhocModelBindingSource;
            this.schedulerStorage1.Appointments.Mappings.AppointmentId = "LichhocDayhocId";
            this.schedulerStorage1.Appointments.Mappings.End = "GioKetthuc";
            this.schedulerStorage1.Appointments.Mappings.Start = "GioBatdau";
            this.schedulerStorage1.Appointments.Mappings.Subject = "Text2";
            // 
            // lichhocDayhocModelBindingSource
            // 
            this.lichhocDayhocModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.LichhocDayhocModel);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.NumspinEdit);
            this.panelControl2.Controls.Add(this.InLichButton);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 455);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(689, 49);
            this.panelControl2.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(90, 20);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(136, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Số tuần hiển thị trong khung";
            // 
            // NumspinEdit
            // 
            this.NumspinEdit.EditValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumspinEdit.Location = new System.Drawing.Point(18, 17);
            this.NumspinEdit.Name = "NumspinEdit";
            this.NumspinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.NumspinEdit.Properties.MaxValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumspinEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumspinEdit.Size = new System.Drawing.Size(56, 20);
            this.NumspinEdit.TabIndex = 1;
            this.NumspinEdit.EditValueChanged += new System.EventHandler(this.NumspinEdit_EditValueChanged);
            // 
            // InLichButton
            // 
            this.InLichButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InLichButton.Image = ((System.Drawing.Image)(resources.GetObject("InLichButton.Image")));
            this.InLichButton.Location = new System.Drawing.Point(599, 14);
            this.InLichButton.Name = "InLichButton";
            this.InLichButton.Size = new System.Drawing.Size(75, 23);
            this.InLichButton.TabIndex = 0;
            this.InLichButton.Text = "In Lịch";
            this.InLichButton.Click += new System.EventHandler(this.InLichButton_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ReloadButton);
            this.panelControl1.Controls.Add(this.NamspinEdit);
            this.panelControl1.Controls.Add(this.ThangcomboBox);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(689, 49);
            this.panelControl1.TabIndex = 0;
            // 
            // ReloadButton
            // 
            this.ReloadButton.Location = new System.Drawing.Point(349, 15);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(75, 21);
            this.ReloadButton.TabIndex = 3;
            this.ReloadButton.Text = "Tải lại";
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // NamspinEdit
            // 
            this.NamspinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NamspinEdit.Location = new System.Drawing.Point(251, 15);
            this.NamspinEdit.Name = "NamspinEdit";
            this.NamspinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.NamspinEdit.Size = new System.Drawing.Size(66, 20);
            this.NamspinEdit.TabIndex = 2;
            // 
            // ThangcomboBox
            // 
            this.ThangcomboBox.DataSource = this.thangModelBindingSource;
            this.ThangcomboBox.DisplayMember = "Tenthang";
            this.ThangcomboBox.FormattingEnabled = true;
            this.ThangcomboBox.Location = new System.Drawing.Point(90, 15);
            this.ThangcomboBox.Name = "ThangcomboBox";
            this.ThangcomboBox.Size = new System.Drawing.Size(88, 21);
            this.ThangcomboBox.TabIndex = 1;
            this.ThangcomboBox.ValueMember = "Thang";
            this.ThangcomboBox.SelectedValueChanged += new System.EventHandler(this.ThangcomboBox_SelectedValueChanged);
            // 
            // thangModelBindingSource
            // 
            this.thangModelBindingSource.DataSource = typeof(TrainingAccounting.Model.BusinessObject.ThangModel);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(212, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(21, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Năm";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chọn tháng";
            // 
            // printingSystem
            // 
            this.printingSystem.Links.AddRange(new object[] {
            this.printableComponentLink});
            // 
            // printableComponentLink
            // 
            this.printableComponentLink.Component = this.schedulerControl1;
            // 
            // 
            // 
            this.printableComponentLink.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink.ImageCollection.ImageStream")));
            this.printableComponentLink.Landscape = true;
            this.printableComponentLink.Margins = new System.Drawing.Printing.Margins(20, 20, 60, 20);
            this.printableComponentLink.Owner = null;
            this.printableComponentLink.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.printableComponentLink.PrintingSystem = this.printingSystem;
            this.printableComponentLink.PrintingSystemBase = this.printingSystem;
            // 
            // ThoikhoabieuGiaovienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 504);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "ThoikhoabieuGiaovienForm";
            this.Text = "LỊCH GIẢNG DẠY CỦA GIÁO VIÊN";
            this.Load += new System.EventHandler(this.ThoikhoabieuGiaovienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichhocDayhocModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumspinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamspinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thangModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink.ImageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl nhanvienModelGridControl;
        private System.Windows.Forms.BindingSource nhanvienModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colHodem;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SpinEdit NamspinEdit;
        private System.Windows.Forms.ComboBox ThangcomboBox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private System.Windows.Forms.BindingSource lichhocDayhocModelBindingSource;
        private System.Windows.Forms.BindingSource thangModelBindingSource;
        private DevExpress.XtraEditors.SimpleButton ReloadButton;
        private DevExpress.XtraEditors.SimpleButton InLichButton;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit NumspinEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
    }
}