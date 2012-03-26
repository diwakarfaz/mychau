namespace PL.frmForm
{
    partial class frmMain
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnCoBao = new DevExpress.XtraBars.BarButtonItem();
            this.btnThuongTruc = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhamXet = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCNLT = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grpNhapLieu1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grpTimTiem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grpBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grpDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage7 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage8 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonText = null;
            // 
            // 
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnCoBao,
            this.btnThuongTruc,
            this.btnKhamXet,
            this.barButtonItem2,
            this.btnCNLT});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage7,
            this.ribbonPage8,
            this.ribbonPage5});
            this.ribbon.SelectedPage = this.ribbonPage1;
            this.ribbon.Size = new System.Drawing.Size(890, 145);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnCoBao
            // 
            this.btnCoBao.Caption = "Cơ báo";
            this.btnCoBao.Id = 1;
            this.btnCoBao.Name = "btnCoBao";
            // 
            // btnThuongTruc
            // 
            this.btnThuongTruc.Caption = "Thường trực";
            this.btnThuongTruc.Id = 2;
            this.btnThuongTruc.Name = "btnThuongTruc";
            // 
            // btnKhamXet
            // 
            this.btnKhamXet.Caption = "Khám xét";
            this.btnKhamXet.Id = 3;
            this.btnKhamXet.Name = "btnKhamXet";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnCNLT
            // 
            this.btnCNLT.Caption = "Ngày công CNLT";
            this.btnCNLT.Id = 6;
            this.btnCNLT.Name = "btnCNLT";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.grpNhapLieu1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "NHẬP LIỆU";
            // 
            // grpNhapLieu1
            // 
            this.grpNhapLieu1.ItemLinks.Add(this.btnCoBao);
            this.grpNhapLieu1.ItemLinks.Add(this.btnThuongTruc);
            this.grpNhapLieu1.ItemLinks.Add(this.btnKhamXet);
            this.grpNhapLieu1.ItemLinks.Add(this.btnCNLT);
            this.grpNhapLieu1.Name = "grpNhapLieu1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.grpTimTiem});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "TÌM KIẾM";
            // 
            // grpTimTiem
            // 
            this.grpTimTiem.Name = "grpTimTiem";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.grpBaoCao});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "BÁO CÁO - THỐNG KÊ";
            // 
            // grpBaoCao
            // 
            this.grpBaoCao.Name = "grpBaoCao";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.grpDanhMuc});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "DANH MỤC";
            // 
            // grpDanhMuc
            // 
            this.grpDanhMuc.Name = "grpDanhMuc";
            // 
            // ribbonPage7
            // 
            this.ribbonPage7.Name = "ribbonPage7";
            this.ribbonPage7.Text = "QUẢN LÝ NGƯỜI DÙNG";
            // 
            // ribbonPage8
            // 
            this.ribbonPage8.Name = "ribbonPage8";
            this.ribbonPage8.Text = "QUẢN LÝ LƯƠNG";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "HỆ THỐNG";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 668);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(890, 31);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 699);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Chương trình nhập cơ báo và tính lương khoán chuyến cho công nhân lái tàu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grpNhapLieu1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnCoBao;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grpTimTiem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage8;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.BarButtonItem btnThuongTruc;
        private DevExpress.XtraBars.BarButtonItem btnKhamXet;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grpBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grpDanhMuc;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnCNLT;
    }
}