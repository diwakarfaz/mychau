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
    public partial class frmTaiXe : DevExpress.XtraEditors.XtraForm
    {
        #region khai bái
        private ToProvider tp;
        private TaiXeProvider txp;
        private string mataixe;
        private bool tai;
        private Guid mato;
        ConditionValidationRule ruleTrong;
        private AlertControl alert;
        #endregion
        #region formload
        public frmTaiXe()
        {
            InitializeComponent();
            tp = new ToProvider();
            txp = new TaiXeProvider();
            ruleTrong = new ConditionValidationRule();
            alert = new AlertControl { AutoFormDelay = COBAOMessage.AlertDelayTime };
         
        }


        private void frmTaiXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOBAODataSet.To' table. You can move, or remove it, as needed.
            this.toTableAdapter.Fill(this.cOBAODataSet.To);
           
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            cbbMaTo.Select();
            tp = new ToProvider();
            txp = new TaiXeProvider();
            gcTaiXe.DataSource = txp.GetAll();
            cbbMaTo.Properties.DataSource = tp.GetAll();
            lTo.DataSource = tp.GetAll();
            mataixe = txtMaTaiXe.Text = null;
            cbbMaTo.EditValue = txtTenTaiXe.Text =txtDienThoai.Text= null;
            txtHeSoLuong.Text= 0.0+" ";
            txtDiaChi.Text = "";
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
                if (cbbMaTo.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbMaTo, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtMaTaiXe.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtMaTaiXe, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtTenTaiXe.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenTaiXe, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtDienThoai.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtDienThoai, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbTai.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbTai, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    if (cbbTai.EditValue.Equals("Tài")) tai = true;
                    else   tai = false;
                    TaiXe tx = new TaiXe { MaTo = (Guid)cbbMaTo.EditValue, MaTaiXe = txtMaTaiXe.Text.Trim(), TenTaiXe = txtTenTaiXe.Text.Trim(), DiaChi = txtDiaChi.Text.Trim(), DienThoai = txtDienThoai.Text.Trim(),HeSoLuong = Double.Parse(txtHeSoLuong.Text.Trim()), Tai = tai };
                    if (txp.IsExisted(tx))
                    {
                        ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtMaTaiXe, ruleTrong);
                        dxValid.Validate();
                    }
                    else
                    {
                        txp.Insert(tx);
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
                if (cbbMaTo.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbMaTo, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtMaTaiXe.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtMaTaiXe, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtTenTaiXe.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenTaiXe, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtDienThoai.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtDienThoai, ruleTrong);
                    dxValid.Validate();
                }
                else if (cbbTai.EditValue == null)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(cbbTai, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    if (cbbTai.EditValue.Equals("Tài")) tai = true;
                    else   tai = false;
                    TaiXe tx = new TaiXe { MaTaiXe = mataixe, MaTo = (Guid)cbbMaTo.EditValue, TenTaiXe = txtTenTaiXe.Text.Trim(), DienThoai = txtDienThoai.Text.Trim(), DiaChi=txtDiaChi.Text.Trim(), HeSoLuong = Double.Parse(txtHeSoLuong.Text.Trim()), Tai = tai };
                    ruleTrong.ConditionOperator = ConditionOperator.IsBlank;                                  
                    txp.Update(tx);
                    txtMaTaiXe.Enabled = true;
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
                TaiXe tx = gvTaiXe.GetRow(gvTaiXe.GetSelectedRows()[0]) as TaiXe;
                int tontai = 0;
                var cblt = new CoBaoLaiTauProvider().GetAll();
                foreach (var item in cblt)
                {
                    if (item.MaTaiXe == tx.MaTaiXe)
                        tontai = 1;
                    break;
                }
                int tontai2 = 0;
                var cttt = new ChiTietThuongTrucProvider().GetAll();
                foreach (var item in cttt)
                {
                    if (item.MaTaiXe == tx.MaTaiXe)
                        tontai2 = 1;
                    break;
                }
                if ((tontai == 1) || (tontai2 == 1))
                {
                    XtraMessageBox.Show(String.Format("Bạn không xóa được tài xế '{0}'", tx.TenTaiXe.Trim()), Text, MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                if (XtraMessageBox.Show(String.Format("Bạn chắc chắn xoá tài xế có mã '{0}' không?", tx.MaTaiXe.Trim()), Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txp.Delete(tx);
                    LoadDataSource();
                    txtMaTaiXe.Enabled = true;
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
        private void gvTaiXe_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                btnThemMoi.Enabled = false;
                btnSuaChua.Enabled = btnXoa.Enabled = true;
                var tx =gvTaiXe.GetRow(gvTaiXe.GetSelectedRows()[0]) as TaiXe;
                cbbMaTo.EditValue = mato = (Guid)tx.MaTo;
                mataixe = txtMaTaiXe.Text = tx.MaTaiXe;
                txtTenTaiXe.Text = tx.TenTaiXe;
                txtDiaChi.Text = tx.DiaChi;
                txtDienThoai.Text = tx.DienThoai;
                txtHeSoLuong.Text = tx.HeSoLuong.ToString();
                tai = tx.Tai;
                if (tai == true)
                    cbbTai.EditValue = "Tài";
                else cbbTai.EditValue = "Phụ tài";
                txtMaTaiXe.Enabled = false;
                cbbMaTo.Focus();
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
            txtMaTaiXe.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        } 
    }
}