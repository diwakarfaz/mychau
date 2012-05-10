using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using COBAO.DAL;
using COBAO.BLL;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;

namespace COBAO.PL.NhapLieu
{
    public partial class frmCoBao : XtraForm
    {
        #region khai báo
        private COBAOLINQDataContext db;
        private CoBao1Provider cbp;
        private string socobao;
        private HanhTrinhProvider htp;
        private CoBaoLaiTauProvider cbltp;
        private TheoTauProvider ttp;
        List<HanhTrinh> listht;
        ConditionValidationRule ruleTrong;
        private AlertControl alert;
        #endregion
        #region form load
        public frmCoBao()
        {
            InitializeComponent();
            cbp = new CoBao1Provider();
            htp = new HanhTrinhProvider();
            cbltp = new CoBaoLaiTauProvider();
            ttp = new TheoTauProvider();
            db = new COBAOLINQDataContext();
            ruleTrong = new ConditionValidationRule();
            List<HanhTrinh> listht = new List<HanhTrinh>();
            alert = new AlertControl { AutoFormDelay = COBAOMessage.AlertDelayTime };

        }
        private void frmCoBao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOBAODataSet.TheoTau' table. You can move, or remove it, as needed.
            this.theoTauTableAdapter.Fill(this.cOBAODataSet.TheoTau);
            // TODO: This line of code loads data into the 'cOBAODataSet.TheoTau' table. You can move, or remove it, as needed.
            this.theoTauTableAdapter.GetData();
            // TODO: This line of code loads data into the 'cOBAODataSet.HanhTrinh' table. You can move, or remove it, as needed.          
            hanhTrinhTableAdapter.GetData();
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            txtSoCoBao.Select();
            txtSoCoBao.Text = null;
            cbbMaDM.EditValue = cbbMaMacTau.EditValue = cbbMaTaiChinh.EditValue = cbbMaTaiPhu.EditValue = null;
            cbbTheoTauChinh.EditValue = cbbTheoTauPhu.EditValue = null;
            cbbXepLoai.EditValue = null;
            txtLyDo.EditValue = "";
            txtGioLamViec.Text = txtLuuTruTaiChinh.Text = txtLuuTruTaiPhu.Text = txtGioCaBa.Text = txtThoiGianTruc.Text = txtThoiGianBBH.Text = "0h0";
            dtNgayGiaoMay.EditValue = dtNgayNhanMay.EditValue = tmGioNhanMay.EditValue = tmGioGiaoMay.EditValue = null;
            cbp = new CoBao1Provider();
            cbltp = new CoBaoLaiTauProvider();
            htp = new HanhTrinhProvider();
            ttp = new TheoTauProvider();
            cbbMaDM.Properties.DataSource = new DauMayProvider().GetAll();
            cbbMaMacTau.Properties.DataSource = new MacTauProvider().GetAll();
            lGa.DataSource = new GaProvider().GetAll();
            lTinhChat.DataSource = new TinhChatProvider().GetAll();
            var a = (from taixe in db.TaiXes
                     where taixe.Tai.Equals(true)
                     select taixe).ToList();
            cbbMaTaiChinh.Properties.DataSource = a;
            cbbTheoTauChinh.Properties.DataSource = a;
            cbbMaTaiPhu.Properties.DataSource = new TaiXeProvider().GetAll();
            cbbTheoTauPhu.Properties.DataSource = new TaiXeProvider().GetAll();
            txtGioLuuTruTheoTauChinh.Text = txtGioLuuTruTheoTauPhu.Text = txtGioTheoTau.Text = null;
            dxValid.Dispose();
            txtGioLamViec.Enabled = txtGioCaBa.Enabled = txtThoiGianBBH.Enabled = txtThoiGianTruc.Enabled = false;
            btnSuaChua.Enabled = btnXoa.Enabled = btnThemMoi.Enabled = false;
            btnTinhCB.Enabled = true;
        }
        #endregion

        private void gcHanhTrinh_Click(object sender, EventArgs e)
        {
            if (txtSoCoBao.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show(String.Format("Bạn hãy nhập cơ báo", Text, MessageBoxButtons.OK, MessageBoxIcon.Question));
                txtSoCoBao.Focus();
            }
        }


