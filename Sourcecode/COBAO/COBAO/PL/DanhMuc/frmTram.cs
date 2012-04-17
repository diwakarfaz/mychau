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
    public partial class frmTram : DevExpress.XtraEditors.XtraForm
    {
        #region khai bao
        private TramProvider tp;
        private string tentram;
        private Guid matram;
        ConditionValidationRule ruleTrong;      
        private AlertControl alert; 
        #endregion
        #region formload
        public frmTram()
        {
            InitializeComponent();
            tp = new TramProvider();
            ruleTrong = new ConditionValidationRule();
            alert = new AlertControl { AutoFormDelay = COBAOMessage.AlertDelayTime };
        }           

        private void frmTram_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            tp = new TramProvider();
            gcTram.DataSource = tp.GetAll();
            matram = new Guid("00000000-0000-0000-0000-000000000000");
            txtTenTram.Text = tentram = null;
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
                if (txtTenTram.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenTram, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    Tram t = new Tram { TenTram = txtTenTram.Text.Trim() };
                    if (tp.IsExisted(t))
                    {
                        ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtTenTram, ruleTrong);
                        dxValid.Validate();
                    }
                    else
                    {
                        tp.Insert(t);
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
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (txtTenTram.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenTram, ruleTrong);
                    dxValid.Validate();
                }
                else if (!tentram.Equals(txtTenTram.Text.Trim()) && matram != new Guid("00000000-0000-0000-0000-000000000000"))
                {
                    Tram t = new Tram { MaTram = matram, TenTram = txtTenTram.Text.Trim() };
                    if (tp.IsExisted(t))
                    {
                        ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtTenTram, ruleTrong);
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
        #region xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Tram t =gvTram.GetRow(gvTram.GetSelectedRows()[0]) as Tram;
                if (XtraMessageBox.Show(String.Format("Bạn chắc chắn xoá trạm '{0}' không?", t.TenTram.Trim()), Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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
        #region do du lieu
        private void gvTram_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                btnThemMoi.Enabled = false;
                btnSuaChua.Enabled = btnXoa.Enabled = true;
                var t = gvTram.GetRow(gvTram.GetSelectedRows()[0]) as Tram;
                matram = t.MaTram;
                tentram = txtTenTram.Text = t.TenTram.Trim();
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