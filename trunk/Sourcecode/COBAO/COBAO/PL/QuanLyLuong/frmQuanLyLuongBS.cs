using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using COBAO.BLL;
using COBAO.DAL;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Collections;
using DevExpress.XtraEditors.Controls;

namespace COBAO.PL.QuanLyLuong
{
    public partial class frmQuanLyLuongBS : DevExpress.XtraEditors.XtraForm
    {
        #region Khai báo
        private  DonGiaLuongBoSungProvider dglbsp;
        private NhatKyLuongBoSungProvider nklbsp;
        private NhatKyThayDoiDonGiaBoSung nklbs;
        List<NhatKyThayDoiDonGiaBoSung> listNhatKyThayDoiGiaBS;
        private DonGiaLuongBoSung dglbs;
        private Guid madglbs;
        private Guid mankdglbs;
        private string mota;
        ConditionValidationRule ruleTrong;
        private AlertControl alert;
        #endregion
        #region form load
        public frmQuanLyLuongBS()
        {
            InitializeComponent();
            dglbsp = new DonGiaLuongBoSungProvider();
            nklbsp = new NhatKyLuongBoSungProvider();
            listNhatKyThayDoiGiaBS = new List<NhatKyThayDoiDonGiaBoSung>();
            ruleTrong = new ConditionValidationRule();
            alert = new AlertControl { AutoFormDelay = COBAOMessage.AlertDelayTime };
        }

