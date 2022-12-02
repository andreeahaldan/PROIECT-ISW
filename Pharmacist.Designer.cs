namespace PharmacyStore
{
    partial class Pharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pharmacist_label = new System.Windows.Forms.Label();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedicineValidityCheck = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifyMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewMedicines = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMedicines = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_P_Profile1 = new PharmacyStore.PharmacistUC.UC_P_Profile();
            this.uC_P_MedicineValidityCheck1 = new PharmacyStore.PharmacistUC.UC_P_MedicineValidityCheck();
            this.uC_P_ModifyMedicines1 = new PharmacyStore.PharmacistUC.UC_P_ModifyMedicines();
            this.uC_P_ViewMedicines1 = new PharmacyStore.PharmacistUC.UC_P_ViewMedicines();
            this.uC_P_AddMedicines1 = new PharmacyStore.PharmacistUC.UC_P_AddMedicines();
            this.uC_P_Dashboard1 = new PharmacyStore.PharmacistUC.UC_P_Dashboard();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pharmacist_label);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnMedicineValidityCheck);
            this.panel1.Controls.Add(this.btnModifyMedicine);
            this.panel1.Controls.Add(this.btnViewMedicines);
            this.panel1.Controls.Add(this.btnAddMedicines);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 768);
            this.panel1.TabIndex = 0;
            // 
            // pharmacist_label
            // 
            this.pharmacist_label.AutoSize = true;
            this.pharmacist_label.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pharmacist_label.ForeColor = System.Drawing.Color.Yellow;
            this.pharmacist_label.Location = new System.Drawing.Point(119, 680);
            this.pharmacist_label.Name = "pharmacist_label";
            this.pharmacist_label.Size = new System.Drawing.Size(167, 40);
            this.pharmacist_label.TabIndex = 9;
            this.pharmacist_label.Text = "pharmacist";
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
            this.btnLogOut.Location = new System.Drawing.Point(25, 614);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(300, 45);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
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
            this.btnProfile.Location = new System.Drawing.Point(25, 551);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(300, 45);
            this.btnProfile.TabIndex = 7;
            this.btnProfile.Text = "Update Profile";
            this.btnProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnMedicineValidityCheck
            // 
            this.btnMedicineValidityCheck.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMedicineValidityCheck.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMedicineValidityCheck.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnMedicineValidityCheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMedicineValidityCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicineValidityCheck.ForeColor = System.Drawing.Color.White;
            this.btnMedicineValidityCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicineValidityCheck.Image")));
            this.btnMedicineValidityCheck.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMedicineValidityCheck.ImageSize = new System.Drawing.Size(35, 35);
            this.btnMedicineValidityCheck.Location = new System.Drawing.Point(25, 487);
            this.btnMedicineValidityCheck.Name = "btnMedicineValidityCheck";
            this.btnMedicineValidityCheck.Size = new System.Drawing.Size(300, 45);
            this.btnMedicineValidityCheck.TabIndex = 6;
            this.btnMedicineValidityCheck.Text = "Medicine Validity";
            this.btnMedicineValidityCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMedicineValidityCheck.Click += new System.EventHandler(this.btnMedicineValidityCheck_Click);
            // 
            // btnModifyMedicine
            // 
            this.btnModifyMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnModifyMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnModifyMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnModifyMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModifyMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyMedicine.ForeColor = System.Drawing.Color.White;
            this.btnModifyMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyMedicine.Image")));
            this.btnModifyMedicine.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnModifyMedicine.ImageSize = new System.Drawing.Size(35, 35);
            this.btnModifyMedicine.Location = new System.Drawing.Point(25, 424);
            this.btnModifyMedicine.Name = "btnModifyMedicine";
            this.btnModifyMedicine.Size = new System.Drawing.Size(300, 45);
            this.btnModifyMedicine.TabIndex = 5;
            this.btnModifyMedicine.Text = "Modify Medicine";
            this.btnModifyMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnModifyMedicine.Click += new System.EventHandler(this.btnModifyMedicine_Click);
            // 
            // btnViewMedicines
            // 
            this.btnViewMedicines.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewMedicines.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewMedicines.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewMedicines.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewMedicines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedicines.ForeColor = System.Drawing.Color.White;
            this.btnViewMedicines.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMedicines.Image")));
            this.btnViewMedicines.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnViewMedicines.ImageSize = new System.Drawing.Size(35, 35);
            this.btnViewMedicines.Location = new System.Drawing.Point(25, 363);
            this.btnViewMedicines.Name = "btnViewMedicines";
            this.btnViewMedicines.Size = new System.Drawing.Size(300, 45);
            this.btnViewMedicines.TabIndex = 4;
            this.btnViewMedicines.Text = "View Medicine";
            this.btnViewMedicines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnViewMedicines.Click += new System.EventHandler(this.btnViewMedicines_Click);
            // 
            // btnAddMedicines
            // 
            this.btnAddMedicines.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddMedicines.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddMedicines.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddMedicines.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddMedicines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicines.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicines.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedicines.Image")));
            this.btnAddMedicines.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddMedicines.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddMedicines.Location = new System.Drawing.Point(25, 303);
            this.btnAddMedicines.Name = "btnAddMedicines";
            this.btnAddMedicines.Size = new System.Drawing.Size(300, 45);
            this.btnAddMedicines.TabIndex = 3;
            this.btnAddMedicines.Text = "Add Medicine";
            this.btnAddMedicines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddMedicines.Click += new System.EventHandler(this.btnAddMedicines_Click);
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
            this.btnDashboard.Location = new System.Drawing.Point(25, 240);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(300, 45);
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
            this.label1.Location = new System.Drawing.Point(117, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pharmacist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_P_Profile1);
            this.panel2.Controls.Add(this.uC_P_MedicineValidityCheck1);
            this.panel2.Controls.Add(this.uC_P_ModifyMedicines1);
            this.panel2.Controls.Add(this.uC_P_ViewMedicines1);
            this.panel2.Controls.Add(this.uC_P_AddMedicines1);
            this.panel2.Controls.Add(this.uC_P_Dashboard1);
            this.panel2.Location = new System.Drawing.Point(440, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 768);
            this.panel2.TabIndex = 1;
            // 
            // uC_P_Profile1
            // 
            this.uC_P_Profile1.BackColor = System.Drawing.Color.White;
            this.uC_P_Profile1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_Profile1.Name = "uC_P_Profile1";
            this.uC_P_Profile1.Size = new System.Drawing.Size(940, 768);
            this.uC_P_Profile1.TabIndex = 5;
            // 
            // uC_P_MedicineValidityCheck1
            // 
            this.uC_P_MedicineValidityCheck1.BackColor = System.Drawing.Color.White;
            this.uC_P_MedicineValidityCheck1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_MedicineValidityCheck1.Name = "uC_P_MedicineValidityCheck1";
            this.uC_P_MedicineValidityCheck1.Size = new System.Drawing.Size(940, 768);
            this.uC_P_MedicineValidityCheck1.TabIndex = 4;
            // 
            // uC_P_ModifyMedicines1
            // 
            this.uC_P_ModifyMedicines1.BackColor = System.Drawing.Color.White;
            this.uC_P_ModifyMedicines1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_ModifyMedicines1.Name = "uC_P_ModifyMedicines1";
            this.uC_P_ModifyMedicines1.Size = new System.Drawing.Size(940, 768);
            this.uC_P_ModifyMedicines1.TabIndex = 3;
            // 
            // uC_P_ViewMedicines1
            // 
            this.uC_P_ViewMedicines1.BackColor = System.Drawing.Color.White;
            this.uC_P_ViewMedicines1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_ViewMedicines1.Name = "uC_P_ViewMedicines1";
            this.uC_P_ViewMedicines1.Size = new System.Drawing.Size(940, 768);
            this.uC_P_ViewMedicines1.TabIndex = 2;
            // 
            // uC_P_AddMedicines1
            // 
            this.uC_P_AddMedicines1.BackColor = System.Drawing.Color.White;
            this.uC_P_AddMedicines1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_AddMedicines1.Name = "uC_P_AddMedicines1";
            this.uC_P_AddMedicines1.Size = new System.Drawing.Size(940, 768);
            this.uC_P_AddMedicines1.TabIndex = 1;
            // 
            // uC_P_Dashboard1
            // 
            this.uC_P_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_P_Dashboard1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_Dashboard1.Name = "uC_P_Dashboard1";
            this.uC_P_Dashboard1.Size = new System.Drawing.Size(940, 768);
            this.uC_P_Dashboard1.TabIndex = 0;
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
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist";
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnMedicineValidityCheck;
        private Guna.UI2.WinForms.Guna2Button btnModifyMedicine;
        private Guna.UI2.WinForms.Guna2Button btnViewMedicines;
        private Guna.UI2.WinForms.Guna2Button btnAddMedicines;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PharmacistUC.UC_P_Dashboard uC_P_Dashboard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private PharmacistUC.UC_P_AddMedicines uC_P_AddMedicines1;
        private System.Windows.Forms.Label pharmacist_label;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private PharmacistUC.UC_P_ViewMedicines uC_P_ViewMedicines1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private PharmacistUC.UC_P_ModifyMedicines uC_P_ModifyMedicines1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private PharmacistUC.UC_P_MedicineValidityCheck uC_P_MedicineValidityCheck1;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private PharmacistUC.UC_P_Profile uC_P_Profile1;
    }
}