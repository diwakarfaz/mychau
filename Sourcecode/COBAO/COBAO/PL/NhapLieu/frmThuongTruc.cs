using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using COBAO.BLL;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraBars.Alerter;
using COBAO.DAL;

namespace COBAO.PL.NhapLieu
{
    public partial class frmThuongTruc : DevExpress.XtraEditors.XtraForm
    {
        private TaiXeProvider txp;
        private ThuongTrucProvider ttp;
        private ChiTietThuongTrucProvider ctttp;
        private string mataichinh;
        private string mataiphu;
        ConditionValidationRule ruleTrong;
        private AlertControl alert;
        public frmThuongTruc()
        {
            InitializeComponent();
            txp = new TaiXeProvider();
            ttp = new ThuongTrucProvider();
            ctttp = new ChiTietThuongTrucProvider();
            ruleTrong = new ConditionValidationRule();
            alert = new AlertControl { AutoFormDelay = COBAOMessage.AlertDelayTime };
        }

        private void frmThuongTruc_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            cbbMaTram.Select();
            dtNgayBatDau.EditValue = dtNgayKetThuc.EditValue = DateTime.Now;
            cbbMaTram.EditValue = cbbTaiChinh.EditValue = cbbTaiPhu.EditValue = null;
            tmGioBatDau.EditValue = tmGioKetThuc.EditValue = null;
            txp = new TaiXeProvider();
            ttp = new ThuongTrucProvider();
            ctttp = new ChiTietThuongTrucProvider();
            cbbMaTram.Properties.DataSource = new TramProvider().GetAll();           
            cbbTaiChinh.Properties.DataSource = new TaiXeProvider().TaiChinh(true);
            cbbTaiPhu.Properties.DataSource = new TaiXeProvider().GetAll();
            var lsThuongTruc = new ThuongTrucProvider().GetAll();
            List<HienThiThuongTruc> lsHT = new List<HienThiThuongTruc>();
            foreach (var item in lsThuongTruc)
            {
                HienThiThuongTruc ht = new HienThiThuongTruc();
                ht.MaThuongTruc = item.MaThuongTruc;
                ht.MaTram= item.MaTram;
                ht.TenTram = item.Tram.TenTram;
                var lschitiet = new ChiTietThuongTrucProvider().listThuongTrucTheoMaThuongTruc((Guid)item.MaThuongTruc);
                foreach (var item1 in lschitiet)
                {
                    if (item1.Tai == true)
                    {
                        ht.MaTaiXeChinh = item1.MaTaiXe;
                        ht.TenTaiXeChinh = item1.TaiXe.TenTaiXe;
                    }
                    else
                    {
                        ht.MaTaiXePhu = item1.MaTaiXe;
                        ht.TenTaiXePhu = item1.TaiXe.TenTaiXe;
                    }
                }                
                ht.NgayBatDau = item.NgayBatDau.ToShortDateString();
                ht.GioBatDau = item.NgayBatDau.ToShortTimeString();
                ht.NgayKetThuc = item.NgayKetThuc.ToShortDateString();
                ht.GioKetThuc = item.NgayKetThuc.ToShortTimeString();
                ht.ThoiGianTruc = clsFuntion.PhutRaGio((int)item.ThoiGianTruc);
                ht.GioCaBa = clsFuntion.PhutRaGio((int)item.GioCaBa);
                if (item.NgayBatDau.Month == DateTime.Now.Month)
                {
                    lsHT.Add(ht);
                }
            }
            gcThuongTruc.DataSource = lsHT;
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
                if (cbbMaTram.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbMaTram, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbTaiChinh.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbTaiChinh, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbTaiPhu.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbTaiPhu, ruleTrong);
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
                    int giotruc, giocaba;
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
                    giotruc = (int)tinh.TotalMinutes;
                    giocaba = clsFuntion.GioCaBa(ngaydau, ngaycuoi);
                    #endregion
                    var a = new Guid();
                    a = Guid.NewGuid();
                    ThuongTruc tt = new ThuongTruc { MaThuongTruc = a, MaTram = (Guid)cbbMaTram.EditValue, MaNV = COBAOMessage.nhanvien.MaNV, NgayBatDau = ngaydau, NgayKetThuc = ngaycuoi, ThoiGianTruc = giotruc, GioCaBa = giocaba };
                    ttp.Insert(tt);
                    ChiTietThuongTruc cttt = new ChiTietThuongTruc { MaThuongTruc = a, MaTaiXe = cbbTaiChinh.EditValue.ToString(), Tai = true };
                    ctttp.Insert(cttt);
                    ChiTietThuongTruc cttt1 = new ChiTietThuongTruc { MaThuongTruc = a, MaTaiXe = cbbTaiPhu.EditValue.ToString(), Tai = false };
                    ctttp.Insert(cttt1);
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

        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            try
            {
                dxValid.Dispose();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (cbbMaTram.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbMaTram, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbTaiChinh.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbTaiChinh, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbTaiPhu.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbTaiPhu, ruleTrong);
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
                    int giotruc, giocaba;
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
                    giotruc = (int)tinh.TotalMinutes;
                    giocaba = clsFuntion.GioCaBa(ngaydau, ngaycuoi);
                    #endregion
                    HienThiThuongTruc ht = gvThuongTruc.GetRow(gvThuongTruc.GetSelectedRows()[0]) as HienThiThuongTruc;
                    ThuongTruc thuongtruc = new ThuongTruc { MaThuongTruc = ht.MaThuongTruc, MaTram = (Guid)cbbMaTram.EditValue, MaNV = COBAOMessage.nhanvien.MaNV, NgayBatDau = ngaydau, NgayKetThuc = ngaycuoi, ThoiGianTruc = giotruc, GioCaBa = giocaba };
                    ttp.Update(thuongtruc);
                    ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                    var a = new ChiTietThuongTrucProvider().GetAll();
                    foreach (var item in a)
                        if (item.MaThuongTruc == thuongtruc.MaThuongTruc)
                            ctttp.Delete(item);
                    ChiTietThuongTruc cttt = new ChiTietThuongTruc { MaThuongTruc = thuongtruc.MaThuongTruc, MaTaiXe = cbbTaiChinh.EditValue.ToString(), Tai = true };
                    ctttp.Insert(cttt);
                    ChiTietThuongTruc cttt1 = new ChiTietThuongTruc { MaThuongTruc = thuongtruc.MaThuongTruc, MaTaiXe = cbbTaiPhu.EditValue.ToString(), Tai = false };
                    ctttp.Insert(cttt1);
                    LoadDataSource();
                    clsFuntion.ShowMess(Text, COBAOMessage.SUACHUATHANHCONG);
                }
                dxValid.Validate();
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

