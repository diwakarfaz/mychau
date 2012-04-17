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
            this.tmGioKetThuc = new DevExpress.XtraEditors.TimeEdit();
            this.tmGioBatDau = new DevExpress.XtraEditors.TimeEdit();
            this.cbbMaDauMay = new DevExpress.XtraEditors.LookUpEdit();
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
            this.colMaTaiXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTaiXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGioBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGioKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.cbbTaiChinh = new DevExpress.XtraEditors.LookUpEdit();
            this.cbbTaiPhu = new DevExpress.XtraEditors.LookUpEdit();
            this.dxValid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmGioKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmGioBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaDauMay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhamXet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhamXet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTaiChinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTaiPhu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
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
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
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
            // cbbMaDauMay
            // 
            this.cbbMaDauMay.Location = new System.Drawing.Point(99, 11);
            this.cbbMaDauMay.Name = "cbbMaDauMay";
            this.cbbMaDauMay.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.cbbMaDauMay.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbbMaDauMay.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.cbbMaDauMay.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbbMaDauMay.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.cbbMaDauMay.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbMaDauMay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMaDauMay.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenChungLoaiXe", "Chọn chủng loại xe", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbbMaDauMay.Properties.DisplayMember = "TenChungLoaiXe";
            this.cbbMaDauMay.Properties.NullText = "";
            this.cbbMaDauMay.Properties.ValueMember = "MaChungLoaiXe";
            this.cbbMaDauMay.Size = new System.Drawing.Size(212, 20);
            this.cbbMaDauMay.TabIndex = 9;
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
            this.colMaTaiXe,
            this.colTenTaiXe,
            this.colNgayGioBatDau,
            this.colNgayGioKetThuc});
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
            this.colMaDauMay.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaDauMay.AppearanceHeader.Options.UseFont = true;
            this.colMaDauMay.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaDauMay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaDauMay.Caption = "Mã đầu máy";
            this.colMaDauMay.FieldName = "MaDauMay";
            this.colMaDauMay.Name = "colMaDauMay";
            this.colMaDauMay.Visible = true;
            this.colMaDauMay.VisibleIndex = 2;
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
            this.cbbTaiChinh.TabIndex = 9;
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
            this.cbbTaiPhu.TabIndex = 9;
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
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmGioKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmGioBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaDauMay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhamXet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhamXet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTaiChinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTaiPhu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TimeEdit tmGioKetThuc;
        private DevExpress.XtraEditors.TimeEdit tmGioBatDau;
        private DevExpress.XtraEditors.LookUpEdit cbbTaiPhu;
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
        private DevExpress.XtraGrid.Columns.GridColumn colMaTaiXe;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTaiXe;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGioBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGioKetThuc;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValid;
    }
}