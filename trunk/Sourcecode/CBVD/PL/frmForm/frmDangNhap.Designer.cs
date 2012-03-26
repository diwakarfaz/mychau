namespace PL.frmForm
{
    partial class frmDangNhap
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
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblPass = new DevExpress.XtraEditors.LabelControl();
            this.lblUseName = new DevExpress.XtraEditors.LabelControl();
            this.txtMaDonViTheoISO = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDonVi = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonViTheoISO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonVi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(150, 116);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "&Thoát";
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Location = new System.Drawing.Point(28, 116);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 23);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "&Đăng nhập";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblPass);
            this.panelControl1.Controls.Add(this.lblUseName);
            this.panelControl1.Controls.Add(this.txtMaDonViTheoISO);
            this.panelControl1.Controls.Add(this.txtMaDonVi);
            this.panelControl1.Location = new System.Drawing.Point(20, 9);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(354, 101);
            this.panelControl1.TabIndex = 12;
            // 
            // lblPass
            // 
            this.lblPass.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPass.Location = new System.Drawing.Point(52, 50);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "Mật khẩu";
            // 
            // lblUseName
            // 
            this.lblUseName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUseName.Location = new System.Drawing.Point(22, 22);
            this.lblUseName.Name = "lblUseName";
            this.lblUseName.Size = new System.Drawing.Size(83, 13);
            this.lblUseName.TabIndex = 6;
            this.lblUseName.Text = "Tên đăng nhập";
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
            this.txtMaDonViTheoISO.Size = new System.Drawing.Size(172, 20);
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
            this.txtMaDonVi.Size = new System.Drawing.Size(172, 20);
            this.txtMaDonVi.TabIndex = 1;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 162);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonViTheoISO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDonVi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblPass;
        private DevExpress.XtraEditors.LabelControl lblUseName;
        private DevExpress.XtraEditors.TextEdit txtMaDonViTheoISO;
        private DevExpress.XtraEditors.TextEdit txtMaDonVi;
    }
}