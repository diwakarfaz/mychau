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
    public partial class frmTo : DevExpress.XtraEditors.XtraForm
    {
        #region khai báo
        private DoiProvider dp;
        private ToProvider tp;
        private Guid madoi;
        private Guid mato;
        private string tento;
        ConditionValidationRule ruleTrong;
        private AlertControl alert;
        #endregion
        #region formload
        public frmTo()
        {
            InitializeComponent();
            dp = new DoiProvider();
            tp = new ToProvider();
            ruleTrong = new ConditionValidationRule();
            alert = new AlertControl { AutoFormDelay = COBAOMessage.AlertDelayTime };
        }

        private void frmTo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOBAODataSet.Doi' table. You can move, or remove it, as needed.
            this.doiTableAdapter.Fill(this.cOBAODataSet.Doi);
           LoadDataSource();
        }

        private void LoadDataSource()
        {
            tp = new ToProvider();
            dp = new DoiProvider();
            gcTo.DataSource = tp.GetAll();
            cbbMaDoi.Properties.DataSource = dp.GetAll();
            lThuocDoi.DataSource = dp.GetAll();
            mato = new Guid("00000000-0000-0000-0000-000000000000");
            cbbMaDoi.EditValue = txtTenTo.Text = null;
            dxValid.Dispose();
            btnSuaChua.Enabled = btnXoa.Enabled = false;
            btnThemMoi.Enabled = true;
        }
        #endregion
        #region thêm
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                dxValid.Dispose();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (cbbMaDoi.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbMaDoi, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtTenTo.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenTo, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    To t = new To { MaDoi = (Guid)cbbMaDoi.EditValue, TenTo = txtTenTo.Text.Trim() };
                    if (tp.IsExisted(t))
                    {
                        ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtTenTo, ruleTrong);
                        dxValid.Validate();
                    }
                    else
                    {
                        tp.Insert(t);
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
        #region sua
        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            try
            {
                dxValid.Dispose();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (txtTenTo.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenTo, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    To t = new To { MaTo = mato, MaDoi = (Guid)cbbMaDoi.EditValue, TenTo = txtTenTo.Text.Trim() };
                    ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                    if (tp.IsExisted(t))
                    {
                        ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtTenTo, ruleTrong);
                        dxValid.Validate();
                    }
                    else
                    {
                        tp.Update(t);
                        LoadDataSource();
                        clsFuntion.ShowMess(Text, COBAOMessage.SUACHUATHANHCONG);
                    }
                }
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
                To t = gvTo.GetRow(gvTo.GetSelectedRows()[0]) as To;
                if (XtraMessageBox.Show(String.Format("Bạn chắc chắn xoá tổ '{0}' không?", t.TenTo.Trim()), Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    tp.Delete(t);
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
        private void gvTo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                btnThemMoi.Enabled = false;
                btnSuaChua.Enabled = btnXoa.Enabled = true;
                var t = gvTo.GetRow(gvTo.GetSelectedRows()[0]) as To;
                cbbMaDoi.EditValue = madoi = (Guid)t.MaDoi;
                mato = t.MaTo;
                txtTenTo.Text = t.TenTo;
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
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}