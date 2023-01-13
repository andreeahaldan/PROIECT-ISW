using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;

namespace PharmacyStore
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
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

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
       {

           DataSet ds;
       
            InjectionChecker inj_check= new InjectionChecker();
            if (txtUsername.Text != "")
                if (!inj_check.WordCheck(txtUsername.Text))
                {
                    query = "Select * from users where username='" + txtUsername.Text + "'and pass='" + txtPassword.Text + "'";
                    ds = fn.getData(query);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        String role = ds.Tables[0].Rows[0][1].ToString();

                        if (role == "Administrator")
                        {
                            Administrator admin = new Administrator(txtUsername.Text);
                            admin.Show();
                            this.Hide();
                        }
                        else if (role == "Pharmacist")
                        {
                            Pharmacist pharm = new Pharmacist(txtUsername.Text);
                            pharm.Show();
                            this.Hide();

                        }
                        else if (role == "Customer")
                        {
                            Customer customer = new Customer(txtUsername.Text);
                            customer.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            else MessageBox.Show("Risk detected, aborting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

       }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
