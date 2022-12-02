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
    public partial class UC_Dashboard : UserControl
    {
        function fn = new function();
        DataSet ds = new DataSet();
        String Query;

        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {

            getRoleCounter("Administrator");
            getRoleCounter("Pharmacist");
            getRoleCounter("Customer");


        }
        private void getRoleCounter(String role) //get the numbers of an user category from db
        {
            Query = "Select count(userRole) from users where userRole='"+ role+"'";
            
            ds = fn.getData(Query);
            Label counter=new Label();
            if (role == "Administrator")
            {
                counter = a_counter;
            }
            else if (role == "Pharmacist")
            {
                counter = p_counter;
            }
            else if (role == "Customer")
            {
                counter = c_counter;
            }

            setRoleCounter(ds, counter);
        }
      
   
        private void setRoleCounter(DataSet ds, Label counter) //insert the numbers of an user category to a label
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                counter.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                counter.Text = "0";
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_Dashboard_Load(this, null);
        }
    }
}
