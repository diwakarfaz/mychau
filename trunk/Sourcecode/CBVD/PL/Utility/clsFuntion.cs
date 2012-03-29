using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PL.Utility
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

    }
}
