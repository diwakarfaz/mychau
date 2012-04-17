using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace COBAO.PL.NhapLieu
{
    public partial class frmCoBao : DevExpress.XtraEditors.XtraForm
    {
        public frmCoBao()
        {
            InitializeComponent();
        }

        private void frmCoBao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOBAODataSet.Ga' table. You can move, or remove it, as needed.
            this.gaTableAdapter.Fill(this.cOBAODataSet.Ga);
            // TODO: This line of code loads data into the 'cOBAODataSet.TaiXe' table. You can move, or remove it, as needed.
            this.taiXeTableAdapter.Fill(this.cOBAODataSet.TaiXe);
            // TODO: This line of code loads data into the 'cOBAODataSet.MacTau' table. You can move, or remove it, as needed.
            this.macTauTableAdapter.Fill(this.cOBAODataSet.MacTau);
            // TODO: This line of code loads data into the 'cOBAODataSet.DauMay' table. You can move, or remove it, as needed.
            this.dauMayTableAdapter.Fill(this.cOBAODataSet.DauMay);

        }
    }
}