        private void frmQuanLyLuongBS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOBAODataSet.DonGiaLuongBoSung' table. You can move, or remove it, as needed.
            this.donGiaLuongBoSungTableAdapter.Fill(this.cOBAODataSet.DonGiaLuongBoSung);
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            dtNgayNhap.EditValue = dtNgayThayDoi.EditValue = DateTime.Now;
            txtMoTa.Text = txtDonGia.Text = txtDonGiaMoi.Text = null;
            txtDonGiaMoi.Enabled = dtNgayThayDoi.Enabled = false;
            dglbsp = new DonGiaLuongBoSungProvider();
            nklbsp = new NhatKyLuongBoSungProvider();
            List<NhatKyThayDoiDonGiaBoSung> dtsource = new List<NhatKyThayDoiDonGiaBoSung>();
            var a = new DonGiaLuongBoSungProvider().GetAll();
            foreach (var item in a)
            {
                dtsource.Add(nklbsp.nhomNhatKy(item.MaDonGia));
            }
            gcDonGiaBS.DataSource = dtsource;
            lDonGiaBS.DataSource = dglbsp.GetAll();
            ////madglbs = new Guid("00000000-0000-0000-0000-000000000000");
            ////mankdglbs = new Guid("00000000-0000-0000-0000-000000000000");
            dxValid.Dispose();
            btnSuaChua.Enabled = btnXoa.Enabled = false;
            btnThemMoi.Enabled = true;
            txtMoTa.Select();
        }
        #endregion

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                dxValid.Dispose();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (txtMoTa.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtMoTa, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtDonGia.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtDonGia, ruleTrong);
                    dxValid.Validate();
                }                
                else if (txtDonViTinh.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtDonViTinh, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    var a = new Guid();
                    a = Guid.NewGuid();
                    DonGiaLuongBoSung dglbs = new DonGiaLuongBoSung { MaDonGia = a, MoTa = txtMoTa.Text.Trim(), DonViTinh = txtDonViTinh.Text.Trim() };
                    if (dglbsp.IsExisted(dglbs))
                    {
                        ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtMoTa, ruleTrong);
                        dxValid.Validate();
                    }
                    else
                    {
                        dglbsp.Insert(dglbs);
                        nklbs = new NhatKyThayDoiDonGiaBoSung();
                        nklbs.MaDonGia = dglbs.MaDonGia;
                        nklbs.DonGiaMoi = Int32.Parse(txtDonGia.Text.Trim());
                        nklbs.MaNV = COBAOMessage.nhanvien.MaNV;
                        try { nklbs.NgayThayDoi = DateTime.Parse(dtNgayNhap.EditValue.ToString()); }
                        catch { }
                        new NhatKyLuongBoSungProvider().Insert(nklbs);
                        LoadDataSource();
                        clsFuntion.ShowMess(Text, COBAOMessage.THEMTHANHCONG);
                    }
                    dxValid.Validate();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            dxValid.Dispose();
            ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
            if (txtDonGiaMoi.Text.Trim().Length == 0)
            {
                ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                dxValid.SetValidationRule(txtDonGiaMoi, ruleTrong);
                dxValid.Validate();
            }
            if (dtNgayThayDoi.EditValue == null)
            {
                ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                dxValid.SetValidationRule(dtNgayThayDoi, ruleTrong);
                dxValid.Validate();
            }
            else
            {
                NhatKyThayDoiDonGiaBoSung nkdglbs = new NhatKyThayDoiDonGiaBoSung();
                string mota = txtMoTa.Text.Trim();
                dglbs = new DonGiaLuongBoSungProvider().GetDonGiaByMoTa(mota);
                nkdglbs.MaDonGia = dglbs.MaDonGia;
                nkdglbs.DonGiaCu = Int32.Parse(txtDonGia.Text.Trim());
                nkdglbs.DonGiaMoi = Int32.Parse(txtDonGiaMoi.Text.Trim());
                try { nkdglbs.NgayThayDoi = DateTime.Parse(dtNgayThayDoi.EditValue.ToString()); }
                catch { };
                nkdglbs.MaNV = COBAOMessage.nhanvien.MaNV;
                ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                nklbsp.Insert(nkdglbs);
                txtMoTa.Enabled = txtDonGia.Enabled = txtDonViTinh.Enabled = dtNgayNhap.Enabled = true;
                txtDonGiaMoi.Enabled = dtNgayThayDoi.Enabled = false;
                LoadDataSource();
                clsFuntion.ShowMess(Text, COBAOMessage.THAYDOITHANHCONG);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mota = txtMoTa.Text.Trim();
            dglbs = new DonGiaLuongBoSungProvider().GetDonGiaByMoTa(mota);
            int tontai = 0;
            int cobao = 0;
            var nc = new HopPhepOmProvider().GetAll();
            foreach (var item in nc)
            {
                if (item.TrangThai == dglbs.MoTa)
                    tontai = 1;
                break;
            }
            var cb = new CoBao1Provider().GetAll();
            foreach (var item1 in cb)
            {
                if (item1.XepLoai == dglbs.MoTa)
                    cobao = 1;
                break;
            }
            if (tontai == 1 || cobao==1)
            {
                XtraMessageBox.Show(String.Format("Bạn không xóa được đơn giá lương '{0}' vì đơn giá đã được sử dụng", dglbs.MoTa.Trim()), Text, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (XtraMessageBox.Show(String.Format("Bạn chắc chắn xoá hạng giá '{0}' không?", dglbs.MoTa.Trim()), Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                var a = new NhatKyLuongBoSungProvider().GetAll();
                foreach (var item in a)
                {
                    if (item.MaDonGia == dglbs.MaDonGia)
                        nklbsp.Delete(item);
                }
                dglbsp.Delete(dglbs);
                txtMoTa.Enabled = txtDonGia.Enabled  = txtDonViTinh.Enabled = dtNgayNhap.Enabled = true;
                txtDonGiaMoi.Enabled = dtNgayThayDoi.Enabled = false;
                LoadDataSource();
                clsFuntion.ShowMess(Text, COBAOMessage.XOATHANHCONG);
            }
        }

        private void gvDonGiaBS_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                var nklbs = gvDonGiaBS.GetRow(gvDonGiaBS.GetSelectedRows()[0]) as NhatKyThayDoiDonGiaBoSung;
                madglbs = (Guid)nklbs.MaDonGia;
                mankdglbs = (Guid)nklbs.MaNhayKyBS;
                dglbs = new DonGiaLuongBoSungProvider().GetDonGiaByMaDG(madglbs);
                txtMoTa.Text = dglbs.MoTa;
                txtDonViTinh.Text = dglbs.DonViTinh;
                txtDonGia.Text = nklbs.DonGiaMoi.ToString();
                dtNgayNhap.EditValue = nklbs.NgayThayDoi;
                txtMoTa.Enabled = txtDonGia.Enabled =txtDonViTinh.Enabled = dtNgayNhap.Enabled = false;
                txtDonGiaMoi.Enabled =  dtNgayThayDoi.Enabled = true;
                btnSuaChua.Enabled = btnXoa.Enabled = true;
                btnThemMoi.Enabled = false;
                txtDonGiaMoi.Focus();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            LoadDataSource();
            txtMoTa.Enabled = txtDonGia.Enabled = txtDonViTinh.Enabled = dtNgayNhap.Enabled = true;
            txtDonGiaMoi.Enabled = dtNgayThayDoi.Enabled = false;
        }

        private void btnXoaLuoi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit ed = gvDonGiaBS.ActiveEditor as ButtonEdit;
            if (ed == null) return;
            if (e.Button.Kind == ButtonPredefines.Delete)
            {
                var nklbs = gvDonGiaBS.GetRow(gvDonGiaBS.GetSelectedRows()[0]) as NhatKyThayDoiDonGiaBoSung;
                dglbs = new DonGiaLuongBoSungProvider().GetDonGiaByMaDG((Guid)nklbs.MaDonGia);
                int count = 0;
                var a = new NhatKyLuongBoSungProvider().GetAll();
                foreach (var item in a)
                {
                    if (item.MaDonGia == dglbs.MaDonGia)
                        count += 1;
                }
                if (count > 1)
                {
                    nklbsp.Delete(nklbs);
                    clsFuntion.ShowMess(Text, COBAOMessage.XOATHANHCONG);

                }
                else
                {
                    int tontai = 0;
                    int cobao = 0;
                    var nc = new HopPhepOmProvider().GetAll();
                    foreach (var item in nc)
                    {
                        if (item.TrangThai == dglbs.MoTa)
                            tontai = 1;
                        break;
                    }
                    var cb = new CoBao1Provider().GetAll();
                    foreach (var item1 in cb)
                    {
                        if (item1.XepLoai == dglbs.MoTa)
                            cobao = 1;
                        break;
                    }
                    if (tontai == 1 || cobao == 1)
                    {
                        XtraMessageBox.Show(String.Format("Bạn không xóa được đơn giá lương '{0}' vì đơn giá đã được sử dụng", dglbs.MoTa.Trim()), Text, MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else
                    {
                        nklbsp.Delete(nklbs);
                        dglbsp.Delete(dglbs);
                        clsFuntion.ShowMess(Text, COBAOMessage.XOATHANHCONG);
                    }
                }

                List<NhatKyThayDoiDonGiaBoSung> dtsource = new List<NhatKyThayDoiDonGiaBoSung>();
                var b = new DonGiaLuongBoSungProvider().GetAll();
                foreach (var item in b)
                {
                    dtsource.Add(nklbsp.nhomNhatKy(item.MaDonGia));
                }
                gcDonGiaBS.DataSource = dtsource;
            }
        }


    }
}