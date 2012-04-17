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
            this.colMaTaiXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTram = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvThuongTruc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgayGioBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGioKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.tmGioKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tmGioKetThuc.Size = new System.Drawing.Size(212, 20);
            this.tmGioKetThuc.TabIndex = 10;
            // 
            // tmGioBatDau
            // 
            this.tmGioBatDau.EditValue = new System.DateTime(2012, 3, 27, 0, 0, 0, 0);
            this.tmGioBatDau.Location = new System.Drawing.Point(461, 67);
            this.tmGioBatDau.Name = "tmGioBatDau";
            this.tmGioBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tmGioBatDau.Size = new System.Drawing.Size(212, 20);
            this.tmGioBatDau.TabIndex = 10;
            // 
            // cbbMaTram
            // 
            this.cbbMaTram.Location = new System.Drawing.Point(99, 11);
            this.cbbMaTram.Name = "cbbMaTram";
            this.cbbMaTram.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.cbbMaTram.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbbMaTram.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.cbbMaTram.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbbMaTram.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.cbbMaTram.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbMaTram.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMaTram.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenChungLoaiXe", "Chọn chủng loại xe", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbbMaTram.Properties.DisplayMember = "TenChungLoaiXe";
            this.cbbMaTram.Properties.NullText = "";
            this.cbbMaTram.Properties.ValueMember = "MaChungLoaiXe";
            this.cbbMaTram.Size = new System.Drawing.Size(212, 20);
            this.cbbMaTram.TabIndex = 9;
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.EditValue = null;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(99, 95);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
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
            this.dtNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayBatDau.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtNgayBatDau.Size = new System.Drawing.Size(212, 20);
            this.dtNgayBatDau.TabIndex = 4;
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
            this.panelControl1.Size = new System.Drawing.Size(963, 137);
            this.panelControl1.TabIndex = 26;
            // 
            // cbbTaiPhu
            // 
            this.cbbTaiPhu.Location = new System.Drawing.Point(461, 39);
            this.cbbTaiPhu.Name = "cbbTaiPhu";
            this.cbbTaiPhu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.cbbTaiPhu.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbbTaiPhu.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.cbbTaiPhu.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbbTaiPhu.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.cbbTaiPhu.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbTaiPhu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbTaiPhu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenChungLoaiXe", "Chọn chủng loại xe", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbbTaiPhu.Properties.DisplayMember = "TenChungLoaiXe";
            this.cbbTaiPhu.Properties.NullText = "";
            this.cbbTaiPhu.Properties.ValueMember = "MaChungLoaiXe";
            this.cbbTaiPhu.Size = new System.Drawing.Size(212, 20);
            this.cbbTaiPhu.TabIndex = 13;
            // 
            // cbbTaiChinh
            // 
            this.cbbTaiChinh.Location = new System.Drawing.Point(99, 39);
            this.cbbTaiChinh.Name = "cbbTaiChinh";
            this.cbbTaiChinh.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.cbbTaiChinh.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbbTaiChinh.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.cbbTaiChinh.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbbTaiChinh.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.cbbTaiChinh.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbTaiChinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbTaiChinh.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenChungLoaiXe", "Chọn chủng loại xe", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbbTaiChinh.Properties.DisplayMember = "TenChungLoaiXe";
            this.cbbTaiChinh.Properties.NullText = "";
            this.cbbTaiChinh.Properties.ValueMember = "MaChungLoaiXe";
            this.cbbTaiChinh.Size = new System.Drawing.Size(212, 20);
            this.cbbTaiChinh.TabIndex = 12;
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
            this.colTenTaiXe.Caption = "Tên tài xế";
            this.colTenTaiXe.FieldName = "TenTaiXe";
            this.colTenTaiXe.Name = "colTenTaiXe";
            this.colTenTaiXe.Visible = true;
            this.colTenTaiXe.VisibleIndex = 1;
            // 
            // colMaTaiXe
            // 
            this.colMaTaiXe.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaTaiXe.AppearanceCell.Options.UseFont = true;
            this.colMaTaiXe.AppearanceCell.Options.UseTextOptions = true;
            this.colMaTaiXe.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaTaiXe.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaTaiXe.AppearanceHeader.Options.UseFont = true;
            this.colMaTaiXe.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaTaiXe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaTaiXe.Caption = "Mã tài xế";
            this.colMaTaiXe.FieldName = "MaTaiXe";
            this.colMaTaiXe.Name = "colMaTaiXe";
            this.colMaTaiXe.Visible = true;
            this.colMaTaiXe.VisibleIndex = 0;
            // 
            // colMaTram
            // 
            this.colMaTram.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaTram.AppearanceHeader.Options.UseFont = true;
            this.colMaTram.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaTram.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaTram.Caption = "Trạm";
            this.colMaTram.FieldName = "MaTram";
            this.colMaTram.Name = "colMaTram";
            this.colMaTram.Visible = true;
            this.colMaTram.VisibleIndex = 2;
            // 
            // gvThuongTruc
            // 
            this.gvThuongTruc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTram,
            this.colMaTaiXe,
            this.colTenTaiXe,
            this.colNgayGioBatDau,
            this.colNgayGioKetThuc});
            this.gvThuongTruc.GridControl = this.gcThuongTruc;
            this.gvThuongTruc.GroupPanelText = " ";
            this.gvThuongTruc.Name = "gvThuongTruc";
            this.gvThuongTruc.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvThuongTruc.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvThuongTruc.OptionsBehavior.Editable = false;
            this.gvThuongTruc.OptionsBehavior.ReadOnly = true;
            this.gvThuongTruc.OptionsView.ShowDetailButtons = false;
            // 
            // colNgayGioBatDau
            // 
            this.colNgayGioBatDau.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNgayGioBatDau.AppearanceHeader.Options.UseFont = true;
            this.colNgayGioBatDau.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgayGioBatDau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayGioBatDau.Caption = "Ngày giờ bắt đầu";
            this.colNgayGioBatDau.FieldName = "NgayGioBatDau";
            this.colNgayGioBatDau.Name = "colNgayGioBatDau";
            this.colNgayGioBatDau.Visible = true;
            this.colNgayGioBatDau.VisibleIndex = 3;
            // 
            // colNgayGioKetThuc
            // 
            this.colNgayGioKetThuc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNgayGioKetThuc.AppearanceHeader.Options.UseFont = true;
            this.colNgayGioKetThuc.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgayGioKetThuc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayGioKetThuc.Caption = "Ngày giờ kết thúc";
            this.colNgayGioKetThuc.FieldName = "NgayGioKetThuc";
            this.colNgayGioKetThuc.Name = "colNgayGioKetThuc";
            this.colNgayGioKetThuc.Visible = true;
            this.colNgayGioKetThuc.VisibleIndex = 4;
            // 
            // gcThuongTruc
            // 
            this.gcThuongTruc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcThuongTruc.Location = new System.Drawing.Point(12, 184);
            this.gcThuongTruc.MainView = this.gvThuongTruc;
            this.gcThuongTruc.Name = "gcThuongTruc";
            this.gcThuongTruc.Size = new System.Drawing.Size(963, 145);
            this.gcThuongTruc.TabIndex = 25;
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
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "&Thoát";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(439, 155);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "&Xóa";
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaTrang.Appearance.Options.UseFont = true;
            this.btnXoaTrang.Location = new System.Drawing.Point(340, 155);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(85, 23);
            this.btnXoaTrang.TabIndex = 22;
            this.btnXoaTrang.Text = "Xóa &trắng";
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaChua.Appearance.Options.UseFont = true;
            this.btnSuaChua.Location = new System.Drawing.Point(241, 155);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(85, 23);
            this.btnSuaChua.TabIndex = 21;
            this.btnSuaChua.Text = "&Sửa chữa";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(140, 155);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 23);
            this.btnThemMoi.TabIndex = 20;
            this.btnThemMoi.Text = "&Ghi nhận";
            // 
            // frmThuongTruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 362);
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
        private DevExpress.XtraGrid.Columns.GridColumn colMaTaiXe;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTram;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThuongTruc;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGioBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGioKetThuc;
        private DevExpress.XtraGrid.GridControl gcThuongTruc;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.LookUpEdit cbbTaiPhu;
        private DevExpress.XtraEditors.LookUpEdit cbbTaiChinh;
    }
}