                    HienThiThuongTruc HT = gvThuongTruc.GetRow(gvThuongTruc.GetSelectedRows()[0]) as HienThiThuongTruc;
                    var a = new ChiTietThuongTrucProvider().GetAll();
                    foreach (var item in a)
                        if (item.MaThuongTruc == HT.MaThuongTruc)
                            ctttp.Delete(item);
                    var thuongtruc = new ThuongTrucProvider().GetThuongTrucTheoMaThuongTruc(HT.MaThuongTruc);
                    ttp.Delete(thuongtruc);
                    LoadDataSource();
                    clsFuntion.ShowMess(Text, COBAOMessage.XOATHANHCONG);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Lỗi: Không thể xoá dữ liệu đã chọn.{0}{1}", Environment.NewLine, ex.Message), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvThuongTruc_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                HienThiThuongTruc HT = gvThuongTruc.GetRow(gvThuongTruc.GetSelectedRows()[0]) as HienThiThuongTruc;
                cbbMaTram.EditValue = HT.MaTram;
                cbbTaiChinh.EditValue = HT.MaTaiXeChinh;
                cbbTaiPhu.EditValue = HT.MaTaiXePhu;
                dtNgayBatDau.EditValue = DateTime.Parse(HT.NgayBatDau);
                dtNgayKetThuc.EditValue = DateTime.Parse(HT.NgayKetThuc);
                tmGioBatDau.EditValue = HT.GioBatDau;
                tmGioKetThuc.EditValue = HT.GioKetThuc;
                btnSuaChua.Enabled = btnXoa.Enabled = true;
                btnThemMoi.Enabled = false;
                cbbMaTram.Focus();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
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
             
    }
}