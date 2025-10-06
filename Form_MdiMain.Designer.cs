namespace RepairDBMS
{
    partial class Form_MdiMain
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
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.MenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Connection = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Test = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_File,
            this.MenuItem_Help,
            this.MenuItem_Test});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Size = new System.Drawing.Size(1774, 24);
            this.MenuStrip_Main.TabIndex = 1;
            this.MenuStrip_Main.Text = "menuStrip1";
            // 
            // MenuItem_File
            // 
            this.MenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Connection,
            this.MenuItem_Setting,
            this.MenuItem_Logout,
            this.MenuItem_Exit});
            this.MenuItem_File.Name = "MenuItem_File";
            this.MenuItem_File.Size = new System.Drawing.Size(37, 20);
            this.MenuItem_File.Text = "File";
            // 
            // MenuItem_Connection
            // 
            this.MenuItem_Connection.Name = "MenuItem_Connection";
            this.MenuItem_Connection.Size = new System.Drawing.Size(136, 22);
            this.MenuItem_Connection.Text = "Connection";
            // 
            // MenuItem_Setting
            // 
            this.MenuItem_Setting.Name = "MenuItem_Setting";
            this.MenuItem_Setting.Size = new System.Drawing.Size(136, 22);
            this.MenuItem_Setting.Text = "Setting";
            // 
            // MenuItem_Logout
            // 
            this.MenuItem_Logout.Name = "MenuItem_Logout";
            this.MenuItem_Logout.Size = new System.Drawing.Size(136, 22);
            this.MenuItem_Logout.Text = "Logout";
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.Name = "MenuItem_Exit";
            this.MenuItem_Exit.Size = new System.Drawing.Size(136, 22);
            this.MenuItem_Exit.Text = "Exit";
            this.MenuItem_Exit.Click += new System.EventHandler(this.MenuItem_Exit_Click);
            // 
            // MenuItem_Help
            // 
            this.MenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_About});
            this.MenuItem_Help.Name = "MenuItem_Help";
            this.MenuItem_Help.Size = new System.Drawing.Size(44, 20);
            this.MenuItem_Help.Text = "Help";
            // 
            // MenuItem_About
            // 
            this.MenuItem_About.Name = "MenuItem_About";
            this.MenuItem_About.Size = new System.Drawing.Size(107, 22);
            this.MenuItem_About.Text = "About";
            // 
            // MenuItem_Test
            // 
            this.MenuItem_Test.Name = "MenuItem_Test";
            this.MenuItem_Test.Size = new System.Drawing.Size(40, 20);
            this.MenuItem_Test.Text = "Test";
            this.MenuItem_Test.Click += new System.EventHandler(this.MenuItem_Test_Click);
            // 
            // Form_MdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 959);
            this.Controls.Add(this.MenuStrip_Main);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip_Main;
            this.Name = "Form_MdiMain";
            this.Text = "MdiMain";
            this.Load += new System.EventHandler(this.Form_MdiMain_Load);
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Connection;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Setting;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Logout;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_About;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Test;
    }
}

