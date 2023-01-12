namespace PharmacyStore
{
    partial class Customer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.customer_label = new System.Windows.Forms.Label();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuyMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_C_Dashboard1 = new PharmacyStore.CustomerUC.UC_C_Dashboard();
            this.uC_C_BuyMedicine1 = new PharmacyStore.CustomerUC.UC_C_BuyMedicine();
            this.uC_C_Profile1 = new PharmacyStore.CustomerUC.UC_C_Profile();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.customer_label);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnBuyMedicine);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 768);
            this.panel1.TabIndex = 1;
            // 
            // customer_label
            // 
            this.customer_label.AutoSize = true;
            this.customer_label.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_label.ForeColor = System.Drawing.Color.Yellow;
            this.customer_label.Location = new System.Drawing.Point(135, 668);
            this.customer_label.Name = "customer_label";
            this.customer_label.Size = new System.Drawing.Size(143, 40);
            this.customer_label.TabIndex = 7;
            this.customer_label.Text = "customer";
            // 
            // btnLogOut
            // 
            this.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLogOut.ImageSize = new System.Drawing.Size(35, 35);
            this.btnLogOut.Location = new System.Drawing.Point(105, 506);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(240, 45);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProfile.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnProfile.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnProfile.ImageSize = new System.Drawing.Size(35, 35);
            this.btnProfile.Location = new System.Drawing.Point(105, 437);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(240, 45);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Update Profile";
            this.btnProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnBuyMedicine
            // 
            this.btnBuyMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBuyMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnBuyMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnBuyMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuyMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyMedicine.ForeColor = System.Drawing.Color.White;
            this.btnBuyMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnBuyMedicine.Image")));
            this.btnBuyMedicine.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBuyMedicine.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBuyMedicine.Location = new System.Drawing.Point(105, 373);
            this.btnBuyMedicine.Name = "btnBuyMedicine";
            this.btnBuyMedicine.Size = new System.Drawing.Size(240, 45);
            this.btnBuyMedicine.TabIndex = 3;
            this.btnBuyMedicine.Text = "Buy Medicine";
            this.btnBuyMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBuyMedicine.Click += new System.EventHandler(this.btnBuyMedicine_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDashboard.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDashboard.Location = new System.Drawing.Point(105, 302);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(240, 45);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_C_Dashboard1);
            this.panel2.Controls.Add(this.uC_C_BuyMedicine1);
            this.panel2.Controls.Add(this.uC_C_Profile1);
            this.panel2.Location = new System.Drawing.Point(440, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 768);
            this.panel2.TabIndex = 2;
            // 
            // uC_C_Dashboard1
            // 
            this.uC_C_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_C_Dashboard1.Location = new System.Drawing.Point(0, 0);
            this.uC_C_Dashboard1.Name = "uC_C_Dashboard1";
            this.uC_C_Dashboard1.Size = new System.Drawing.Size(940, 768);
            this.uC_C_Dashboard1.TabIndex = 3;
            // 
            // uC_C_BuyMedicine1
            // 
            this.uC_C_BuyMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_C_BuyMedicine1.Location = new System.Drawing.Point(0, 0);
            this.uC_C_BuyMedicine1.Name = "uC_C_BuyMedicine1";
            this.uC_C_BuyMedicine1.Size = new System.Drawing.Size(940, 768);
            this.uC_C_BuyMedicine1.TabIndex = 2;
            // 
            // uC_C_Profile1
            // 
            this.uC_C_Profile1.BackColor = System.Drawing.Color.White;
            this.uC_C_Profile1.Location = new System.Drawing.Point(0, 0);
            this.uC_C_Profile1.Name = "uC_C_Profile1";
            this.uC_C_Profile1.Size = new System.Drawing.Size(940, 768);
            this.uC_C_Profile1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label customer_label;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnBuyMedicine;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private CustomerUC.UC_C_Profile uC_C_Profile1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
     //   private CustomerUC.UC_C_ViewPurchase uC_C_ViewPurchase1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private CustomerUC.UC_C_BuyMedicine uC_C_BuyMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private CustomerUC.UC_C_Dashboard uC_C_Dashboard1;
    }
}