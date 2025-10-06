using System;
using System.Windows.Forms;

namespace RepairDBMS
{
    public partial class Form_Connection : Form_Sample_B
    {
        public Form_Connection()
        {
            InitializeComponent();
        }

        private void Form_Connection_Load(object sender, EventArgs e)
        {
            // Load current settings into textboxes
            TextBox_Connection_DBConnection.Text = Class_ConfigManager.DBConnection;
            TextBox_Connection_LibMobile.Text = Class_ConfigManager.LibMobileDevice;
            TextBox_Connection_Log.Text = Class_ConfigManager.LogsFolder;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Save updated settings
                Class_ConfigManager.Set("DBConnection", TextBox_Connection_DBConnection.Text);
                Class_ConfigManager.Set("LibMobileDevice", TextBox_Connection_LibMobile.Text);
                Class_ConfigManager.Set("Logs", TextBox_Connection_Log.Text);

                MessageBox.Show("Settings saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving settings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseLibMobile_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select libimobiledevice folder";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    TextBox_Connection_LibMobile.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnBrowseLogs_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select Logs folder";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    TextBox_Connection_Log.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
