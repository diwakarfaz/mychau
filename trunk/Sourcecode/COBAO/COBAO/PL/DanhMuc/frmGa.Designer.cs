namespace COBAO.PL.DanhMuc
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
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.txtKm = new DevExpress.XtraEditors.TextEdit();
            this.txtTenGa = new DevExpress.XtraEditors.TextEdit();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaGa = new DevExpress.XtraEditors.TextEdit();
            this.gcGa = new DevExpress.XtraGrid.GridControl();
            this.gvGa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaGa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenGa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblKm = new DevExpress.XtraEditors.LabelControl();
            this.lblTenGa = new DevExpress.XtraEditors.LabelControl();
            this.lblMaGa = new DevExpress.XtraEditors.LabelControl();
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.dxValid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtKm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenGa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(612, 64);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(632, 9);
            this.txtKm.Name = "txtKm";
            this.txtKm.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKm.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKm.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtKm.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtKm.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtKm.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKm.Properties.Mask.EditMask = "\\d{1,9}";
            this.txtKm.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtKm.Size = new System.Drawing.Size(206, 20);
            this.txtKm.TabIndex = 3;
            // 
            // txtTenGa
            // 
            this.txtTenGa.Location = new System.Drawing.Point(354, 9);
            this.txtTenGa.Name = "txtTenGa";
            this.txtTenGa.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTenGa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenGa.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTenGa.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtTenGa.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtTenGa.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenGa.Size = new System.Drawing.Size(206, 20);
            this.txtTenGa.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(513, 64);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaGa
            // 
            this.txtMaGa.Location = new System.Drawing.Point(45, 9);
            this.txtMaGa.Name = "txtMaGa";
            this.txtMaGa.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaGa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaGa.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtMaGa.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtMaGa.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtMaGa.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaGa.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaGa.Properties.MaxLength = 5;
            this.txtMaGa.Size = new System.Drawing.Size(206, 20);
            this.txtMaGa.TabIndex = 1;
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
            this.gcGa.TabIndex = 9;
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
            this.gvGa.GroupPanelText = " ";
            this.gvGa.Name = "gvGa";
            this.gvGa.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvGa.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvGa.OptionsBehavior.Editable = false;
            this.gvGa.OptionsBehavior.ReadOnly = true;
            this.gvGa.OptionsView.ShowDetailButtons = false;
            this.gvGa.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvGa_RowClick);
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
            // btnXoaTrang
            // 
            this.btnXoaTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaTrang.Appearance.Options.UseFont = true;
            this.btnXoaTrang.Location = new System.Drawing.Point(414, 64);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(85, 23);
            this.btnXoaTrang.TabIndex = 6;
            this.btnXoaTrang.Text = "Xóa &trắng";
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaChua.Appearance.Options.UseFont = true;
            this.btnSuaChua.Location = new System.Drawing.Point(315, 64);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(85, 23);
            this.btnSuaChua.TabIndex = 5;
            this.btnSuaChua.Text = "&Sửa chữa";
            this.btnSuaChua.Click += new System.EventHandler(this.btnSuaChua_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(214, 64);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 23);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "&Ghi nhận";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
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
            this.panelControl1.TabIndex = 22;
            // 
            // frmGa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 340);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gcGa);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnSuaChua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.panelControl1);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmGa";
            this.Text = "Ga tàu";
            this.Load += new System.EventHandler(this.frmGa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenGa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.TextEdit txtKm;
        private DevExpress.XtraEditors.TextEdit txtTenGa;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.TextEdit txtMaGa;
        private DevExpress.XtraGrid.GridControl gcGa;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGa;
        private DevExpress.XtraGrid.Columns.GridColumn colMaGa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenGa;
        private DevExpress.XtraGrid.Columns.GridColumn colKm;
        private DevExpress.XtraEditors.LabelControl lblKm;
        private DevExpress.XtraEditors.LabelControl lblTenGa;
        private DevExpress.XtraEditors.LabelControl lblMaGa;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValid;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}