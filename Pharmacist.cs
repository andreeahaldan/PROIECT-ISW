using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyStore.PharmacistUC;

namespace PharmacyStore
{
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }
        public Pharmacist(String User)
        {
            InitializeComponent();
            pharmacist_label.Text = User;
            UC_P_Profile.Username = User;
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = true;
            uC_P_Dashboard1.BringToFront();
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = false;
            uC_P_AddMedicines1.Visible = false;
            uC_P_ViewMedicines1.Visible = false;
            uC_P_ModifyMedicines1.Visible = false;
            uC_P_MedicineValidityCheck1.Visible = false;
            uC_P_Profile1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            Form fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnAddMedicines_Click(object sender, EventArgs e)
        {
            uC_P_AddMedicines1.Visible = true;
            uC_P_AddMedicines1.BringToFront();
        }

        private void btnViewMedicines_Click(object sender, EventArgs e)
        {
            uC_P_ViewMedicines1.Visible = true;
            uC_P_ViewMedicines1.BringToFront();
        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
            uC_P_ModifyMedicines1.Visible = true;
            uC_P_ModifyMedicines1.BringToFront();
        }

        private void btnMedicineValidityCheck_Click(object sender, EventArgs e)
        {
            uC_P_MedicineValidityCheck1.Visible = true;
            uC_P_MedicineValidityCheck1.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_P_Profile1.Visible = true;
            uC_P_Profile1.BringToFront();
        }
    }
}
