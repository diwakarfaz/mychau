namespace COBAO.PL.DanhMuc
{
    partial class frmMacTau
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
            this.colMaCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lCongTy = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbMaLuongXL = new DevExpress.XtraEditors.LookUpEdit();
            this.cbbMaCT = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTenMacTau = new DevExpress.XtraEditors.TextEdit();
            this.lblMaLuongXL = new DevExpress.XtraEditors.LabelControl();
            this.txtMaMacTau = new DevExpress.XtraEditors.TextEdit();
            this.lblMaCongTy = new DevExpress.XtraEditors.LabelControl();
            this.lblTenMacTau = new DevExpress.XtraEditors.LabelControl();
            this.lblMaMacTau = new DevExpress.XtraEditors.LabelControl();
            this.colTenMacTau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLuongXL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lDonGiaXL = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.colMaMacTau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.gvMacTau = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMacTau = new DevExpress.XtraGrid.GridControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.dxValid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lCongTy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaLuongXL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMacTau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMacTau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDonGiaXL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMacTau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMacTau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
            this.SuspendLayout();
            // 
            // colMaCT
            // 
            this.colMaCT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaCT.AppearanceHeader.Options.UseFont = true;
            this.colMaCT.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaCT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaCT.Caption = "Công ty";
            this.colMaCT.ColumnEdit = this.lCongTy;
            this.colMaCT.FieldName = "MaCT";
            this.colMaCT.Name = "colMaCT";
            this.colMaCT.Visible = true;
            this.colMaCT.VisibleIndex = 2;
            // 
            // lCongTy
            // 
            this.lCongTy.AutoHeight = false;
            this.lCongTy.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lCongTy.DisplayMember = "TenCT";
            this.lCongTy.Name = "lCongTy";
            this.lCongTy.ValueMember = "MaCT";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.cbbMaLuongXL);
            this.panelControl1.Controls.Add(this.cbbMaCT);
            this.panelControl1.Controls.Add(this.txtTenMacTau);
            this.panelControl1.Controls.Add(this.lblMaLuongXL);
            this.panelControl1.Controls.Add(this.txtMaMacTau);
            this.panelControl1.Controls.Add(this.lblMaCongTy);
            this.panelControl1.Controls.Add(this.lblTenMacTau);
            this.panelControl1.Controls.Add(this.lblMaMacTau);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(963, 81);
            this.panelControl1.TabIndex = 43;
            // 
            // cbbMaLuongXL
            // 
            this.cbbMaLuongXL.Location = new System.Drawing.Point(460, 38);
            this.cbbMaLuongXL.Name = "cbbMaLuongXL";
            this.cbbMaLuongXL.Properties.Appearance.Options.UseTextOptions = true;
            this.cbbMaLuongXL.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbMaLuongXL.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbbMaLuongXL.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbbMaLuongXL.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.cbbMaLuongXL.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbMaLuongXL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMaLuongXL.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MoTa", "Hạng giá")});
            this.cbbMaLuongXL.Properties.DisplayMember = "MoTa";
            this.cbbMaLuongXL.Properties.NullText = "";
            this.cbbMaLuongXL.Properties.PopupSizeable = false;
            this.cbbMaLuongXL.Properties.ValueMember = "MaLuongXL";
            this.cbbMaLuongXL.Size = new System.Drawing.Size(206, 20);
            this.cbbMaLuongXL.TabIndex = 4;
            // 
            // cbbMaCT
            // 
            this.dxValid.SetIconAlignment(this.cbbMaCT, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.cbbMaCT.Location = new System.Drawing.Point(99, 38);
            this.cbbMaCT.Name = "cbbMaCT";
            this.cbbMaCT.Properties.Appearance.Options.UseTextOptions = true;
            this.cbbMaCT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbMaCT.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbbMaCT.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbbMaCT.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.cbbMaCT.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbMaCT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMaCT.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenCT", "Tên công ty")});
            this.cbbMaCT.Properties.DisplayMember = "TenCT";
            this.cbbMaCT.Properties.NullText = "";
            this.cbbMaCT.Properties.PopupSizeable = false;
            this.cbbMaCT.Properties.ValueMember = "MaCT";
            this.cbbMaCT.Size = new System.Drawing.Size(206, 20);
            this.cbbMaCT.TabIndex = 3;
            // 
            // txtTenMacTau
            // 
            this.txtTenMacTau.Location = new System.Drawing.Point(460, 12);
            this.txtTenMacTau.Name = "txtTenMacTau";
            this.txtTenMacTau.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTenMacTau.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenMacTau.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTenMacTau.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtTenMacTau.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtTenMacTau.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenMacTau.Size = new System.Drawing.Size(206, 20);
            this.txtTenMacTau.TabIndex = 2;
            // 
            // lblMaLuongXL
            // 
            this.lblMaLuongXL.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMaLuongXL.Location = new System.Drawing.Point(340, 41);
            this.lblMaLuongXL.Name = "lblMaLuongXL";
            this.lblMaLuongXL.Size = new System.Drawing.Size(101, 13);
            this.lblMaLuongXL.TabIndex = 8;
            this.lblMaLuongXL.Text = "Thuộc loại đơn giá";
            // 
            // txtMaMacTau
            // 
            this.txtMaMacTau.Location = new System.Drawing.Point(99, 12);
            this.txtMaMacTau.Name = "txtMaMacTau";
            this.txtMaMacTau.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaMacTau.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaMacTau.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtMaMacTau.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtMaMacTau.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtMaMacTau.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaMacTau.Properties.MaxLength = 5;
            this.txtMaMacTau.Size = new System.Drawing.Size(206, 20);
            this.txtMaMacTau.TabIndex = 1;
            // 
            // lblMaCongTy
            // 
            this.lblMaCongTy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMaCongTy.Location = new System.Drawing.Point(18, 41);
            this.lblMaCongTy.Name = "lblMaCongTy";
            this.lblMaCongTy.Size = new System.Drawing.Size(43, 13);
            this.lblMaCongTy.TabIndex = 8;
            this.lblMaCongTy.Text = "Công ty";
            // 
            // lblTenMacTau
            // 
            this.lblTenMacTau.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTenMacTau.Location = new System.Drawing.Point(340, 15);
            this.lblTenMacTau.Name = "lblTenMacTau";
            this.lblTenMacTau.Size = new System.Drawing.Size(70, 13);
            this.lblTenMacTau.TabIndex = 7;
            this.lblTenMacTau.Text = "Tên mác tàu";
            // 
            // lblMaMacTau
            // 
            this.lblMaMacTau.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMaMacTau.Location = new System.Drawing.Point(18, 16);
            this.lblMaMacTau.Name = "lblMaMacTau";
            this.lblMaMacTau.Size = new System.Drawing.Size(66, 13);
            this.lblMaMacTau.TabIndex = 6;
            this.lblMaMacTau.Text = "Mã mác tàu";
            // 
            // colTenMacTau
            // 
            this.colTenMacTau.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenMacTau.AppearanceHeader.Options.UseFont = true;
            this.colTenMacTau.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenMacTau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenMacTau.Caption = "Tên mác tàu";
            this.colTenMacTau.FieldName = "TenMacTau";
            this.colTenMacTau.Name = "colTenMacTau";
            this.colTenMacTau.Visible = true;
            this.colTenMacTau.VisibleIndex = 1;
            // 
            // colMaLuongXL
            // 
            this.colMaLuongXL.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaLuongXL.AppearanceHeader.Options.UseFont = true;
            this.colMaLuongXL.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaLuongXL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaLuongXL.Caption = "Thuộc loại lương";
            this.colMaLuongXL.ColumnEdit = this.lDonGiaXL;
            this.colMaLuongXL.FieldName = "MaLuongXL";
            this.colMaLuongXL.Name = "colMaLuongXL";
            this.colMaLuongXL.Visible = true;
            this.colMaLuongXL.VisibleIndex = 3;
            // 
            // lDonGiaXL
            // 
            this.lDonGiaXL.AutoHeight = false;
            this.lDonGiaXL.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lDonGiaXL.DisplayMember = "MoTa";
            this.lDonGiaXL.Name = "lDonGiaXL";
            this.lDonGiaXL.ValueMember = "MaLuongXL";
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaChua.Appearance.Options.UseFont = true;
            this.btnSuaChua.Location = new System.Drawing.Point(253, 99);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(85, 23);
            this.btnSuaChua.TabIndex = 6;
            this.btnSuaChua.Text = "&Sửa chữa";
            this.btnSuaChua.Click += new System.EventHandler(this.btnSuaChua_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(152, 99);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 23);
            this.btnThemMoi.TabIndex = 5;
            this.btnThemMoi.Text = "&Ghi nhận";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // colMaMacTau
            // 
            this.colMaMacTau.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaMacTau.AppearanceCell.Options.UseFont = true;
            this.colMaMacTau.AppearanceCell.Options.UseTextOptions = true;
            this.colMaMacTau.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaMacTau.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaMacTau.AppearanceHeader.Options.UseFont = true;
            this.colMaMacTau.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaMacTau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaMacTau.Caption = "Mã mác tàu";
            this.colMaMacTau.FieldName = "MaMacTau";
            this.colMaMacTau.Name = "colMaMacTau";
            this.colMaMacTau.Visible = true;
            this.colMaMacTau.VisibleIndex = 0;
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaTrang.Appearance.Options.UseFont = true;
            this.btnXoaTrang.Location = new System.Drawing.Point(352, 99);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(85, 23);
            this.btnXoaTrang.TabIndex = 7;
            this.btnXoaTrang.Text = "Xóa &trắng";
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // gvMacTau
            // 
            this.gvMacTau.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaMacTau,
            this.colTenMacTau,
            this.colMaCT,
            this.colMaLuongXL});
            this.gvMacTau.GridControl = this.gcMacTau;
            this.gvMacTau.GroupPanelText = " ";
            this.gvMacTau.Name = "gvMacTau";
            this.gvMacTau.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvMacTau.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvMacTau.OptionsBehavior.Editable = false;
            this.gvMacTau.OptionsBehavior.ReadOnly = true;
            this.gvMacTau.OptionsView.ShowDetailButtons = false;
            this.gvMacTau.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvMacTau_RowClick);
            // 
            // gcMacTau
            // 
            this.gcMacTau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcMacTau.Location = new System.Drawing.Point(12, 128);
            this.gcMacTau.LookAndFeel.SkinName = "Blue";
            this.gcMacTau.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gcMacTau.MainView = this.gvMacTau;
            this.gcMacTau.Name = "gcMacTau";
            this.gcMacTau.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lCongTy,
            this.lDonGiaXL});
            this.gcMacTau.Size = new System.Drawing.Size(963, 200);
            this.gcMacTau.TabIndex = 10;
            this.gcMacTau.UseEmbeddedNavigator = true;
            this.gcMacTau.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMacTau});
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(550, 99);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(451, 99);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmMacTau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 362);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnSuaChua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gcMacTau);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmMacTau";
            this.Text = "Mác tàu";
            this.Load += new System.EventHandler(this.frmMacTau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lCongTy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaLuongXL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMacTau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMacTau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDonGiaXL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMacTau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMacTau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colMaCT;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenMacTau;
        private DevExpress.XtraEditors.LabelControl lblMaLuongXL;
        private DevExpress.XtraEditors.TextEdit txtMaMacTau;
        private DevExpress.XtraEditors.LabelControl lblMaCongTy;
        private DevExpress.XtraEditors.LabelControl lblTenMacTau;
        private DevExpress.XtraEditors.LabelControl lblMaMacTau;
        private DevExpress.XtraGrid.Columns.GridColumn colTenMacTau;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLuongXL;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMacTau;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMacTau;
        private DevExpress.XtraGrid.GridControl gcMacTau;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValid;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.LookUpEdit cbbMaLuongXL;
        private DevExpress.XtraEditors.LookUpEdit cbbMaCT;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lCongTy;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lDonGiaXL;
    }
}