using System;
using COBAO.BLL;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors.DXErrorProvider;
using COBAO.DAL;
using DevExpress.XtraEditors;
using System.Windows.Forms;


namespace COBAO.PL.DanhMuc
{
    public partial class frmTinhChat : DevExpress.XtraEditors.XtraForm
    {
        #region Khai báo
        private TinhChatProvider tcp;
        private string tentinhchat;
        private string matinhchat;
        ConditionValidationRule ruleTrong;
        private AlertControl alert;
        #endregion
        #region Form load
        public frmTinhChat()
        {
            InitializeComponent();
            tcp = new TinhChatProvider();
            ruleTrong = new ConditionValidationRule();
            alert = new AlertControl { AutoFormDelay = COBAOMessage.AlertDelayTime };
        }

        private void frmTinhChat_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            tcp = new TinhChatProvider();
            gcTinhChat.DataSource = tcp.GetAll();
            txtMaTinhChat.Text = matinhchat = null;
            txtTenTinhChat.Text = tentinhchat = null;
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
                if (txtMaTinhChat.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtMaTinhChat, ruleTrong);
                    dxValid.Validate();
                }
                else if (txtTenTinhChat.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenTinhChat, ruleTrong);
                    dxValid.Validate();
                }
                else
                {
                    TinhChat tc = new TinhChat { MaTinhChat = txtMaTinhChat.Text.Trim(), TenTinhChat = txtTenTinhChat.Text.Trim() };
                    ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                    if (tcp.IsExisted(tc))
                    {
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtMaTinhChat, ruleTrong);
                        dxValid.Validate();
                    }
                    else if (tcp.IsExistedTenTinhChat(tc))
                    {
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtTenTinhChat, ruleTrong);
                        dxValid.Validate();
                    }
                    else
                    {
                        tcp.Insert(tc);
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
        #region Update
        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            try
            {
                dxValid.Dispose();
                ruleTrong.ConditionOperator = ConditionOperator.IsNotBlank;
                if (txtMaTinhChat.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtMaTinhChat, ruleTrong);
                }
                else if (txtTenTinhChat.Text.Trim().Length == 0)
                {
                    ruleTrong.ErrorText = COBAOMessage.KHONGDUOCTRONG;
                    dxValid.SetValidationRule(txtTenTinhChat, ruleTrong);
                }
                else
                {
                    TinhChat tc = new TinhChat { MaTinhChat = matinhchat, TenTinhChat = txtTenTinhChat.Text.Trim()};
                    ruleTrong.ConditionOperator = ConditionOperator.IsBlank;
                    if (!tentinhchat.Equals(txtTenTinhChat.Text) && tcp.IsExistedTenTinhChat(tc))
                    {
                        ruleTrong.ErrorText = COBAOMessage.DATONTAI;
                        dxValid.SetValidationRule(txtTenTinhChat, ruleTrong);
                    }
                    else
                    {
                        tcp.Update(tc);
                        dxValid.Validate();
                        txtMaTinhChat.Enabled = true;
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
                TinhChat tc = gvTinhChat.GetRow(gvTinhChat.GetSelectedRows()[0]) as TinhChat;
                int tontai = 0;
                var ht = new HanhTrinhProvider().GetAll();
                foreach (var item in ht)
                {
                    if (item.MaTinhChat == tc.MaTinhChat)
                        tontai = 1;
                    break;
                }
                if (tontai == 1)
                {
                    XtraMessageBox.Show(String.Format("Bạn không xóa được tính chát '{0}' vì tính chất này đã sử dụng", tc.TenTinhChat.Trim()), Text, MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else  if (XtraMessageBox.Show(String.Format("Bạn chắc chắn xoá tính chất '{0}' không?", tc.TenTinhChat.Trim()), Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    tcp.Delete(tc);
                    LoadDataSource();
                    txtMaTinhChat.Enabled = true;
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
        private void gvTinhChat_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                btnThemMoi.Enabled = false;
                btnSuaChua.Enabled = btnXoa.Enabled = true;
                var tc = gvTinhChat.GetRow(gvTinhChat.GetSelectedRows()[0]) as TinhChat;
                matinhchat = txtMaTinhChat.Text = tc.MaTinhChat;
                tentinhchat = txtTenTinhChat.Text = tc.TenTinhChat;
                txtMaTinhChat.Enabled = false;
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
            txtMaTinhChat.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}