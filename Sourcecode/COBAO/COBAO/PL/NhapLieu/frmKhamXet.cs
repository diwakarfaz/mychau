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
            
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            cbbMaDauMay.Select();
            dtNgayBatDau.EditValue = dtNgayKetThuc.EditValue = DateTime.Now;
            cbbMaDauMay.EditValue= cbbTaiChinh.EditValue = cbbTaiPhu.EditValue = null;
            tmGioBatDau.EditValue = tmGioKetThuc.EditValue = null;
            txp = new TaiXeProvider();
            kxp = new KhamXetProvider();
            ctkxp = new ChiTietKhamXetProvider();            
            cbbMaDauMay.Properties.DataSource = new DauMayProvider().GetAll();
            var a = (from taixe in db.TaiXes
                     where taixe.Tai.Equals(true)
                     select taixe).ToList();
            cbbTaiChinh.Properties.DataSource = a;
            cbbTaiPhu.Properties.DataSource = new TaiXeProvider().GetAll();
            var lsKhamXet = new KhamXetProvider().GetAll();
            List<HienThiChiTietKhamXet> lsHT = new List<HienThiChiTietKhamXet>();
            foreach (var item in lsKhamXet)
            {  
                HienThiChiTietKhamXet ht = new HienThiChiTietKhamXet();
                ht.MaKhamXet =item.MaKhamXet;
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
                ht.ThoiGianKhamXet =clsFuntion.PhutRaGio((int)item.ThoiGianKhamXet);
                ht.GioCaBa = clsFuntion.PhutRaGio((int)item.GioCaBa);
                if (item.NgayGioBatDau.Month == DateTime.Now.Month)
                {
                    lsHT.Add(ht);
                }
            }           
            gcKhamXet.DataSource = lsHT;
            dxValid.Dispose();
            btnSuaChua.Enabled = btnXoa.Enabled = false;
            btnThemMoi.Enabled = true;
        }       
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                dxValid.Dispose();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (cbbMaDauMay.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbMaDauMay, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbTaiChinh.EditValue==null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbTaiChinh, ruleTrong);
                    dxValid.Validate();
                }                
                else if (dtNgayBatDau.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(dtNgayBatDau, ruleTrong);
                    dxValid.Validate();
                }
                else if (tmGioBatDau.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(tmGioBatDau, ruleTrong);
                    dxValid.Validate();
                }
                else if (dtNgayKetThuc.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(dtNgayKetThuc, ruleTrong);
                    dxValid.Validate();
                }
                else if (tmGioKetThuc.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(tmGioKetThuc, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    #region tính giờ khám xét, giờ ca ba
                    string tam1, tam2;
                    int giokhamxet, giocaba;
                    string tam;
                    DateTime giodau = DateTime.Parse(tmGioBatDau.EditValue.ToString());
                    DateTime ngaydau = DateTime.Parse(dtNgayBatDau.EditValue.ToString());
                    DateTime giocuoi = DateTime.Parse(tmGioKetThuc.EditValue.ToString());
                    DateTime ngaycuoi = DateTime.Parse(dtNgayKetThuc.EditValue.ToString());
                    tam1 = ngaydau.ToShortDateString() + " " + giodau.ToShortTimeString();
                    tam2 = ngaycuoi.ToShortDateString() + " " + giocuoi.ToShortTimeString();
                    ngaydau = DateTime.Parse(tam1);
                    ngaycuoi = DateTime.Parse(tam2);
                    TimeSpan tinh = ngaycuoi.Subtract(ngaydau);
                    giokhamxet = (int)tinh.TotalMinutes;
                    giocaba = clsFuntion.GioCaBa(ngaydau, ngaycuoi);
                    #endregion
                    var a = new Guid();
                    a = Guid.NewGuid();
                    KhamXet kx = new KhamXet { MaKhamXet = a, MaDM = cbbMaDauMay.EditValue.ToString(), MaNV = COBAOMessage.nhanvien.MaNV, NgayGioBatDau = ngaydau, NgayGioKetThuc = ngaycuoi, ThoiGianKhamXet = giokhamxet, GioCaBa = giocaba };
                    kxp.Insert(kx);
                    ChiTietKhamXet ctkx = new ChiTietKhamXet { MaKhamXet = a, MaTaiXe = cbbTaiChinh.EditValue.ToString(), Tai = true };
                    ctkxp.Insert(ctkx);
                    if (cbbTaiPhu.EditValue != null)
                    {
                        ChiTietKhamXet ctkx1 = new ChiTietKhamXet { MaKhamXet = a, MaTaiXe = cbbTaiPhu.EditValue.ToString(), Tai = false };
                        ctkxp.Insert(ctkx1);
                    }
                    LoadDataSource();
                    clsFuntion.ShowMess(Text, COBAOMessage.THEMTHANHCONG);
                }
                dxValid.Validate();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtNgayKetThuc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime tu = (DateTime)dtNgayBatDau.EditValue;
                DateTime den = (DateTime)dtNgayKetThuc.EditValue;
                if (tu > den)
                {
                    dtNgayKetThuc.EditValue = tu;
                }
            }
            catch { }
        }

        private void dtNgayBatDau_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime tu = (DateTime)dtNgayBatDau.EditValue;
                DateTime den = (DateTime)dtNgayKetThuc.EditValue;
                if (tu > den)
                {
                    dtNgayBatDau.EditValue = den;
                }
            }
            catch { }
        }
        private void tmGioBatDau_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime tu = (DateTime)dtNgayBatDau.EditValue;
                DateTime den = (DateTime)dtNgayKetThuc.EditValue;
                DateTime giodau = DateTime.Parse(tmGioBatDau.EditValue.ToString());
                DateTime giocuoi = DateTime.Parse(tmGioKetThuc.EditValue.ToString());
                if (tu.ToShortDateString() == den.ToShortDateString())
                    if ((giodau.Hour == giocuoi.Hour && giodau.Minute > giocuoi.Minute) || (giodau.Hour > giocuoi.Hour))
                    {
                        tmGioBatDau.EditValue = giocuoi;
                        XtraMessageBox.Show("Ngày giờ kết thúc phải lớn hơn ngày giờ bắt đầu ", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch { }
        }

        private void tmGioKetThuc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime tu = (DateTime)dtNgayBatDau.EditValue;
                DateTime den = (DateTime)dtNgayKetThuc.EditValue;
                DateTime giodau = DateTime.Parse(tmGioBatDau.EditValue.ToString());
                DateTime giocuoi = DateTime.Parse(tmGioKetThuc.EditValue.ToString());
                if (tu.ToShortDateString() == den.ToShortDateString())
                    if ((giodau.Hour == giocuoi.Hour && giodau.Minute > giocuoi.Minute) || (giodau.Hour > giocuoi.Hour))
                    {
                        tmGioKetThuc.EditValue = giodau;
                        XtraMessageBox.Show("Ngày giờ kết thúc phải lớn hơn ngày giờ bắt đầu ", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch { }

        }

        private void cbbTaiChinh_TextChanged(object sender, EventArgs e)
        {

            if (cbbTaiChinh.EditValue != null)
            {
                List<TaiXe> dtsource = new List<TaiXe>();
                var a = new TaiXeProvider().TaiPhu(cbbTaiChinh.EditValue.ToString());
                cbbTaiPhu.Properties.DataSource = a;
            }
            else
                cbbTaiPhu.Properties.DataSource = new TaiXeProvider().GetAll();
        }

        private void gvKhamXet_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                HienThiChiTietKhamXet HT = gvKhamXet.GetRow(gvKhamXet.GetSelectedRows()[0]) as HienThiChiTietKhamXet;
                makx = HT.MaKhamXet;
                cbbMaDauMay.EditValue = HT.MaDM;
                cbbTaiChinh.EditValue = HT.MaTaiXeChinh;
                cbbTaiPhu.EditValue = HT.MaTaiXePhu;
                dtNgayBatDau.EditValue =DateTime.Parse(HT.NgayBatDau);
                dtNgayKetThuc.EditValue =DateTime.Parse(HT.NgayKetThuc);
                tmGioBatDau.EditValue = HT.GioBatDau;
                tmGioKetThuc.EditValue = HT.GioKetThuc;
                btnSuaChua.Enabled = btnXoa.Enabled = true;
                btnThemMoi.Enabled = false;
                cbbMaDauMay.Focus();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            try
            {
                dxValid.Dispose();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (cbbMaDauMay.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbMaDauMay, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbTaiChinh.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbTaiChinh, ruleTrong);
                    dxValid.Validate();
                }
                else if (dtNgayBatDau.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(dtNgayBatDau, ruleTrong);
                    dxValid.Validate();
                }
                else if (tmGioBatDau.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(tmGioBatDau, ruleTrong);
                    dxValid.Validate();
                }
                else if (dtNgayKetThuc.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(dtNgayKetThuc, ruleTrong);
                    dxValid.Validate();
                }
                else if (tmGioKetThuc.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(tmGioKetThuc, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    #region tính giờ khám xét, giờ ca ba
                    string tam1, tam2;
                    int giokhamxet, giocaba;
                    string tam;
                    DateTime giodau = DateTime.Parse(tmGioBatDau.EditValue.ToString());
                    DateTime ngaydau = DateTime.Parse(dtNgayBatDau.EditValue.ToString());
                    DateTime giocuoi = DateTime.Parse(tmGioKetThuc.EditValue.ToString());
                    DateTime ngaycuoi = DateTime.Parse(dtNgayKetThuc.EditValue.ToString());
                    tam1 = ngaydau.ToShortDateString() + " " + giodau.ToShortTimeString();
                    tam2 = ngaycuoi.ToShortDateString() + " " + giocuoi.ToShortTimeString();
                    ngaydau = DateTime.Parse(tam1);
                    ngaycuoi = DateTime.Parse(tam2);
                    TimeSpan tinh = ngaycuoi.Subtract(ngaydau);
                    giokhamxet = (int)tinh.TotalMinutes;
                    giocaba = clsFuntion.GioCaBa(ngaydau, ngaycuoi);
                    #endregion
                    HienThiChiTietKhamXet ht = gvKhamXet.GetRow(gvKhamXet.GetSelectedRows()[0]) as HienThiChiTietKhamXet;
                    KhamXet kx = new KhamXet { MaKhamXet = ht.MaKhamXet, MaDM = cbbMaDauMay.EditValue.ToString(), MaNV = COBAOMessage.nhanvien.MaNV, NgayGioBatDau = ngaydau, NgayGioKetThuc = ngaycuoi, ThoiGianKhamXet = giokhamxet, GioCaBa = giocaba };
                    kxp.Update(kx);
                    ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                    var a = new ChiTietKhamXetProvider().GetAll();
                    foreach (var item in a)
                        if (item.MaKhamXet == kx.MaKhamXet)
                            ctkxp.Delete(item);
                    ChiTietKhamXet ctkx = new ChiTietKhamXet { MaKhamXet = kx.MaKhamXet, MaTaiXe = cbbTaiChinh.EditValue.ToString(), Tai = true };
                    ctkxp.Insert(ctkx);
                    if (cbbTaiPhu.EditValue != null)
                    {
                        ChiTietKhamXet ctkx1 = new ChiTietKhamXet { MaKhamXet = kx.MaKhamXet, MaTaiXe = cbbTaiPhu.EditValue.ToString(), Tai = false };
                        ctkxp.Insert(ctkx1);
                    }
                    LoadDataSource();
                    LoadDataSource();
                    clsFuntion.ShowMess(Text, COBAOMessage.SUACHUATHANHCONG);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show(String.Format("Bạn có chắc chắn xóa không?"), Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    HienThiChiTietKhamXet ht = gvKhamXet.GetRow(gvKhamXet.GetSelectedRows()[0]) as HienThiChiTietKhamXet;
                    var a = new ChiTietKhamXetProvider().GetAll();
                    foreach (var item in a)
                        if (item.MaKhamXet == ht.MaKhamXet)
                            ctkxp.Delete(item);
                    var kx = (from kamxet in db.KhamXets
                              where kamxet.MaKhamXet.Equals(ht.MaKhamXet)
                              select kamxet).Single();
                    kxp.Delete(kx);
                    LoadDataSource();
                    clsFuntion.ShowMess(Text, COBAOMessage.XOATHANHCONG);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Lỗi: Không thể xoá dữ liệu đã chọn.{0}{1}", Environment.NewLine, ex.Message), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

 

   


    }
}