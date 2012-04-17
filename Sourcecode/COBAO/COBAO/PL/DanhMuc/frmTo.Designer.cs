namespace COBAO.PL.DanhMuc
{
    partial class frmTo
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
            this.gcTo = new DevExpress.XtraGrid.GridControl();
            this.gvTo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lThuocDoi = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lDoi = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.dxValid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbMaDoi = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTenTo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblTenTram = new DevExpress.XtraEditors.LabelControl();
            this.cOBAODataSet = new COBAO.DAL.COBAODataSet();
            this.doiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doiTableAdapter = new COBAO.DAL.COBAODataSetTableAdapters.DoiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lThuocDoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaDoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOBAODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(647, 85);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 49;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(548, 85);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 48;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gcTo
            // 
            this.gcTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTo.Location = new System.Drawing.Point(12, 114);
            this.gcTo.MainView = this.gvTo;
            this.gcTo.Name = "gcTo";
            this.gcTo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lThuocDoi,
            this.lDoi});
            this.gcTo.Size = new System.Drawing.Size(963, 221);
            this.gcTo.TabIndex = 50;
            this.gcTo.UseEmbeddedNavigator = true;
            this.gcTo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTo});
            // 
            // gvTo
            // 
            this.gvTo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenTo,
            this.colMaDoi});
            this.gvTo.GridControl = this.gcTo;
            this.gvTo.GroupPanelText = " ";
            this.gvTo.Name = "gvTo";
            this.gvTo.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTo.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTo.OptionsBehavior.Editable = false;
            this.gvTo.OptionsBehavior.ReadOnly = true;
            this.gvTo.OptionsView.ShowDetailButtons = false;
            this.gvTo.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvTo_RowClick);
            // 
            // colTenTo
            // 
            this.colTenTo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenTo.AppearanceCell.Options.UseFont = true;
            this.colTenTo.AppearanceCell.Options.UseTextOptions = true;
            this.colTenTo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenTo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenTo.AppearanceHeader.Options.UseFont = true;
            this.colTenTo.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenTo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenTo.Caption = "Tên tổ";
            this.colTenTo.FieldName = "TenTo";
            this.colTenTo.Name = "colTenTo";
            this.colTenTo.Visible = true;
            this.colTenTo.VisibleIndex = 0;
            // 
            // colMaDoi
            // 
            this.colMaDoi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaDoi.AppearanceCell.Options.UseFont = true;
            this.colMaDoi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaDoi.AppearanceHeader.Options.UseFont = true;
            this.colMaDoi.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaDoi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaDoi.Caption = "Thuộc đội";
            this.colMaDoi.ColumnEdit = this.lThuocDoi;
            this.colMaDoi.FieldName = "MaDoi";
            this.colMaDoi.Name = "colMaDoi";
            this.colMaDoi.Visible = true;
            this.colMaDoi.VisibleIndex = 1;
            // 
            // lThuocDoi
            // 
            this.lThuocDoi.AutoHeight = false;
            this.lThuocDoi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lThuocDoi.DataSource = this.doiBindingSource;
            this.lThuocDoi.DisplayMember = "TenDoi";
            this.lThuocDoi.Name = "lThuocDoi";
            this.lThuocDoi.ValueMember = "MaDoi";
            // 
            // lDoi
            // 
            this.lDoi.AutoHeight = false;
            this.lDoi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.lDoi.Name = "lDoi";
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaChua.Appearance.Options.UseFont = true;
            this.btnSuaChua.Location = new System.Drawing.Point(350, 85);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(85, 23);
            this.btnSuaChua.TabIndex = 46;
            this.btnSuaChua.Text = "&Sửa chữa";
            this.btnSuaChua.Click += new System.EventHandler(this.btnSuaChua_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(249, 85);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 23);
            this.btnThemMoi.TabIndex = 45;
            this.btnThemMoi.Text = "&Ghi nhận";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaTrang.Appearance.Options.UseFont = true;
            this.btnXoaTrang.Location = new System.Drawing.Point(449, 85);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(85, 23);
            this.btnXoaTrang.TabIndex = 47;
            this.btnXoaTrang.Text = "Xóa &trắng";
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.cbbMaDoi);
            this.panelControl1.Controls.Add(this.txtTenTo);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.lblTenTram);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(963, 67);
            this.panelControl1.TabIndex = 51;
            // 
            // cbbMaDoi
            // 
            this.cbbMaDoi.Location = new System.Drawing.Point(273, 10);
            this.cbbMaDoi.Name = "cbbMaDoi";
            this.cbbMaDoi.Properties.Appearance.Options.UseTextOptions = true;
            this.cbbMaDoi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbMaDoi.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbbMaDoi.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbbMaDoi.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.cbbMaDoi.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbbMaDoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMaDoi.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cbbMaDoi.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDoi", "Chọn đội")});
            this.cbbMaDoi.Properties.DisplayMember = "TenDoi";
            this.cbbMaDoi.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText;
            this.cbbMaDoi.Properties.PopupSizeable = false;
            this.cbbMaDoi.Properties.ValueMember = "MaDoi";
            this.cbbMaDoi.Size = new System.Drawing.Size(249, 20);
            this.cbbMaDoi.TabIndex = 1;
            // 
            // txtTenTo
            // 
            this.txtTenTo.Location = new System.Drawing.Point(273, 36);
            this.txtTenTo.Name = "txtTenTo";
            this.txtTenTo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTenTo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenTo.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTenTo.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtTenTo.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtTenTo.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenTo.Size = new System.Drawing.Size(412, 20);
            this.txtTenTo.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(188, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Đội lái tàu";
            // 
            // lblTenTram
            // 
            this.lblTenTram.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTenTram.Location = new System.Drawing.Point(188, 40);
            this.lblTenTram.Name = "lblTenTram";
            this.lblTenTram.Size = new System.Drawing.Size(36, 13);
            this.lblTenTram.TabIndex = 8;
            this.lblTenTram.Text = "Tên tổ";
            // 
            // cOBAODataSet
            // 
            this.cOBAODataSet.DataSetName = "COBAODataSet";
            this.cOBAODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doiBindingSource
            // 
            this.doiBindingSource.DataMember = "Doi";
            this.doiBindingSource.DataSource = this.cOBAODataSet;
            // 
            // doiTableAdapter
            // 
            this.doiTableAdapter.ClearBeforeFill = true;
            // 
            // frmTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 440);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gcTo);
            this.Controls.Add(this.btnSuaChua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.panelControl1);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmTo";
            this.Text = "Tổ lái tàu";
            this.Load += new System.EventHandler(this.frmTo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lThuocDoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMaDoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOBAODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraGrid.GridControl gcTo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTo;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lThuocDoi;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValid;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit cbbMaDoi;
        private DevExpress.XtraEditors.TextEdit txtTenTo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblTenTram;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDoi;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit lDoi;
        private DAL.COBAODataSet cOBAODataSet;
        private System.Windows.Forms.BindingSource doiBindingSource;
        private DAL.COBAODataSetTableAdapters.DoiTableAdapter doiTableAdapter;
    }
}