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
    public partial class frmDoi : DevExpress.XtraEditors.XtraForm
    {
        #region khai bao
        private TramProvider tp;
        private DoiProvider dp;
        private Guid madoi;
        private string tendoi;
        private Guid matram;
        ConditionValidationRule ruleTrong;
        private AlertControl alert;
        #endregion
        #region formload
        public frmDoi()
        {
            InitializeComponent();
            dp = new DoiProvider();
            tp = new TramProvider();
            ruleTrong = new ConditionValidationRule();
            alert = new AlertControl { AutoFormDelay = COBAOMessage.AlertDelayTime };
        }

        private void frmDoi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOBAODataSet.Tram' table. You can move, or remove it, as needed.
            this.tramTableAdapter.Fill(this.cOBAODataSet.Tram);           
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            cbbMaTram.Select();
            tp = new TramProvider();
            dp = new DoiProvider();
            gcDoi.DataSource = dp.GetAll();
            cbbMaTram.Properties.DataSource = tp.GetAll();
            lTram.DataSource = tp.GetAll();
            madoi = new Guid("00000000-0000-0000-0000-000000000000");
            cbbMaTram.EditValue = txtTenDoi.Text = null;
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
                if (cbbMaTram.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbMaTram, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtTenDoi.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenDoi, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    Doi d = new Doi { MaTram = (Guid)cbbMaTram.EditValue, TenDoi = txtTenDoi.Text.Trim()};
                    if (dp.IsExisted(d))
                    {
                        ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtTenDoi, ruleTrong);
                        dxValid.Validate();
                    }
                    else
                    {
                        dp.Insert(d);
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
                txtTenDoi.Text = txtTenDoi.Text.Trim();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
               if (txtTenDoi.Text.Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenDoi, ruleTrong);
                    dxValid.Validate();
                }
                else 
                {
                    Doi d = new Doi {MaDoi = madoi, MaTram =(Guid)cbbMaTram.EditValue, TenDoi = txtTenDoi.Text.Trim()};
                    ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                    if (dp.IsExisted(d))
                    {
                        ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtTenDoi, ruleTrong);
                        dxValid.Validate();
                    }
                    else
                    {                        
                        dp.Update(d);                       
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
                Doi d = gvDoi.GetRow(gvDoi.GetSelectedRows()[0]) as Doi;
                int tontai = 0;
                var t = new ToProvider().GetAll();
                foreach (var item in t)
                {
                    if (item.MaDoi == d.MaDoi)
                        tontai = 1;
                    break;
                }                
                if ((tontai == 1))
                {
                    XtraMessageBox.Show(String.Format("Bạn không xóa được đội '{0}'", d.TenDoi.Trim()), Text, MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else    if (XtraMessageBox.Show(String.Format("Bạn chắc chắn xoá đội '{0}' không?", d.TenDoi.Trim()), Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    dp.Delete(d);
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
        #region do du lieu
        private void gvDoi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                btnThemMoi.Enabled = false;
                btnSuaChua.Enabled = btnXoa.Enabled = true;
                var d = gvDoi.GetRow(gvDoi.GetSelectedRows()[0]) as Doi;
                cbbMaTram.EditValue = matram = (Guid)d.MaTram;
                madoi = d.MaDoi;
                txtTenDoi.Text = d.TenDoi;
                cbbMaTram.Focus();
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