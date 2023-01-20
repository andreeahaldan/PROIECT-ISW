using PharmacyStore.AdministratorUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyStore
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }
        public Administrator(String user)
        {
            InitializeComponent();
            admin_label.Text = user;
            UC_ViewUser.Username=user;
            UC_Profile.Username = user;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_AddUser1.Visible = false;
            uC_ViewUser1.Visible = false;
            uC_Profile1.Visible = false;
            btnDashboard.PerformClick();

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
        }

        private void uC_Profile1_Load(object sender, EventArgs e)
        {

        }
    }
}
