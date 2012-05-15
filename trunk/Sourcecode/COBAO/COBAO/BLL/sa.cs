using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace COBAO.BLL
{
    public partial class sa : DevExpress.XtraEditors.XtraForm
    {
        public sa()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(new TaiXeProvider().luong("301", 5, 2012)+"");
        }
    }
}