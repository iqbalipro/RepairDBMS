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
    public partial class Form_Test : Form_Sample_A
    {
        public Form_Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Job_Entry jobEntryForm = new Form_Job_Entry();
            Class_Form_Manager.ShowWin(jobEntryForm, MdiParent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Connection connectionForm = new Form_Connection();
            Class_Form_Manager.ShowWin(connectionForm, MdiParent);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Product_Brand_List brandListForm = new Form_Product_Brand_List();
            Class_Form_Manager.ShowWin(brandListForm, MdiParent);
        }
    }
}
