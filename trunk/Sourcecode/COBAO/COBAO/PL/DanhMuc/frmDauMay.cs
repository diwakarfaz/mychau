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
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraBars.Alerter;


namespace COBAO.PL.DanhMuc
{
    public partial class frmDauMay : DevExpress.XtraEditors.XtraForm
    {
        #region khai bao
        private LoaiDMProvider ldmp;
        private DauMayProvider dmp;
        private string madm;
        private string tendm;
        private Guid maloai;
        ConditionValidationRule ruleTrong;
        private AlertControl alert;
        #endregion
        #region formload
        public frmDauMay()
        {
            InitializeComponent();
            dmp = new DauMayProvider();
            ldmp = new LoaiDMProvider();
            ruleTrong = new ConditionValidationRule();
            alert = new AlertControl { AutoFormDelay = COBAOMessage.AlertDelayTime };
        }

        private void frmDauMay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOBAODataSet.LoaiDauMay' table. You can move, or remove it, as needed.
            this.loaiDauMayTableAdapter.Fill(this.cOBAODataSet.LoaiDauMay);
            
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            ldmp = new LoaiDMProvider();
            dmp = new DauMayProvider();
            gcDauMay.DataSource = dmp.GetAll();
            cbbLoaiDM.Properties.DataSource = ldmp.GetAll();
            lLoaiDauMay.DataSource = ldmp.GetAll();
            madm = txtMaDM.Text = null;
            cbbLoaiDM.EditValue = txtTenDauMay.Text = null;
            dxValid.Dispose();
            btnSuaChua.Enabled = btnXoa.Enabled = false;
            btnThemMoi.Enabled = true;
        }
        #endregion
        #region them
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                dxValid.Dispose();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (cbbLoaiDM.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbLoaiDM, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtMaDM.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtMaDM, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtTenDauMay.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenDauMay, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    DauMay dm = new DauMay { MaLoai = (Guid)cbbLoaiDM.EditValue, MaDM = txtMaDM.Text.Trim(), TenDM = txtTenDauMay.Text.Trim() };
                    if (dmp.IsExisted(dm))
                    {
                        ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtMaDM, ruleTrong);
                        dxValid.Validate();
                    }
                    else
                    {
                        dmp.Insert(dm);
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
        #endregion
        #region Sua

        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            try
            {
                dxValid.Dispose();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (cbbLoaiDM.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbLoaiDM, ruleTrong);
                }
                else if (txtMaDM.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtMaDM, ruleTrong);
                }
                else if (txtTenDauMay.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenDauMay, ruleTrong);
                }
                else
                {
                    DauMay dm = new DauMay { MaDM = madm, TenDM = txtTenDauMay.Text.Trim(), MaLoai = (Guid)cbbLoaiDM.EditValue };
                    ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                    if (!madm.Equals(txtMaDM.Text) && dmp.IsExisted(dm))
                    {
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtMaDM, ruleTrong);
                        dxValid.Validate();
                    }
                    else
                    {
                        dmp.Update(dm);
                        dxValid.Validate();
                        txtMaDM.Enabled = true;
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
        #region xoa

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DauMay dm = gvDauMay.GetRow(gvDauMay.GetSelectedRows()[0]) as DauMay;
                if (XtraMessageBox.Show(String.Format("Bạn chắc chắn xoá đầu máy '{0}' không?", dm.MaDM.Trim()), Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    dmp.Delete(dm);
                    LoadDataSource();
                    txtMaDM.Enabled = true;
                    clsFuntion.ShowMess(Text, COBAOMessage.XOATHANHCONG);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Lỗi: Không thể xoá dữ liệu đã chọn.{0}{1}", Environment.NewLine, ex.Message), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            LoadDataSource();
            txtMaDM.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region do du lieu

        private void gvDauMay_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                btnThemMoi.Enabled = false;
                btnSuaChua.Enabled = btnXoa.Enabled = true;
                var dm = gvDauMay.GetRow(gvDauMay.GetSelectedRows()[0]) as DauMay;
                cbbLoaiDM.EditValue = maloai = (Guid)dm.MaLoai;
                madm = txtMaDM.Text = dm.MaDM;
                tendm = txtTenDauMay.Text = dm.TenDM;
                txtMaDM.Enabled = false;
                btnSuaChua.Enabled = btnXoa.Enabled = true;
                btnThemMoi.Enabled = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}