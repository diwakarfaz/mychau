using System;
using DevExpress.XtraBars.Alerter;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Security.Cryptography;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace COBAO.BLL
{
    class clsFuntion
    {

        public static void AddMdiChild(Form parentFrm, Form childFrm)
        {
            Form[] childArr = parentFrm.MdiChildren;
            bool isExist = false;
            Form currentForm = null;

            foreach (Form f in childArr)
            {
                if (f.Name == childFrm.Name)
                {
                    isExist = true;
                    currentForm = f;
                    break;
                }
            }

            if (isExist == true)
            {
                currentForm.Select();
            }
            else
            {
                childFrm.MdiParent = parentFrm;
                childFrm.Show();
            }
        }
        public static void ShowMess(string Title, string Mess)
        {
            AlertControl alert = new AlertControl();
            {
                if (COBAOMessage.AutoCloseAlert)
                    alert.AutoFormDelay = COBAOMessage.AlertDelayTime;
                alert.Show(null, Title, Mess);
            }
        }
    }
}