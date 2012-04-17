namespace COBAO.PL.DanhMuc
{
    partial class frmTaiXe
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
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenTaiXe = new DevExpress.XtraEditors.TextEdit();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.txtDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.txtHeSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTaiXe = new DevExpress.XtraEditors.TextEdit();
            this.lblHeSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.gcTaiXe = new DevExpress.XtraGrid.GridControl();
            this.gvTaiXe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTaiXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTaiXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lTo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lblTài = new DevExpress.XtraEditors.LabelControl();
            this.lblDienThoai = new DevExpress.XtraEditors.LabelControl();
            this.lblDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.lblMaTo = new DevExpress.XtraEditors.LabelControl();
            this.lblTenTaiXe = new DevExpress.XtraEditors.LabelControl();
            this.lblMaTaiXe = new DevExpress.XtraEditors.LabelControl();
            this.dxValid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.cbbMaTo = new DevExpress.XtraEditors.LookUpEdit();
            this.cbbTai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cOBAODataSet = new COBAO.DAL.COBAODataSet();
            this.toBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toTableAdapter = new COBAO.DAL.COBAODataSetTableAdapters.ToTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiXe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTaiXe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaiXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOBAODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(533, 149);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTenTaiXe
            // 
            this.txtTenTaiXe.Location = new System.Drawing.Point(442, 42);
            this.txtTenTaiXe.Name = "txtTenTaiXe";
            this.txtTenTaiXe.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTenTaiXe.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenTaiXe.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTenTaiXe.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtTenTaiXe.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtTenTaiXe.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenTaiXe.Size = new System.Drawing.Size(245, 20);
            this.txtTenTaiXe.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(434, 149);
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
            this.btnXoaTrang.Location = new System.Drawing.Point(335, 149);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(85, 23);
            this.btnXoaTrang.TabIndex = 10;
            this.btnXoaTrang.Text = "Xóa &trắng";
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(84, 70);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDienThoai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtDienThoai.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtDienThoai.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtDienThoai.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtDienThoai.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtDienThoai.Properties.Mask.EditMask = "\\d{1,11}";
            this.txtDienThoai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtDienThoai.Size = new System.Drawing.Size(184, 20);
            this.txtDienThoai.TabIndex = 4;
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaChua.Appearance.Options.UseFont = true;
            this.btnSuaChua.Location = new System.Drawing.Point(236, 149);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(85, 23);
            this.btnSuaChua.TabIndex = 9;
            this.btnSuaChua.Text = "&Sửa chữa";
            this.btnSuaChua.Click += new System.EventHandler(this.btnSuaChua_Click);
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Location = new System.Drawing.Point(442, 98);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Properties.Appearance.Options.UseTextOptions = true;
            this.txtHeSoLuong.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtHeSoLuong.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtHeSoLuong.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtHeSoLuong.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtHeSoLuong.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtHeSoLuong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtHeSoLuong.Size = new System.Drawing.Size(245, 20);
            this.txtHeSoLuong.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(442, 70);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDiaChi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtDiaChi.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtDiaChi.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtDiaChi.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtDiaChi.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtDiaChi.Size = new System.Drawing.Size(245, 20);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtMaTaiXe
            // 
            this.txtMaTaiXe.Location = new System.Drawing.Point(84, 42);
            this.txtMaTaiXe.Name = "txtMaTaiXe";
            this.txtMaTaiXe.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaTaiXe.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaTaiXe.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtMaTaiXe.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtMaTaiXe.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtMaTaiXe.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaTaiXe.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaTaiXe.Properties.MaxLength = 5;
            this.txtMaTaiXe.Size = new System.Drawing.Size(184, 20);
            this.txtMaTaiXe.TabIndex = 2;
            // 
            // lblHeSoLuong
            // 
            this.lblHeSoLuong.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblHeSoLuong.Location = new System.Drawing.Point(352, 102);
            this.lblHeSoLuong.Name = "lblHeSoLuong";
            this.lblHeSoLuong.Size = new System.Drawing.Size(66, 13);
            this.lblHeSoLuong.TabIndex = 8;
            this.lblHeSoLuong.Text = "Hệ số lương";
            // 
            // gcTaiXe
            // 
            this.gcTaiXe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTaiXe.Location = new System.Drawing.Point(12, 178);
            this.gcTaiXe.MainView = this.gvTaiXe;
            this.gcTaiXe.Name = "gcTaiXe";
            this.gcTaiXe.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lTo});
            this.gcTaiXe.Size = new System.Drawing.Size(963, 145);
            this.gcTaiXe.TabIndex = 13;
            this.gcTaiXe.UseEmbeddedNavigator = true;
            this.gcTaiXe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTaiXe});
            // 
            // gvTaiXe
            // 
            this.gvTaiXe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTaiXe,
            this.colTenTaiXe,
            this.colDiaChi,
            this.colDienThoai,
            this.colTai,
            this.colHeSoLuong,
            this.colMaTo});
            this.gvTaiXe.GridControl = this.gcTaiXe;
            this.gvTaiXe.GroupPanelText = " ";
            this.gvTaiXe.Name = "gvTaiXe";
            this.gvTaiXe.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTaiXe.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTaiXe.OptionsBehavior.Editable = false;
            this.gvTaiXe.OptionsBehavior.ReadOnly = true;
            this.gvTaiXe.OptionsView.ShowDetailButtons = false;
            this.gvTaiXe.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvTaiXe_RowClick);
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
            // colDiaChi
            // 
            this.colDiaChi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDiaChi.AppearanceHeader.Options.UseFont = true;
            this.colDiaChi.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiaChi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiaChi.Caption = "Địa chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 2;
            // 
            // colDienThoai
            // 
            this.colDienThoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDienThoai.AppearanceHeader.Options.UseFont = true;
            this.colDienThoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colDienThoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDienThoai.Caption = "Điện thoại";
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 3;
            // 
            // colTai
            // 
            this.colTai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTai.AppearanceHeader.Options.UseFont = true;
            this.colTai.AppearanceHeader.Options.UseTextOptions = true;
            this.colTai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTai.Caption = "Tài (T/P)";
            this.colTai.FieldName = "Tai";
            this.colTai.Name = "colTai";
            this.colTai.Visible = true;
            this.colTai.VisibleIndex = 4;
            // 
            // colHeSoLuong
            // 
            this.colHeSoLuong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colHeSoLuong.AppearanceHeader.Options.UseFont = true;
            this.colHeSoLuong.AppearanceHeader.Options.UseTextOptions = true;
            this.colHeSoLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHeSoLuong.Caption = "Hệ số lương";
            this.colHeSoLuong.FieldName = "HeSoLuong";
            this.colHeSoLuong.Name = "colHeSoLuong";
            this.colHeSoLuong.Visible = true;
            this.colHeSoLuong.VisibleIndex = 5;
            // 
            // colMaTo
            // 
            this.colMaTo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaTo.AppearanceHeader.Options.UseFont = true;
            this.colMaTo.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaTo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaTo.Caption = "Tổ";
            this.colMaTo.ColumnEdit = this.lTo;
            this.colMaTo.FieldName = "MaTo";
            this.colMaTo.Name = "colMaTo";
            this.colMaTo.Visible = true;
            this.colMaTo.VisibleIndex = 6;
            // 
            // lTo
            // 
            this.lTo.AutoHeight = false;
            this.lTo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lTo.DataSource = this.toBindingSource;
            this.lTo.DisplayMember = "TenTo";
            this.lTo.Name = "lTo";
            this.lTo.ValidateOnEnterKey = true;
            this.lTo.ValueMember = "MaTo";
            // 
            // lblTài
            // 
            this.lblTài.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTài.Location = new System.Drawing.Point(16, 102);
            this.lblTài.Name = "lblTài";
            this.lblTài.Size = new System.Drawing.Size(17, 13);
            this.lblTài.TabIndex = 8;
            this.lblTài.Text = "Tài";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDienThoai.Location = new System.Drawing.Point(16, 74);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(58, 13);
            this.lblDienThoai.TabIndex = 8;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDiaChi.Location = new System.Drawing.Point(352, 74);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(38, 13);
            this.lblDiaChi.TabIndex = 8;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblMaTo
            // 
            this.lblMaTo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMaTo.Location = new System.Drawing.Point(16, 18);
            this.lblMaTo.Name = "lblMaTo";
            this.lblMaTo.Size = new System.Drawing.Size(14, 13);
            this.lblMaTo.TabIndex = 7;
            this.lblMaTo.Text = "Tổ";
            // 
            // lblTenTaiXe
            // 
            this.lblTenTaiXe.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTenTaiXe.Location = new System.Drawing.Point(352, 46);
            this.lblTenTaiXe.Name = "lblTenTaiXe";
            this.lblTenTaiXe.Size = new System.Drawing.Size(56, 13);
            this.lblTenTaiXe.TabIndex = 6;
            this.lblTenTaiXe.Text = "Tên tài xế";
            // 
            // lblMaTaiXe
            // 
            this.lblMaTaiXe.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMaTaiXe.Location = new System.Drawing.Point(16, 46);
            this.lblMaTaiXe.Name = "lblMaTaiXe";
            this.lblMaTaiXe.Size = new System.Drawing.Size(52, 13);
            this.lblMaTaiXe.TabIndex = 6;
            this.lblMaTaiXe.Text = "Mã tài xế";
            // 
            // cbbMaTo
            // 
            this.dxValid.SetIconAlignment(this.cbbMaTo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.cbbMaTo.Location = new System.Drawing.Point(84, 14);
            this.cbbMaTo.Name = "cbbMaTo";
            this.cbbMaTo.Properties.Appearance.Options.UseTextOptions = true;
            this.cbbMaTo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbMaTo.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbbMaTo.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbbMaTo.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.cbbMaTo.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbMaTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMaTo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTo", "Tổ tài xế")});
            this.cbbMaTo.Properties.DisplayMember = "TenTo";
            this.cbbMaTo.Properties.NullText = "";
            this.cbbMaTo.Properties.PopupSizeable = false;
            this.cbbMaTo.Properties.ValueMember = "MaTo";
            this.cbbMaTo.Size = new System.Drawing.Size(184, 20);
            this.cbbMaTo.TabIndex = 1;
            // 
            // cbbTai
            // 
            this.cbbTai.Location = new System.Drawing.Point(84, 98);
            this.cbbTai.Name = "cbbTai";
            this.cbbTai.Properties.Appearance.Options.UseTextOptions = true;
            this.cbbTai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbTai.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbbTai.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbbTai.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.cbbTai.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbTai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbTai.Properties.Items.AddRange(new object[] {
            "Tài",
            "Phụ tài"});
            this.cbbTai.Size = new System.Drawing.Size(184, 20);
            this.cbbTai.TabIndex = 6;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(135, 149);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 23);
            this.btnThemMoi.TabIndex = 8;
            this.btnThemMoi.Text = "&Ghi nhận";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.cbbMaTo);
            this.panelControl1.Controls.Add(this.cbbTai);
            this.panelControl1.Controls.Add(this.txtTenTaiXe);
            this.panelControl1.Controls.Add(this.txtHeSoLuong);
            this.panelControl1.Controls.Add(this.txtDienThoai);
            this.panelControl1.Controls.Add(this.txtDiaChi);
            this.panelControl1.Controls.Add(this.txtMaTaiXe);
            this.panelControl1.Controls.Add(this.lblHeSoLuong);
            this.panelControl1.Controls.Add(this.lblTài);
            this.panelControl1.Controls.Add(this.lblDienThoai);
            this.panelControl1.Controls.Add(this.lblDiaChi);
            this.panelControl1.Controls.Add(this.lblMaTo);
            this.panelControl1.Controls.Add(this.lblTenTaiXe);
            this.panelControl1.Controls.Add(this.lblMaTaiXe);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(963, 131);
            this.panelControl1.TabIndex = 32;
            // 
            // cOBAODataSet
            // 
            this.cOBAODataSet.DataSetName = "COBAODataSet";
            this.cOBAODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toBindingSource
            // 
            this.toBindingSource.DataMember = "To";
            this.toBindingSource.DataSource = this.cOBAODataSet;
            // 
            // toTableAdapter
            // 
            this.toTableAdapter.ClearBeforeFill = true;
            // 
            // frmTaiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 362);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnSuaChua);
            this.Controls.Add(this.gcTaiXe);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.panelControl1);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmTaiXe";
            this.Text = "Danh mục tài xế";
            this.Load += new System.EventHandler(this.frmTaiXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiXe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTaiXe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaiXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOBAODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.TextEdit txtTenTaiXe;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.TextEdit txtDienThoai;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.TextEdit txtHeSoLuong;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtMaTaiXe;
        private DevExpress.XtraEditors.LabelControl lblHeSoLuong;
        private DevExpress.XtraGrid.GridControl gcTaiXe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTaiXe;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTaiXe;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTaiXe;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colTai;
        private DevExpress.XtraGrid.Columns.GridColumn colHeSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTo;
        private DevExpress.XtraEditors.LabelControl lblTài;
        private DevExpress.XtraEditors.LabelControl lblDienThoai;
        private DevExpress.XtraEditors.LabelControl lblDiaChi;
        private DevExpress.XtraEditors.LabelControl lblMaTo;
        private DevExpress.XtraEditors.LabelControl lblTenTaiXe;
        private DevExpress.XtraEditors.LabelControl lblMaTaiXe;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValid;
        private DevExpress.XtraEditors.ComboBoxEdit cbbTai;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit cbbMaTo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lTo;
        private DAL.COBAODataSet cOBAODataSet;
        private System.Windows.Forms.BindingSource toBindingSource;
        private DAL.COBAODataSetTableAdapters.ToTableAdapter toTableAdapter;
    }
}