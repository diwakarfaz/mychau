using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using COBAO.BLL;
using COBAO.PL.DanhMuc;
using COBAO.PL.NhapLieu;
using COBAO.PL.HeThong;
using COBAO.PL.QuanLyLuong;
using COBAO.PL.BaoCao;

namespace COBAO.PL
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            if (COBAOMessage.nhanvien.MaNV.Length > 0)
            {
                //if (NhanVienProvider.ChucDanh.Equals("Quản lý"))
                //{
                //    btnCNLT.Enabled = false;
                //}
                if (COBAOMessage.nhanvien.ChucDanh.Equals("Nhân viên"))
                {
                    btnQuanLyNguoiDung.Enabled = false;
                    btnSaoLuuDL.Enabled = false;
                    btnPhucHoiDL.Enabled = false;
                }
                //toolStripStatusLabel1.Text = strXinChao + NhanVienProvider.HoTen;
            }
            btnLogin.Enabled = false;
            
        }

        private void btnCoBao_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmCoBao());
        }

        private void btnThuongTruc_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmThuongTruc());
        }

        private void btnKhamXet_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmKhamXet());
        }

        private void btnNgayCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmNgayCong());
        }

        private void btnLoaiDM_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmLoaiDauMay());
        }

        private void btnDauMay_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmDauMay());
        }

        private void btnCongTy_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmCongTy());
        }

        private void btnMacTau_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmMacTau());
        }

        private void btnGaTau_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmGa());
        }

        private void btnCNLT_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmTaiXe());
        }

        private void btnQuanLyNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmQuanLyNguoiDung());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
          //  ribbon.SelectedPage = ribbonPage1;
        }

        private void btnQLLuongXL_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmQuanLyLuongXL());
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

        private void btnTinhChat_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmTinhChat());           
        }

        private void btnQLLuongBS_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsFuntion.AddMdiChild(this, new frmQuanLyLuongBS());
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnTongHopGioLaoDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            rptTongHopThoiGianLaoDong rpthgld = new rptTongHopThoiGianLaoDong();
            rpthgld.ShowPreviewDialog();
        }

        private void btnCoBaoLoaiC_ItemClick(object sender, ItemClickEventArgs e)
        {
            rpTongHopCoBaoLoaiC rpthcblc = new rpTongHopCoBaoLoaiC();
            rpthcblc.ShowPreviewDialog();
        }

        private void btnTongHopLuongCNLT_ItemClick(object sender, ItemClickEventArgs e)
        {
            rpTinhLuong rpluong = new rpTinhLuong();
            rpluong.ShowPreviewDialog();
        }

    }
}