namespace PL.frmForm.DanhMuc
{
    partial class frmDauMay
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
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.gcDauMay = new DevExpress.XtraGrid.GridControl();
            this.gvDauMay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDauMay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDauMay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLoaiDM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.dxValid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbMaLoaiDM = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTenDaumay = new DevExpress.XtraEditors.TextEdit();
            this.txtTenLoaiDM = new DevExpress.XtraEditors.TextEdit();
            this.lblMaLoaiDM = new DevExpress.XtraEditors.LabelControl();
            this.lblTenDauMay = new DevExpress.XtraEditors.LabelControl();
            this.lblMaDM = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcDauMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDauMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaLoaiDM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDaumay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiDM.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(626, 63);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "&Thoát";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(527, 63);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "&Xóa";
            // 
            // gcDauMay
            // 
            this.gcDauMay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDauMay.Location = new System.Drawing.Point(12, 92);
            this.gcDauMay.MainView = this.gvDauMay;
            this.gcDauMay.Name = "gcDauMay";
            this.gcDauMay.Size = new System.Drawing.Size(963, 200);
            this.gcDauMay.TabIndex = 32;
            this.gcDauMay.UseEmbeddedNavigator = true;
            this.gcDauMay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDauMay});
            // 
            // gvDauMay
            // 
            this.gvDauMay.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDauMay,
            this.colTenDauMay,
            this.colMaLoaiDM});
            this.gvDauMay.GridControl = this.gcDauMay;
            this.gvDauMay.Name = "gvDauMay";
            this.gvDauMay.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvDauMay.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvDauMay.OptionsBehavior.Editable = false;
            this.gvDauMay.OptionsBehavior.ReadOnly = true;
            this.gvDauMay.OptionsView.ShowDetailButtons = false;
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
            this.colMaDauMay.FieldName = "MaDauMay";
            this.colMaDauMay.Name = "colMaDauMay";
            this.colMaDauMay.Visible = true;
            this.colMaDauMay.VisibleIndex = 0;
            // 
            // colTenDauMay
            // 
            this.colTenDauMay.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenDauMay.AppearanceHeader.Options.UseFont = true;
            this.colTenDauMay.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenDauMay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDauMay.Caption = "Tên đầu máy";
            this.colTenDauMay.FieldName = "TenDauMay";
            this.colTenDauMay.Name = "colTenDauMay";
            this.colTenDauMay.Visible = true;
            this.colTenDauMay.VisibleIndex = 1;
            // 
            // colMaLoaiDM
            // 
            this.colMaLoaiDM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaLoaiDM.AppearanceHeader.Options.UseFont = true;
            this.colMaLoaiDM.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaLoaiDM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaLoaiDM.Caption = "Loại đầu máy";
            this.colMaLoaiDM.FieldName = "MaLoaiDM";
            this.colMaLoaiDM.Name = "colMaLoaiDM";
            this.colMaLoaiDM.Visible = true;
            this.colMaLoaiDM.VisibleIndex = 2;
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaChua.Appearance.Options.UseFont = true;
            this.btnSuaChua.Location = new System.Drawing.Point(329, 63);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(85, 23);
            this.btnSuaChua.TabIndex = 27;
            this.btnSuaChua.Text = "&Sửa chữa";
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaTrang.Appearance.Options.UseFont = true;
            this.btnXoaTrang.Location = new System.Drawing.Point(428, 63);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(85, 23);
            this.btnXoaTrang.TabIndex = 28;
            this.btnXoaTrang.Text = "Xóa &trắng";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(228, 63);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 23);
            this.btnThemMoi.TabIndex = 26;
            this.btnThemMoi.Text = "&Ghi nhận";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.cbbMaLoaiDM);
            this.panelControl1.Controls.Add(this.txtTenDaumay);
            this.panelControl1.Controls.Add(this.txtTenLoaiDM);
            this.panelControl1.Controls.Add(this.lblMaLoaiDM);
            this.panelControl1.Controls.Add(this.lblTenDauMay);
            this.panelControl1.Controls.Add(this.lblMaDM);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(963, 41);
            this.panelControl1.TabIndex = 29;
            // 
            // cbbMaLoaiDM
            // 
            this.cbbMaLoaiDM.Location = new System.Drawing.Point(98, 9);
            this.cbbMaLoaiDM.Name = "cbbMaLoaiDM";
            this.cbbMaLoaiDM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMaLoaiDM.Size = new System.Drawing.Size(180, 20);
            this.cbbMaLoaiDM.TabIndex = 9;
            // 
            // txtTenDaumay
            // 
            this.txtTenDaumay.Location = new System.Drawing.Point(681, 10);
            this.txtTenDaumay.Name = "txtTenDaumay";
            this.txtTenDaumay.Size = new System.Drawing.Size(206, 20);
            this.txtTenDaumay.TabIndex = 2;
            // 
            // txtTenLoaiDM
            // 
            this.txtTenLoaiDM.Location = new System.Drawing.Point(373, 10);
            this.txtTenLoaiDM.Name = "txtTenLoaiDM";
            this.txtTenLoaiDM.Size = new System.Drawing.Size(206, 20);
            this.txtTenLoaiDM.TabIndex = 1;
            // 
            // lblMaLoaiDM
            // 
            this.lblMaLoaiDM.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMaLoaiDM.Location = new System.Drawing.Point(7, 12);
            this.lblMaLoaiDM.Name = "lblMaLoaiDM";
            this.lblMaLoaiDM.Size = new System.Drawing.Size(75, 13);
            this.lblMaLoaiDM.TabIndex = 8;
            this.lblMaLoaiDM.Text = "Loại đầu máy";
            // 
            // lblTenDauMay
            // 
            this.lblTenDauMay.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTenDauMay.Location = new System.Drawing.Point(602, 12);
            this.lblTenDauMay.Name = "lblTenDauMay";
            this.lblTenDauMay.Size = new System.Drawing.Size(73, 13);
            this.lblTenDauMay.TabIndex = 7;
            this.lblTenDauMay.Text = "Tên đầu máy";
            // 
            // lblMaDM
            // 
            this.lblMaDM.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMaDM.Location = new System.Drawing.Point(298, 13);
            this.lblMaDM.Name = "lblMaDM";
            this.lblMaDM.Size = new System.Drawing.Size(69, 13);
            this.lblMaDM.TabIndex = 6;
            this.lblMaDM.Text = "Mã đầu máy";
            // 
            // frmDauMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 410);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gcDauMay);
            this.Controls.Add(this.btnSuaChua);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.panelControl1);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmDauMay";
            this.Text = "Đầu máy";
            ((System.ComponentModel.ISupportInitialize)(this.gcDauMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDauMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaLoaiDM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDaumay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiDM.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraGrid.GridControl gcDauMay;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDauMay;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDauMay;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDauMay;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiDM;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValid;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenDaumay;
        private DevExpress.XtraEditors.TextEdit txtTenLoaiDM;
        private DevExpress.XtraEditors.LabelControl lblMaLoaiDM;
        private DevExpress.XtraEditors.LabelControl lblTenDauMay;
        private DevExpress.XtraEditors.LabelControl lblMaDM;
        private DevExpress.XtraEditors.ComboBoxEdit cbbMaLoaiDM;
    }
}