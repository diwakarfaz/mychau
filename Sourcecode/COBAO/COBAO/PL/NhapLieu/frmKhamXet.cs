using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using COBAO.BLL;
using COBAO.DAL;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraBars.Alerter;



namespace COBAO.PL.NhapLieu
{
    public partial class frmKhamXet : DevExpress.XtraEditors.XtraForm
    {
        #region Khai báo
        private TaiXeProvider txp;
        private KhamXetProvider kxp;
        private ChiTietKhamXetProvider ctkxp;
        private Guid makx;
        private COBAOLINQDataContext db;
        private string mataichinh;
        private string mataiphu;
        private string mota;
        private ChiTietKhamXet ctkx;
        private ChiTietKhamXet ctkx1;
        ConditionValidationRule ruleTrong;
        private AlertControl alert;
        #endregion
        public frmKhamXet()
        {
            InitializeComponent();
            txp = new TaiXeProvider();
            kxp = new KhamXetProvider();
            ctkxp = new ChiTietKhamXetProvider();
            db = new COBAOLINQDataContext();
            ruleTrong = new ConditionValidationRule();
            alert = new AlertControl { AutoFormDelay = COBAOMessage.AlertDelayTime };
        }

        private void frmKhamXet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOBAODataSet.TaiXe' table. You can move, or remove it, as needed.
            this.taiXeTableAdapter.Fill(this.cOBAODataSet.TaiXe);
            // TODO: This line of code loads data into the 'cOBAODataSet.TaiXe' table. You can move, or remove it, as needed.
            this.taiXeTableAdapter.Fill(this.cOBAODataSet.TaiXe);
            // TODO: This line of code loads data into the 'cOBAODataSet.DauMay' table. You can move, or remove it, as needed.
            this.dauMayTableAdapter.Fill(this.cOBAODataSet.DauMay);
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            dtNgayBatDau.EditValue = dtNgayKetThuc.EditValue = DateTime.Now;
            cbbTaiChinh.EditValue = cbbTaiPhu.EditValue = null;
            tmGioBatDau.EditValue = tmGioKetThuc.EditValue = null;

            txp = new TaiXeProvider();
            kxp = new KhamXetProvider();
            ctkxp = new ChiTietKhamXetProvider();
            var lsKhamXet = new KhamXetProvider().GetAll();
            //List<ChiTietKhamXet> dtsource = new List<ChiTietKhamXet>();
            List<HienThiChiTietKhamXet> lsHT = new List<HienThiChiTietKhamXet>();
            foreach (var item in lsKhamXet)
            {  
                HienThiChiTietKhamXet ht = new HienThiChiTietKhamXet();
                ht.MaDM = item.MaDM;
                ht.MaTaiXeChinh = (from sql in db.ChiTietKhamXets
                                   where sql.MaKhamXet.Equals(item.MaKhamXet)
                                   && sql.Tai
                                   select sql).Single().MaTaiXe;
                ht.TenTaiXeChinh = (from sql in db.ChiTietKhamXets
                                  where sql.MaKhamXet.Equals(item.MaKhamXet)
                                  && sql.Tai
                                  select sql).Single().TaiXe.TenTaiXe;
                try
                {
                    ht.MaTaiXePhu = (from sql in db.ChiTietKhamXets
                                     where sql.MaKhamXet.Equals(item.MaKhamXet)
                                     && !sql.Tai
                                     select sql).Single().MaTaiXe;
                    ht.TenTaiXePhu= (from sql in db.ChiTietKhamXets
                                     where sql.MaKhamXet.Equals(item.MaKhamXet)
                                     && !sql.Tai
                                     select sql).Single().TaiXe.TenTaiXe;

                }
                catch { ht.MaTaiXePhu = ""; ht.TenTaiXePhu = ""; }
                ht.NgayBatDau = item.NgayGioBatDau.ToShortDateString();
                ht.GioBatDau = item.NgayGioBatDau.ToShortTimeString();
                ht.NgayKetThuc = item.NgayGioKetThuc.ToShortDateString();
                ht.GioKetThuc = item.NgayGioKetThuc.ToShortTimeString();
                ht.ThoiGianKhamXet = item.ThoiGianKhamXet.ToString();
                ht.GioCaBa = item.GioCaBa.ToString();
                lsHT.Add(ht);
            }           
            gcKhamXet.DataSource = lsHT;
            dxValid.Dispose();
            btnSuaChua.Enabled = btnXoa.Enabled = false;
            btnThemMoi.Enabled = true;
        }

