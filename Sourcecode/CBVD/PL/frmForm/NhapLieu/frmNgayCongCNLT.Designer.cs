namespace PL.frmForm.NhapLieu
{
    partial class frmNgayCongCNLT
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
            this.leChungLoai = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaChua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblNgayBatDau = new DevExpress.XtraEditors.LabelControl();
            this.lblTrangThai = new DevExpress.XtraEditors.LabelControl();
            this.lblMaTaiXe = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDonVi = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDonViTheoISO = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDonVi = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.lblTenTaiXe = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.lblSoNgay = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.leChungLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonViTheoISO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // leChungLoai
            // 
            this.leChungLoai.AutoHeight = false;
            this.leChungLoai.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leChungLoai.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenChungLoaiXe", "", 99, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.leChungLoai.DisplayMember = "TenChungLoaiXe";
            this.leChungLoai.Name = "leChungLoai";
            this.leChungLoai.ValueMember = "MaChungLoaiXe";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(559, 173);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "&Thoát";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(460, 173);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "&Xóa";
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaTrang.Appearance.Options.UseFont = true;
            this.btnXoaTrang.Location = new System.Drawing.Point(361, 173);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTrang.TabIndex = 12;
            this.btnXoaTrang.Text = "Xóa &trắng";
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaChua.Appearance.Options.UseFont = true;
            this.btnSuaChua.Location = new System.Drawing.Point(262, 173);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(75, 23);
            this.btnSuaChua.TabIndex = 11;
            this.btnSuaChua.Text = "&Sửa chữa";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(163, 173);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 10;
            this.btnThemMoi.Text = "&Ghi nhận";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.lblSoNgay);
            this.panelControl1.Controls.Add(this.lblNgayBatDau);
            this.panelControl1.Controls.Add(this.lblTrangThai);
            this.panelControl1.Controls.Add(this.lblTenTaiXe);
            this.panelControl1.Controls.Add(this.lblMaTaiXe);
            this.panelControl1.Controls.Add(this.textEdit2);
            this.panelControl1.Controls.Add(this.txtTenDonVi);
            this.panelControl1.Controls.Add(this.txtMaDonViTheoISO);
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this.txtMaDonVi);
            this.panelControl1.Location = new System.Drawing.Point(33, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(724, 132);
            this.panelControl1.TabIndex = 9;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNgayBatDau.Location = new System.Drawing.Point(41, 80);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(74, 13);
            this.lblNgayBatDau.TabIndex = 8;
            this.lblNgayBatDau.Text = "Ngày bắt đầu";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.Location = new System.Drawing.Point(57, 50);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(58, 13);
            this.lblTrangThai.TabIndex = 7;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // lblMaTaiXe
            // 
            this.lblMaTaiXe.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMaTaiXe.Location = new System.Drawing.Point(63, 22);
            this.lblMaTaiXe.Name = "lblMaTaiXe";
            this.lblMaTaiXe.Size = new System.Drawing.Size(52, 13);
            this.lblMaTaiXe.TabIndex = 6;
            this.lblMaTaiXe.Text = "Mã tài xế";
            // 
            // txtTenDonVi
            // 
            this.txtTenDonVi.Location = new System.Drawing.Point(130, 77);
            this.txtTenDonVi.Name = "txtTenDonVi";
            this.txtTenDonVi.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTenDonVi.Properties.Appearance.Options.UseBackColor = true;
            this.txtTenDonVi.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTenDonVi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenDonVi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.txtTenDonVi.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTenDonVi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtTenDonVi.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtTenDonVi.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtTenDonVi.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenDonVi.Properties.MaxLength = 250;
            this.txtTenDonVi.Size = new System.Drawing.Size(127, 20);
            this.txtTenDonVi.TabIndex = 3;
            // 
            // txtMaDonViTheoISO
            // 
            this.txtMaDonViTheoISO.EditValue = "";
            this.txtMaDonViTheoISO.Location = new System.Drawing.Point(130, 47);
            this.txtMaDonViTheoISO.Name = "txtMaDonViTheoISO";
            this.txtMaDonViTheoISO.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtMaDonViTheoISO.Properties.Appearance.Options.UseBackColor = true;
            this.txtMaDonViTheoISO.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaDonViTheoISO.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaDonViTheoISO.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.txtMaDonViTheoISO.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtMaDonViTheoISO.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtMaDonViTheoISO.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtMaDonViTheoISO.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtMaDonViTheoISO.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaDonViTheoISO.Properties.MaxLength = 5;
            this.txtMaDonViTheoISO.Size = new System.Drawing.Size(127, 20);
            this.txtMaDonViTheoISO.TabIndex = 2;
            // 
            // txtMaDonVi
            // 
            this.txtMaDonVi.EditValue = "";
            this.txtMaDonVi.Location = new System.Drawing.Point(130, 19);
            this.txtMaDonVi.Name = "txtMaDonVi";
            this.txtMaDonVi.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtMaDonVi.Properties.Appearance.Options.UseBackColor = true;
            this.txtMaDonVi.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaDonVi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaDonVi.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaDonVi.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtMaDonVi.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtMaDonVi.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtMaDonVi.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtMaDonVi.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtMaDonVi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.txtMaDonVi.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtMaDonVi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtMaDonVi.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtMaDonVi.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtMaDonVi.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaDonVi.Properties.MaxLength = 5;
            this.txtMaDonVi.Size = new System.Drawing.Size(127, 20);
            this.txtMaDonVi.TabIndex = 1;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "";
            this.textEdit1.Location = new System.Drawing.Point(474, 19);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit1.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro;
            this.textEdit1.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.textEdit1.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.textEdit1.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textEdit1.Properties.AppearanceDisabled.Options.UseFont = true;
            this.textEdit1.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.textEdit1.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.textEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textEdit1.Properties.AppearanceFocused.Options.UseFont = true;
            this.textEdit1.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.textEdit1.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit1.Properties.MaxLength = 5;
            this.textEdit1.Size = new System.Drawing.Size(127, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // lblTenTaiXe
            // 
            this.lblTenTaiXe.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTenTaiXe.Location = new System.Drawing.Point(389, 22);
            this.lblTenTaiXe.Name = "lblTenTaiXe";
            this.lblTenTaiXe.Size = new System.Drawing.Size(56, 13);
            this.lblTenTaiXe.TabIndex = 6;
            this.lblTenTaiXe.Text = "Tên tài xế";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(130, 107);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.textEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit2.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.textEdit2.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.textEdit2.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.textEdit2.Properties.AppearanceFocused.Options.UseFont = true;
            this.textEdit2.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.textEdit2.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit2.Properties.MaxLength = 250;
            this.textEdit2.Size = new System.Drawing.Size(127, 20);
            this.textEdit2.TabIndex = 3;
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSoNgay.Location = new System.Drawing.Point(70, 110);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(45, 13);
            this.lblSoNgay.TabIndex = 8;
            this.lblSoNgay.Text = "Số ngày";
            // 
            // frmNgayCongCNLT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 410);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnSuaChua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmNgayCongCNLT";
            this.Text = "NGÀY CÔNG CÔNG NHÂN LÁI TÀU";
            ((System.ComponentModel.ISupportInitialize)(this.leChungLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonViTheoISO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit leChungLoai;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnXoaTrang;
        private DevExpress.XtraEditors.SimpleButton btnSuaChua;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblNgayBatDau;
        private DevExpress.XtraEditors.LabelControl lblTrangThai;
        private DevExpress.XtraEditors.LabelControl lblMaTaiXe;
        private DevExpress.XtraEditors.TextEdit txtTenDonVi;
        private DevExpress.XtraEditors.TextEdit txtMaDonViTheoISO;
        private DevExpress.XtraEditors.TextEdit txtMaDonVi;
        private DevExpress.XtraEditors.LabelControl lblTenTaiXe;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl lblSoNgay;
        private DevExpress.XtraEditors.TextEdit textEdit2;
    }
}