using System;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using COBAO.DAL;
using COBAO.BLL;
namespace COBAO.PL.BaoCao
{
    public partial class rpTinhLuong : DevExpress.XtraReports.UI.XtraReport
    {
        DateTime dt;
        private int STT;
        private object dataSource;
        private COBAOLINQDataContext db;
        public rpTinhLuong()
        {
            InitializeComponent();
            STT = 0;
            prThang.Value = DateTime.Now;
            xrMaTaiXe.DataBindings.AddRange(new XRBinding[]{
            new XRBinding("Text", dataSource, "MaTaiXe")});
            xrTenTaiXe.DataBindings.AddRange(new XRBinding[]{
            new XRBinding("Text", dataSource, "TenTaiXe")});
            xrTenDoi.DataBindings.AddRange(new XRBinding[] {
            new XRBinding("Text", dataSource, "TenDoi")});
            xrTenTo.DataBindings.AddRange(new XRBinding[] {
            new XRBinding("Text", dataSource, "TenTo")});
            xrGioDiTau.DataBindings.AddRange(new XRBinding[] {
            new XRBinding("Text", dataSource, "GioDiTau")});
            xrTongSoCoBao.DataBindings.AddRange(new XRBinding[] {
            new XRBinding("Text", dataSource, "TongSoCoBao")});
            xrTongSoGioHop.DataBindings.AddRange(new XRBinding[] {
            new XRBinding("Text", dataSource, "TongSoGioHop")});
            xrTongSoNgayNghi.DataBindings.AddRange(new XRBinding[] {
            new XRBinding("Text", dataSource, "TongSoNgayNghi")});
            xrTongLuong.DataBindings.AddRange(new XRBinding[] {
            new XRBinding("Text", dataSource, "TongLuong")});      
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            STT++;
            xrSTT.Text = STT.ToString();
        }

        private void rpTinhLuong_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            try { dt = (DateTime)prThang.Value; }
            catch { }
            try { xrThang.Text = " Tháng " + dt.Month + " năm " + dt.Year; }
            catch { }
            try { xrNgayThangNam.Text = String.Format("Đà Nẵng, ngày {0} tháng {1} năm {2}.", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year); }
            catch { }
            try
            {
                db = new COBAOLINQDataContext();
                dataSource = from taixe in db.TaiXes
                             join to in db.Tos on taixe.MaTo equals to.MaTo
                             join doi in db.Dois on to.MaDoi equals doi.MaDoi
                             orderby doi.TenDoi ascending, to.TenTo ascending, taixe.MaTaiXe ascending
                             select new
                              {
                                  MaTaiXe = taixe.MaTaiXe,
                                  TenTaiXe = taixe.TenTaiXe,
                                  TenDoi = doi.TenDoi,
                                  TenTo = to.TenTo,
                                  GioDiTau = new CoBao1Provider().giolv(taixe.MaTaiXe, dt.Month, dt.Year) ,
                                  TongSoCoBao = (from cb in db.CoBaos
                                                 join cblt in db.CoBaoLaiTaus on cb.SoCoBao equals cblt.SoCoBao
                                                 where cblt.MaTaiXe.Equals(taixe.MaTaiXe) && cb.NgayGioNhanMay.Month.Equals(dt.Month)
                                                 && cb.NgayGioNhanMay.Year.Equals(dt.Year)
                                                 select cb).Count(),
                                  TongSoGioHop = new HopPhepOmProvider().giohop(taixe.MaTaiXe, dt.Month, dt.Year),
                                  TongSoNgayNghi = new HopPhepOmProvider().NgayNghi(taixe.MaTaiXe, dt.Month, dt.Year),
                                  TongLuong= new TaiXeProvider().luong(taixe.MaTaiXe, dt.Month, dt.Year)                                
                             };

            }
            catch { }
            try { DataSource = dataSource; }
            catch { }
            STT = 0;
        }

    }
}
