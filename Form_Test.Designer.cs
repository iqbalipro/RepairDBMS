namespace RepairDBMS
{
    partial class Form_Test
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Panel_A_Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_A_Home
            // 
            this.Panel_A_Home.Size = new System.Drawing.Size(109, 860);
            // 
            // Panel_A_Top
            // 
            this.Panel_A_Top.Location = new System.Drawing.Point(109, 0);
            this.Panel_A_Top.Size = new System.Drawing.Size(1213, 154);
            // 
            // Panel_A_Bottom
            // 
            this.Panel_A_Bottom.Location = new System.Drawing.Point(109, 760);
            this.Panel_A_Bottom.Size = new System.Drawing.Size(1213, 100);
            // 
            // Panel_A_Left
            // 
            this.Panel_A_Left.Controls.Add(this.button3);
            this.Panel_A_Left.Controls.Add(this.button2);
            this.Panel_A_Left.Controls.Add(this.button1);
            this.Panel_A_Left.Location = new System.Drawing.Point(109, 154);
            this.Panel_A_Left.Size = new System.Drawing.Size(750, 606);
            // 
            // Panel_A_Right
            // 
            this.Panel_A_Right.Location = new System.Drawing.Point(859, 154);
            this.Panel_A_Right.Size = new System.Drawing.Size(463, 606);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(87, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "connection";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(269, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 52);
            this.button3.TabIndex = 5;
            this.button3.Text = "brand";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 860);
            this.Name = "Form_Test";
            this.Text = "Form_Test";
            this.Panel_A_Left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}