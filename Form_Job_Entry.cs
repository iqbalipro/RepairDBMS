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
    public partial class Form_Job_Entry : Form_Sample_B
    {
        public Form_Job_Entry()
        {
            InitializeComponent();
        }
    

        // Button: Fetch iPhone info
        private void btnFetchDevice_Click(object sender, EventArgs e)
        {
            var device = IPhoneDeviceManager.GetDeviceInfo();
            if (device != null)
            {
                TextBox_Entry_Brand.Text = device.DeviceName;
                TextBox_Entry_Serial.Text = device.SerialNumber;
                TextBox_Entry_Version.Text = device.IOSVersion;
                TextBox_Entry_IMEI.Text = device.IMEI;
                TextBox_Entry_ICCID.Text = device.ICCID;
            }
        }

        // Button: Save Job
        private void btnSaveJob_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SqlConnection(Class_ConfigManager.DBConnection))
                {
                    conn.Open();

                    string query = @"INSERT INTO JobDataTBL 
                                    (CustomerName, DeviceName, SerialNumber, IOSVersion, IMEI, ICCID, JobDescription, CreatedAt)
                                     VALUES
                                    (@Customer, @DeviceName, @Serial, @iOS, @IMEI, @ICCID, @JobDesc, @CreatedAt)";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Customer", TextBox_Entry_Customer.Text);
                        cmd.Parameters.AddWithValue("@DeviceName", TextBox_Entry_Brand.Text);
                        cmd.Parameters.AddWithValue("@Serial", TextBox_Entry_Serial.Text);
                        cmd.Parameters.AddWithValue("@iOS", TextBox_Entry_Version.Text);
                        cmd.Parameters.AddWithValue("@IMEI", TextBox_Entry_IMEI.Text);
                        cmd.Parameters.AddWithValue("@ICCID", TextBox_Entry_ICCID.Text);
                        cmd.Parameters.AddWithValue("@JobDesc", TextBox_Entry_Description.Text);
                        cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Job saved successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving job: " + ex.Message);
            }
        }

        // Optional: clear textboxes after save
        private void ClearForm()
        {
            TextBox_Entry_Customer.Text = "";
            TextBox_Entry_Brand.Text = "";
            TextBox_Entry_Serial.Text = "";
            TextBox_Entry_Version.Text = "";
            TextBox_Entry_IMEI.Text = "";
            TextBox_Entry_ICCID.Text = "";
            TextBox_Entry_Description.Text = "";
        }
    }
}
