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
    public partial class Form_Product_Brand_List : Form_Sample_B
    {

     public Form_Product_Brand_List()
        {
            InitializeComponent();
            LoadBrandData(); // Populate datagv_b
            DataGV_B.CellClick += DataGV_B_CellClick; // Handle cell click event
        }

        private void LoadBrandData()
        {
            // Example: Using a stored procedure to fetch brand data
            using (SqlConnection conn = new SqlConnection(Class_ConfigManager.DBConnection))
            {
                SqlCommand cmd = new SqlCommand("GetAll_DeviceTBL", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataGV_B.DataSource = dt; // Use the inherited DataGridView
            }
        }

        private void DataGV_B_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Avoid header row
            {
                DataGridViewRow row = DataGV_B.Rows[e.RowIndex];

                TextBox_Brand_DeviceID.Text = row.Cells["DeviceID"].Value.ToString();
                TextBox_Brand_Device.Text = row.Cells["DeviceName"].Value.ToString();
            }
        }
    }
}
