namespace PL.frmForm.DanhMuc
{
    partial class frmCNLT
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
            this.gcCNLT = new DevExpress.XtraGrid.GridControl();
            this.gvCNLT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTaiXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTaiXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbTai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbMaTo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTenTaiXe = new DevExpress.XtraEditors.TextEdit();
            this.txtHeSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTaiXe = new DevExpress.XtraEditors.TextEdit();
            this.lblHeSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.lblTài = new DevExpress.XtraEditors.LabelControl();
            this.lblDienThoai = new DevExpress.XtraEditors.LabelControl();
            this.lblDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.lblMaTo = new DevExpress.XtraEditors.LabelControl();
            this.lblTenTaiXe = new DevExpress.XtraEditors.LabelControl();
            this.lblMaTaiXe = new DevExpress.XtraEditors.LabelControl();
            this.dxValid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcCNLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCNLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiXe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTaiXe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCNLT
            // 
            this.gcCNLT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcCNLT.Location = new System.Drawing.Point(12, 178);
            this.gcCNLT.MainView = this.gvCNLT;
            this.gcCNLT.Name = "gcCNLT";
            this.gcCNLT.Size = new System.Drawing.Size(963, 145);
            this.gcCNLT.TabIndex = 13;
            this.gcCNLT.UseEmbeddedNavigator = true;
            this.gcCNLT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCNLT});
            // 
            // gvCNLT
            // 
            this.gvCNLT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTaiXe,
            this.colTenTaiXe,
            this.colDiaChi,
            this.colDienThoai,
            this.colTai,
            this.colHeSoLuong,
            this.colMaTo});
            this.gvCNLT.GridControl = this.gcCNLT;
            this.gvCNLT.Name = "gvCNLT";
            this.gvCNLT.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCNLT.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCNLT.OptionsBehavior.Editable = false;
            this.gvCNLT.OptionsBehavior.ReadOnly = true;
            this.gvCNLT.OptionsView.ShowDetailButtons = false;
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
            this.colMaTo.FieldName = "MaTo";
            this.colMaTo.Name = "colMaTo";
            this.colMaTo.Visible = true;
            this.colMaTo.VisibleIndex = 6;
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
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.cbbTai);
            this.panelControl1.Controls.Add(this.cbbMaTo);
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
            this.panelControl1.TabIndex = 25;
            // 
            // cbbTai
            // 
            this.cbbTai.Location = new System.Drawing.Point(84, 97);
            this.cbbTai.Name = "cbbTai";
            this.cbbTai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbTai.Size = new System.Drawing.Size(245, 20);
            this.cbbTai.TabIndex = 6;
            // 
            // cbbMaTo
            // 
            this.cbbMaTo.Location = new System.Drawing.Point(85, 13);
            this.cbbMaTo.Name = "cbbMaTo";
            this.cbbMaTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMaTo.Size = new System.Drawing.Size(129, 20);
            this.cbbMaTo.TabIndex = 1;
            // 
            // txtTenTaiXe
            // 
            this.txtTenTaiXe.Location = new System.Drawing.Point(503, 41);
            this.txtTenTaiXe.Name = "txtTenTaiXe";
            this.txtTenTaiXe.Size = new System.Drawing.Size(192, 20);
            this.txtTenTaiXe.TabIndex = 3;
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Location = new System.Drawing.Point(503, 97);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(192, 20);
            this.txtHeSoLuong.TabIndex = 7;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(503, 69);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(192, 20);
            this.txtDienThoai.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(84, 69);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(245, 20);
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtMaTaiXe
            // 
            this.txtMaTaiXe.Location = new System.Drawing.Point(84, 41);
            this.txtMaTaiXe.Name = "txtMaTaiXe";
            this.txtMaTaiXe.Size = new System.Drawing.Size(245, 20);
            this.txtMaTaiXe.TabIndex = 2;
            // 
            // lblHeSoLuong
            // 
            this.lblHeSoLuong.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblHeSoLuong.Location = new System.Drawing.Point(413, 101);
            this.lblHeSoLuong.Name = "lblHeSoLuong";
            this.lblHeSoLuong.Size = new System.Drawing.Size(66, 13);
            this.lblHeSoLuong.TabIndex = 8;
            this.lblHeSoLuong.Text = "Hệ số lương";
            // 
            // lblTài
            // 
            this.lblTài.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTài.Location = new System.Drawing.Point(16, 101);
            this.lblTài.Name = "lblTài";
            this.lblTài.Size = new System.Drawing.Size(17, 13);
            this.lblTài.TabIndex = 8;
            this.lblTài.Text = "Tài";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDienThoai.Location = new System.Drawing.Point(421, 73);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(58, 13);
            this.lblDienThoai.TabIndex = 8;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDiaChi.Location = new System.Drawing.Point(16, 73);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(38, 13);
            this.lblDiaChi.TabIndex = 8;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblMaTo
            // 
            this.lblMaTo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMaTo.Location = new System.Drawing.Point(16, 17);
            this.lblMaTo.Name = "lblMaTo";
            this.lblMaTo.Size = new System.Drawing.Size(14, 13);
            this.lblMaTo.TabIndex = 7;
            this.lblMaTo.Text = "Tổ";
            // 
            // lblTenTaiXe
            // 
            this.lblTenTaiXe.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTenTaiXe.Location = new System.Drawing.Point(423, 45);
            this.lblTenTaiXe.Name = "lblTenTaiXe";
            this.lblTenTaiXe.Size = new System.Drawing.Size(56, 13);
            this.lblTenTaiXe.TabIndex = 6;
            this.lblTenTaiXe.Text = "Tên tài xế";
            // 
            // lblMaTaiXe
            // 
            this.lblMaTaiXe.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMaTaiXe.Location = new System.Drawing.Point(16, 45);
            this.lblMaTaiXe.Name = "lblMaTaiXe";
            this.lblMaTaiXe.Size = new System.Drawing.Size(52, 13);
            this.lblMaTaiXe.TabIndex = 6;
            this.lblMaTaiXe.Text = "Mã tài xế";
            // 
            // frmCNLT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 410);
            this.Controls.Add(this.gcCNLT);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnSuaChua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.panelControl1);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmCNLT";
            this.Text = "Công nhân lái tàu";
            ((System.ComponentModel.ISupportInitialize)(this.gcCNLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCNLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiXe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTaiXe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCNLT;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCNLT;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTaiXe;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTaiXe;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenTaiXe;
        private DevExpress.XtraEditors.TextEdit txtMaTaiXe;
        private DevExpress.XtraEditors.LabelControl lblHeSoLuong;
        private DevExpress.XtraEditors.LabelControl lblTài;
        private DevExpress.XtraEditors.LabelControl lblDienThoai;
        private DevExpress.XtraEditors.LabelControl lblDiaChi;
        private DevExpress.XtraEditors.LabelControl lblMaTo;
        private DevExpress.XtraEditors.LabelControl lblMaTaiXe;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValid;
        private DevExpress.XtraEditors.ComboBoxEdit cbbMaTo;
        private DevExpress.XtraEditors.LabelControl lblTenTaiXe;
        private DevExpress.XtraEditors.ComboBoxEdit cbbTai;
        private DevExpress.XtraEditors.TextEdit txtHeSoLuong;
        private DevExpress.XtraEditors.TextEdit txtDienThoai;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colTai;
        private DevExpress.XtraGrid.Columns.GridColumn colHeSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTo;
    }
}