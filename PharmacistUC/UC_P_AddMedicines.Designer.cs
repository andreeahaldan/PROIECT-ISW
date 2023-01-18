namespace PharmacyStore.PharmacistUC
{
    partial class UC_P_AddMedicines
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMNr = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPPU = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtManDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtExpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_AddMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Reset = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Medicine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Medicine ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medicine Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Medicine Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Manufacturing Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(501, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Expired Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(501, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Quantity";
            // 
            // txtMID
            // 
            this.txtMID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMID.DefaultText = "";
            this.txtMID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMID.ForeColor = System.Drawing.Color.Black;
            this.txtMID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMID.Location = new System.Drawing.Point(69, 187);
            this.txtMID.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtMID.Name = "txtMID";
            this.txtMID.PasswordChar = '\0';
            this.txtMID.PlaceholderText = "";
            this.txtMID.SelectedText = "";
            this.txtMID.Size = new System.Drawing.Size(340, 36);
            this.txtMID.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(501, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Price Per Unit";
            // 
            // txtMName
            // 
            this.txtMName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMName.DefaultText = "";
            this.txtMName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMName.ForeColor = System.Drawing.Color.Black;
            this.txtMName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMName.Location = new System.Drawing.Point(69, 282);
            this.txtMName.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtMName.Name = "txtMName";
            this.txtMName.PasswordChar = '\0';
            this.txtMName.PlaceholderText = "";
            this.txtMName.SelectedText = "";
            this.txtMName.Size = new System.Drawing.Size(340, 36);
            this.txtMName.TabIndex = 11;
            // 
            // txtMNr
            // 
            this.txtMNr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMNr.DefaultText = "";
            this.txtMNr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMNr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMNr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMNr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMNr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMNr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMNr.ForeColor = System.Drawing.Color.Black;
            this.txtMNr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMNr.Location = new System.Drawing.Point(69, 383);
            this.txtMNr.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtMNr.Name = "txtMNr";
            this.txtMNr.PasswordChar = '\0';
            this.txtMNr.PlaceholderText = "";
            this.txtMNr.SelectedText = "";
            this.txtMNr.Size = new System.Drawing.Size(340, 36);
            this.txtMNr.TabIndex = 12;
            // 
            // txtQuan
            // 
            this.txtQuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuan.DefaultText = "";
            this.txtQuan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuan.ForeColor = System.Drawing.Color.Black;
            this.txtQuan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuan.Location = new System.Drawing.Point(507, 282);
            this.txtQuan.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.PasswordChar = '\0';
            this.txtQuan.PlaceholderText = "";
            this.txtQuan.SelectedText = "";
            this.txtQuan.Size = new System.Drawing.Size(340, 36);
            this.txtQuan.TabIndex = 13;
            // 
            // txtPPU
            // 
            this.txtPPU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPPU.DefaultText = "";
            this.txtPPU.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPPU.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPPU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPPU.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPPU.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPPU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPU.ForeColor = System.Drawing.Color.Black;
            this.txtPPU.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPPU.Location = new System.Drawing.Point(507, 383);
            this.txtPPU.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtPPU.Name = "txtPPU";
            this.txtPPU.PasswordChar = '\0';
            this.txtPPU.PlaceholderText = "";
            this.txtPPU.SelectedText = "";
            this.txtPPU.Size = new System.Drawing.Size(340, 36);
            this.txtPPU.TabIndex = 14;
            // 
            // txtManDate
            // 
            this.txtManDate.BorderThickness = 1;
            this.txtManDate.Checked = true;
            this.txtManDate.FillColor = System.Drawing.Color.White;
            this.txtManDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtManDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtManDate.Location = new System.Drawing.Point(69, 474);
            this.txtManDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtManDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtManDate.Name = "txtManDate";
            this.txtManDate.Size = new System.Drawing.Size(340, 36);
            this.txtManDate.TabIndex = 15;
            this.txtManDate.Value = new System.DateTime(2022, 11, 15, 22, 19, 19, 365);
            this.txtManDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtManDate_MouseClick);
            // 
            // txtExpDate
            // 
            this.txtExpDate.BorderThickness = 1;
            this.txtExpDate.Checked = true;
            this.txtExpDate.FillColor = System.Drawing.Color.White;
            this.txtExpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtExpDate.Location = new System.Drawing.Point(507, 187);
            this.txtExpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtExpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(340, 36);
            this.txtExpDate.TabIndex = 16;
            this.txtExpDate.Value = new System.DateTime(2022, 11, 15, 22, 19, 19, 365);
            this.txtExpDate.Click += new System.EventHandler(this.txtExpDate_Click);
            // 
            // btn_AddMedicine
            // 
            this.btn_AddMedicine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_AddMedicine.BorderRadius = 12;
            this.btn_AddMedicine.BorderThickness = 1;
            this.btn_AddMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_AddMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddMedicine.ForeColor = System.Drawing.Color.White;
            this.btn_AddMedicine.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_AddMedicine.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_AddMedicine.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_AddMedicine.Location = new System.Drawing.Point(507, 465);
            this.btn_AddMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddMedicine.Name = "btn_AddMedicine";
            this.btn_AddMedicine.Size = new System.Drawing.Size(159, 46);
            this.btn_AddMedicine.TabIndex = 17;
            this.btn_AddMedicine.Text = "Add";
            this.btn_AddMedicine.Click += new System.EventHandler(this.btn_AddMedicine_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_Reset.BorderRadius = 12;
            this.btn_Reset.BorderThickness = 1;
            this.btn_Reset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_Reset.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Reset.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_Reset.Location = new System.Drawing.Point(688, 465);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(159, 46);
            this.btn_Reset.TabIndex = 18;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel2.Location = new System.Drawing.Point(457, 122);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 500);
            this.panel2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(529, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 75);
            this.label9.TabIndex = 23;
            this.label9.Text = "*Check the details before add\r\n              a new medicine\r\n\r\n";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_P_AddMedicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_AddMedicine);
            this.Controls.Add(this.txtExpDate);
            this.Controls.Add(this.txtManDate);
            this.Controls.Add(this.txtPPU);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.txtMNr);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_P_AddMedicines";
            this.Size = new System.Drawing.Size(940, 768);
            this.Load += new System.EventHandler(this.UC_P_AddMedicines_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtMID;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtMName;
        private Guna.UI2.WinForms.Guna2TextBox txtMNr;
        private Guna.UI2.WinForms.Guna2TextBox txtQuan;
        private Guna.UI2.WinForms.Guna2TextBox txtPPU;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtManDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtExpDate;
        private Guna.UI2.WinForms.Guna2Button btn_AddMedicine;
        private Guna.UI2.WinForms.Guna2Button btn_Reset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
