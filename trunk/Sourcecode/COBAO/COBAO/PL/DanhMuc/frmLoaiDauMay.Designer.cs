namespace COBAO.PL.DanhMuc
{
    partial class frmLoaiDauMay
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
            this.lblTrongLuong = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtTrongLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtTanSoThap = new DevExpress.XtraEditors.TextEdit();
            this.txtTenLoaiDM = new DevExpress.XtraEditors.TextEdit();
            this.lblTanSoThap = new DevExpress.XtraEditors.LabelControl();
            this.lblTenLoaiDM = new DevExpress.XtraEditors.LabelControl();
            this.colTrongLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.colTanSoThap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dxValid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.colTenLoaiDM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLoaiDM = new DevExpress.XtraGrid.GridControl();
            this.gvLoaiDM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrongLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanSoThap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiDM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiDM)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrongLuong
            // 
            this.lblTrongLuong.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTrongLuong.Location = new System.Drawing.Point(660, 13);
            this.lblTrongLuong.Name = "lblTrongLuong";
            this.lblTrongLuong.Size = new System.Drawing.Size(68, 13);
            this.lblTrongLuong.TabIndex = 8;
            this.lblTrongLuong.Text = "Trọng lượng";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.txtTrongLuong);
            this.panelControl1.Controls.Add(this.txtTanSoThap);
            this.panelControl1.Controls.Add(this.txtTenLoaiDM);
            this.panelControl1.Controls.Add(this.lblTrongLuong);
            this.panelControl1.Controls.Add(this.lblTanSoThap);
            this.panelControl1.Controls.Add(this.lblTenLoaiDM);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(963, 41);
            this.panelControl1.TabIndex = 29;
            // 
            // txtTrongLuong
            // 
            this.txtTrongLuong.EnterMoveNextControl = true;
            this.txtTrongLuong.Location = new System.Drawing.Point(734, 9);
            this.txtTrongLuong.Name = "txtTrongLuong";
            this.txtTrongLuong.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTrongLuong.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTrongLuong.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTrongLuong.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtTrongLuong.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtTrongLuong.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTrongLuong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTrongLuong.Size = new System.Drawing.Size(206, 20);
            this.txtTrongLuong.TabIndex = 3;
            // 
            // txtTanSoThap
            // 
            this.txtTanSoThap.EnterMoveNextControl = true;
            this.txtTanSoThap.Location = new System.Drawing.Point(390, 9);
            this.txtTanSoThap.Name = "txtTanSoThap";
            this.txtTanSoThap.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTanSoThap.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTanSoThap.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTanSoThap.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtTanSoThap.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtTanSoThap.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTanSoThap.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTanSoThap.Properties.MaxLength = 4;
            this.txtTanSoThap.Size = new System.Drawing.Size(206, 20);
            this.txtTanSoThap.TabIndex = 2;
            // 
            // txtTenLoaiDM
            // 
            this.txtTenLoaiDM.Location = new System.Drawing.Point(55, 9);
            this.txtTenLoaiDM.Name = "txtTenLoaiDM";
            this.txtTenLoaiDM.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTenLoaiDM.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenLoaiDM.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTenLoaiDM.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtTenLoaiDM.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtTenLoaiDM.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenLoaiDM.Size = new System.Drawing.Size(206, 20);
            this.txtTenLoaiDM.TabIndex = 1;
            // 
            // lblTanSoThap
            // 
            this.lblTanSoThap.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTanSoThap.Location = new System.Drawing.Point(318, 13);
            this.lblTanSoThap.Name = "lblTanSoThap";
            this.lblTanSoThap.Size = new System.Drawing.Size(66, 13);
            this.lblTanSoThap.TabIndex = 7;
            this.lblTanSoThap.Text = "Tấn số thấp";
            // 
            // lblTenLoaiDM
            // 
            this.lblTenLoaiDM.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTenLoaiDM.Location = new System.Drawing.Point(5, 13);
            this.lblTenLoaiDM.Name = "lblTenLoaiDM";
            this.lblTenLoaiDM.Size = new System.Drawing.Size(44, 13);
            this.lblTenLoaiDM.TabIndex = 6;
            this.lblTenLoaiDM.Text = "Tên loại";
            // 
            // colTrongLuong
            // 
            this.colTrongLuong.AppearanceCell.Options.UseTextOptions = true;
            this.colTrongLuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTrongLuong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTrongLuong.AppearanceHeader.Options.UseFont = true;
            this.colTrongLuong.AppearanceHeader.Options.UseTextOptions = true;
            this.colTrongLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTrongLuong.Caption = "Trọng lượng";
            this.colTrongLuong.FieldName = "Trongluong";
            this.colTrongLuong.Name = "colTrongLuong";
            this.colTrongLuong.Visible = true;
            this.colTrongLuong.VisibleIndex = 2;
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaChua.Appearance.Options.UseFont = true;
            this.btnSuaChua.Location = new System.Drawing.Point(397, 59);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(85, 23);
            this.btnSuaChua.TabIndex = 24;
            this.btnSuaChua.Text = "&Sửa chữa";
            this.btnSuaChua.Click += new System.EventHandler(this.btnSuaChua_Click);
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaTrang.Appearance.Options.UseFont = true;
            this.btnXoaTrang.Location = new System.Drawing.Point(496, 59);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(85, 23);
            this.btnXoaTrang.TabIndex = 25;
            this.btnXoaTrang.Text = "Xóa &trắng";
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // colTanSoThap
            // 
            this.colTanSoThap.AppearanceCell.Options.UseTextOptions = true;
            this.colTanSoThap.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTanSoThap.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTanSoThap.AppearanceHeader.Options.UseFont = true;
            this.colTanSoThap.AppearanceHeader.Options.UseTextOptions = true;
            this.colTanSoThap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTanSoThap.Caption = "Tấn số thấp";
            this.colTanSoThap.FieldName = "TanSoThap";
            this.colTanSoThap.Name = "colTanSoThap";
            this.colTanSoThap.Visible = true;
            this.colTanSoThap.VisibleIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(694, 59);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(595, 59);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // colTenLoaiDM
            // 
            this.colTenLoaiDM.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenLoaiDM.AppearanceCell.Options.UseFont = true;
            this.colTenLoaiDM.AppearanceCell.Options.UseTextOptions = true;
            this.colTenLoaiDM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenLoaiDM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenLoaiDM.AppearanceHeader.Options.UseFont = true;
            this.colTenLoaiDM.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenLoaiDM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenLoaiDM.Caption = "Tên loại đầu máy";
            this.colTenLoaiDM.FieldName = "TenLoai";
            this.colTenLoaiDM.Name = "colTenLoaiDM";
            this.colTenLoaiDM.Visible = true;
            this.colTenLoaiDM.VisibleIndex = 0;
            // 
            // gcLoaiDM
            // 
            this.gcLoaiDM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcLoaiDM.Location = new System.Drawing.Point(12, 88);
            this.gcLoaiDM.MainView = this.gvLoaiDM;
            this.gcLoaiDM.Name = "gcLoaiDM";
            this.gcLoaiDM.Size = new System.Drawing.Size(963, 200);
            this.gcLoaiDM.TabIndex = 28;
            this.gcLoaiDM.UseEmbeddedNavigator = true;
            this.gcLoaiDM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLoaiDM});
            // 
            // gvLoaiDM
            // 
            this.gvLoaiDM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenLoaiDM,
            this.colTanSoThap,
            this.colTrongLuong});
            this.gvLoaiDM.GridControl = this.gcLoaiDM;
            this.gvLoaiDM.GroupPanelText = " ";
            this.gvLoaiDM.Name = "gvLoaiDM";
            this.gvLoaiDM.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvLoaiDM.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvLoaiDM.OptionsBehavior.Editable = false;
            this.gvLoaiDM.OptionsBehavior.ReadOnly = true;
            this.gvLoaiDM.OptionsView.ShowDetailButtons = false;
            this.gvLoaiDM.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvLoaiDauMay_RowClick);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(296, 59);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 23);
            this.btnThemMoi.TabIndex = 23;
            this.btnThemMoi.Text = "&Ghi nhận";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // frmLoaiDauMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 340);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnSuaChua);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gcLoaiDM);
            this.Controls.Add(this.btnThemMoi);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmLoaiDauMay";
            this.Text = "Loại đầu máy";
            this.Load += new System.EventHandler(this.frmLoaiDauMay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrongLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanSoThap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiDM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiDM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTrongLuong;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtTrongLuong;
        private DevExpress.XtraEditors.TextEdit txtTanSoThap;
        private DevExpress.XtraEditors.TextEdit txtTenLoaiDM;
        private DevExpress.XtraEditors.LabelControl lblTanSoThap;
        private DevExpress.XtraEditors.LabelControl lblTenLoaiDM;
        private DevExpress.XtraGrid.Columns.GridColumn colTrongLuong;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraGrid.Columns.GridColumn colTanSoThap;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValid;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiDM;
        private DevExpress.XtraGrid.GridControl gcLoaiDM;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLoaiDM;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
    }
}