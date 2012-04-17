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
    public partial class frmGa : DevExpress.XtraEditors.XtraForm
    {
        private GaProvider gp;
        private string tenga;
        private string maga;
        ConditionValidationRule ruleTrong;
        private AlertControl alert;
        public frmGa()
        {
            InitializeComponent();
            gp = new GaProvider();
            ruleTrong = new ConditionValidationRule();
            alert = new AlertControl { AutoFormDelay = COBAOMessage.AlertDelayTime };
        }

        private void frmGa_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            gp = new GaProvider();
            gcGa.DataSource = gp.GetAll();
            txtMaGa.Text = maga = null;
            txtTenGa.Text = tenga = null;
            txtKm.Text = "0";
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
                if (txtMaGa.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtMaGa, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtTenGa.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenGa, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    Ga g = new Ga { MaGa = txtMaGa.Text.Trim(), TenGa = txtTenGa.Text.Trim(), Km = Int32.Parse(txtKm.Text.Trim()) };
                    ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                    if (gp.IsExistedMaGa(g))
                    {
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtMaGa, ruleTrong);
                        dxValid.Validate();
                    }
                    else if (gp.IsExistedTenGa(g))
                    {
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtTenGa, ruleTrong);
                        dxValid.Validate();
                    }
                    else
                    {
                        gp.Insert(g);
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

        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            try
            {
                dxValid.Dispose();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (txtMaGa.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtMaGa, ruleTrong);
                }
                else if (txtTenGa.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenGa, ruleTrong);
                }
                else
                {
                    Ga g = new Ga { MaGa = maga, TenGa = txtTenGa.Text.Trim(), Km = Int32.Parse(txtKm.Text.Trim()) };
                    ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                    if (!maga.Equals(txtMaGa.Text) && gp.IsExistedMaGa(g))
                    {
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtMaGa, ruleTrong);
                    }
                    else if (!tenga.Equals(txtTenGa.Text) && gp.IsExistedTenGa(g))
                    {
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtTenGa, ruleTrong);
                    }
                    else
                    {
                        gp.Update(g);
                        dxValid.Validate();
                        txtMaGa.Enabled = true;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Ga g = gvGa.GetRow(gvGa.GetSelectedRows()[0]) as Ga;
                if (XtraMessageBox.Show(String.Format("Bạn chắc chắn xoá ga '{0}' không?", g.TenGa.Trim()), Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    gp.Delete(g);
                    LoadDataSource();
                    txtMaGa.Enabled = true;
                    clsFuntion.ShowMess(Text, COBAOMessage.XOATHANHCONG);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Lỗi: Không thể xoá dữ liệu đã chọn.{0}{1}", Environment.NewLine, ex.Message), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvGa_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                btnThemMoi.Enabled = false;
                btnSuaChua.Enabled = btnXoa.Enabled = true;
                var g = gvGa.GetRow(gvGa.GetSelectedRows()[0]) as Ga;
                maga = txtMaGa.Text = g.MaGa;
                tenga = txtTenGa.Text = g.TenGa;
                txtKm.Text = g.Km.ToString();
                txtMaGa.Enabled = false;
                btnSuaChua.Enabled = btnXoa.Enabled = true;
                btnThemMoi.Enabled = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            LoadDataSource();
            txtMaGa.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}