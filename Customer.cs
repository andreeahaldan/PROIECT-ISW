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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        public Customer(String User)
        {
            InitializeComponent();
            customer_label.Text = User;
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            uC_C_Dashboard1.Visible = true;
            uC_C_Profile1.Visible = false;
            uC_C_ViewPurchase1.Visible = false;
            uC_C_BuyMedicine1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_C_Profile1.Visible = true;
            uC_C_Profile1.BringToFront();
        }

        private void btnViewPurchase_Click(object sender, EventArgs e)
        {
            uC_C_ViewPurchase1.Visible = true;
            uC_C_ViewPurchase1.BringToFront();
        }

        private void btnBuyMedicine_Click(object sender, EventArgs e)
        {
            uC_C_BuyMedicine1.Visible = true;
            uC_C_BuyMedicine1.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_C_Dashboard1.Visible = true;
            uC_C_Dashboard1.BringToFront();
        }
    }
}
