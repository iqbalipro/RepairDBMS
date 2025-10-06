using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairDBMS
{
    public partial class Form_Sample_B : Form_Sample_A
    {
        public DataGridView DataGV_SB; // <--- declare it here
        public Form_Sample_B()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            DataGV_SB = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            this.Controls.Add(DataGV_SB);
        }

        // Generic method to load any stored procedure into datagv_b
        protected void LoadData(string storedProcedure)
        {
            try
            {
                string connString = Class_ConfigManager.DBConnection;
                if (string.IsNullOrWhiteSpace(connString))
                {
                    MessageBox.Show("Database connection string is not set!");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand(storedProcedure, conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataGV_SB.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


        protected virtual void Button_B_Add_Click(object sender, EventArgs e)
        {

        }

        protected virtual void Button_B_Edit_Click(object sender, EventArgs e)
        {

        }

        protected virtual void Button_B_Delete_Click(object sender, EventArgs e)
        {

        }

        protected virtual void Button_B_Save_Click(object sender, EventArgs e)
        {

        }

        protected virtual void Button_B_View_Click(object sender, EventArgs e)
        {

        }

        protected virtual void Button_B_Close_Click(object sender, EventArgs e)
        {

        }
    }

    
}
