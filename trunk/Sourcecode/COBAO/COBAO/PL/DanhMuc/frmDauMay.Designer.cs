namespace COBAO.PL.DanhMuc
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
            this.colTenDauMay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.gcDauMay = new DevExpress.XtraGrid.GridControl();
            this.gvDauMay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDauMay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLoaiDM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lLoaiDauMay = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.loaiDauMayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOBAODataSet = new COBAO.DAL.COBAODataSet();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.dxValid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.cbbLoaiDM = new DevExpress.XtraEditors.LookUpEdit();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtTenDauMay = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDM = new DevExpress.XtraEditors.TextEdit();
            this.lblMaLoaiDM = new DevExpress.XtraEditors.LabelControl();
            this.lblTenDauMay = new DevExpress.XtraEditors.LabelControl();
            this.lblMaDM = new DevExpress.XtraEditors.LabelControl();
            this.loaiDauMayTableAdapter = new COBAO.DAL.COBAODataSetTableAdapters.LoaiDauMayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcDauMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDauMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLoaiDauMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiDauMayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOBAODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiDM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDauMay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDM.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // colTenDauMay
            // 
            this.colTenDauMay.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenDauMay.AppearanceHeader.Options.UseFont = true;
            this.colTenDauMay.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenDauMay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDauMay.Caption = "Tên đầu máy";
            this.colTenDauMay.FieldName = "TenDM";
            this.colTenDauMay.Name = "colTenDauMay";
            this.colTenDauMay.Visible = true;
            this.colTenDauMay.VisibleIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(626, 63);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(527, 63);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gcDauMay
            // 
            this.gcDauMay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDauMay.Location = new System.Drawing.Point(12, 92);
            this.gcDauMay.MainView = this.gvDauMay;
            this.gcDauMay.Name = "gcDauMay";
            this.gcDauMay.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lLoaiDauMay});
            this.gcDauMay.Size = new System.Drawing.Size(963, 200);
            this.gcDauMay.TabIndex = 9;
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
            this.gvDauMay.GroupPanelText = " ";
            this.gvDauMay.Name = "gvDauMay";
            this.gvDauMay.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvDauMay.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvDauMay.OptionsBehavior.Editable = false;
            this.gvDauMay.OptionsBehavior.ReadOnly = true;
            this.gvDauMay.OptionsView.ShowDetailButtons = false;
            this.gvDauMay.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvDauMay_RowClick);
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
            this.colMaDauMay.FieldName = "MaDM";
            this.colMaDauMay.Name = "colMaDauMay";
            this.colMaDauMay.Visible = true;
            this.colMaDauMay.VisibleIndex = 0;
            // 
            // colMaLoaiDM
            // 
            this.colMaLoaiDM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaLoaiDM.AppearanceHeader.Options.UseFont = true;
            this.colMaLoaiDM.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaLoaiDM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaLoaiDM.Caption = "Loại đầu máy";
            this.colMaLoaiDM.ColumnEdit = this.lLoaiDauMay;
            this.colMaLoaiDM.FieldName = "MaLoai";
            this.colMaLoaiDM.Name = "colMaLoaiDM";
            this.colMaLoaiDM.Visible = true;
            this.colMaLoaiDM.VisibleIndex = 2;
            // 
            // lLoaiDauMay
            // 
            this.lLoaiDauMay.AutoHeight = false;
            this.lLoaiDauMay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lLoaiDauMay.DataSource = this.loaiDauMayBindingSource;
            this.lLoaiDauMay.DisplayMember = "TenLoai";
            this.lLoaiDauMay.Name = "lLoaiDauMay";
            this.lLoaiDauMay.ValueMember = "MaLoai";
            // 
            // loaiDauMayBindingSource
            // 
            this.loaiDauMayBindingSource.DataMember = "LoaiDauMay";
            this.loaiDauMayBindingSource.DataSource = this.cOBAODataSet;
            // 
            // cOBAODataSet
            // 
            this.cOBAODataSet.DataSetName = "COBAODataSet";
            this.cOBAODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaChua.Appearance.Options.UseFont = true;
            this.btnSuaChua.Location = new System.Drawing.Point(329, 63);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(85, 23);
            this.btnSuaChua.TabIndex = 5;
            this.btnSuaChua.Text = "&Sửa chữa";
            this.btnSuaChua.Click += new System.EventHandler(this.btnSuaChua_Click);
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaTrang.Appearance.Options.UseFont = true;
            this.btnXoaTrang.Location = new System.Drawing.Point(428, 63);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(85, 23);
            this.btnXoaTrang.TabIndex = 6;
            this.btnXoaTrang.Text = "Xóa &trắng";
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // cbbLoaiDM
            // 
            this.dxValid.SetIconAlignment(this.cbbLoaiDM, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.cbbLoaiDM.Location = new System.Drawing.Point(88, 10);
            this.cbbLoaiDM.Name = "cbbLoaiDM";
            this.cbbLoaiDM.Properties.Appearance.Options.UseTextOptions = true;
            this.cbbLoaiDM.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbLoaiDM.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbbLoaiDM.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbbLoaiDM.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.cbbLoaiDM.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbLoaiDM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbLoaiDM.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenLoai", "Loại đầu máy")});
            this.cbbLoaiDM.Properties.DisplayMember = "TenLoai";
            this.cbbLoaiDM.Properties.NullText = "";
            this.cbbLoaiDM.Properties.PopupSizeable = false;
            this.cbbLoaiDM.Properties.ValueMember = "MaLoai";
            this.cbbLoaiDM.Size = new System.Drawing.Size(180, 20);
            this.cbbLoaiDM.TabIndex = 1;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(228, 63);
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
            this.panelControl1.Controls.Add(this.cbbLoaiDM);
            this.panelControl1.Controls.Add(this.txtTenDauMay);
            this.panelControl1.Controls.Add(this.txtMaDM);
            this.panelControl1.Controls.Add(this.lblMaLoaiDM);
            this.panelControl1.Controls.Add(this.lblTenDauMay);
            this.panelControl1.Controls.Add(this.lblMaDM);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(963, 41);
            this.panelControl1.TabIndex = 36;
            // 
            // txtTenDauMay
            // 
            this.txtTenDauMay.Location = new System.Drawing.Point(681, 10);
            this.txtTenDauMay.Name = "txtTenDauMay";
            this.txtTenDauMay.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTenDauMay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenDauMay.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTenDauMay.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtTenDauMay.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtTenDauMay.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenDauMay.Size = new System.Drawing.Size(180, 20);
            this.txtTenDauMay.TabIndex = 3;
            // 
            // txtMaDM
            // 
            this.txtMaDM.Location = new System.Drawing.Point(373, 10);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaDM.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaDM.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtMaDM.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtMaDM.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtMaDM.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaDM.Properties.MaxLength = 5;
            this.txtMaDM.Size = new System.Drawing.Size(180, 20);
            this.txtMaDM.TabIndex = 2;
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
            // loaiDauMayTableAdapter
            // 
            this.loaiDauMayTableAdapter.ClearBeforeFill = true;
            // 
            // frmDauMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 340);
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
            this.Load += new System.EventHandler(this.frmDauMay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDauMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDauMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLoaiDauMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiDauMayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOBAODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiDM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDauMay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDM.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colTenDauMay;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraGrid.GridControl gcDauMay;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDauMay;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDauMay;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiDM;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lLoaiDauMay;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValid;
        private DevExpress.XtraEditors.LookUpEdit cbbLoaiDM;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenDauMay;
        private DevExpress.XtraEditors.TextEdit txtMaDM;
        private DevExpress.XtraEditors.LabelControl lblMaLoaiDM;
        private DevExpress.XtraEditors.LabelControl lblTenDauMay;
        private DevExpress.XtraEditors.LabelControl lblMaDM;
        private DAL.COBAODataSet cOBAODataSet;
        private System.Windows.Forms.BindingSource loaiDauMayBindingSource;
        private DAL.COBAODataSetTableAdapters.LoaiDauMayTableAdapter loaiDauMayTableAdapter;
    }
}