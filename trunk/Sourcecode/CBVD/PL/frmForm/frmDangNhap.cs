using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PL.frmForm
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private frmMain frmMain;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        public frmDangNhap(frmMain frmMain)
        {
            // TODO: Complete member initialization
            this.frmMain = frmMain;
        }

        private void frmDanhNhap_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            //throw new NotImplementedException();
        }
    }
}