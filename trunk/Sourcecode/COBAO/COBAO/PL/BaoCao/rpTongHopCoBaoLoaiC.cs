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
    public partial class rpTongHopCoBaoLoaiC : DevExpress.XtraReports.UI.XtraReport
    {
        DateTime dt;
        private int STT;
        private object dataSource;
        private COBAOLINQDataContext db;
        public rpTongHopCoBaoLoaiC()
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
            xrSoCoBao.DataBindings.AddRange(new XRBinding[] {
            new XRBinding("Text", dataSource, "SoCoBao")});
            xrMaDauMay.DataBindings.AddRange(new XRBinding[] {
            new XRBinding("Text", dataSource, "DauMay")});
            xrMaMacTau.DataBindings.AddRange(new XRBinding[] {
            new XRBinding("Text", dataSource, "MacTau")});
            xrLyDoXL.DataBindings.AddRange(new XRBinding[] {
            new XRBinding("Text", dataSource, "LyDoXL")});
            xrNgayNhanMay.DataBindings.AddRange(new XRBinding[] {
            new XRBinding("Text", dataSource, "NgayNhanMay")});            
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            STT++;
            xrSTT.Text = STT.ToString();
        }

        private void rpTongHopCoBaoLoaiC_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
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
                dataSource = from cobao in db.CoBaos
                             join cblt in db.CoBaoLaiTaus on cobao.SoCoBao equals cblt.SoCoBao
                             join taixe in db.TaiXes on cblt.MaTaiXe equals taixe.MaTaiXe
                             join to in db.Tos on taixe.MaTo equals to.MaTo
                             join doi in db.Dois on to.MaDoi equals doi.MaDoi
                             where cblt.Tai == true && cobao.XepLoai == "C"
                             select new
                             {
                                 MaTaiXe = taixe.MaTaiXe,
                                 TenTaiXe = taixe.TenTaiXe,
                                 TenDoi = doi.TenDoi,
                                 TenTo = to.TenTo,
                                 SoCoBao = cobao.SoCoBao,
                                 DauMay = cobao.MaDM,
                                 MacTau = cobao.MaMacTau,
                                 LyDoXL = cobao.LyDoXL,
                                 NgayNhanMay = cobao.NgayGioNhanMay.ToShortDateString(),                                 
                             };

            }
            catch { }
            try { DataSource = dataSource; }
            catch { }
            STT = 0;
        }

    }
}
