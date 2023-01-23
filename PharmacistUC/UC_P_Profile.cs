using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PharmacyStore.PharmacistUC
{
    public partial class UC_P_Profile : UserControl
    {
        function fn = new function();
        public static string Username;
        String Query;

        public UC_P_Profile()
        {
            InitializeComponent();
        }

        private void UC_P_Profile_Enter(object sender, EventArgs e)
        {
            Query = "select * from users where username='" + Username + "'";
            DataSet ds = fn.getData(Query);
            txtUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
            txtName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDateOfBirth.Text = ds.Tables[0].Rows[0][3].ToString();
            txtMobile.Text = ds.Tables[0].Rows[0][4].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
          
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            UC_P_Profile_Enter(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String Role = txtUserRole.Text;
            String Name = txtName.Text;
            String DoB = txtDateOfBirth.Text;
            Int64 Mobile = Int64.Parse(txtMobile.Text);
            String Email = txtEmail.Text;
            String password = txtPassword.Text;

            Query = "update users set userRole='" + Role + "',name='" + Name + "',dob='" + DoB + "',mobile='" + Mobile + "',email='" + Email + "',pass='" + password + "'where username='" + Username + "'";
            fn.setData(Query, "Profile was updated successfully");
        }
    }
}
