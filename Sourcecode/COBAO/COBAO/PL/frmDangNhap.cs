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

namespace COBAO.PL
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        #region khai báo
        public static string manv;
        public static string pass; 
        public static string chucdanh;
        private NhanVienProvider nvp;
        ConditionValidationRule ruleTrong;
        private AlertControl alert;
        #endregion
        #region formload
        public frmDangNhap()
        {
            InitializeComponent();
            nvp = new NhanVienProvider();
            ruleTrong = new ConditionValidationRule();
            alert = new AlertControl { AutoFormDelay = COBAOMessage.AlertDelayTime };
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region dang nhap
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Length > 0 && txtMatKhau.Text.Length > 0)
            {
                manv = txtMaNhanVien.Text;
                pass = txtMatKhau.Text;
                DoLogin(manv, pass);
            }            
        }
        public void DoLogin(string manv, string pass)
        {
            try
            {
                nvp = new NhanVienProvider();
                List<NhanVien> list = nvp.nvlist(manv);
                if (list.Count == 0)
                {
                    MessageBox.Show("Người dùng không tồn tại trong hệ thống, Xin vui lòng thử lại");
                    txtMaNhanVien.Focus();
                    return;
                }
                string CurrentPassword = list[0].Pass;
                if (pass.Equals(CurrentPassword))
                {
                    COBAOMessage.nhanvien = list[0];
                    this.Hide();
                    frmMain frmmain = new frmMain();                   
                    frmmain.Show();         
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng, Xin vui lòng thử lại");
                    txtMatKhau.Focus();
                    return;
                }
            }
            catch (Exception e) { }
        }
        #endregion
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}