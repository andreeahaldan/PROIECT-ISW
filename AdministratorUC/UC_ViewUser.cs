using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyStore.AdministratorUC
{
    public partial class UC_ViewUser : UserControl
    {
        function fn = new function();
        String Selected_Username;
        public static string Username;

        public UC_ViewUser()
        {
            InitializeComponent();
        }

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            String query = "Select * from users";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            String query = "Select * from users where username like '" + txtUserName.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                Selected_Username = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (Selected_Username == Username)
                {
                    MessageBox.Show("You can't delete your own profile");
                }
                else
                {
                    String Query = "delete from users where username='" + Selected_Username + "'";
                    fn.setData(Query, "User data was deleted");
                    UC_ViewUser_Load(this, null);
                }
            }

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < guna2DataGridView1.Columns.Count; i++)
            {
                if (guna2DataGridView1.Columns[i].HeaderCell.Value.Equals("pass"))
                {
                    guna2DataGridView1.Columns[i].HeaderCell.Value = "Password";
                }
                if (guna2DataGridView1.Columns[i].HeaderCell.Value.Equals("dob"))
                {
                    guna2DataGridView1.Columns[i].HeaderCell.Value = "Date of Birth";
                }

                guna2DataGridView1.Columns[i].HeaderCell.Value = guna2DataGridView1.Columns[i].HeaderCell.Value.ToString().ToUpper();
            }
        }
    }
}
