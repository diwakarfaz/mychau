namespace COBAO.PL.NhapLieu
{
    partial class frmThuongTruc
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
            this.tmGioKetThuc = new DevExpress.XtraEditors.TimeEdit();
            this.tmGioBatDau = new DevExpress.XtraEditors.TimeEdit();
            this.cbbMaTram = new DevExpress.XtraEditors.LookUpEdit();
            this.dtNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.lblGioKetThuc = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbTaiPhu = new DevExpress.XtraEditors.LookUpEdit();
            this.cbbTaiChinh = new DevExpress.XtraEditors.LookUpEdit();
            this.lblNgayKetThuc = new DevExpress.XtraEditors.LabelControl();
            this.lblGioBatDau = new DevExpress.XtraEditors.LabelControl();
            this.lblNgayBatDau = new DevExpress.XtraEditors.LabelControl();
            this.lblTaiPhu = new DevExpress.XtraEditors.LabelControl();
            this.lblMaDauMay = new DevExpress.XtraEditors.LabelControl();
            this.lblMaTaiXe1 = new DevExpress.XtraEditors.LabelControl();
            this.dxValid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.colTenTaiXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTaiChinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTram = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvThuongTruc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTaiPhu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTaiPhu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioTruc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioCaBa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcThuongTruc = new DevExpress.XtraGrid.GridControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tmGioKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmGioBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaTram.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTaiPhu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTaiChinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThuongTruc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThuongTruc)).BeginInit();
            this.SuspendLayout();
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
            this.tmGioKetThuc.TabIndex = 7;
            this.tmGioKetThuc.EditValueChanged += new System.EventHandler(this.tmGioKetThuc_EditValueChanged);
            // 
            // tmGioBatDau
            // 
            this.tmGioBatDau.EditValue = new System.DateTime(2012, 3, 27, 0, 0, 0, 0);
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
            this.tmGioBatDau.TabIndex = 5;
            this.tmGioBatDau.EditValueChanged += new System.EventHandler(this.tmGioBatDau_EditValueChanged);
            // 
            // cbbMaTram
            // 
            this.cbbMaTram.Location = new System.Drawing.Point(99, 11);
            this.cbbMaTram.Name = "cbbMaTram";
            this.cbbMaTram.Properties.Appearance.Options.UseTextOptions = true;
            this.cbbMaTram.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbMaTram.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.cbbMaTram.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbbMaTram.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.cbbMaTram.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbbMaTram.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.cbbMaTram.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbMaTram.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMaTram.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTram", "Tên trạm")});
            this.cbbMaTram.Properties.DisplayMember = "TenTram";
            this.cbbMaTram.Properties.NullText = "";
            this.cbbMaTram.Properties.ValueMember = "MaTram";
            this.cbbMaTram.Size = new System.Drawing.Size(212, 20);
            this.cbbMaTram.TabIndex = 1;
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
            this.dtNgayKetThuc.TabIndex = 6;
            this.dtNgayKetThuc.EditValueChanged += new System.EventHandler(this.dtNgayKetThuc_EditValueChanged);
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
            this.dtNgayBatDau.EditValueChanged += new System.EventHandler(this.dtNgayBatDau_EditValueChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.cbbTaiPhu);
            this.panelControl1.Controls.Add(this.cbbTaiChinh);
            this.panelControl1.Controls.Add(this.tmGioKetThuc);
            this.panelControl1.Controls.Add(this.tmGioBatDau);
            this.panelControl1.Controls.Add(this.cbbMaTram);
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
            this.panelControl1.Size = new System.Drawing.Size(953, 137);
            this.panelControl1.TabIndex = 26;
            // 
            // cbbTaiPhu
            // 
            this.cbbTaiPhu.Location = new System.Drawing.Point(461, 39);
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
            this.cbbTaiPhu.Properties.DisplayMember = "MaTaiXe";
            this.cbbTaiPhu.Properties.NullText = "";
            this.cbbTaiPhu.Properties.ValueMember = "MaTaiXe";
            this.cbbTaiPhu.Size = new System.Drawing.Size(212, 20);
            this.cbbTaiPhu.TabIndex = 3;
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTaiXe", "Tên tài xế")});
            this.cbbTaiChinh.Properties.DisplayMember = "MaTaiXe";
            this.cbbTaiChinh.Properties.NullText = "";
            this.cbbTaiChinh.Properties.ValueMember = "MaTaiXe";
            this.cbbTaiChinh.Size = new System.Drawing.Size(212, 20);
            this.cbbTaiChinh.TabIndex = 2;
            this.cbbTaiChinh.TextChanged += new System.EventHandler(this.cbbTaiChinh_TextChanged);
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
            this.lblMaDauMay.Size = new System.Drawing.Size(48, 13);
            this.lblMaDauMay.TabIndex = 6;
            this.lblMaDauMay.Text = "Mã trạm";
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
            // colTenTaiXe
            // 
            this.colTenTaiXe.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenTaiXe.AppearanceHeader.Options.UseFont = true;
            this.colTenTaiXe.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenTaiXe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenTaiXe.Caption = "Tên tài chính";
            this.colTenTaiXe.FieldName = "TenTaiXeChinh";
            this.colTenTaiXe.Name = "colTenTaiXe";
            this.colTenTaiXe.Visible = true;
            this.colTenTaiXe.VisibleIndex = 2;
            this.colTenTaiXe.Width = 85;
            // 
            // colMaTaiChinh
            // 
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
            this.colMaTaiChinh.Width = 85;
            // 
            // colTenTram
            // 
            this.colTenTram.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenTram.AppearanceCell.Options.UseFont = true;
            this.colTenTram.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenTram.AppearanceHeader.Options.UseFont = true;
            this.colTenTram.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenTram.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenTram.Caption = "Trạm";
            this.colTenTram.FieldName = "TenTram";
            this.colTenTram.Name = "colTenTram";
            this.colTenTram.Visible = true;
            this.colTenTram.VisibleIndex = 0;
            this.colTenTram.Width = 76;
            // 
            // gvThuongTruc
            // 
            this.gvThuongTruc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenTram,
            this.colMaTaiChinh,
            this.colTenTaiXe,
            this.colNgayBatDau,
            this.colNgayKetThuc,
            this.colMaTaiPhu,
            this.colTenTaiPhu,
            this.colGioBatDau,
            this.colGioKetThuc,
            this.colGioTruc,
            this.colGioCaBa});
            this.gvThuongTruc.GridControl = this.gcThuongTruc;
            this.gvThuongTruc.GroupPanelText = " ";
            this.gvThuongTruc.Name = "gvThuongTruc";
            this.gvThuongTruc.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvThuongTruc.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvThuongTruc.OptionsBehavior.Editable = false;
            this.gvThuongTruc.OptionsBehavior.ReadOnly = true;
            this.gvThuongTruc.OptionsView.ShowDetailButtons = false;
            this.gvThuongTruc.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNgayBatDau, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGioBatDau, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvThuongTruc.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvThuongTruc_RowClick);
            // 
            // colNgayBatDau
            // 
            this.colNgayBatDau.AppearanceCell.Options.UseTextOptions = true;
            this.colNgayBatDau.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayBatDau.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNgayBatDau.AppearanceHeader.Options.UseFont = true;
            this.colNgayBatDau.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgayBatDau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayBatDau.Caption = "Ngày  bắt đầu";
            this.colNgayBatDau.FieldName = "NgayBatDau";
            this.colNgayBatDau.Name = "colNgayBatDau";
            this.colNgayBatDau.Visible = true;
            this.colNgayBatDau.VisibleIndex = 5;
            this.colNgayBatDau.Width = 95;
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
            this.colNgayKetThuc.Width = 99;
            // 
            // colMaTaiPhu
            // 
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
            this.colMaTaiPhu.Width = 78;
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
            this.colTenTaiPhu.Width = 85;
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
            this.colGioBatDau.Width = 83;
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
            this.colGioKetThuc.Width = 84;
            // 
            // colGioTruc
            // 
            this.colGioTruc.AppearanceCell.Options.UseTextOptions = true;
            this.colGioTruc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGioTruc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colGioTruc.AppearanceHeader.Options.UseFont = true;
            this.colGioTruc.AppearanceHeader.Options.UseTextOptions = true;
            this.colGioTruc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGioTruc.Caption = "Thời gian trực";
            this.colGioTruc.FieldName = "ThoiGianTruc";
            this.colGioTruc.Name = "colGioTruc";
            this.colGioTruc.Visible = true;
            this.colGioTruc.VisibleIndex = 9;
            this.colGioTruc.Width = 100;
            // 
            // colGioCaBa
            // 
            this.colGioCaBa.AppearanceCell.Options.UseTextOptions = true;
            this.colGioCaBa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGioCaBa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colGioCaBa.AppearanceHeader.Options.UseFont = true;
            this.colGioCaBa.AppearanceHeader.Options.UseTextOptions = true;
            this.colGioCaBa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGioCaBa.Caption = "Giờ ca ba";
            this.colGioCaBa.FieldName = "GioCaBa";
            this.colGioCaBa.Name = "colGioCaBa";
            this.colGioCaBa.Visible = true;
            this.colGioCaBa.VisibleIndex = 10;
            this.colGioCaBa.Width = 72;
            // 
            // gcThuongTruc
            // 
            this.gcThuongTruc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcThuongTruc.Location = new System.Drawing.Point(12, 184);
            this.gcThuongTruc.MainView = this.gvThuongTruc;
            this.gcThuongTruc.Name = "gcThuongTruc";
            this.gcThuongTruc.Size = new System.Drawing.Size(953, 145);
            this.gcThuongTruc.TabIndex = 13;
            this.gcThuongTruc.UseEmbeddedNavigator = true;
            this.gcThuongTruc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThuongTruc});
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(538, 155);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(439, 155);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaTrang.Appearance.Options.UseFont = true;
            this.btnXoaTrang.Location = new System.Drawing.Point(340, 155);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(85, 23);
            this.btnXoaTrang.TabIndex = 10;
            this.btnXoaTrang.Text = "Xóa &trắng";
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaChua.Appearance.Options.UseFont = true;
            this.btnSuaChua.Location = new System.Drawing.Point(241, 155);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(85, 23);
            this.btnSuaChua.TabIndex = 9;
            this.btnSuaChua.Text = "&Sửa chữa";
            this.btnSuaChua.Click += new System.EventHandler(this.btnSuaChua_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(140, 155);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 23);
            this.btnThemMoi.TabIndex = 8;
            this.btnThemMoi.Text = "&Ghi nhận";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // frmThuongTruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 362);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcThuongTruc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnSuaChua);
            this.Controls.Add(this.btnThemMoi);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmThuongTruc";
            this.Text = "Thường trực";
            this.Load += new System.EventHandler(this.frmThuongTruc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tmGioKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmGioBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaTram.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTaiPhu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTaiChinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThuongTruc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThuongTruc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TimeEdit tmGioKetThuc;
        private DevExpress.XtraEditors.TimeEdit tmGioBatDau;
        private DevExpress.XtraEditors.LookUpEdit cbbMaTram;
        private DevExpress.XtraEditors.DateEdit dtNgayKetThuc;
        private DevExpress.XtraEditors.LabelControl lblGioKetThuc;
        private DevExpress.XtraEditors.DateEdit dtNgayBatDau;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblNgayKetThuc;
        private DevExpress.XtraEditors.LabelControl lblGioBatDau;
        private DevExpress.XtraEditors.LabelControl lblNgayBatDau;
        private DevExpress.XtraEditors.LabelControl lblTaiPhu;
        private DevExpress.XtraEditors.LabelControl lblMaDauMay;
        private DevExpress.XtraEditors.LabelControl lblMaTaiXe1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValid;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTaiXe;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTaiChinh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTram;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThuongTruc;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKetThuc;
        private DevExpress.XtraGrid.GridControl gcThuongTruc;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.LookUpEdit cbbTaiPhu;
        private DevExpress.XtraEditors.LookUpEdit cbbTaiChinh;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTaiPhu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTaiPhu;
        private DevExpress.XtraGrid.Columns.GridColumn colGioBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn colGioKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn colGioTruc;
        private DevExpress.XtraGrid.Columns.GridColumn colGioCaBa;
    }
}