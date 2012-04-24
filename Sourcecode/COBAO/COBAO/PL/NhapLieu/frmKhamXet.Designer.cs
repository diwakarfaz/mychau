namespace COBAO.PL.NhapLieu
{
    partial class frmKhamXet
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
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtGio = new DevExpress.XtraEditors.TextEdit();
            this.txtNgay = new DevExpress.XtraEditors.TextEdit();
            this.txtGop = new DevExpress.XtraEditors.TextEdit();
            this.tmGioKetThuc = new DevExpress.XtraEditors.TimeEdit();
            this.tmGioBatDau = new DevExpress.XtraEditors.TimeEdit();
            this.cbbTaiPhu = new DevExpress.XtraEditors.LookUpEdit();
            this.taiXeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cOBAODataSet = new COBAO.DAL.COBAODataSet();
            this.cbbTaiChinh = new DevExpress.XtraEditors.LookUpEdit();
            this.taiXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbMaDauMay = new DevExpress.XtraEditors.LookUpEdit();
            this.dauMayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.lblGioKetThuc = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.lblNgayKetThuc = new DevExpress.XtraEditors.LabelControl();
            this.lblGioBatDau = new DevExpress.XtraEditors.LabelControl();
            this.lblNgayBatDau = new DevExpress.XtraEditors.LabelControl();
            this.lblTaiPhu = new DevExpress.XtraEditors.LabelControl();
            this.lblMaDauMay = new DevExpress.XtraEditors.LabelControl();
            this.lblMaTaiXe1 = new DevExpress.XtraEditors.LabelControl();
            this.gcKhamXet = new DevExpress.XtraGrid.GridControl();
            this.gvKhamXet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDauMay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTaiChinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTaiPhu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTaiPhu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTaiChinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiGianKhamXet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioCaBa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.dxValid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dauMayTableAdapter = new COBAO.DAL.COBAODataSetTableAdapters.DauMayTableAdapter();
            this.taiXeTableAdapter = new COBAO.DAL.COBAODataSetTableAdapters.TaiXeTableAdapter();
            this.thu = new DevExpress.XtraEditors.TimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmGioKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmGioBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTaiPhu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiXeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOBAODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTaiChinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiXeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaDauMay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dauMayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhamXet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhamXet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(137, 155);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 23);
            this.btnThemMoi.TabIndex = 26;
            this.btnThemMoi.Text = "&Ghi nhận";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.thu);
            this.panelControl1.Controls.Add(this.txtGio);
            this.panelControl1.Controls.Add(this.txtNgay);
            this.panelControl1.Controls.Add(this.txtGop);
            this.panelControl1.Controls.Add(this.tmGioKetThuc);
            this.panelControl1.Controls.Add(this.tmGioBatDau);
            this.panelControl1.Controls.Add(this.cbbTaiPhu);
            this.panelControl1.Controls.Add(this.cbbTaiChinh);
            this.panelControl1.Controls.Add(this.cbbMaDauMay);
            this.panelControl1.Controls.Add(this.dtNgayKetThuc);
            this.panelControl1.Controls.Add(this.lblGioKetThuc);
            this.panelControl1.Controls.Add(this.dtNgayBatDau);
            this.panelControl1.Controls.Add(this.lblNgayKetThuc);
            this.panelControl1.Controls.Add(this.lblGioBatDau);
            this.panelControl1.Controls.Add(this.lblNgayBatDau);
            this.panelControl1.Controls.Add(this.lblTaiPhu);
            this.panelControl1.Controls.Add(this.lblMaDauMay);
            this.panelControl1.Controls.Add(this.lblMaTaiXe1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(963, 137);
            this.panelControl1.TabIndex = 25;
            // 
            // txtGio
            // 
            this.txtGio.Location = new System.Drawing.Point(700, 112);
            this.txtGio.Name = "txtGio";
            this.txtGio.Size = new System.Drawing.Size(193, 20);
            this.txtGio.TabIndex = 11;
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(700, 83);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(193, 20);
            this.txtNgay.TabIndex = 11;
            // 
            // txtGop
            // 
            this.txtGop.Location = new System.Drawing.Point(700, 43);
            this.txtGop.Name = "txtGop";
            this.txtGop.Properties.Mask.EditMask = "d";
            this.txtGop.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtGop.Size = new System.Drawing.Size(193, 20);
            this.txtGop.TabIndex = 11;
            // 
            // tmGioKetThuc
            // 
            this.tmGioKetThuc.EditValue = new System.DateTime(2012, 3, 27, 0, 0, 0, 0);
            this.tmGioKetThuc.Location = new System.Drawing.Point(461, 95);
            this.tmGioKetThuc.Name = "tmGioKetThuc";
            this.tmGioKetThuc.Properties.Appearance.Options.UseTextOptions = true;
            this.tmGioKetThuc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tmGioKetThuc.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tmGioKetThuc.Properties.AppearanceFocused.Options.UseFont = true;
            this.tmGioKetThuc.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.tmGioKetThuc.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tmGioKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tmGioKetThuc.Properties.Mask.EditMask = "t";
            this.tmGioKetThuc.Size = new System.Drawing.Size(212, 20);
            this.tmGioKetThuc.TabIndex = 10;
            // 
            // tmGioBatDau
            // 
            this.tmGioBatDau.EditValue = new System.DateTime(2012, 4, 24, 0, 0, 0, 0);
            this.tmGioBatDau.Location = new System.Drawing.Point(461, 67);
            this.tmGioBatDau.Name = "tmGioBatDau";
            this.tmGioBatDau.Properties.Appearance.Options.UseTextOptions = true;
            this.tmGioBatDau.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tmGioBatDau.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tmGioBatDau.Properties.AppearanceFocused.Options.UseFont = true;
            this.tmGioBatDau.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.tmGioBatDau.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tmGioBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tmGioBatDau.Properties.Mask.EditMask = "t";
            this.tmGioBatDau.Size = new System.Drawing.Size(212, 20);
            this.tmGioBatDau.TabIndex = 10;
            // 
            // cbbTaiPhu
            // 
            this.cbbTaiPhu.Location = new System.Drawing.Point(461, 40);
            this.cbbTaiPhu.Name = "cbbTaiPhu";
            this.cbbTaiPhu.Properties.Appearance.Options.UseTextOptions = true;
            this.cbbTaiPhu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbTaiPhu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.cbbTaiPhu.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbbTaiPhu.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.cbbTaiPhu.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbbTaiPhu.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.cbbTaiPhu.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbTaiPhu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbTaiPhu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaTaiXe", "Mã tài xế", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTaiXe", "Tên tài xế"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tai", "Là tài")});
            this.cbbTaiPhu.Properties.DataSource = this.taiXeBindingSource1;
            this.cbbTaiPhu.Properties.DisplayMember = "MaTaiXe";
            this.cbbTaiPhu.Properties.NullText = "";
            this.cbbTaiPhu.Properties.ValueMember = "MaTaiXe";
            this.cbbTaiPhu.Size = new System.Drawing.Size(212, 20);
            this.cbbTaiPhu.TabIndex = 9;
            this.cbbTaiPhu.Click += new System.EventHandler(this.cbbTaiPhu_click);
            // 
            // taiXeBindingSource1
            // 
            this.taiXeBindingSource1.DataMember = "TaiXe";
            this.taiXeBindingSource1.DataSource = this.cOBAODataSet;
            // 
            // cOBAODataSet
            // 
            this.cOBAODataSet.DataSetName = "COBAODataSet";
            this.cOBAODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbTaiChinh
            // 
            this.cbbTaiChinh.Location = new System.Drawing.Point(99, 39);
            this.cbbTaiChinh.Name = "cbbTaiChinh";
            this.cbbTaiChinh.Properties.Appearance.Options.UseTextOptions = true;
            this.cbbTaiChinh.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbTaiChinh.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.cbbTaiChinh.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbbTaiChinh.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.cbbTaiChinh.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbbTaiChinh.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.cbbTaiChinh.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbTaiChinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbTaiChinh.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaTaiXe", "Mã tài xế", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTaiXe", "Tên tài xế"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tai", "Là tài")});
            this.cbbTaiChinh.Properties.DataSource = this.taiXeBindingSource;
            this.cbbTaiChinh.Properties.DisplayMember = "MaTaiXe";
            this.cbbTaiChinh.Properties.NullText = "";
            this.cbbTaiChinh.Properties.ValueMember = "MaTaiXe";
            this.cbbTaiChinh.Size = new System.Drawing.Size(212, 20);
            this.cbbTaiChinh.TabIndex = 9;
            // 
            // taiXeBindingSource
            // 
            this.taiXeBindingSource.DataMember = "TaiXe";
            this.taiXeBindingSource.DataSource = this.cOBAODataSet;
            // 
            // cbbMaDauMay
            // 
            this.cbbMaDauMay.Location = new System.Drawing.Point(99, 11);
            this.cbbMaDauMay.Name = "cbbMaDauMay";
            this.cbbMaDauMay.Properties.Appearance.Options.UseTextOptions = true;
            this.cbbMaDauMay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbMaDauMay.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.cbbMaDauMay.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbbMaDauMay.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.cbbMaDauMay.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbbMaDauMay.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.cbbMaDauMay.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbMaDauMay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMaDauMay.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDM", "Mã đầu máy", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDM", "Tên đầu máy")});
            this.cbbMaDauMay.Properties.DataSource = this.dauMayBindingSource;
            this.cbbMaDauMay.Properties.DisplayMember = "TenDM";
            this.cbbMaDauMay.Properties.NullText = "";
            this.cbbMaDauMay.Properties.ValueMember = "MaDM";
            this.cbbMaDauMay.Size = new System.Drawing.Size(212, 20);
            this.cbbMaDauMay.TabIndex = 9;
            // 
            // dauMayBindingSource
            // 
            this.dauMayBindingSource.DataMember = "DauMay";
            this.dauMayBindingSource.DataSource = this.cOBAODataSet;
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.EditValue = null;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(99, 95);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Properties.Appearance.Options.UseTextOptions = true;
            this.dtNgayKetThuc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dtNgayKetThuc.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtNgayKetThuc.Properties.AppearanceFocused.Options.UseFont = true;
            this.dtNgayKetThuc.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.dtNgayKetThuc.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dtNgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayKetThuc.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtNgayKetThuc.Size = new System.Drawing.Size(212, 20);
            this.dtNgayKetThuc.TabIndex = 4;
            // 
            // lblGioKetThuc
            // 
            this.lblGioKetThuc.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblGioKetThuc.Location = new System.Drawing.Point(369, 99);
            this.lblGioKetThuc.Name = "lblGioKetThuc";
            this.lblGioKetThuc.Size = new System.Drawing.Size(68, 13);
            this.lblGioKetThuc.TabIndex = 8;
            this.lblGioKetThuc.Text = "Giờ kết thúc";
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.EditValue = null;
            this.dtNgayBatDau.Location = new System.Drawing.Point(99, 67);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Properties.Appearance.Options.UseTextOptions = true;
            this.dtNgayBatDau.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dtNgayBatDau.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtNgayBatDau.Properties.AppearanceFocused.Options.UseFont = true;
            this.dtNgayBatDau.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.dtNgayBatDau.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dtNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayBatDau.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtNgayBatDau.Size = new System.Drawing.Size(212, 20);
            this.dtNgayBatDau.TabIndex = 4;
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNgayKetThuc.Location = new System.Drawing.Point(5, 99);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(78, 13);
            this.lblNgayKetThuc.TabIndex = 8;
            this.lblNgayKetThuc.Text = "Ngày kết thúc";
            // 
            // lblGioBatDau
            // 
            this.lblGioBatDau.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblGioBatDau.Location = new System.Drawing.Point(369, 71);
            this.lblGioBatDau.Name = "lblGioBatDau";
            this.lblGioBatDau.Size = new System.Drawing.Size(64, 13);
            this.lblGioBatDau.TabIndex = 8;
            this.lblGioBatDau.Text = "Giờ bắt đầu";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNgayBatDau.Location = new System.Drawing.Point(5, 71);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(74, 13);
            this.lblNgayBatDau.TabIndex = 8;
            this.lblNgayBatDau.Text = "Ngày bắt đầu";
            // 
            // lblTaiPhu
            // 
            this.lblTaiPhu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTaiPhu.Location = new System.Drawing.Point(369, 43);
            this.lblTaiPhu.Name = "lblTaiPhu";
            this.lblTaiPhu.Size = new System.Drawing.Size(41, 13);
            this.lblTaiPhu.TabIndex = 7;
            this.lblTaiPhu.Text = "Tài phụ";
            // 
            // lblMaDauMay
            // 
            this.lblMaDauMay.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMaDauMay.Location = new System.Drawing.Point(5, 14);
            this.lblMaDauMay.Name = "lblMaDauMay";
            this.lblMaDauMay.Size = new System.Drawing.Size(69, 13);
            this.lblMaDauMay.TabIndex = 6;
            this.lblMaDauMay.Text = "Mã đầu máy";
            // 
            // lblMaTaiXe1
            // 
            this.lblMaTaiXe1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMaTaiXe1.Location = new System.Drawing.Point(5, 43);
            this.lblMaTaiXe1.Name = "lblMaTaiXe1";
            this.lblMaTaiXe1.Size = new System.Drawing.Size(50, 13);
            this.lblMaTaiXe1.TabIndex = 6;
            this.lblMaTaiXe1.Text = "Tài chính";
            // 
            // gcKhamXet
            // 
            this.gcKhamXet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcKhamXet.Location = new System.Drawing.Point(12, 184);
            this.gcKhamXet.MainView = this.gvKhamXet;
            this.gcKhamXet.Name = "gcKhamXet";
            this.gcKhamXet.Size = new System.Drawing.Size(963, 127);
            this.gcKhamXet.TabIndex = 31;
            this.gcKhamXet.UseEmbeddedNavigator = true;
            this.gcKhamXet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhamXet});
            // 
            // gvKhamXet
            // 
            this.gvKhamXet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDauMay,
            this.colMaTaiChinh,
            this.colMaTaiPhu,
            this.colTenTaiPhu,
            this.colTenTaiChinh,
            this.colNgayBatDau,
            this.colGioBatDau,
            this.colGioKetThuc,
            this.colNgayKetThuc,
            this.colThoiGianKhamXet,
            this.colGioCaBa});
            this.gvKhamXet.GridControl = this.gcKhamXet;
            this.gvKhamXet.GroupPanelText = " ";
            this.gvKhamXet.Name = "gvKhamXet";
            this.gvKhamXet.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvKhamXet.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvKhamXet.OptionsBehavior.Editable = false;
            this.gvKhamXet.OptionsBehavior.ReadOnly = true;
            this.gvKhamXet.OptionsView.ShowDetailButtons = false;
            // 
            // colMaDauMay
            // 
            this.colMaDauMay.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaDauMay.AppearanceCell.Options.UseFont = true;
            this.colMaDauMay.AppearanceCell.Options.UseTextOptions = true;
            this.colMaDauMay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaDauMay.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaDauMay.AppearanceHeader.Options.UseFont = true;
            this.colMaDauMay.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaDauMay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaDauMay.Caption = "Mã đầu máy";
            this.colMaDauMay.FieldName = "MaDM";
            this.colMaDauMay.Name = "colMaDauMay";
            this.colMaDauMay.Visible = true;
            this.colMaDauMay.VisibleIndex = 0;
            // 
            // colMaTaiChinh
            // 
            this.colMaTaiChinh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaTaiChinh.AppearanceCell.Options.UseFont = true;
            this.colMaTaiChinh.AppearanceCell.Options.UseTextOptions = true;
            this.colMaTaiChinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaTaiChinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaTaiChinh.AppearanceHeader.Options.UseFont = true;
            this.colMaTaiChinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaTaiChinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaTaiChinh.Caption = "Mã tài chính";
            this.colMaTaiChinh.FieldName = "MaTaiXeChinh";
            this.colMaTaiChinh.Name = "colMaTaiChinh";
            this.colMaTaiChinh.Visible = true;
            this.colMaTaiChinh.VisibleIndex = 1;
            // 
            // colMaTaiPhu
            // 
            this.colMaTaiPhu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaTaiPhu.AppearanceCell.Options.UseFont = true;
            this.colMaTaiPhu.AppearanceCell.Options.UseTextOptions = true;
            this.colMaTaiPhu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaTaiPhu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaTaiPhu.AppearanceHeader.Options.UseFont = true;
            this.colMaTaiPhu.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaTaiPhu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaTaiPhu.Caption = "Mã tài phụ";
            this.colMaTaiPhu.FieldName = "MaTaiXePhu";
            this.colMaTaiPhu.Name = "colMaTaiPhu";
            this.colMaTaiPhu.Visible = true;
            this.colMaTaiPhu.VisibleIndex = 3;
            // 
            // colTenTaiPhu
            // 
            this.colTenTaiPhu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenTaiPhu.AppearanceHeader.Options.UseFont = true;
            this.colTenTaiPhu.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenTaiPhu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenTaiPhu.Caption = "Tên tài phụ";
            this.colTenTaiPhu.FieldName = "TenTaiXePhu";
            this.colTenTaiPhu.Name = "colTenTaiPhu";
            this.colTenTaiPhu.Visible = true;
            this.colTenTaiPhu.VisibleIndex = 4;
            // 
            // colTenTaiChinh
            // 
            this.colTenTaiChinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenTaiChinh.AppearanceHeader.Options.UseFont = true;
            this.colTenTaiChinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenTaiChinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenTaiChinh.Caption = "Tên tài chính";
            this.colTenTaiChinh.FieldName = "TenTaiXeChinh";
            this.colTenTaiChinh.Name = "colTenTaiChinh";
            this.colTenTaiChinh.Visible = true;
            this.colTenTaiChinh.VisibleIndex = 2;
            // 
            // colNgayBatDau
            // 
            this.colNgayBatDau.AppearanceCell.Options.UseTextOptions = true;
            this.colNgayBatDau.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayBatDau.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNgayBatDau.AppearanceHeader.Options.UseFont = true;
            this.colNgayBatDau.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgayBatDau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayBatDau.Caption = "Ngày bắt đầu";
            this.colNgayBatDau.FieldName = "NgayBatDau";
            this.colNgayBatDau.Name = "colNgayBatDau";
            this.colNgayBatDau.Visible = true;
            this.colNgayBatDau.VisibleIndex = 5;
            // 
            // colGioBatDau
            // 
            this.colGioBatDau.AppearanceCell.Options.UseTextOptions = true;
            this.colGioBatDau.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGioBatDau.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colGioBatDau.AppearanceHeader.Options.UseFont = true;
            this.colGioBatDau.AppearanceHeader.Options.UseTextOptions = true;
            this.colGioBatDau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGioBatDau.Caption = "Giờ bắt đầu";
            this.colGioBatDau.FieldName = "GioBatDau";
            this.colGioBatDau.Name = "colGioBatDau";
            this.colGioBatDau.Visible = true;
            this.colGioBatDau.VisibleIndex = 6;
            // 
            // colGioKetThuc
            // 
            this.colGioKetThuc.AppearanceCell.Options.UseTextOptions = true;
            this.colGioKetThuc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGioKetThuc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colGioKetThuc.AppearanceHeader.Options.UseFont = true;
            this.colGioKetThuc.AppearanceHeader.Options.UseTextOptions = true;
            this.colGioKetThuc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGioKetThuc.Caption = "Giờ kết thúc";
            this.colGioKetThuc.FieldName = "GioKetThuc";
            this.colGioKetThuc.Name = "colGioKetThuc";
            this.colGioKetThuc.Visible = true;
            this.colGioKetThuc.VisibleIndex = 8;
            // 
            // colNgayKetThuc
            // 
            this.colNgayKetThuc.AppearanceCell.Options.UseTextOptions = true;
            this.colNgayKetThuc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayKetThuc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNgayKetThuc.AppearanceHeader.Options.UseFont = true;
            this.colNgayKetThuc.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgayKetThuc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayKetThuc.Caption = "Ngày kết thúc";
            this.colNgayKetThuc.FieldName = "NgayKetThuc";
            this.colNgayKetThuc.Name = "colNgayKetThuc";
            this.colNgayKetThuc.Visible = true;
            this.colNgayKetThuc.VisibleIndex = 7;
            // 
            // colThoiGianKhamXet
            // 
            this.colThoiGianKhamXet.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colThoiGianKhamXet.AppearanceHeader.Options.UseFont = true;
            this.colThoiGianKhamXet.AppearanceHeader.Options.UseTextOptions = true;
            this.colThoiGianKhamXet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colThoiGianKhamXet.Caption = "Thời giam khám xét ( phút)";
            this.colThoiGianKhamXet.FieldName = "ThoiGianKhamXet";
            this.colThoiGianKhamXet.Name = "colThoiGianKhamXet";
            this.colThoiGianKhamXet.Visible = true;
            this.colThoiGianKhamXet.VisibleIndex = 9;
            // 
            // colGioCaBa
            // 
            this.colGioCaBa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colGioCaBa.AppearanceHeader.Options.UseFont = true;
            this.colGioCaBa.AppearanceHeader.Options.UseTextOptions = true;
            this.colGioCaBa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGioCaBa.Caption = "Giờ ca ba (phút)";
            this.colGioCaBa.FieldName = "GioCaBa";
            this.colGioCaBa.Name = "colGioCaBa";
            this.colGioCaBa.Visible = true;
            this.colGioCaBa.VisibleIndex = 10;
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaChua.Appearance.Options.UseFont = true;
            this.btnSuaChua.Location = new System.Drawing.Point(238, 155);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(85, 23);
            this.btnSuaChua.TabIndex = 27;
            this.btnSuaChua.Text = "&Sửa chữa";
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaTrang.Appearance.Options.UseFont = true;
            this.btnXoaTrang.Location = new System.Drawing.Point(337, 155);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(85, 23);
            this.btnXoaTrang.TabIndex = 28;
            this.btnXoaTrang.Text = "Xóa &trắng";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(436, 155);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "&Xóa";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(535, 155);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "&Thoát";
            // 
            // dauMayTableAdapter
            // 
            this.dauMayTableAdapter.ClearBeforeFill = true;
            // 
            // taiXeTableAdapter
            // 
            this.taiXeTableAdapter.ClearBeforeFill = true;
            // 
            // thu
            // 
            this.thu.EditValue = new System.DateTime(2012, 4, 24, 0, 0, 0, 0);
            this.thu.Location = new System.Drawing.Point(424, 14);
            this.thu.Name = "thu";
            this.thu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.thu.Size = new System.Drawing.Size(100, 20);
            this.thu.TabIndex = 12;
            // 
            // frmKhamXet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 344);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcKhamXet);
            this.Controls.Add(this.btnSuaChua);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmKhamXet";
            this.Text = "Khám xét đầu máy";
            this.Load += new System.EventHandler(this.frmKhamXet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmGioKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmGioBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTaiPhu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiXeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOBAODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTaiChinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiXeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaDauMay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dauMayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhamXet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhamXet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TimeEdit tmGioKetThuc;
        private DevExpress.XtraEditors.TimeEdit tmGioBatDau;
        private DevExpress.XtraEditors.LookUpEdit cbbTaiChinh;
        private DevExpress.XtraEditors.LookUpEdit cbbMaDauMay;
        private DevExpress.XtraEditors.DateEdit dtNgayKetThuc;
        private DevExpress.XtraEditors.LabelControl lblGioKetThuc;
        private DevExpress.XtraEditors.DateEdit dtNgayBatDau;
        private DevExpress.XtraEditors.LabelControl lblNgayKetThuc;
        private DevExpress.XtraEditors.LabelControl lblGioBatDau;
        private DevExpress.XtraEditors.LabelControl lblNgayBatDau;
        private DevExpress.XtraEditors.LabelControl lblTaiPhu;
        private DevExpress.XtraEditors.LabelControl lblMaDauMay;
        private DevExpress.XtraEditors.LabelControl lblMaTaiXe1;
        private DevExpress.XtraGrid.GridControl gcKhamXet;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhamXet;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDauMay;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTaiChinh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTaiChinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKetThuc;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValid;
        private DevExpress.XtraGrid.Columns.GridColumn colGioBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn colGioKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGianKhamXet;
        private DevExpress.XtraGrid.Columns.GridColumn colGioCaBa;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTaiPhu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTaiPhu;
        private DAL.COBAODataSet cOBAODataSet;
        private System.Windows.Forms.BindingSource dauMayBindingSource;
        private DAL.COBAODataSetTableAdapters.DauMayTableAdapter dauMayTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit cbbTaiPhu;
        private DevExpress.XtraEditors.TextEdit txtGio;
        private DevExpress.XtraEditors.TextEdit txtNgay;
        private DevExpress.XtraEditors.TextEdit txtGop;
        private System.Windows.Forms.BindingSource taiXeBindingSource;
        private DAL.COBAODataSetTableAdapters.TaiXeTableAdapter taiXeTableAdapter;
        private System.Windows.Forms.BindingSource taiXeBindingSource1;
        private DevExpress.XtraEditors.TimeEdit thu;
    }
}