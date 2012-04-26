using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using COBAO.DAL;
using COBAO.BLL;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraBars.Alerter;

namespace COBAO.PL.NhapLieu
{
    public partial class frmCoBao : XtraForm
    {
        private COBAOLINQDataContext db;
        private CoBao1Provider cbp;
        private string socobao;
        private HanhTrinhProvider htp;
        private CoBaoLaiTauProvider cbltp;
        private TheoTauProvider ttp;
        ConditionValidationRule ruleTrong;
        private AlertControl alert;
        public frmCoBao()
        {
            InitializeComponent();
            cbp = new CoBao1Provider();
            htp = new HanhTrinhProvider();
            cbltp = new CoBaoLaiTauProvider();
            ttp = new TheoTauProvider();
            db = new COBAOLINQDataContext();
            ruleTrong = new ConditionValidationRule();
            alert = new AlertControl { AutoFormDelay = COBAOMessage.AlertDelayTime };

        }

        private void frmCoBao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOBAODataSet.TinhChat' table. You can move, or remove it, as needed.
            this.tinhChatTableAdapter.Fill(this.cOBAODataSet.TinhChat);
            // TODO: This line of code loads data into the 'cOBAODataSet.Ga' table. You can move, or remove it, as needed.
            this.gaTableAdapter.Fill(this.cOBAODataSet.Ga);
            // TODO: This line of code loads data into the 'cOBAODataSet.HanhTrinh' table. You can move, or remove it, as needed.          
            hanhTrinhTableAdapter.GetData();
            txtSoCoBao.Focus();
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            txtSoCoBao.Text = null;
            cbbMaDM.EditValue = cbbMaMacTau.EditValue = cbbMaTaiChinh.EditValue = cbbMaTaiPhu.EditValue = null;
            cbbTrangThaiGa = null;
            cbbXepLoai = null;
            txtGioCaBa.Text = txtGioLamViec.Text = txtLuuTruTaiChinh.Text = txtLuuTruTaiPhu.Text = txtThoiGianTruc.Text = null;
            cbp = new CoBao1Provider();
            cbltp = new CoBaoLaiTauProvider();
            htp = new HanhTrinhProvider();
            ttp = new TheoTauProvider();
            var a = (from taixe in db.TaiXes
                        where taixe.Tai.Equals(true)
                         select taixe).ToList();
            cbbMaTaiChinh.Properties.DataSource = a;
            var b = (from taixe1 in db.TaiXes
                         where !(taixe1.MaTaiXe.Equals(cbbMaTaiChinh.EditValue))
                         select taixe1).ToList();
            cbbMaTaiPhu.Properties.DataSource = b; 
            //dxValid.Dispose();
            btnSuaChua.Enabled = btnXoa.Enabled = false;
            btnThemMoi.Enabled = true;
        }

        private void gvHanhTrinh_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["MaHanhTrinh"], Guid.NewGuid());
            view.SetRowCellValue(e.RowHandle, view.Columns["SoCoBao"], txtSoCoBao.Text.Trim());
            //if (view != null)

            //    view.AddNewRow();
        }
        private void txtSoCoBao_TextChanged(object sender, EventArgs e)
        {
            var SelectCmdtxt = (from ht in db.HanhTrinhs
                                where ht.SoCoBao.Equals(txtSoCoBao.Text.Trim())
                                select ht).ToList();
            hanhTrinhBindingSource.DataSource = SelectCmdtxt.ToList();
        }

        private void gcHanhTrinh_Click(object sender, EventArgs e)
        {
            if (txtSoCoBao.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show(String.Format("Bạn hãy nhập cơ báo",Text, MessageBoxButtons.OK, MessageBoxIcon.Question));
                txtSoCoBao.Focus();
            }
        }     

    }
}