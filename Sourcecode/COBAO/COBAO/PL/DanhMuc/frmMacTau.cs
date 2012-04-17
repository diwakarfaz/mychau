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
    public partial class frmMacTau : DevExpress.XtraEditors.XtraForm
    {
        #region khai báo
        private DonGiaLuongXLProvider dglxlp;
        private CongTyProvider ctp;
        private MacTauProvider mtp;
        private string mamactau;
        private Guid madongiaxl;
        private Guid mact; 
        ConditionValidationRule ruleTrong;
        private AlertControl alert;
        #endregion
        #region FormLoad
        public frmMacTau()
        {
            InitializeComponent();
            dglxlp = new DonGiaLuongXLProvider();
            ctp = new CongTyProvider();
            mtp = new MacTauProvider();
            ruleTrong = new ConditionValidationRule();
            alert = new AlertControl { AutoFormDelay = COBAOMessage.AlertDelayTime };
        }

        private void frmMacTau_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            txtMaMacTau.Text = txtTenMacTau.Text = null;
            cbbMaCT.EditValue = cbbMaLuongXL.EditValue = null;
            dglxlp = new DonGiaLuongXLProvider();
            ctp = new CongTyProvider();
            mtp = new MacTauProvider();
            gcMacTau.DataSource = mtp.GetAll();
            cbbMaCT.Properties.DataSource = lCongTy.DataSource = ctp.GetAll();
            cbbMaLuongXL.Properties.DataSource =lDonGiaXL.DataSource = dglxlp.GetAll();                      
            dxValid.Dispose();
            btnSuaChua.Enabled = btnXoa.Enabled = false;
            btnThemMoi.Enabled = true;
        }
        #endregion
        #region Thêm

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                dxValid.Dispose();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (txtMaMacTau.Text.Trim().Length==0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtMaMacTau, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtTenMacTau.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenMacTau, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbMaCT.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbMaCT, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbMaLuongXL.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbMaLuongXL, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    MacTau mt = new MacTau { MaMacTau = txtMaMacTau.Text.Trim(), TenMacTau = txtTenMacTau.Text.Trim(), MaCT = (Guid)cbbMaCT.EditValue, MaLuongXL =(Guid)cbbMaLuongXL.EditValue};
                    if (mtp.IsExisted(mt))
                    {
                        ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtMaMacTau, ruleTrong);
                        dxValid.Validate();
                    }
                    else
                    {
                        mtp.Insert(mt);
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
        #region Sửa
        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            try
            {
                dxValid.Dispose();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (txtMaMacTau.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtMaMacTau, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtTenMacTau.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenMacTau, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbMaCT.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbMaCT, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbMaLuongXL.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbMaLuongXL, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    MacTau mt = new MacTau { MaMacTau = mamactau, MaCT = (Guid)cbbMaCT.EditValue, MaLuongXL= (Guid)cbbMaLuongXL.EditValue,TenMacTau = txtTenMacTau.Text.Trim()};
                    ruleTrong.ConditionOperator = ConditionOperator.IsBlank;                                  
                    mtp.Update(mt);
                    txtMaMacTau.Enabled = true;
                    LoadDataSource();
                    clsFuntion.ShowMess(Text, COBAOMessage.SUACHUATHANHCONG);                   
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
                MacTau mt = gvMacTau.GetRow(gvMacTau.GetSelectedRows()[0]) as MacTau;
                if (XtraMessageBox.Show(String.Format("Bạn chắc chắn xoá các tàu có mã '{0}' không?", mt.MaMacTau.Trim()), Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    mtp.Delete(mt);
                    LoadDataSource();
                    txtMaMacTau.Enabled = true;
                    clsFuntion.ShowMess(Text, COBAOMessage.XOATHANHCONG);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Lỗi: Không thể xoá dữ liệu đã chọn.{0}{1}", Environment.NewLine, ex.Message), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region đõ dữ liệu
        private void gvMacTau_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                btnThemMoi.Enabled = false;
                btnSuaChua.Enabled = btnXoa.Enabled = true;
                var mt =gvMacTau.GetRow(gvMacTau.GetSelectedRows()[0]) as MacTau;
                mamactau = txtMaMacTau.Text = mt.MaMacTau;
                txtTenMacTau.Text = mt.TenMacTau;
                cbbMaCT.EditValue = mact = (Guid)mt.MaCT;
                cbbMaLuongXL.EditValue = madongiaxl = (Guid)mt.MaLuongXL;
                txtMaMacTau.Enabled = false;
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
            txtMaMacTau.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

             
    }
}