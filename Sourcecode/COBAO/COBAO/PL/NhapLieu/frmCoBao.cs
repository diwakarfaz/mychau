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

namespace COBAO.PL.NhapLieu
{
    public partial class frmCoBao : XtraForm
    {
        private COBAOLINQDataContext db;
        public frmCoBao()
        {
            InitializeComponent();
        }

        private void frmCoBao_Load(object sender, EventArgs e)
        {            
            // TODO: This line of code loads data into the 'cOBAODataSet.MacTau' table. You can move, or remove it, as needed.
            this.macTauTableAdapter.Fill(this.cOBAODataSet.MacTau);
            // TODO: This line of code loads data into the 'cOBAODataSet.DauMay' table. You can move, or remove it, as needed.
            this.dauMayTableAdapter.Fill(this.cOBAODataSet.DauMay);
            // TODO: This line of code loads data into the 'cOBAODataSet.TinhChat' table. You can move, or remove it, as needed.
            this.tinhChatTableAdapter.Fill(this.cOBAODataSet.TinhChat);
            // TODO: This line of code loads data into the 'cOBAODataSet.HanhTrinh' table. You can move, or remove it, as needed.
            this.hanhTrinhTableAdapter.Fill(this.cOBAODataSet.HanhTrinh);
            // TODO: This line of code loads data into the 'cOBAODataSet.Ga' table. You can move, or remove it, as needed.
            gaTableAdapter.Fill(this.cOBAODataSet.Ga);
            // TODO: This line of code loads data into the 'cOBAODataSet.HanhTrinh' table. You can move, or remove it, as needed.
            txtSoCoBao.Focus();
        }

        private void gvHanhTrinh_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["MaHanhTrinh"], Guid.NewGuid());
            view.SetRowCellValue(e.RowHandle, view.Columns["SoCoBao"], txtSoCoBao.Text.Trim());           
        }

       

        //List<HienThiHanhTrinh> GetData()
        //{
        //    List<HienThiHanhTrinh> ret = new List<HienThiHanhTrinh>();
        //    var ls = new HanhTrinhProvider().GetAll();
        //    foreach (var item in ls)
        //    {
        //        HienThiHanhTrinh ht = new HienThiHanhTrinh();
        //        ht.MaGa = item.MaGa;
        //        ht.GioDen = ((DateTime)item.NgayDen).ToShortTimeString();
        //        //ht.GioDi = ((DateTime)item.NgayDi).ToShortTimeString();
        //        //ht.MaTinhChat = item.MaTinhChat;
        //        //ht.NgayDen = ((DateTime)item.NgayGioDen).ToShortDateString();
        //        //ht.NgayDi = ((DateTime)item.NgayGioDi).ToShortDateString();
        //        ht.TrangThaiGa = item.TrangThaiGa;
        //        ret.Add(ht);
        //    }
        //    return ret;
        //}
    }
}