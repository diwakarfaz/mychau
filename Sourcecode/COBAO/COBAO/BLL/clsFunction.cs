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
        public static string PhutRaGio(int n)
        {
            int h, p;
            h = n / 60;
            p = n - (60 * h);
            return h + "h" + p;
        }
        public static int GioRaPhut(string g)
        {
            int h, p;
            string strCut;
            strCut = g.Trim();
            while (strCut.IndexOf(" ") >= 0)    //tim trong chuoi vi tri co      
                strCut = strCut.Replace(" ", "");

            int n;
            n = strCut.IndexOf("h");
            h = int.Parse(strCut.Substring(0, n));
            p = int.Parse(strCut.Substring(n + 1));
            return h*60 + p;
        }
        public static int GioCaBa(DateTime ngaydau, DateTime ngaycuoi)
        {
            int giocaba = 0;
            TimeSpan tinh = ngaycuoi.Subtract(ngaydau);
            int songay = (int)tinh.TotalDays;
            if (ngaydau.ToString() == ngaycuoi.ToString())
                giocaba = 0;
            else if (ngaydau.Hour < ngaycuoi.Hour)
            {
                if (ngaydau.Hour < 6 && ngaycuoi.Hour > 21)
                    giocaba += (6 - ngaydau.Hour) * 60 - ngaydau.Minute + (ngaycuoi.Hour - 22) * 60 + ngaycuoi.Minute;
                else if (ngaydau.Hour < 6 && ngaycuoi.Hour >= 6)
                    giocaba += (6 - ngaydau.Hour) * 60 - ngaydau.Minute;
                else if (ngaydau.Hour <= 21 && ngaycuoi.Hour > 21)
                    giocaba += (ngaycuoi.Hour - 22) * 60 + ngaycuoi.Minute;
                else if ((ngaydau.Hour < 6 && ngaycuoi.Hour < 6) || (ngaydau.Hour > 21 && ngaycuoi.Hour > 21))
                    giocaba += (int)tinh.Hours * 60 + (int)tinh.Minutes;
                giocaba = giocaba + songay * 8 * 60;
            }
            else if (ngaycuoi.Hour == ngaydau.Hour && ngaycuoi.Minute >= ngaydau.Minute)
            {
                giocaba = songay * 8 * 60 + (ngaycuoi.Minute - ngaydau.Minute);
            }
            else if ((ngaycuoi.Hour == ngaydau.Hour && ngaycuoi.Minute < ngaydau.Minute) || (ngaycuoi.Hour < ngaydau.Hour))
            {
                if (ngaydau.Hour < 6 && ngaycuoi.Hour <= ngaydau.Hour)
                    giocaba += (6 - ngaydau.Hour) * 60 - ngaydau.Minute + (8 - (6 - ngaycuoi.Hour)) * 60 + ngaycuoi.Minute;
                else if (ngaydau.Hour < 22 && ngaycuoi.Hour < 6)
                    giocaba += (8 - (6 - ngaycuoi.Hour)) * 60 + ngaycuoi.Minute;
                else if (ngaydau.Hour > 21 && ngaycuoi.Hour < 6)
                    giocaba += (8 - (6 - ngaycuoi.Hour) - (ngaydau.Hour - 22)) * 60 - ngaydau.Minute + ngaycuoi.Minute;
                else if (ngaydau.Hour > 21 && ngaycuoi.Hour > 21)
                    giocaba += (8 - (ngaydau.Hour - 22)) * 60 - ngaydau.Minute + (ngaycuoi.Hour - 22) * 60 + ngaycuoi.Minute;
                else if (ngaydau.Hour < 22 && ngaycuoi.Hour >= 6)
                    giocaba += 8 * 60;
                giocaba = giocaba + (songay) * 8 * 60;
            }
            return giocaba;
        }
    }
}