        #region tính cơ báo
        private void btnTinhCB_Click(object sender, EventArgs e)
        {
            try
            {
                dxValid.Dispose();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (txtSoCoBao.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtSoCoBao, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbMaDM.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbMaDM, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbMaMacTau.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbMaMacTau, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbMaTaiChinh.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbMaTaiChinh, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbMaTaiPhu.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbMaTaiPhu, ruleTrong);
                    dxValid.Validate();
                }
                else if (dtNgayNhanMay.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(dtNgayNhanMay, ruleTrong);
                    dxValid.Validate();
                }
                else if (tmGioNhanMay.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(tmGioNhanMay, ruleTrong);
                    dxValid.Validate();
                }
                else if (dtNgayGiaoMay.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(dtNgayGiaoMay, ruleTrong);
                    dxValid.Validate();
                }
                else if (tmGioNhanMay.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(tmGioNhanMay, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbXepLoai.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbXepLoai, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    if (cbbXepLoai.EditValue == "C")
                    {
                        ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                        dxValid.SetValidationRule(txtLyDo, ruleTrong);
                        dxValid.Validate();
                    }
                    int n;
                    n = gvHanhTrinh.RowCount;
                    if (n <= 1)
                    {
                        XtraMessageBox.Show(String.Format("Bạn chưa nhập hành trình", MessageBoxButtons.OK, MessageBoxIcon.Question));
                    }
                    else
                    {                                              
                        var a = new CoBao1Provider().GetAll();
                        if (a != null)
                        {
                            foreach (var item in a)
                                if (item.SoCoBao.Equals(txtSoCoBao.Text))
                                {                                    
                                    btnSuaChua.Enabled = btnXoa.Enabled = true;
                                    break;
                                }
                                else
                                {
                                    btnThemMoi.Enabled = true;
                                    btnSuaChua.Enabled = btnXoa.Enabled = false;
                                }

                        }
                        else
                        {
                            btnThemMoi.Enabled = true;
                            btnSuaChua.Enabled = btnXoa.Enabled = false;
                        }
                        #region tính giờ làm việc, giờ ca ba
                        string tam1, tam2;
                        int giolamviec, giocaba;
                        DateTime giodau = DateTime.Parse(tmGioNhanMay.EditValue.ToString());
                        DateTime ngaydau = DateTime.Parse(dtNgayNhanMay.EditValue.ToString());
                        DateTime giocuoi = DateTime.Parse(tmGioGiaoMay.EditValue.ToString());
                        DateTime ngaycuoi = DateTime.Parse(dtNgayGiaoMay.EditValue.ToString());
                        tam1 = ngaydau.ToShortDateString() + " " + giodau.ToShortTimeString();
                        tam2 = ngaycuoi.ToShortDateString() + " " + giocuoi.ToShortTimeString();
                        ngaydau = DateTime.Parse(tam1);
                        ngaycuoi = DateTime.Parse(tam2);
                        TimeSpan tinh = ngaycuoi.Subtract(ngaydau);
                        giolamviec = (int)tinh.TotalMinutes;
                        txtGioLamViec.Text = clsFuntion.PhutRaGio(giolamviec);
                        giocaba = clsFuntion.GioCaBa(ngaydau, ngaycuoi);
                        txtGioCaBa.Text = clsFuntion.PhutRaGio(giocaba);
                        #endregion

                        #region tính giờ bbh
                        int giobbh = 0;
                        if (cbbXepLoai.EditValue.Equals("BBH"))
                        {
                            giobbh = 360;
                            txtThoiGianBBH.Enabled = true;
                        }

                        txtThoiGianBBH.Text = clsFuntion.PhutRaGio(giobbh);

                        #endregion

                        #region tính giờ trực
                        int giotruc = 0;
                        if (cbbXepLoai.EditValue.Equals("BBH"))
                        {
                            giotruc = giolamviec - giobbh;
                            txtThoiGianTruc.Text = clsFuntion.PhutRaGio(giotruc);
                        }
                        else
                        {
                            for (int i = 0; i < n - 1; i++)
                            {
                                var ht = gvHanhTrinh.GetRow(i) as HanhTrinh;
                                if (ht.ThoiGianDung != null)
                                    giotruc += (int)ht.ThoiGianDung;
                            }
                            txtThoiGianTruc.Text = clsFuntion.PhutRaGio(giotruc);
                        }
                        #endregion

                        txtThoiGianTruc.Enabled = true;
                        dxValid.Validate();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            LoadDataSource();
            var SelectCmdtxt = (from ht in db.HanhTrinhs
                                where ht.SoCoBao.Equals(txtSoCoBao.Text.Trim())
                                select ht).ToList();
            hanhTrinhBindingSource.DataSource = SelectCmdtxt.ToList();            
        }

        #region xóa cơ báo
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show(String.Format("Bạn chắc chắn xoá cơ báo '{0}' không?", txtSoCoBao.Text.Trim()), Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var a = new CoBaoLaiTauProvider().GetAll();
                    foreach (var item in a)
                        if (item.SoCoBao == txtSoCoBao.Text.Trim())
                            cbltp.Delete(item);

                    var b = new HanhTrinhProvider().GetAll();
                    foreach (var item in b)
                        if (item.SoCoBao == txtSoCoBao.Text.Trim())
                            htp.Delete(item);
                    CoBao cb = (from cb1 in db.CoBaos
                                where cb1.SoCoBao.Equals(txtSoCoBao.Text.Trim())
                                select cb1).Single();

                    cbp.Delete(cb);
                    LoadDataSource();
                    clsFuntion.ShowMess(Text, COBAOMessage.XOATHANHCONG);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Lỗi: Không thể xoá dữ liệu đã chọn.{0}{1}", Environment.NewLine, ex.Message), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region thêm mới
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (cbbTheoTauChinh.EditValue == null)
            {
                cbbTheoTauPhu.EditValue = txtGioLuuTruTheoTauChinh.Text = txtGioLuuTruTheoTauPhu.Text = txtGioTheoTau.Text = null;
            }
            else if (txtGioTheoTau.Text.Trim().Length == 0)
            {
                ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                dxValid.SetValidationRule(txtGioTheoTau, ruleTrong);
                dxValid.Validate();
            }
            else
            {
                #region luu cobao
                DateTime ngaydau = DateTime.Parse(DateTime.Parse(dtNgayNhanMay.EditValue.ToString()).ToShortDateString() + " " + DateTime.Parse(tmGioNhanMay.EditValue.ToString()).ToShortTimeString());
                DateTime ngaycuoi = DateTime.Parse(DateTime.Parse(dtNgayGiaoMay.EditValue.ToString()).ToShortDateString() + " " + DateTime.Parse(tmGioGiaoMay.EditValue.ToString()).ToShortTimeString());
                CoBao cb = new CoBao
                {
                    SoCoBao = txtSoCoBao.Text.Trim(),
                    MaDM = cbbMaDM.EditValue.ToString(),
                    MaMacTau = cbbMaMacTau.EditValue.ToString(),
                    MaNV = COBAOMessage.nhanvien.MaNV,
                    NgayGioNhanMay = ngaydau,
                    NgayGioGiaoMay = ngaycuoi,
                    XepLoai = cbbXepLoai.EditValue.ToString(),
                    LyDoXL = txtLyDo.Text.Trim(),
                    GioLamViec = clsFuntion.GioRaPhut(txtGioLamViec.Text.Trim()),
                    GioCaBa = clsFuntion.GioRaPhut(txtGioCaBa.Text.Trim()),
                    ThoiGianBBH = clsFuntion.GioRaPhut(txtThoiGianBBH.Text.Trim()),
                    ThoiGianTruc = clsFuntion.GioRaPhut(txtThoiGianTruc.Text.Trim())
                };
                cbp.Insert(cb);
                #endregion
                #region luu cobaolaitau
                CoBaoLaiTau cblt = new CoBaoLaiTau { SoCoBao = txtSoCoBao.Text.Trim(), MaTaiXe = cbbMaTaiChinh.EditValue.ToString(), Tai = true, GioLuuTru = clsFuntion.GioRaPhut(txtLuuTruTaiChinh.Text.Trim()) };
                cbltp.Insert(cblt);
                CoBaoLaiTau cblt1 = new CoBaoLaiTau { SoCoBao = txtSoCoBao.Text.Trim(), MaTaiXe = cbbMaTaiPhu.EditValue.ToString(), Tai = false, GioLuuTru = clsFuntion.GioRaPhut(txtLuuTruTaiPhu.Text.Trim()) };
                cbltp.Insert(cblt1);
                #endregion
                #region luu hanh trinh
                int n = gvHanhTrinh.RowCount;
                for (int i = 0; i < n - 1; i++)
                {
                    var ht = gvHanhTrinh.GetRow(i) as HanhTrinh;
                    ht.MaHanhTrinh = new Guid();
                    ht.SoCoBao = txtSoCoBao.Text.ToString();
                    htp.Insert(ht);
                }
                #endregion
                LoadDataSource();
                clsFuntion.ShowMess(Text, COBAOMessage.THEMTHANHCONG);
            }
        }
        #endregion
        #region sửa cơ báo
        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            if (cbbTheoTauChinh.EditValue == null)
            {
                cbbTheoTauPhu.EditValue = txtGioLuuTruTheoTauChinh.Text = txtGioLuuTruTheoTauPhu.Text = txtGioTheoTau.Text = null;
            }
            else if (txtGioTheoTau.Text.Trim().Length == 0)
            {
                ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                dxValid.SetValidationRule(txtGioTheoTau, ruleTrong);
                dxValid.Validate();
            }
            else
            {
                DateTime ngaydau = DateTime.Parse(DateTime.Parse(dtNgayNhanMay.EditValue.ToString()).ToShortDateString() + " " + DateTime.Parse(tmGioNhanMay.EditValue.ToString()).ToShortTimeString());
                DateTime ngaycuoi = DateTime.Parse(DateTime.Parse(dtNgayGiaoMay.EditValue.ToString()).ToShortDateString() + " " + DateTime.Parse(tmGioGiaoMay.EditValue.ToString()).ToShortTimeString());
                CoBao cb = new CoBao
                {
                    SoCoBao = txtSoCoBao.Text.Trim(),
                    MaDM = cbbMaDM.EditValue.ToString(),
                    MaMacTau = cbbMaMacTau.EditValue.ToString(),
                    MaNV = COBAOMessage.nhanvien.MaNV,
                    NgayGioNhanMay = ngaydau,
                    NgayGioGiaoMay = ngaycuoi,
                    XepLoai = cbbXepLoai.EditValue.ToString(),
                    LyDoXL = txtLyDo.Text.Trim(),
                    GioLamViec = clsFuntion.GioRaPhut(txtGioLamViec.Text.Trim()),
                    GioCaBa = clsFuntion.GioRaPhut(txtGioCaBa.Text.Trim()),
                    ThoiGianBBH = clsFuntion.GioRaPhut(txtThoiGianBBH.Text.Trim()),
                    ThoiGianTruc = clsFuntion.GioRaPhut(txtThoiGianTruc.Text.Trim())
                };
                cbp.Update(cb);
                ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                #region luu cobaolaitau
                var a = new CoBaoLaiTauProvider().GetAll();
                foreach (var item in a)
                    if (item.SoCoBao == txtSoCoBao.Text.Trim())
                        cbltp.Delete(item);
                CoBaoLaiTau cblt = new CoBaoLaiTau { SoCoBao = txtSoCoBao.Text.Trim(), MaTaiXe = cbbMaTaiChinh.EditValue.ToString(), Tai = true, GioLuuTru = clsFuntion.GioRaPhut(txtLuuTruTaiChinh.Text.Trim()) };
                cbltp.Insert(cblt);
                CoBaoLaiTau cblt1 = new CoBaoLaiTau { SoCoBao = txtSoCoBao.Text.Trim(), MaTaiXe = cbbMaTaiPhu.EditValue.ToString(), Tai = false, GioLuuTru = clsFuntion.GioRaPhut(txtLuuTruTaiPhu.Text.Trim()) };
                cbltp.Insert(cblt1);
                #endregion
                #region luu hanh trinh
                var b = new HanhTrinhProvider().GetAll();
                foreach (var item in b)
                    if (item.SoCoBao == txtSoCoBao.Text.Trim())
                        htp.Delete(item);

                int n = gvHanhTrinh.RowCount;
                for (int i = 0; i < n - 1; i++)
                {
                    var ht = gvHanhTrinh.GetRow(i) as HanhTrinh;
                    ht.MaHanhTrinh = new Guid();
                    ht.SoCoBao = txtSoCoBao.Text.ToString();
                    htp.Insert(ht);
                }
                #endregion
                LoadDataSource();
                clsFuntion.ShowMess(Text, COBAOMessage.SUACHUATHANHCONG);
            }
        }
        #endregion

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region thay đổi hiển thị số cơ báo
        private void txtSoCoBao_TextChanged(object sender, EventArgs e)
        {
            var SelectCmdtxt = (from ht in db.HanhTrinhs
                                where ht.SoCoBao.Equals(txtSoCoBao.Text.Trim())
                                orderby ht.TrangThaiGa descending, ht.NgayDi ascending, ht.GioDi ascending, ht.NgayDen ascending, ht.GioDen ascending
                                select ht).ToList();
            hanhTrinhBindingSource.DataSource = SelectCmdtxt.ToList();
            var a = new CoBao1Provider().GetAll();
            foreach (var item in a)
                if (item.SoCoBao.Equals(txtSoCoBao.Text))
                {
                    cbbMaDM.EditValue = item.MaDM;
                    cbbMaMacTau.EditValue = item.MaMacTau;
                    var taichinh = (from cblt1 in db.CoBaoLaiTaus
                                    where cblt1.SoCoBao.Equals(item.SoCoBao) && cblt1.Tai.Equals(true)
                                    select cblt1).Single();
                    cbbMaTaiChinh.EditValue = taichinh.MaTaiXe;
                    txtLuuTruTaiChinh.Text = clsFuntion.PhutRaGio((int)taichinh.GioLuuTru);
                    var taiphu = (from cblt2 in db.CoBaoLaiTaus
                                  where cblt2.SoCoBao.Equals(item.SoCoBao) && cblt2.Tai.Equals(false)
                                  select cblt2).Single();
                    cbbMaTaiPhu.EditValue = taiphu.MaTaiXe;
                    txtLuuTruTaiPhu.Text = clsFuntion.PhutRaGio((int)taiphu.GioLuuTru);
                    cbbXepLoai.EditValue = item.XepLoai;
                    txtLyDo.Text = item.LyDoXL;
                    dtNgayGiaoMay.EditValue = item.NgayGioGiaoMay.ToShortDateString();
                    tmGioGiaoMay.EditValue = item.NgayGioGiaoMay.ToShortTimeString();
                    dtNgayNhanMay.EditValue = item.NgayGioNhanMay.ToShortDateString();
                    tmGioNhanMay.EditValue = item.NgayGioNhanMay.ToShortTimeString();
                    txtGioLamViec.Text = clsFuntion.PhutRaGio((int)item.GioLamViec);
                    txtGioCaBa.Text = clsFuntion.PhutRaGio((int)item.GioCaBa);
                    txtThoiGianBBH.Text = clsFuntion.PhutRaGio((int)item.ThoiGianBBH);
                    txtThoiGianTruc.Text = clsFuntion.PhutRaGio((int)item.ThoiGianTruc);
                    btnXoa.Enabled = true;
                    //btnSuaChua.Enabled = true;
                    //break;
                }

        }
        #endregion

        private void gvHanhTrinh_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["MaHanhTrinh"], Guid.NewGuid());
            view.SetRowCellValue(e.RowHandle, view.Columns["SoCoBao"], txtSoCoBao.Text.Trim());
        }

