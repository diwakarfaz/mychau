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
    public partial class frmLoaiDauMay : DevExpress.XtraEditors.XtraForm
    {
        private LoaiDMProvider ldmp;
        private string tenloai;
        ConditionValidationRule ruleTrong;
        private Guid maloai;
        private AlertControl alert;
        public frmLoaiDauMay()
        {
            InitializeComponent();
            ldmp = new LoaiDMProvider();
            ruleTrong = new ConditionValidationRule();
            alert = new AlertControl { AutoFormDelay = COBAOMessage.AlertDelayTime };
        }
        private void frmLoaiDauMay_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            ldmp = new LoaiDMProvider();
            gcLoaiDM.DataSource = ldmp.GetAll();
            maloai = new Guid("00000000-0000-0000-0000-000000000000");
            txtTenLoaiDM.Text = tenloai = null;
            txtTanSoThap.Text = txtTrongLuong.Text = 0 + "";
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
                if (txtTenLoaiDM.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenLoaiDM, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    LoaiDauMay ldm = new LoaiDauMay { TenLoai = txtTenLoaiDM.Text.Trim(), TanSoThap = Double.Parse(txtTanSoThap.Text.Trim()), Trongluong = Double.Parse(txtTrongLuong.Text.Trim()) };
                    if (ldmp.IsExisted(ldm))
                    {
                        ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtTenLoaiDM, ruleTrong);
                        dxValid.Validate();
                    }
                    else
                    {
                        ldmp.Insert(ldm);
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

        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            try
            {
                dxValid.Dispose();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (txtTenLoaiDM.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenLoaiDM, ruleTrong);
                }
                else
                {
                    LoaiDauMay ldm = new LoaiDauMay { MaLoai = maloai, TenLoai = txtTenLoaiDM.Text.Trim(), TanSoThap = Double.Parse(txtTanSoThap.Text.Trim()), Trongluong = Double.Parse(txtTrongLuong.Text.Trim()) };
                    ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                    if (!tenloai.Equals(txtTenLoaiDM.Text) && ldmp.IsExisted(ldm))
                    {
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtTenLoaiDM, ruleTrong);
                        dxValid.Validate();
                    }
                    else
                    {
                        ldmp.Update(ldm);
                        dxValid.Validate();
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
                LoaiDauMay ldm = gvLoaiDM.GetRow(gvLoaiDM.GetSelectedRows()[0]) as LoaiDauMay;
                int tontai = 0;
                var dm = new DauMayProvider().GetAll();
                foreach (var item in dm)
                {
                    if (item.MaLoai == ldm.MaLoai)
                        tontai = 1;
                    break;
                }
                if (tontai == 1)
                {
                    XtraMessageBox.Show(String.Format("Bạn không xóa được loại đầu máy '{0}' vì có loại đầu máy trong danh mục đầu máy", ldm.TenLoai.Trim()), Text, MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else  if (XtraMessageBox.Show(String.Format("Bạn chắc chắn xoá loại đầu máy có tên: '{0}' không?", ldm.TenLoai.Trim()), Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ldmp.Delete(ldm);
                    LoadDataSource();
                    clsFuntion.ShowMess(Text, COBAOMessage.XOATHANHCONG);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Lỗi: Không thể xoá dữ liệu đã chọn.{0}{1}", Environment.NewLine, ex.Message), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvLoaiDauMay_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                btnThemMoi.Enabled = false;
                btnSuaChua.Enabled = btnXoa.Enabled = true;
                var ldm = gvLoaiDM.GetRow(gvLoaiDM.GetSelectedRows()[0]) as LoaiDauMay;
                maloai = ldm.MaLoai;
                tenloai = txtTenLoaiDM.Text = ldm.TenLoai;
                txtTanSoThap.Text = ldm.TanSoThap.ToString();
                txtTrongLuong.Text = ldm.Trongluong.ToString();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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