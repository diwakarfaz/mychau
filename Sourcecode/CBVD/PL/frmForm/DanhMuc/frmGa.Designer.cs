namespace PL.frmForm.DanhMuc
{
    partial class frmGa
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
            this.gcGa = new DevExpress.XtraGrid.GridControl();
            this.gvGa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaGa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenGa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtKm = new DevExpress.XtraEditors.TextEdit();
            this.txtTenGa = new DevExpress.XtraEditors.TextEdit();
            this.txtMaGa = new DevExpress.XtraEditors.TextEdit();
            this.lblKm = new DevExpress.XtraEditors.LabelControl();
            this.lblTenGa = new DevExpress.XtraEditors.LabelControl();
            this.lblMaGa = new DevExpress.XtraEditors.LabelControl();
            this.dxValid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcGa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenGa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
            this.SuspendLayout();
            // 
            // gcGa
            // 
            this.gcGa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcGa.Location = new System.Drawing.Point(12, 93);
            this.gcGa.MainView = this.gvGa;
            this.gcGa.Name = "gcGa";
            this.gcGa.Size = new System.Drawing.Size(963, 200);
            this.gcGa.TabIndex = 18;
            this.gcGa.UseEmbeddedNavigator = true;
            this.gcGa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGa});
            // 
            // gvGa
            // 
            this.gvGa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaGa,
            this.colTenGa,
            this.colKm});
            this.gvGa.GridControl = this.gcGa;
            this.gvGa.Name = "gvGa";
            this.gvGa.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvGa.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvGa.OptionsBehavior.Editable = false;
            this.gvGa.OptionsBehavior.ReadOnly = true;
            this.gvGa.OptionsView.ShowDetailButtons = false;
            // 
            // colMaGa
            // 
            this.colMaGa.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaGa.AppearanceCell.Options.UseFont = true;
            this.colMaGa.AppearanceCell.Options.UseTextOptions = true;
            this.colMaGa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaGa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaGa.AppearanceHeader.Options.UseFont = true;
            this.colMaGa.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaGa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaGa.Caption = "Mã ga";
            this.colMaGa.FieldName = "MaGa";
            this.colMaGa.Name = "colMaGa";
            this.colMaGa.Visible = true;
            this.colMaGa.VisibleIndex = 0;
            // 
            // colTenGa
            // 
            this.colTenGa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenGa.AppearanceHeader.Options.UseFont = true;
            this.colTenGa.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenGa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenGa.Caption = "Tên ga";
            this.colTenGa.FieldName = "TenGa";
            this.colTenGa.Name = "colTenGa";
            this.colTenGa.Visible = true;
            this.colTenGa.VisibleIndex = 1;
            // 
            // colKm
            // 
            this.colKm.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colKm.AppearanceHeader.Options.UseFont = true;
            this.colKm.AppearanceHeader.Options.UseTextOptions = true;
            this.colKm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKm.Caption = "Km";
            this.colKm.FieldName = "Km";
            this.colKm.Name = "colKm";
            this.colKm.Visible = true;
            this.colKm.VisibleIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(672, 64);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "&Thoát";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(573, 64);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "&Xóa";
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaTrang.Appearance.Options.UseFont = true;
            this.btnXoaTrang.Location = new System.Drawing.Point(474, 64);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(85, 23);
            this.btnXoaTrang.TabIndex = 14;
            this.btnXoaTrang.Text = "Xóa &trắng";
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaChua.Appearance.Options.UseFont = true;
            this.btnSuaChua.Location = new System.Drawing.Point(375, 64);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(85, 23);
            this.btnSuaChua.TabIndex = 13;
            this.btnSuaChua.Text = "&Sửa chữa";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(274, 64);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 23);
            this.btnThemMoi.TabIndex = 12;
            this.btnThemMoi.Text = "&Ghi nhận";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.txtKm);
            this.panelControl1.Controls.Add(this.txtTenGa);
            this.panelControl1.Controls.Add(this.txtMaGa);
            this.panelControl1.Controls.Add(this.lblKm);
            this.panelControl1.Controls.Add(this.lblTenGa);
            this.panelControl1.Controls.Add(this.lblMaGa);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(963, 41);
            this.panelControl1.TabIndex = 15;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(632, 9);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(206, 20);
            this.txtKm.TabIndex = 5;
            // 
            // txtTenGa
            // 
            this.txtTenGa.Location = new System.Drawing.Point(354, 9);
            this.txtTenGa.Name = "txtTenGa";
            this.txtTenGa.Size = new System.Drawing.Size(206, 20);
            this.txtTenGa.TabIndex = 2;
            // 
            // txtMaGa
            // 
            this.txtMaGa.Location = new System.Drawing.Point(45, 9);
            this.txtMaGa.Name = "txtMaGa";
            this.txtMaGa.Size = new System.Drawing.Size(206, 20);
            this.txtMaGa.TabIndex = 1;
            // 
            // lblKm
            // 
            this.lblKm.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblKm.Location = new System.Drawing.Point(608, 13);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(18, 13);
            this.lblKm.TabIndex = 8;
            this.lblKm.Text = "Km";
            // 
            // lblTenGa
            // 
            this.lblTenGa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTenGa.Location = new System.Drawing.Point(310, 13);
            this.lblTenGa.Name = "lblTenGa";
            this.lblTenGa.Size = new System.Drawing.Size(38, 13);
            this.lblTenGa.TabIndex = 7;
            this.lblTenGa.Text = "Tên ga";
            // 
            // lblMaGa
            // 
            this.lblMaGa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMaGa.Location = new System.Drawing.Point(5, 13);
            this.lblMaGa.Name = "lblMaGa";
            this.lblMaGa.Size = new System.Drawing.Size(34, 13);
            this.lblMaGa.TabIndex = 6;
            this.lblMaGa.Text = "Mã ga";
            // 
            // frmGa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 410);
            this.Controls.Add(this.gcGa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnSuaChua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.panelControl1);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmGa";
            this.Text = "Ga tàu";
            ((System.ComponentModel.ISupportInitialize)(this.gcGa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenGa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcGa;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGa;
        private DevExpress.XtraGrid.Columns.GridColumn colMaGa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenGa;
        private DevExpress.XtraGrid.Columns.GridColumn colKm;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtKm;
        private DevExpress.XtraEditors.TextEdit txtTenGa;
        private DevExpress.XtraEditors.TextEdit txtMaGa;
        private DevExpress.XtraEditors.LabelControl lblKm;
        private DevExpress.XtraEditors.LabelControl lblTenGa;
        private DevExpress.XtraEditors.LabelControl lblMaGa;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValid;
    }
}