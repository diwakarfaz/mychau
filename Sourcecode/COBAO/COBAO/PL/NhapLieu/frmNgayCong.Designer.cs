namespace COBAO.PL.NhapLieu
{
    partial class frmNgayCong
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSoNgay = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTaiXe = new DevExpress.XtraEditors.TextEdit();
            this.cbbTrangThai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.lblSoNgay = new DevExpress.XtraEditors.LabelControl();
            this.lblNgayBatDau = new DevExpress.XtraEditors.LabelControl();
            this.lblTrangThai = new DevExpress.XtraEditors.LabelControl();
            this.lblMaTaiXe = new DevExpress.XtraEditors.LabelControl();
            this.gvNgayCong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTaiXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTaiXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNgayCong = new DevExpress.XtraGrid.GridControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.leChungLoai = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.dxValid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.cbbMaTaiXe = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiXe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNgayCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNgayCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leChungLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaTaiXe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.cbbMaTaiXe);
            this.panelControl1.Controls.Add(this.txtSoNgay);
            this.panelControl1.Controls.Add(this.txtTenTaiXe);
            this.panelControl1.Controls.Add(this.cbbTrangThai);
            this.panelControl1.Controls.Add(this.dtNgayBatDau);
            this.panelControl1.Controls.Add(this.lblSoNgay);
            this.panelControl1.Controls.Add(this.lblNgayBatDau);
            this.panelControl1.Controls.Add(this.lblTrangThai);
            this.panelControl1.Controls.Add(this.lblMaTaiXe);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(963, 77);
            this.panelControl1.TabIndex = 15;
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Location = new System.Drawing.Point(537, 38);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(142, 20);
            this.txtSoNgay.TabIndex = 5;
            // 
            // txtTenTaiXe
            // 
            this.txtTenTaiXe.Location = new System.Drawing.Point(242, 11);
            this.txtTenTaiXe.Name = "txtTenTaiXe";
            this.txtTenTaiXe.Size = new System.Drawing.Size(142, 20);
            this.txtTenTaiXe.TabIndex = 2;
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.Location = new System.Drawing.Point(537, 10);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbTrangThai.Size = new System.Drawing.Size(142, 20);
            this.cbbTrangThai.TabIndex = 3;
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.EditValue = null;
            this.dtNgayBatDau.Location = new System.Drawing.Point(92, 38);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayBatDau.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtNgayBatDau.Size = new System.Drawing.Size(144, 20);
            this.dtNgayBatDau.TabIndex = 4;
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSoNgay.Location = new System.Drawing.Point(469, 42);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(45, 13);
            this.lblSoNgay.TabIndex = 8;
            this.lblSoNgay.Text = "Số ngày";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNgayBatDau.Location = new System.Drawing.Point(5, 42);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(74, 13);
            this.lblNgayBatDau.TabIndex = 8;
            this.lblNgayBatDau.Text = "Ngày bắt đầu";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.Location = new System.Drawing.Point(469, 13);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(58, 13);
            this.lblTrangThai.TabIndex = 7;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // lblMaTaiXe
            // 
            this.lblMaTaiXe.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMaTaiXe.Location = new System.Drawing.Point(5, 14);
            this.lblMaTaiXe.Name = "lblMaTaiXe";
            this.lblMaTaiXe.Size = new System.Drawing.Size(52, 13);
            this.lblMaTaiXe.TabIndex = 6;
            this.lblMaTaiXe.Text = "Mã tài xế";
            // 
            // gvNgayCong
            // 
            this.gvNgayCong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTaiXe,
            this.colTenTaiXe,
            this.colTrangThai,
            this.colNgayBatDau,
            this.colSoNgay});
            this.gvNgayCong.GridControl = this.gcNgayCong;
            this.gvNgayCong.GroupPanelText = " ";
            this.gvNgayCong.Name = "gvNgayCong";
            this.gvNgayCong.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvNgayCong.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvNgayCong.OptionsBehavior.Editable = false;
            this.gvNgayCong.OptionsBehavior.ReadOnly = true;
            this.gvNgayCong.OptionsView.ShowDetailButtons = false;
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
            // colTrangThai
            // 
            this.colTrangThai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTrangThai.AppearanceHeader.Options.UseFont = true;
            this.colTrangThai.AppearanceHeader.Options.UseTextOptions = true;
            this.colTrangThai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTrangThai.Caption = "Trạng thái";
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 2;
            // 
            // colNgayBatDau
            // 
            this.colNgayBatDau.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNgayBatDau.AppearanceHeader.Options.UseFont = true;
            this.colNgayBatDau.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgayBatDau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayBatDau.Caption = "Ngày bắt đầu";
            this.colNgayBatDau.FieldName = "NgayBatDau";
            this.colNgayBatDau.Name = "colNgayBatDau";
            this.colNgayBatDau.Visible = true;
            this.colNgayBatDau.VisibleIndex = 3;
            // 
            // colSoNgay
            // 
            this.colSoNgay.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSoNgay.AppearanceHeader.Options.UseFont = true;
            this.colSoNgay.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoNgay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoNgay.Caption = "Số ngày";
            this.colSoNgay.FieldName = "SoNgay";
            this.colSoNgay.Name = "colSoNgay";
            this.colSoNgay.Visible = true;
            this.colSoNgay.VisibleIndex = 4;
            // 
            // gcNgayCong
            // 
            this.gcNgayCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcNgayCong.Location = new System.Drawing.Point(12, 125);
            this.gcNgayCong.MainView = this.gvNgayCong;
            this.gcNgayCong.Name = "gcNgayCong";
            this.gcNgayCong.Size = new System.Drawing.Size(963, 200);
            this.gcNgayCong.TabIndex = 18;
            this.gcNgayCong.UseEmbeddedNavigator = true;
            this.gcNgayCong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNgayCong});
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(606, 96);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "&Thoát";
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaTrang.Appearance.Options.UseFont = true;
            this.btnXoaTrang.Location = new System.Drawing.Point(356, 96);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(85, 23);
            this.btnXoaTrang.TabIndex = 14;
            this.btnXoaTrang.Text = "Xóa &trắng";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(481, 96);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "&Xóa";
            // 
            // leChungLoai
            // 
            this.leChungLoai.AutoHeight = false;
            this.leChungLoai.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leChungLoai.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenChungLoaiXe", "", 99, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.leChungLoai.DisplayMember = "TenChungLoaiXe";
            this.leChungLoai.Name = "leChungLoai";
            this.leChungLoai.ValueMember = "MaChungLoaiXe";
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaChua.Appearance.Options.UseFont = true;
            this.btnSuaChua.Location = new System.Drawing.Point(231, 96);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(85, 23);
            this.btnSuaChua.TabIndex = 13;
            this.btnSuaChua.Text = "&Sửa chữa";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(106, 96);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 23);
            this.btnThemMoi.TabIndex = 12;
            this.btnThemMoi.Text = "&Ghi nhận";
            // 
            // cbbMaTaiXe
            // 
            this.cbbMaTaiXe.Location = new System.Drawing.Point(92, 12);
            this.cbbMaTaiXe.Name = "cbbMaTaiXe";
            this.cbbMaTaiXe.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.cbbMaTaiXe.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbbMaTaiXe.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.cbbMaTaiXe.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbbMaTaiXe.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.cbbMaTaiXe.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbMaTaiXe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMaTaiXe.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenChungLoaiXe", "Chọn chủng loại xe", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbbMaTaiXe.Properties.DisplayMember = "TenChungLoaiXe";
            this.cbbMaTaiXe.Properties.NullText = "";
            this.cbbMaTaiXe.Properties.ValueMember = "MaChungLoaiXe";
            this.cbbMaTaiXe.Size = new System.Drawing.Size(144, 20);
            this.cbbMaTaiXe.TabIndex = 10;
            // 
            // frmNgayCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 362);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcNgayCong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSuaChua);
            this.Controls.Add(this.btnThemMoi);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmNgayCong";
            this.Text = "Ngày công công nhân lái tàu";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiXe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNgayCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNgayCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leChungLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaTaiXe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtSoNgay;
        private DevExpress.XtraEditors.TextEdit txtTenTaiXe;
        private DevExpress.XtraEditors.ComboBoxEdit cbbTrangThai;
        private DevExpress.XtraEditors.DateEdit dtNgayBatDau;
        private DevExpress.XtraEditors.LabelControl lblSoNgay;
        private DevExpress.XtraEditors.LabelControl lblNgayBatDau;
        private DevExpress.XtraEditors.LabelControl lblTrangThai;
        private DevExpress.XtraEditors.LabelControl lblMaTaiXe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNgayCong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTaiXe;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTaiXe;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn colSoNgay;
        private DevExpress.XtraGrid.GridControl gcNgayCong;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit leChungLoai;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValid;
        private DevExpress.XtraEditors.LookUpEdit cbbMaTaiXe;
    }
}