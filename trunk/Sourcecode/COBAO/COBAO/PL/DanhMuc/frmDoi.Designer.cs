namespace COBAO.PL.DanhMuc
{
    partial class frmDoi
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
            this.gcDoi = new DevExpress.XtraGrid.GridControl();
            this.gvDoi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTram = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lTram = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOBAODataSet = new COBAO.DAL.COBAODataSet();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.dxValid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbMaTram = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTenDoi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblTenTram = new DevExpress.XtraEditors.LabelControl();
            this.tramTableAdapter = new COBAO.DAL.COBAODataSetTableAdapters.TramTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcDoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOBAODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaTram.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(598, 85);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(499, 85);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gcDoi
            // 
            this.gcDoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDoi.Location = new System.Drawing.Point(12, 114);
            this.gcDoi.MainView = this.gvDoi;
            this.gcDoi.Name = "gcDoi";
            this.gcDoi.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lTram});
            this.gcDoi.Size = new System.Drawing.Size(963, 221);
            this.gcDoi.TabIndex = 8;
            this.gcDoi.UseEmbeddedNavigator = true;
            this.gcDoi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDoi});
            // 
            // gvDoi
            // 
            this.gvDoi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDoi,
            this.colMaTram});
            this.gvDoi.GridControl = this.gcDoi;
            this.gvDoi.GroupPanelText = " ";
            this.gvDoi.Name = "gvDoi";
            this.gvDoi.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvDoi.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvDoi.OptionsBehavior.Editable = false;
            this.gvDoi.OptionsBehavior.ReadOnly = true;
            this.gvDoi.OptionsView.ShowDetailButtons = false;
            this.gvDoi.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvDoi_RowClick);
            // 
            // colTenDoi
            // 
            this.colTenDoi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenDoi.AppearanceCell.Options.UseFont = true;
            this.colTenDoi.AppearanceCell.Options.UseTextOptions = true;
            this.colTenDoi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDoi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenDoi.AppearanceHeader.Options.UseFont = true;
            this.colTenDoi.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenDoi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDoi.Caption = "Tên đội";
            this.colTenDoi.FieldName = "TenDoi";
            this.colTenDoi.Name = "colTenDoi";
            this.colTenDoi.Visible = true;
            this.colTenDoi.VisibleIndex = 0;
            // 
            // colMaTram
            // 
            this.colMaTram.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaTram.AppearanceHeader.Options.UseFont = true;
            this.colMaTram.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaTram.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaTram.Caption = "Thuộc trạm";
            this.colMaTram.ColumnEdit = this.lTram;
            this.colMaTram.FieldName = "MaTram";
            this.colMaTram.Name = "colMaTram";
            this.colMaTram.Visible = true;
            this.colMaTram.VisibleIndex = 1;
            // 
            // lTram
            // 
            this.lTram.AutoHeight = false;
            this.lTram.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lTram.DataSource = this.tramBindingSource;
            this.lTram.DisplayMember = "TenTram";
            this.lTram.Name = "lTram";
            this.lTram.ValueMember = "MaTram";
            // 
            // tramBindingSource
            // 
            this.tramBindingSource.DataMember = "Tram";
            this.tramBindingSource.DataSource = this.cOBAODataSet;
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
            this.btnSuaChua.Location = new System.Drawing.Point(301, 85);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(85, 23);
            this.btnSuaChua.TabIndex = 4;
            this.btnSuaChua.Text = "&Sửa chữa";
            this.btnSuaChua.Click += new System.EventHandler(this.btnSuaChua_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(200, 85);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 23);
            this.btnThemMoi.TabIndex = 3;
            this.btnThemMoi.Text = "&Ghi nhận";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaTrang.Appearance.Options.UseFont = true;
            this.btnXoaTrang.Location = new System.Drawing.Point(400, 85);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(85, 23);
            this.btnXoaTrang.TabIndex = 5;
            this.btnXoaTrang.Text = "Xóa &trắng";
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.cbbMaTram);
            this.panelControl1.Controls.Add(this.txtTenDoi);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.lblTenTram);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(963, 67);
            this.panelControl1.TabIndex = 44;
            // 
            // cbbMaTram
            // 
            this.cbbMaTram.Location = new System.Drawing.Point(273, 10);
            this.cbbMaTram.Name = "cbbMaTram";
            this.cbbMaTram.Properties.Appearance.Options.UseTextOptions = true;
            this.cbbMaTram.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbMaTram.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbbMaTram.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbbMaTram.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.cbbMaTram.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbMaTram.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMaTram.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cbbMaTram.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTram", "Chọn trạm")});
            this.cbbMaTram.Properties.DisplayMember = "TenTram";
            this.cbbMaTram.Properties.NullText = "";
            this.cbbMaTram.Properties.PopupSizeable = false;
            this.cbbMaTram.Properties.ValueMember = "MaTram";
            this.cbbMaTram.Size = new System.Drawing.Size(249, 20);
            this.cbbMaTram.TabIndex = 1;
            // 
            // txtTenDoi
            // 
            this.txtTenDoi.Location = new System.Drawing.Point(273, 36);
            this.txtTenDoi.Name = "txtTenDoi";
            this.txtTenDoi.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTenDoi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenDoi.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTenDoi.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtTenDoi.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtTenDoi.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenDoi.Size = new System.Drawing.Size(398, 20);
            this.txtTenDoi.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(188, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Trạm trực tàu";
            // 
            // lblTenTram
            // 
            this.lblTenTram.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTenTram.Location = new System.Drawing.Point(188, 40);
            this.lblTenTram.Name = "lblTenTram";
            this.lblTenTram.Size = new System.Drawing.Size(41, 13);
            this.lblTenTram.TabIndex = 8;
            this.lblTenTram.Text = "Tên đội";
            // 
            // tramTableAdapter
            // 
            this.tramTableAdapter.ClearBeforeFill = true;
            // 
            // frmDoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 440);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gcDoi);
            this.Controls.Add(this.btnSuaChua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.panelControl1);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmDoi";
            this.Text = "Đội lái tàu";
            this.Load += new System.EventHandler(this.frmDoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOBAODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaTram.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDoi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraGrid.GridControl gcDoi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDoi;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTram;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValid;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit cbbMaTram;
        private DevExpress.XtraEditors.TextEdit txtTenDoi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblTenTram;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDoi;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lTram;
        private DAL.COBAODataSet cOBAODataSet;
        private System.Windows.Forms.BindingSource tramBindingSource;
        private DAL.COBAODataSetTableAdapters.TramTableAdapter tramTableAdapter;
    }
}