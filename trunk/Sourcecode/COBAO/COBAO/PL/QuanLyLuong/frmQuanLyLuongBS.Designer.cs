namespace COBAO.PL.QuanLyLuong
{
    partial class frmQuanLyLuongBS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyLuongBS));
            this.lblLoaiA = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayThayDoi = new DevExpress.XtraEditors.DateEdit();
            this.txtDonGiaMoi = new DevExpress.XtraEditors.TextEdit();
            this.donGiaLuongXLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOBAODataSet = new COBAO.DAL.COBAODataSet();
            this.colLoaiAMoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.colLoaiBMoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThuNguyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.colNgayThayDoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.donGiaLuongXLTableAdapter = new COBAO.DAL.COBAODataSetTableAdapters.DonGiaLuongXLTableAdapter();
            this.im = new DevExpress.Utils.ImageCollection(this.components);
            this.colXoaLuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoaLuoi = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.lDonGiaXL = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.txtDonViTinh = new DevExpress.XtraEditors.TextEdit();
            this.colMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtNgayNhap = new DevExpress.XtraEditors.DateEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblSoCoBao = new DevExpress.XtraEditors.LabelControl();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMoTa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gvDonGiaXL = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDonGiaXL = new DevExpress.XtraGrid.GridControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.dxValid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayThayDoi.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayThayDoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGiaMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaLuongXLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOBAODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.im)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoaLuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDonGiaXL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayNhap.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDonGiaXL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDonGiaXL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoaiA
            // 
            this.lblLoaiA.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblLoaiA.Location = new System.Drawing.Point(5, 57);
            this.lblLoaiA.Name = "lblLoaiA";
            this.lblLoaiA.Size = new System.Drawing.Size(43, 13);
            this.lblLoaiA.TabIndex = 8;
            this.lblLoaiA.Text = "Đơn giá";
            // 
            // dtNgayThayDoi
            // 
            this.dtNgayThayDoi.EditValue = null;
            this.dtNgayThayDoi.Location = new System.Drawing.Point(85, 81);
            this.dtNgayThayDoi.Name = "dtNgayThayDoi";
            this.dtNgayThayDoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayThayDoi.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtNgayThayDoi.Size = new System.Drawing.Size(216, 20);
            this.dtNgayThayDoi.TabIndex = 6;
            // 
            // txtDonGiaMoi
            // 
            this.txtDonGiaMoi.Location = new System.Drawing.Point(85, 53);
            this.txtDonGiaMoi.Name = "txtDonGiaMoi";
            this.txtDonGiaMoi.Size = new System.Drawing.Size(216, 20);
            this.txtDonGiaMoi.TabIndex = 2;
            // 
            // donGiaLuongXLBindingSource
            // 
            this.donGiaLuongXLBindingSource.DataMember = "DonGiaLuongXL";
            this.donGiaLuongXLBindingSource.DataSource = this.cOBAODataSet;
            // 
            // cOBAODataSet
            // 
            this.cOBAODataSet.DataSetName = "COBAODataSet";
            this.cOBAODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colLoaiAMoi
            // 
            this.colLoaiAMoi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colLoaiAMoi.AppearanceHeader.Options.UseFont = true;
            this.colLoaiAMoi.AppearanceHeader.Options.UseTextOptions = true;
            this.colLoaiAMoi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoaiAMoi.Caption = "Loại A";
            this.colLoaiAMoi.FieldName = "LoaiAMoi";
            this.colLoaiAMoi.Name = "colLoaiAMoi";
            this.colLoaiAMoi.OptionsColumn.AllowEdit = false;
            this.colLoaiAMoi.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colLoaiAMoi.OptionsColumn.ReadOnly = true;
            this.colLoaiAMoi.Visible = true;
            this.colLoaiAMoi.VisibleIndex = 1;
            this.colLoaiAMoi.Width = 215;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Location = new System.Drawing.Point(4, 85);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(80, 13);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Ngày cập nhật";
            // 
            // colLoaiBMoi
            // 
            this.colLoaiBMoi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colLoaiBMoi.AppearanceHeader.Options.UseFont = true;
            this.colLoaiBMoi.AppearanceHeader.Options.UseTextOptions = true;
            this.colLoaiBMoi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoaiBMoi.Caption = "Loại B";
            this.colLoaiBMoi.FieldName = "LoaiBMoi";
            this.colLoaiBMoi.Name = "colLoaiBMoi";
            this.colLoaiBMoi.OptionsColumn.AllowEdit = false;
            this.colLoaiBMoi.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colLoaiBMoi.OptionsColumn.ReadOnly = true;
            this.colLoaiBMoi.Visible = true;
            this.colLoaiBMoi.VisibleIndex = 2;
            this.colLoaiBMoi.Width = 215;
            // 
            // colThuNguyen
            // 
            this.colThuNguyen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colThuNguyen.AppearanceHeader.Options.UseFont = true;
            this.colThuNguyen.AppearanceHeader.Options.UseTextOptions = true;
            this.colThuNguyen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colThuNguyen.Caption = "Loại C";
            this.colThuNguyen.FieldName = "LoaiCMoi";
            this.colThuNguyen.Name = "colThuNguyen";
            this.colThuNguyen.OptionsColumn.AllowEdit = false;
            this.colThuNguyen.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colThuNguyen.OptionsColumn.ReadOnly = true;
            this.colThuNguyen.Visible = true;
            this.colThuNguyen.VisibleIndex = 3;
            this.colThuNguyen.Width = 204;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(579, 158);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 61;
            this.btnThoat.Text = "&Thoát";
            // 
            // colNgayThayDoi
            // 
            this.colNgayThayDoi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNgayThayDoi.AppearanceHeader.Options.UseFont = true;
            this.colNgayThayDoi.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgayThayDoi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayThayDoi.Caption = "Ngày cập nhật";
            this.colNgayThayDoi.FieldName = "NgayThayDoi";
            this.colNgayThayDoi.Name = "colNgayThayDoi";
            this.colNgayThayDoi.OptionsColumn.AllowEdit = false;
            this.colNgayThayDoi.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNgayThayDoi.OptionsColumn.ReadOnly = true;
            this.colNgayThayDoi.Visible = true;
            this.colNgayThayDoi.VisibleIndex = 4;
            this.colNgayThayDoi.Width = 145;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // donGiaLuongXLTableAdapter
            // 
            this.donGiaLuongXLTableAdapter.ClearBeforeFill = true;
            // 
            // im
            // 
            this.im.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("im.ImageStream")));
            this.im.Images.SetKeyName(0, "add.png");
            this.im.Images.SetKeyName(1, "cross.png");
            this.im.Images.SetKeyName(2, "Save.png");
            this.im.Images.SetKeyName(3, "viewer.png");
            // 
            // colXoaLuoi
            // 
            this.colXoaLuoi.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.colXoaLuoi.AppearanceHeader.Options.UseForeColor = true;
            this.colXoaLuoi.AppearanceHeader.Options.UseTextOptions = true;
            this.colXoaLuoi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXoaLuoi.Caption = "Xóa";
            this.colXoaLuoi.ColumnEdit = this.btnXoaLuoi;
            this.colXoaLuoi.FieldName = "ButtonColumn";
            this.colXoaLuoi.ImageIndex = 1;
            this.colXoaLuoi.Name = "colXoaLuoi";
            this.colXoaLuoi.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colXoaLuoi.Visible = true;
            this.colXoaLuoi.VisibleIndex = 5;
            this.colXoaLuoi.Width = 104;
            // 
            // btnXoaLuoi
            // 
            this.btnXoaLuoi.AutoHeight = false;
            this.btnXoaLuoi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.btnXoaLuoi.Name = "btnXoaLuoi";
            this.btnXoaLuoi.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(97, 158);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(99, 23);
            this.btnThemMoi.TabIndex = 57;
            this.btnThemMoi.Text = "&Thêm mới";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(462, 158);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 60;
            this.btnXoa.Text = "&Xóa";
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaTrang.Appearance.Options.UseFont = true;
            this.btnXoaTrang.Location = new System.Drawing.Point(345, 158);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(85, 23);
            this.btnXoaTrang.TabIndex = 59;
            this.btnXoaTrang.Text = "Xóa &trắng";
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaChua.Appearance.Options.UseFont = true;
            this.btnSuaChua.Location = new System.Drawing.Point(228, 158);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(85, 23);
            this.btnSuaChua.TabIndex = 58;
            this.btnSuaChua.Text = "&Thay đổi giá";
            // 
            // lDonGiaXL
            // 
            this.lDonGiaXL.AutoHeight = false;
            this.lDonGiaXL.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lDonGiaXL.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenThongSoKTV", "Tên thông số - Việt", 97, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lDonGiaXL.DataSource = this.donGiaLuongXLBindingSource;
            this.lDonGiaXL.DisplayMember = "MoTa";
            this.lDonGiaXL.LookAndFeel.SkinName = "Blue";
            this.lDonGiaXL.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lDonGiaXL.Name = "lDonGiaXL";
            this.lDonGiaXL.ValueMember = "MaLuongXL";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.EditValue = "VNĐ/Loại";
            this.txtDonViTinh.Location = new System.Drawing.Point(85, 81);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(216, 20);
            this.txtDonViTinh.TabIndex = 5;
            // 
            // colMoTa
            // 
            this.colMoTa.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMoTa.AppearanceCell.Options.UseFont = true;
            this.colMoTa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMoTa.AppearanceHeader.Options.UseFont = true;
            this.colMoTa.AppearanceHeader.Options.UseTextOptions = true;
            this.colMoTa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMoTa.Caption = "Hạng giá";
            this.colMoTa.ColumnEdit = this.lDonGiaXL;
            this.colMoTa.FieldName = "MaLuongXL";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.OptionsColumn.AllowEdit = false;
            this.colMoTa.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMoTa.OptionsColumn.ReadOnly = true;
            this.colMoTa.Visible = true;
            this.colMoTa.VisibleIndex = 0;
            this.colMoTa.Width = 208;
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.EditValue = null;
            this.dtNgayNhap.Location = new System.Drawing.Point(85, 109);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayNhap.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtNgayNhap.Size = new System.Drawing.Size(216, 20);
            this.dtNgayNhap.TabIndex = 6;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dtNgayNhap);
            this.groupControl2.Controls.Add(this.lblSoCoBao);
            this.groupControl2.Controls.Add(this.txtDonViTinh);
            this.groupControl2.Controls.Add(this.txtDonGia);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtMoTa);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.lblLoaiA);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(315, 140);
            this.groupControl2.TabIndex = 54;
            this.groupControl2.Text = "Thông tin đơn giá";
            // 
            // lblSoCoBao
            // 
            this.lblSoCoBao.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSoCoBao.Location = new System.Drawing.Point(5, 29);
            this.lblSoCoBao.Name = "lblSoCoBao";
            this.lblSoCoBao.Size = new System.Drawing.Size(43, 13);
            this.lblSoCoBao.TabIndex = 6;
            this.lblSoCoBao.Text = "Loại giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(85, 53);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(216, 20);
            this.txtDonGia.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(5, 85);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Đơn vị tính";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(85, 25);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(216, 20);
            this.txtMoTa.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(5, 113);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Ngày nhập";
            // 
            // gvDonGiaXL
            // 
            this.gvDonGiaXL.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMoTa,
            this.colLoaiAMoi,
            this.colLoaiBMoi,
            this.colThuNguyen,
            this.colNgayThayDoi,
            this.colXoaLuoi});
            this.gvDonGiaXL.GridControl = this.gcDonGiaXL;
            this.gvDonGiaXL.GroupPanelText = " ";
            this.gvDonGiaXL.Images = this.im;
            this.gvDonGiaXL.Name = "gvDonGiaXL";
            this.gvDonGiaXL.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvDonGiaXL.OptionsBehavior.ReadOnly = true;
            this.gvDonGiaXL.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gvDonGiaXL.OptionsView.ShowDetailButtons = false;
            this.gvDonGiaXL.OptionsView.ShowFooter = true;
            this.gvDonGiaXL.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMoTa, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // gcDonGiaXL
            // 
            this.gcDonGiaXL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDonGiaXL.Location = new System.Drawing.Point(12, 187);
            this.gcDonGiaXL.LookAndFeel.SkinName = "Money Twins";
            this.gcDonGiaXL.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gcDonGiaXL.MainView = this.gvDonGiaXL;
            this.gcDonGiaXL.Name = "gcDonGiaXL";
            this.gcDonGiaXL.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.lDonGiaXL,
            this.btnXoaLuoi});
            this.gcDonGiaXL.Size = new System.Drawing.Size(947, 321);
            this.gcDonGiaXL.TabIndex = 56;
            this.gcDonGiaXL.UseEmbeddedNavigator = true;
            this.gcDonGiaXL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDonGiaXL});
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Location = new System.Drawing.Point(4, 57);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(67, 13);
            this.labelControl10.TabIndex = 8;
            this.labelControl10.Text = "Đơn giá mới";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dtNgayThayDoi);
            this.groupControl1.Controls.Add(this.txtDonGiaMoi);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Location = new System.Drawing.Point(345, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(315, 140);
            this.groupControl1.TabIndex = 55;
            this.groupControl1.Text = "Thay đổi giá";
            // 
            // frmQuanLyLuongBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 592);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnSuaChua);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gcDonGiaXL);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmQuanLyLuongBS";
            this.Text = "Quản lý đơn giá lương bổ sung";
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayThayDoi.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayThayDoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGiaMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaLuongXLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOBAODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.im)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoaLuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDonGiaXL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayNhap.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDonGiaXL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDonGiaXL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblLoaiA;
        private DevExpress.XtraEditors.DateEdit dtNgayThayDoi;
        private DevExpress.XtraEditors.TextEdit txtDonGiaMoi;
        private System.Windows.Forms.BindingSource donGiaLuongXLBindingSource;
        private DAL.COBAODataSet cOBAODataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiAMoi;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiBMoi;
        private DevExpress.XtraGrid.Columns.GridColumn colThuNguyen;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayThayDoi;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DAL.COBAODataSetTableAdapters.DonGiaLuongXLTableAdapter donGiaLuongXLTableAdapter;
        private DevExpress.Utils.ImageCollection im;
        private DevExpress.XtraGrid.Columns.GridColumn colXoaLuoi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoaLuoi;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lDonGiaXL;
        private DevExpress.XtraEditors.TextEdit txtDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colMoTa;
        private DevExpress.XtraEditors.DateEdit dtNgayNhap;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl lblSoCoBao;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtMoTa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDonGiaXL;
        private DevExpress.XtraGrid.GridControl gcDonGiaXL;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValid;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}