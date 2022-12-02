using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyStore.AdministratorUC
{
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDateOfBirth.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            String email = txtEmail.Text;
            String username = txtUserName.Text;
            String pass = txtPassword.Text;

            try
            {
                query = "insert into [users] (userRole,name,dob,mobile,email,username,pass) values ('" + role
                    + "' ,'"
                    + name +
                    "','" +
                    dob +
                    "','" +
                    mobile +
                    "','" +
                    email +
                   "','" +
                    username +
                    "','" +
                    pass + "' )";
                fn.setData(query, "Sign Up Succesfull");

            }
            catch (Exception exc)
            {


                MessageBox.Show("'" + exc + "'  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            txtName.Clear();
            txtDateOfBirth.ResetText();
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserRole.SelectedIndex = -1;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from [USERS] where username='" + txtUserName.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation="../.././poze/yes.png";
            }
            else
                pictureBox1.ImageLocation ="../.././poze/no.png";
        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}