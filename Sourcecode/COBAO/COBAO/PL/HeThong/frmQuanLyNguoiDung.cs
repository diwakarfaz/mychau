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

namespace COBAO.PL.HeThong
{
    public partial class frmQuanLyNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        #region khai bao
        private NhanVienProvider nvp;
        private string manv;
        private string pass;
        ConditionValidationRule ruleTrong;
        private AlertControl alert;        
        #endregion
        #region formload
        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
            nvp = new NhanVienProvider();
            ruleTrong = new ConditionValidationRule();
            alert = new AlertControl { AutoFormDelay = COBAOMessage.AlertDelayTime };
        }

        private void frmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            nvp = new NhanVienProvider();
            gcNguoiDung.DataSource = nvp.GetAll();
            txtMaNV.Text = manv = null;
            txtPass.Text = pass = null;
            txtTenNV.Text = txtDienThoai.Text = null;
            cbbChucDanh.EditValue = null;
            txtDiaChi.Text = "";
            dxValid.Dispose();
            btnSuaChua.Enabled = btnXoa.Enabled = false;
            btnThemMoi.Enabled = true;
        }
        #endregion
        #region Them

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                dxValid.Dispose();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (txtMaNV.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtMaNV, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtTenNV.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenNV, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtPass.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtPass, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbChucDanh.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbChucDanh, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtDienThoai.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtDienThoai, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    NhanVien nv = new NhanVien { MaNV = txtMaNV.Text.Trim(), TenNV = txtTenNV.Text.Trim(), Pass = txtPass.Text.Trim(), ChucDanh= cbbChucDanh.EditValue.ToString(), DienThoai = txtDienThoai.Text.Trim(), DiaChi = txtDiaChi.Text.Trim()};
                    ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                    if (nvp.IsExisted(nv))
                    {
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtMaNV, ruleTrong);
                        dxValid.Validate();
                    }                    
                    else
                    {
                        nvp.Insert(nv);
                        LoadDataSource();
                        clsFuntion.ShowMess(Text, COBAOMessage.THEMTHANHCONG);
                        btnXoaTrang_Click(null, null);
                    }
                    dxValid.Validate();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region sua
        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            try
            {
                dxValid.Dispose();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (txtMaNV.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtMaNV, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtTenNV.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenNV, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtPass.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtPass, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbChucDanh.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbChucDanh, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtDienThoai.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtDienThoai, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    NhanVien nv = new NhanVien { MaNV = manv, TenNV = txtTenNV.Text.Trim(), Pass = txtPass.Text.Trim(), ChucDanh = cbbChucDanh.EditValue.ToString(), DienThoai = txtDienThoai.Text.Trim(), DiaChi = txtDiaChi.Text.Trim() };
                    ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                    if (!manv.Equals(txtMaNV.Text) && nvp.IsExisted(nv))
                    {
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtMaNV, ruleTrong);
                    }                    
                    else
                    {
                        nvp.Update(nv);
                        dxValid.Validate();
                        txtMaNV.Enabled = true;
                        LoadDataSource();
                        clsFuntion.ShowMess(Text, COBAOMessage.SUACHUATHANHCONG);
                    }
                }
                dxValid.Validate();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = gvNguoiDung.GetRow(gvNguoiDung.GetSelectedRows()[0]) as NhanVien;
                if (XtraMessageBox.Show(String.Format("Bạn chắc chắn xoá người dùng '{0}' không?", nv.TenNV.Trim()), Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    nvp.Delete(nv);
                    txtMaNV.Enabled = true;
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
        #region đỗ dữ liệu
        private void gvNguoiDung_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                btnThemMoi.Enabled = false;
                btnSuaChua.Enabled = btnXoa.Enabled = true;
                var nv = gvNguoiDung.GetRow(gvNguoiDung.GetSelectedRows()[0]) as NhanVien;
                manv = txtMaNV.Text =nv.MaNV;
                txtTenNV.Text = nv.TenNV;
                pass = txtPass.Text = nv.Pass;
                txtDienThoai.Text = nv.DienThoai;
                txtDiaChi.Text = nv.DiaChi;
                cbbChucDanh.EditValue = nv.ChucDanh;
                txtMaNV.Enabled = false;
                btnSuaChua.Enabled = btnXoa.Enabled = true;
                btnThemMoi.Enabled = false;
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
            txtMaNV.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }          
   
    }
}