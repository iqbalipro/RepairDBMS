using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairDBMS
{
    public partial class Form_MdiMain : Form
    {
        public Form_MdiMain()
        {
            InitializeComponent();
        }

        private void MenuItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItem_Test_Click(object sender, EventArgs e)
        {
            Form_Test form_Test = new Form_Test();
            Class_Form_Manager.ShowWin(form_Test, this);
        }

        private void Form_MdiMain_Load(object sender, EventArgs e)
        {
            Form_Connection form_Connection = new Form_Connection();
            Class_Form_Manager.ShowWin(form_Connection, this);
        }
    }
}
