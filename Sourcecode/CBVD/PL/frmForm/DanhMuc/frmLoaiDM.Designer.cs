namespace PL.frmForm.DanhMuc
{
    partial class frmLoaiDM
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
            this.txtTrongLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtTanSoThap = new DevExpress.XtraEditors.TextEdit();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenLoaiDM = new DevExpress.XtraEditors.TextEdit();
            this.gcLoaiDM = new DevExpress.XtraGrid.GridControl();
            this.gvLoaiDM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenLoaiDM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanSoThap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrongLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTrongLuong = new DevExpress.XtraEditors.LabelControl();
            this.lblTanSoThap = new DevExpress.XtraEditors.LabelControl();
            this.lblTenLoaiDM = new DevExpress.XtraEditors.LabelControl();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.dxValid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrongLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanSoThap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiDM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(694, 59);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "&Thoát";
            // 
            // txtTrongLuong
            // 
            this.txtTrongLuong.Location = new System.Drawing.Point(734, 9);
            this.txtTrongLuong.Name = "txtTrongLuong";
            this.txtTrongLuong.Size = new System.Drawing.Size(206, 20);
            this.txtTrongLuong.TabIndex = 5;
            // 
            // txtTanSoThap
            // 
            this.txtTanSoThap.Location = new System.Drawing.Point(390, 9);
            this.txtTanSoThap.Name = "txtTanSoThap";
            this.txtTanSoThap.Size = new System.Drawing.Size(206, 20);
            this.txtTanSoThap.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(595, 59);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "&Xóa";
            // 
            // txtTenLoaiDM
            // 
            this.txtTenLoaiDM.Location = new System.Drawing.Point(55, 9);
            this.txtTenLoaiDM.Name = "txtTenLoaiDM";
            this.txtTenLoaiDM.Size = new System.Drawing.Size(206, 20);
            this.txtTenLoaiDM.TabIndex = 1;
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
            this.gcLoaiDM.TabIndex = 25;
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
            this.gvLoaiDM.Name = "gvLoaiDM";
            this.gvLoaiDM.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvLoaiDM.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvLoaiDM.OptionsBehavior.Editable = false;
            this.gvLoaiDM.OptionsBehavior.ReadOnly = true;
            this.gvLoaiDM.OptionsView.ShowDetailButtons = false;
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
            this.colTenLoaiDM.FieldName = "TenLoaiDM";
            this.colTenLoaiDM.Name = "colTenLoaiDM";
            this.colTenLoaiDM.Visible = true;
            this.colTenLoaiDM.VisibleIndex = 0;
            // 
            // colTanSoThap
            // 
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
            // colTrongLuong
            // 
            this.colTrongLuong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTrongLuong.AppearanceHeader.Options.UseFont = true;
            this.colTrongLuong.AppearanceHeader.Options.UseTextOptions = true;
            this.colTrongLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTrongLuong.Caption = "Trọng lượng";
            this.colTrongLuong.FieldName = "TrongLuong";
            this.colTrongLuong.Name = "colTrongLuong";
            this.colTrongLuong.Visible = true;
            this.colTrongLuong.VisibleIndex = 2;
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
            // btnSuaChua
            // 
            this.btnSuaChua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaChua.Appearance.Options.UseFont = true;
            this.btnSuaChua.Location = new System.Drawing.Point(397, 59);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(85, 23);
            this.btnSuaChua.TabIndex = 20;
            this.btnSuaChua.Text = "&Sửa chữa";
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaTrang.Appearance.Options.UseFont = true;
            this.btnXoaTrang.Location = new System.Drawing.Point(496, 59);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(85, 23);
            this.btnXoaTrang.TabIndex = 21;
            this.btnXoaTrang.Text = "Xóa &trắng";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(296, 59);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 23);
            this.btnThemMoi.TabIndex = 19;
            this.btnThemMoi.Text = "&Ghi nhận";
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
            this.panelControl1.TabIndex = 22;
            // 
            // frmLoaiDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 410);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gcLoaiDM);
            this.Controls.Add(this.btnSuaChua);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.panelControl1);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmLoaiDM";
            this.Text = "Loại đầu máy";
            ((System.ComponentModel.ISupportInitialize)(this.txtTrongLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanSoThap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiDM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.TextEdit txtTrongLuong;
        private DevExpress.XtraEditors.TextEdit txtTanSoThap;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.TextEdit txtTenLoaiDM;
        private DevExpress.XtraGrid.GridControl gcLoaiDM;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLoaiDM;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiDM;
        private DevExpress.XtraGrid.Columns.GridColumn colTanSoThap;
        private DevExpress.XtraGrid.Columns.GridColumn colTrongLuong;
        private DevExpress.XtraEditors.LabelControl lblTrongLuong;
        private DevExpress.XtraEditors.LabelControl lblTanSoThap;
        private DevExpress.XtraEditors.LabelControl lblTenLoaiDM;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValid;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}