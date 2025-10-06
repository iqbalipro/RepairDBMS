using RepairDBMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairDBMS
{
    internal class Class_Form_Manager
    {
        // Open a form and close a specific one
        public static void ShowWin(Form openWin, Form closeWin, Form mdi)
        {
            if (closeWin != null && !closeWin.IsDisposed)
            {
                closeWin.Close();
            }

            if (openWin != null && mdi != null)
            {
                openWin.MdiParent = mdi;
                openWin.WindowState = FormWindowState.Maximized; // optional
                openWin.Show();
            }
        }

        // Open a form only
        public static void ShowWin(Form openWin, Form mdi)
        {
            if (openWin != null && mdi != null)
            {
                openWin.MdiParent = mdi;
                openWin.WindowState = FormWindowState.Maximized; // optional
                openWin.Show();
            }
        }
    }
}

                //// Open new form and close a specific one
                //Class_Form_Manager.ShowWin(new Form_Test(), currentForm, this);

                //// Or just open a new form
                //Class_Form_Manager.ShowWin(new Form_Users(), this);