        private void cbbTaiPhu_click(object sender, EventArgs e)
        {
            List<TaiXe> dtsource = new List<TaiXe>();
            mataichinh = cbbTaiChinh.EditValue.ToString();
            var a = new TaiXeProvider().TaiPhu(mataichinh);
            cbbTaiPhu.Properties.DataSource = a;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    dxValid.Dispose();
            //    ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
            //    if (cbbMaDauMay.EditValue == null)
            //    {
            //        ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
            //        dxValid.SetValidationRule(cbbMaDauMay, ruleTrong);
            //        dxValid.Validate();
            //    }
            //    else if (cbbTaiChinh.EditValue==null)
            //    {
            //        ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
            //        dxValid.SetValidationRule(cbbTaiChinh, ruleTrong);
            //        dxValid.Validate();
            //    }
            //    else if (dtNgayBatDau.EditValue==null)
            //    {
            //        ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
            //        dxValid.SetValidationRule(dtNgayBatDau, ruleTrong);
            //        dxValid.Validate();
            //    }
            //    else if (tmGioBatDau.EditValue == null)
            //    {
            //        ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
            //        dxValid.SetValidationRule(tmGioBatDau, ruleTrong);
            //        dxValid.Validate();
            //    }
            //    else if (dtNgayKetThuc.EditValue == null)
            //    {
            //        ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
            //        dxValid.SetValidationRule(dtNgayKetThuc, ruleTrong);
            //        dxValid.Validate();
            //    }
            //    else if (tmGioKetThuc.EditValue == null)
            //    {
            //        ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
            //        dxValid.SetValidationRule(tmGioKetThuc, ruleTrong);
            //        dxValid.Validate();
            //    }
            //    else
            //    {
            var a = new Guid();
            a = Guid.NewGuid();
            string tam1, tam2;
            int giokhamxet, giocaba;
            string tam;
            giocaba = 0;
            #region tính giờ khám xét
            DateTime giodau = DateTime.Parse(tmGioBatDau.EditValue.ToString());
            DateTime ngaydau = DateTime.Parse(dtNgayBatDau.EditValue.ToString());
            DateTime giocuoi = DateTime.Parse(tmGioKetThuc.EditValue.ToString());
            DateTime ngaycuoi = DateTime.Parse(dtNgayKetThuc.EditValue.ToString());
            tam1 = ngaydau.ToShortDateString() + " "+ giodau.ToShortTimeString();
            tam2 =ngaycuoi.ToShortDateString() + " "+ giocuoi.ToShortTimeString();
            ngaydau = DateTime.Parse(tam1);
            ngaycuoi = DateTime.Parse(tam2);
            TimeSpan tinh = ngaycuoi.Subtract(ngaydau);
            giokhamxet = (int)tinh.TotalMinutes;
            #endregion
            #region tính giờ caba
            int songay =(int)tinh.TotalDays;
            txtGop.Text = songay.ToString();
            if (songay == 0)
            {
                if (giodau.Hour < 6)
                    giocaba += (6 - giodau.Hour) * 60 - giodau.Minute;
                //if (giodau.Hour > 21)
                //        giocaba += (giodau.Hour - 22) * 60 + giodau.Minute;
                if (giocuoi.Hour > 21)
                    giocaba += (giocuoi.Hour - 22) * 60 + giocuoi.Minute;
                if (giodau.Hour >= 22 && giocuoi.Hour < 6)
                    giocaba = (giodau.Hour - 22) * 60 + giodau.Minute + (6 - giocuoi.Hour) * 60 + giocuoi.Minute;
            }
            else
            {
                if (giodau.Hour < 6)
                    giocaba += (6 - giodau.Hour) * 60 - giodau.Minute;
                //if (giodau.Hour > 21)
                //        giocaba += (giodau.Hour - 22) * 60 + giodau.Minute;
                if (giocuoi.Hour > 21)
                    giocaba += (giocuoi.Hour - 22) * 60 + giocuoi.Minute;
                if (giodau.Hour >= 22 && giocuoi.Hour < 6)
                    giocaba = (giodau.Hour - 22) * 60 + giodau.Minute + (6 - giocuoi.Hour) * 60 + giocuoi.Minute;
                for (int i = 1; i <= songay; i++)
                    giocaba += 480;
            }
            
            txtGio.Text = giocaba.ToString();
            #endregion

            ////KhamXet kx = new KhamXet { MaKhamXet = a, MaDM = cbbMaDauMay.EditValue.ToString(), MaNV = COBAOMessage.nhanvien.MaNV, NgayGioBatDau = DateTime.Parse(ngaydau), NgayGioKetThuc = DateTime.Parse(ngaycuoi), ThoiGianKhamXet = giokhamxet, GioCaBa = 12 };
            ////kxp.Insert(kx);
            ////ctkx = new ChiTietKhamXet();
            ////ctkx.MaKhamXet = kx.MaKhamXet;
            ////ctkx.MaTaiXe = cbbTaiChinh.EditValue.ToString();
            ////ctkx.Tai = true;
            ////new ChiTietKhamXetProvider().Insert(ctkx);
            ////if (cbbTaiPhu.EditValue != null)
            ////{
            ////    ctkx1 = new ChiTietKhamXet();
            ////    ctkx1.MaKhamXet = kx.MaKhamXet;
            ////    ctkx1.MaTaiXe = cbbTaiPhu.EditValue.ToString();
            ////    ctkx1.Tai = false;
            ////    new ChiTietKhamXetProvider().Insert(ctkx1);
            ////}
            ////LoadDataSource();
            ////clsFuntion.ShowMess(Text, COBAOMessage.THEMTHANHCONG);
            //        }
            //        dxValid.Validate();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show("Lỗi: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void cbbTaiPhu_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}