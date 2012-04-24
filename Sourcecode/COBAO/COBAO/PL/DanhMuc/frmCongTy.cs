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
    public partial class frmCongTy : DevExpress.XtraEditors.XtraForm
    {
        #region khai bao
        private CongTyProvider ctp;
        private string tencongty;
        ConditionValidationRule ruleTrong;
        private Guid mact;
        private AlertControl alert;
        #endregion
        #region formload
        public frmCongTy()
        {
            InitializeComponent();
            ctp = new CongTyProvider();
            ruleTrong = new ConditionValidationRule();
            alert = new AlertControl { AutoFormDelay = COBAOMessage.AlertDelayTime };
        }
        private void frmCongTy_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            ctp = new CongTyProvider();
            gcCongTy.DataSource = ctp.GetAll();
            mact = new Guid("00000000-0000-0000-0000-000000000000");
            txtTenCT.Text = tencongty = null;
            dxValid.Dispose();
            btnXoa.Enabled = btnSuaChua.Enabled = false;
            btnThemMoi.Enabled = true;
        }
        #endregion
        #region them
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                dxValid.Dispose();
                txtTenCT.Text = txtTenCT.Text.Trim();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (txtTenCT.Text.Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenCT, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    CongTy ct = new CongTy { TenCT = txtTenCT.Text.Trim() };
                    if (ctp.IsExisted(ct))
                    {
                        ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtTenCT, ruleTrong);
                        dxValid.Validate();
                    }
                    else
                    {
                        ctp.Insert(ct);
                        LoadDataSource();
                        clsFuntion.ShowMess(Text, COBAOMessage.THEMTHANHCONG);
                        btnXoaTrang_Click(null, null);

                    }
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
                txtTenCT.Text = txtTenCT.Text.Trim();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (txtTenCT.Text.Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenCT, ruleTrong);
                    dxValid.Validate();
                }
                else if (!tencongty.Equals(txtTenCT.Text.Trim()) && mact != new Guid("00000000-0000-0000-0000-000000000000"))
                {
                    CongTy ct = new CongTy { MaCT = mact, TenCT = txtTenCT.Text.Trim() };
                    if (ctp.IsExisted(ct))
                    {
                        ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtTenCT, ruleTrong);
                        dxValid.Validate();
                    }
                    else
                    {
                        ctp.Update(ct);
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
        #region xoa

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                CongTy ct = gvCongTy.GetRow(gvCongTy.GetSelectedRows()[0]) as CongTy;
                int tontai = 0;
                var mt = new MacTauProvider().GetAll();
                foreach (var item in mt)
                {
                    if (item.MaCT == ct.MaCT)
                        tontai = 1;
                    break;
                }
                if (tontai == 1)
                {
                    XtraMessageBox.Show(String.Format("Bạn không xóa được côngty '{0}' vì công ty này có trong mác tàu", ct.TenCT.Trim()), Text, MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else if (XtraMessageBox.Show(String.Format("Bạn chắc chắn xoá Công ty có tên: '{0}' không?", ct.TenCT.Trim()), Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ctp.Delete(ct);
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
        #region do du llieu
        private void gvCongTy_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                btnThemMoi.Enabled = false;
                btnSuaChua.Enabled = btnXoa.Enabled = true;
                var ct = gvCongTy.GetRow(gvCongTy.GetSelectedRows()[0]) as CongTy;
                mact = ct.MaCT;
                tencongty = txtTenCT.Text =ct.TenCT.Trim();                
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