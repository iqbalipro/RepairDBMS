namespace RepairDBMS
{
    partial class Form_Product_Brand_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_Brand_Device = new System.Windows.Forms.TextBox();
            this.TextBox_Brand_DeviceID = new System.Windows.Forms.TextBox();
            this.Panel_A_Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_A_Home
            // 
            this.Panel_A_Home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_A_Home.Size = new System.Drawing.Size(62, 1030);
            // 
            // Panel_A_Top
            // 
            this.Panel_A_Top.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_A_Top.Size = new System.Drawing.Size(1695, 154);
            // 
            // Panel_A_Bottom
            // 
            this.Panel_A_Bottom.Location = new System.Drawing.Point(62, 966);
            this.Panel_A_Bottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_A_Bottom.Size = new System.Drawing.Size(1695, 64);
            // 
            // Panel_A_Left
            // 
            this.Panel_A_Left.Controls.Add(this.TextBox_Brand_DeviceID);
            this.Panel_A_Left.Controls.Add(this.TextBox_Brand_Device);
            this.Panel_A_Left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_A_Left.Size = new System.Drawing.Size(750, 812);
            // 
            // Panel_A_Right
            // 
            this.Panel_A_Right.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_A_Right.Size = new System.Drawing.Size(945, 812);
            // 
            // TextBox_Brand_Device
            // 
            this.TextBox_Brand_Device.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_Brand_Device.ForeColor = System.Drawing.SystemColors.Info;
            this.TextBox_Brand_Device.Location = new System.Drawing.Point(101, 276);
            this.TextBox_Brand_Device.Name = "TextBox_Brand_Device";
            this.TextBox_Brand_Device.Size = new System.Drawing.Size(413, 26);
            this.TextBox_Brand_Device.TabIndex = 0;
            // 
            // TextBox_Brand_DeviceID
            // 
            this.TextBox_Brand_DeviceID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_Brand_DeviceID.ForeColor = System.Drawing.SystemColors.Info;
            this.TextBox_Brand_DeviceID.Location = new System.Drawing.Point(101, 156);
            this.TextBox_Brand_DeviceID.Name = "TextBox_Brand_DeviceID";
            this.TextBox_Brand_DeviceID.Size = new System.Drawing.Size(413, 26);
            this.TextBox_Brand_DeviceID.TabIndex = 1;
            // 
            // Form_Product_Brand_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1757, 1030);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Product_Brand_List";
            this.Text = "Form_Brand";
            this.Panel_A_Left.ResumeLayout(false);
            this.Panel_A_Left.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Brand_Device;
        private System.Windows.Forms.TextBox TextBox_Brand_DeviceID;
    }
}