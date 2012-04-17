using System;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using COBAO.BLL;
using COBAO.PL.NhapLieu;
using COBAO.PL.DanhMuc;
using COBAO.PL.HeThong;

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

        private void btnThuongTruc_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmThuongTruc());
        }

        private void btnKhamXet_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmKhamXet());
        }

        private void btnNgayCongCNLT_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmNgayCong());
        }

        private void btnCNLT_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmTaiXe());
        }

        private void btnGa_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmGa());           
        }

        private void btnLoaiDM_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmLoaiDauMay());
        }

        private void btnDM_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmDauMay());
        }

        private void btnMacTau_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmMacTau());
        }

        private void btnCT_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmCongTy());
        }

        private void btnCoBao_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmCoBao());
        }

        private void btnTram_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmTram());
        }

        private void btnDoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmDoi());
        }

        private void btnTo_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmTo());
        }

        private void btnQuanLyNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmQuanLyNguoiDung());
        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {

        }


    
    }
}