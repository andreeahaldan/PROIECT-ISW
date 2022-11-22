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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="admin" && txtPassword.Text=="1234")
            {
                Administrator admin = new Administrator();
                admin.Show();
                this.Hide();
            }
            else if (txtUsername.Text == "pharmacist" && txtPassword.Text == "4321")
            {
                Pharmacist pharm = new Pharmacist();
                pharm.Show();
                this.Hide();
            }
            else if (txtUsername.Text == "customer" && txtPassword.Text == "1111")
            {
                Customer customer = new Customer();
                customer.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