        private void dtNgayNhanMay_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime tu = (DateTime)dtNgayNhanMay.EditValue;
                DateTime den = (DateTime)dtNgayGiaoMay.EditValue;
                if (tu > den)
                {
                    dtNgayNhanMay.EditValue = den;
                }
            }
            catch { }
        }

        private void dtNgayGiaoMay_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime tu = (DateTime)dtNgayNhanMay.EditValue;
                DateTime den = (DateTime)dtNgayGiaoMay.EditValue;
                if (tu > den)
                {
                    dtNgayGiaoMay.EditValue = tu;
                }
            }
            catch { }
        }

        private void tmGioGiaoMay_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime tu = (DateTime)dtNgayNhanMay.EditValue;
                DateTime den = (DateTime)dtNgayGiaoMay.EditValue;
                DateTime giodau = DateTime.Parse(tmGioNhanMay.EditValue.ToString());
                DateTime giocuoi = DateTime.Parse(tmGioGiaoMay.EditValue.ToString());
                if (tu.ToShortDateString() == den.ToShortDateString())
                    if ((giodau.Hour == giocuoi.Hour && giodau.Minute > giocuoi.Minute) || (giodau.Hour > giocuoi.Hour))
                    {
                        tmGioGiaoMay.EditValue = giodau;
                        XtraMessageBox.Show("Ngày giờ giao máy phải lớn hơn ngày giờ nhận máy ", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch { }
        }

        private void tmGioNhanMay_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime tu = (DateTime)dtNgayNhanMay.EditValue;
                DateTime den = (DateTime)dtNgayGiaoMay.EditValue;
                DateTime giodau = DateTime.Parse(tmGioNhanMay.EditValue.ToString());
                DateTime giocuoi = DateTime.Parse(tmGioGiaoMay.EditValue.ToString());
                if (tu.ToShortDateString() == den.ToShortDateString())
                    if ((giodau.Hour == giocuoi.Hour && giodau.Minute > giocuoi.Minute) || (giodau.Hour > giocuoi.Hour))
                    {
                        tmGioNhanMay.EditValue = giocuoi;
                        XtraMessageBox.Show("Ngày giờ giao máy phải lớn hơn ngày giờ nhận máy ", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch { }
        }    

        private void cbbMaTaiChinh_TextChanged(object sender, EventArgs e)
        {

            if (cbbMaTaiChinh.EditValue != null)
            {
                List<TaiXe> dtsource = new List<TaiXe>();
                var a = new TaiXeProvider().TaiPhu(cbbMaTaiChinh.EditValue.ToString());
                cbbMaTaiPhu.Properties.DataSource = a;
            }
            else
                cbbMaTaiPhu.Properties.DataSource = new TaiXeProvider().GetAll();
        }

        private void btnXoaLuoi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit ed = gvHanhTrinh.ActiveEditor as ButtonEdit;
            if (ed == null) return;
            if (e.Button.Kind == ButtonPredefines.Delete)
            {
                gvHanhTrinh.DeleteRow(gvHanhTrinh.FocusedRowHandle);
            }
        }

         private void gvHanhTrinh_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {

            GridView view = sender as GridView;
            DataRowView row = e.Row as DataRowView;
            try
            {
                view.ClearColumnErrors();
                if (((DateTime)row["NgayDen"]).Date > ((DateTime)row["NgayDi"]).Date)
                {
                    e.Valid = false;
                    view.SetColumnError(view.Columns["NgayDi"], "Ngày đi không được nhỏ hơn ngày đến", ErrorType.Critical);
                    view.FocusedColumn = view.Columns["NgayDi"];
                }
            }
            catch
            {

            }
            try
            {
                if (((DateTime)row["NgayDen"]).Date == ((DateTime)row["NgayDi"]).Date)
                {
                    view.SetColumnError(view.Columns["NgayDi"], "", ErrorType.None);
                    if (((DateTime.Parse("1/1/2012 " + row["GioDen"].ToString())) >= (DateTime.Parse("1/1/2012 " + row["GioDi"].ToString()))))
                        e.Valid = false;
                    view.SetColumnError(view.Columns["GioDi"], "Giờ đi không được nhỏ hơn giờ đến", ErrorType.Critical);
                    view.FocusedColumn = view.Columns["GioDi"];
                }
            }
            catch
            {
                view.ClearColumnErrors();
            }
        }

        private void gvHanhTrinh_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void cbbMaTaiPhu_EditValueChanged(object sender, EventArgs e)
        {
            if (cbbMaTaiPhu.EditValue != null)
            {
                var a = new TaiXeProvider().theotauchinh(cbbMaTaiChinh.EditValue.ToString(), cbbMaTaiPhu.EditValue.ToString());
                cbbTheoTauChinh.Properties.DataSource = a;
            }
            else
                cbbTheoTauChinh.Properties.DataSource = new TaiXeProvider().TaiChinh(true);
        }


            
      
    }
}