using System;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using COBAO.BLL;
using COBAO.DAL;

namespace COBAO.PL.BaoCao
{
    public partial class rptTongHopThoiGianLaoDong :XtraReport
    {
        DateTime dt;
        private int STT;
        private object dataSource;
        private COBAOLINQDataContext db;
        public rptTongHopThoiGianLaoDong()
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
            xrMaTo.DataBindings.AddRange(new XRBinding[] {
            new XRBinding("Text", dataSource, "TenTo")});
            xrGioDiTau.DataBindings.AddRange(new XRBinding[] {
            new XRBinding("Text", dataSource, "GioDiTau")});
            xrThuongTruc.DataBindings.AddRange(new XRBinding[] {
            new XRBinding("Text", dataSource, "GioThuongTruc")});
            xrKhamXet.DataBindings.AddRange(new XRBinding[] {
            new XRBinding("Text", dataSource, "GioKhamXet")});
            xrTheoTau.DataBindings.AddRange(new XRBinding[] {
            new XRBinding("Text", dataSource, "GioTheoTau")});
            xrHop.DataBindings.AddRange(new XRBinding[] {
            new XRBinding("Text", dataSource, "Hop")});
            xrTong.DataBindings.AddRange(new XRBinding[]{
            new XRBinding("Text", dataSource, "TongGio")});
            xrPhep.DataBindings.AddRange(new XRBinding[]{
            new XRBinding("Text", dataSource,"Phep")});
            xrOm.DataBindings.AddRange(new XRBinding[]{
            new XRBinding("Text", dataSource,"Om")});
        }

        private void rptTongHopThoiGianLaoDong_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
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
                             select new
                              {
                                  MaTaiXe = taixe.MaTaiXe,
                                  TenTaiXe = taixe.TenTaiXe,
                                  TenDoi = doi.TenDoi,
                                  TenTo = to.TenTo,
                                  GioDiTau = new CoBao1Provider().giolv(taixe.MaTaiXe, dt.Month, dt.Year) ,
                                  GioThuongTruc = new ThuongTrucProvider().giothuongtruc(taixe.MaTaiXe, dt.Month, dt.Year),
                                  GioKhamXet = new KhamXetProvider().giokhamxet(taixe.MaTaiXe, dt.Month, dt.Year),
                                  GioTheoTau = new CoBao1Provider().giotheotau(taixe.MaTaiXe, dt.Month, dt.Year),       
                                  Hop = new HopPhepOmProvider().giohop(taixe.MaTaiXe, dt.Month, dt.Year),
                                  TongGio = new TaiXeProvider().Giolam(taixe.MaTaiXe, dt.Month, dt.Year),
                                  Phep = new HopPhepOmProvider().NgayCong(taixe.MaTaiXe, "Phép", dt.Month, dt.Year),          
                                  Om = new HopPhepOmProvider().NgayCong(taixe.MaTaiXe, "Ốm", dt.Month,dt.Year),
                             };
                
            }
            catch { }
            try { DataSource = dataSource; }
            catch { }
            STT = 0;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            STT++;
            xrSTT.Text = STT.ToString();
        }

    }
}
