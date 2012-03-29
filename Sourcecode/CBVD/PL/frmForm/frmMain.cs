using System;
using DevExpress.XtraBars;
using PL.frmForm.NhapLieu;
using PL.frmForm.DanhMuc;
using PL.Utility;
using BLL.Utility;
using DevExpress.XtraBars.Ribbon;

namespace PL.frmForm
{
    public partial class frmMain : RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //using (frmDangNhap fdn = new frmDangNhap())
            //{
            //    fdn.ShowDialog();
            //}
        }

        private void btnNgayCongCNLT_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmNgayCongCNLT());
        }

        private void btnThuongTruc_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmThuongTruc());            
        }

        private void btnKhamXet_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmKhamXet());
        }

        private void btnCNLT_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmCNLT());
        }

        private void btnGa_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmGa());
        }

        private void btnLoaiDM_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmLoaiDM());
        }

        private void btnDM_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmDauMay());
        }

        private void btnCT_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmCongTy());
        }

        private void btnMacTau_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmMacTau());
        }

        private void btnCoBao_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmCoBao());
        }

    
    }
}