namespace PharmacyStore.AdministratorUC
{
    partial class UC_Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.a_counter = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSync = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.c_counter = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.p_counter = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.a_counter);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(24, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 638);
            this.panel1.TabIndex = 1;
            // 
            // a_counter
            // 
            this.a_counter.AutoSize = true;
            this.a_counter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.a_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_counter.Location = new System.Drawing.Point(112, 547);
            this.a_counter.Name = "a_counter";
            this.a_counter.Size = new System.Drawing.Size(32, 34);
            this.a_counter.TabIndex = 3;
            this.a_counter.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total number of admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 150);
            this.label5.TabIndex = 1;
            this.label5.Text = "Task performed:\r\n\r\n   ->add user\r\n   ->view user\r\n   ->profile management\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Administrator";
            // 
            // btnSync
            // 
            this.btnSync.FillColor = System.Drawing.Color.White;
            this.btnSync.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSync.ForeColor = System.Drawing.Color.White;
            this.btnSync.Image = ((System.Drawing.Image)(resources.GetObject("btnSync.Image")));
            this.btnSync.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSync.Location = new System.Drawing.Point(291, 32);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(48, 42);
            this.btnSync.TabIndex = 10;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.c_counter);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(632, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 638);
            this.panel2.TabIndex = 17;
            // 
            // c_counter
            // 
            this.c_counter.AutoSize = true;
            this.c_counter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.c_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_counter.Location = new System.Drawing.Point(131, 547);
            this.c_counter.Name = "c_counter";
            this.c_counter.Size = new System.Drawing.Size(32, 34);
            this.c_counter.TabIndex = 7;
            this.c_counter.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(403, 506);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 34);
            this.label10.TabIndex = 5;
            this.label10.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 506);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(243, 25);
            this.label14.TabIndex = 6;
            this.label14.Text = "Total number of customers\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 175);
            this.label6.TabIndex = 2;
            this.label6.Text = "Task performed:\r\n\r\n   ->add medicines\r\n   ->view medicines\r\n   ->medicine managem" +
    "ent\r\n   \r\n\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(298, 465);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "Total number of customers\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.p_counter);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(328, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 638);
            this.panel3.TabIndex = 18;
            // 
            // p_counter
            // 
            this.p_counter.AutoSize = true;
            this.p_counter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_counter.Location = new System.Drawing.Point(118, 547);
            this.p_counter.Name = "p_counter";
            this.p_counter.Size = new System.Drawing.Size(32, 34);
            this.p_counter.TabIndex = 7;
            this.p_counter.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 506);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(248, 25);
            this.label16.TabIndex = 6;
            this.label16.Text = "Total number of pharmacist";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 175);
            this.label7.TabIndex = 2;
            this.label7.Text = "Task performed:\r\n\r\n   ->add medicines\r\n   ->view medicines\r\n   ->medicine managem" +
    "ent\r\n   \r\n\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(298, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Total number of pharmacist";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 32);
            this.label12.TabIndex = 1;
            this.label12.Text = "Pharmacist";
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(940, 768);
            this.Load += new System.EventHandler(this.UC_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label a_counter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnSync;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label p_counter;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label c_counter;
        private System.Windows.Forms.Label label14;
    }
}
