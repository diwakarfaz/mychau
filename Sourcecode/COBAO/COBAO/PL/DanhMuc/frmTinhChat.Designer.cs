namespace COBAO.PL.DanhMuc
{
    partial class frmTinhChat
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtTenTinhChat = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTinhChat = new DevExpress.XtraEditors.TextEdit();
            this.lblTenGa = new DevExpress.XtraEditors.LabelControl();
            this.lblMaGa = new DevExpress.XtraEditors.LabelControl();
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.colTenTinhChat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.colMaTinhChay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.gvTinhChat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcTinhChat = new DevExpress.XtraGrid.GridControl();
            this.dxValid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTinhChat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTinhChat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTinhChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTinhChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.txtTenTinhChat);
            this.panelControl1.Controls.Add(this.txtMaTinhChat);
            this.panelControl1.Controls.Add(this.lblTenGa);
            this.panelControl1.Controls.Add(this.lblMaGa);
            this.panelControl1.Location = new System.Drawing.Point(23, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(963, 41);
            this.panelControl1.TabIndex = 29;
            // 
            // txtTenTinhChat
            // 
            this.txtTenTinhChat.Location = new System.Drawing.Point(438, 10);
            this.txtTenTinhChat.Name = "txtTenTinhChat";
            this.txtTenTinhChat.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTenTinhChat.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenTinhChat.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTenTinhChat.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtTenTinhChat.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtTenTinhChat.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenTinhChat.Size = new System.Drawing.Size(230, 20);
            this.txtTenTinhChat.TabIndex = 2;
            // 
            // txtMaTinhChat
            // 
            this.txtMaTinhChat.Location = new System.Drawing.Point(81, 10);
            this.txtMaTinhChat.Name = "txtMaTinhChat";
            this.txtMaTinhChat.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaTinhChat.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaTinhChat.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtMaTinhChat.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtMaTinhChat.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtMaTinhChat.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaTinhChat.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaTinhChat.Properties.MaxLength = 5;
            this.txtMaTinhChat.Size = new System.Drawing.Size(230, 20);
            this.txtMaTinhChat.TabIndex = 1;
            // 
            // lblTenGa
            // 
            this.lblTenGa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTenGa.Location = new System.Drawing.Point(358, 14);
            this.lblTenGa.Name = "lblTenGa";
            this.lblTenGa.Size = new System.Drawing.Size(74, 13);
            this.lblTenGa.TabIndex = 7;
            this.lblTenGa.Text = "Tên tính chất";
            // 
            // lblMaGa
            // 
            this.lblMaGa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMaGa.Location = new System.Drawing.Point(5, 14);
            this.lblMaGa.Name = "lblMaGa";
            this.lblMaGa.Size = new System.Drawing.Size(70, 13);
            this.lblMaGa.TabIndex = 6;
            this.lblMaGa.Text = "Mã tính chất";
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaTrang.Appearance.Options.UseFont = true;
            this.btnXoaTrang.Location = new System.Drawing.Point(354, 68);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(85, 23);
            this.btnXoaTrang.TabIndex = 5;
            this.btnXoaTrang.Text = "Xóa &trắng";
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // colTenTinhChat
            // 
            this.colTenTinhChat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenTinhChat.AppearanceHeader.Options.UseFont = true;
            this.colTenTinhChat.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenTinhChat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenTinhChat.Caption = "Tên tính chất";
            this.colTenTinhChat.FieldName = "TenTinhChat";
            this.colTenTinhChat.Name = "colTenTinhChat";
            this.colTenTinhChat.Visible = true;
            this.colTenTinhChat.VisibleIndex = 1;
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaChua.Appearance.Options.UseFont = true;
            this.btnSuaChua.Location = new System.Drawing.Point(229, 68);
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
            this.btnThemMoi.Location = new System.Drawing.Point(104, 68);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 23);
            this.btnThemMoi.TabIndex = 3;
            this.btnThemMoi.Text = "&Ghi nhận";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // colMaTinhChay
            // 
            this.colMaTinhChay.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaTinhChay.AppearanceCell.Options.UseFont = true;
            this.colMaTinhChay.AppearanceCell.Options.UseTextOptions = true;
            this.colMaTinhChay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaTinhChay.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaTinhChay.AppearanceHeader.Options.UseFont = true;
            this.colMaTinhChay.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaTinhChay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaTinhChay.Caption = "Mã tính chất";
            this.colMaTinhChay.FieldName = "MaTinhChat";
            this.colMaTinhChay.Name = "colMaTinhChay";
            this.colMaTinhChay.Visible = true;
            this.colMaTinhChay.VisibleIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(604, 68);
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
            this.btnXoa.Location = new System.Drawing.Point(479, 68);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gvTinhChat
            // 
            this.gvTinhChat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTinhChay,
            this.colTenTinhChat});
            this.gvTinhChat.GridControl = this.gcTinhChat;
            this.gvTinhChat.GroupPanelText = " ";
            this.gvTinhChat.Name = "gvTinhChat";
            this.gvTinhChat.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTinhChat.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTinhChat.OptionsBehavior.Editable = false;
            this.gvTinhChat.OptionsBehavior.ReadOnly = true;
            this.gvTinhChat.OptionsView.ShowDetailButtons = false;
            this.gvTinhChat.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvTinhChat_RowClick);
            // 
            // gcTinhChat
            // 
            this.gcTinhChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTinhChat.Location = new System.Drawing.Point(23, 102);
            this.gcTinhChat.MainView = this.gvTinhChat;
            this.gcTinhChat.Name = "gcTinhChat";
            this.gcTinhChat.Size = new System.Drawing.Size(963, 200);
            this.gcTinhChat.TabIndex = 8;
            this.gcTinhChat.UseEmbeddedNavigator = true;
            this.gcTinhChat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTinhChat});
            // 
            // frmTinhChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 322);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnSuaChua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gcTinhChat);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmTinhChat";
            this.Text = "Tính chất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTinhChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTinhChat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTinhChat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTinhChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTinhChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenTinhChat;
        private DevExpress.XtraEditors.TextEdit txtMaTinhChat;
        private DevExpress.XtraEditors.LabelControl lblTenGa;
        private DevExpress.XtraEditors.LabelControl lblMaGa;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTinhChat;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTinhChay;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTinhChat;
        private DevExpress.XtraGrid.GridControl gcTinhChat;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValid;
    }
}