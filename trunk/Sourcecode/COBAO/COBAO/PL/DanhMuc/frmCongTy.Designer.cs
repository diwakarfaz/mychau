namespace COBAO.PL.DanhMuc
{
    partial class frmCongTy
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
            this.gvCongTy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenCongTy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCongTy = new DevExpress.XtraGrid.GridControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenCT = new DevExpress.XtraEditors.TextEdit();
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.lblTenCT = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dxValid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvCongTy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCongTy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(645, 59);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 41;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gvCongTy
            // 
            this.gvCongTy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenCongTy});
            this.gvCongTy.GridControl = this.gcCongTy;
            this.gvCongTy.GroupPanelText = " ";
            this.gvCongTy.Name = "gvCongTy";
            this.gvCongTy.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCongTy.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCongTy.OptionsBehavior.Editable = false;
            this.gvCongTy.OptionsBehavior.ReadOnly = true;
            this.gvCongTy.OptionsView.ShowDetailButtons = false;
            this.gvCongTy.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCongTy_RowClick);
            // 
            // colTenCongTy
            // 
            this.colTenCongTy.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenCongTy.AppearanceCell.Options.UseFont = true;
            this.colTenCongTy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenCongTy.AppearanceHeader.Options.UseFont = true;
            this.colTenCongTy.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenCongTy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenCongTy.Caption = "Tên công ty";
            this.colTenCongTy.FieldName = "TenCT";
            this.colTenCongTy.Name = "colTenCongTy";
            this.colTenCongTy.Visible = true;
            this.colTenCongTy.VisibleIndex = 0;
            // 
            // gcCongTy
            // 
            this.gcCongTy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcCongTy.Location = new System.Drawing.Point(12, 88);
            this.gcCongTy.MainView = this.gvCongTy;
            this.gcCongTy.Name = "gcCongTy";
            this.gcCongTy.Size = new System.Drawing.Size(963, 221);
            this.gcCongTy.TabIndex = 42;
            this.gcCongTy.UseEmbeddedNavigator = true;
            this.gcCongTy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCongTy});
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(546, 59);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaChua.Appearance.Options.UseFont = true;
            this.btnSuaChua.Location = new System.Drawing.Point(348, 59);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(85, 23);
            this.btnSuaChua.TabIndex = 38;
            this.btnSuaChua.Text = "&Sửa chữa";
            this.btnSuaChua.Click += new System.EventHandler(this.btnSuaChua_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(247, 59);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 23);
            this.btnThemMoi.TabIndex = 37;
            this.btnThemMoi.Text = "&Ghi nhận";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // txtTenCT
            // 
            this.txtTenCT.Location = new System.Drawing.Point(277, 11);
            this.txtTenCT.Name = "txtTenCT";
            this.txtTenCT.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTenCT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenCT.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTenCT.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtTenCT.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtTenCT.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenCT.Size = new System.Drawing.Size(412, 20);
            this.txtTenCT.TabIndex = 1;
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaTrang.Appearance.Options.UseFont = true;
            this.btnXoaTrang.Location = new System.Drawing.Point(447, 59);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(85, 23);
            this.btnXoaTrang.TabIndex = 39;
            this.btnXoaTrang.Text = "Xóa &trắng";
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // lblTenCT
            // 
            this.lblTenCT.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTenCT.Location = new System.Drawing.Point(205, 14);
            this.lblTenCT.Name = "lblTenCT";
            this.lblTenCT.Size = new System.Drawing.Size(66, 13);
            this.lblTenCT.TabIndex = 8;
            this.lblTenCT.Text = "Tên công ty";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.txtTenCT);
            this.panelControl1.Controls.Add(this.lblTenCT);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(963, 41);
            this.panelControl1.TabIndex = 43;
            // 
            // frmCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 432);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gcCongTy);
            this.Controls.Add(this.btnSuaChua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.panelControl1);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmCongTy";
            this.Text = "Công ty";
            this.Load += new System.EventHandler(this.frmCongTy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCongTy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCongTy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCongTy;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCongTy;
        private DevExpress.XtraGrid.GridControl gcCongTy;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.TextEdit txtTenCT;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.LabelControl lblTenCT;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValid;
    }
}