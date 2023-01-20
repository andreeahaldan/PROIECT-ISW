using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace PharmacyStore.PharmacistUC
{
    public partial class UC_P_MedicineValidityCheck : UserControl
    {
        function fn = new function();
        String query;
       

        public UC_P_MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void txtCheckbox_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            String localdate= DateTime.Today.ToString("dd.MM.yyyy");


            if (txtCheckbox.SelectedIndex == 0)
            {
              //  query = "select * from medicine where eDate >=FORMAT (getdate(), 'dd.MM.yyyy')";
                String query2 = "select * from medicine where eDate >='"+localdate+"'";
                setDataGridView(query2, "Valid medicines", Color.Green);
                MessageBox.Show(query2);
               
            }
            else if (txtCheckbox.SelectedIndex == 1)
            {
                query = "select * from medicine where eDate <= FORMAT (getdate(), 'dd.MM.yyyy')";
                String query2 = "select * from medicine where eDate <='" + localdate + "'";
                MessageBox.Show(query2);
                setDataGridView(query2, "Expired medicines", Color.Red);

            }
            else if (txtCheckbox.SelectedIndex == 2)
            {
                query = "select * from medicine";
                setDataGridView(query, "Medicines", Color.Black);

            }
        }
        private void setDataGridView(String query, String labelname, Color col)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            setLabel.Text = labelname;
            setLabel.ForeColor = col;

        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < guna2DataGridView1.Columns.Count; i++)
            {
                if (guna2DataGridView1.Columns[i].HeaderCell.Value.Equals("mnumber"))
                {
                    guna2DataGridView1.Columns[i].HeaderCell.Value = "Lot Number";
                }
                if (guna2DataGridView1.Columns[i].HeaderCell.Value.Equals("eDate"))
                {
                    guna2DataGridView1.Columns[i].HeaderCell.Value = "Expire Date";
                }
                if (guna2DataGridView1.Columns[i].HeaderCell.Value.Equals("mDate"))
                {
                    guna2DataGridView1.Columns[i].HeaderCell.Value = "Manufacture Date";
                }
                if (guna2DataGridView1.Columns[i].HeaderCell.Value.Equals("perUnit"))
                {
                    guna2DataGridView1.Columns[i].HeaderCell.Value += " ($)";
                }
                guna2DataGridView1.Columns[i].HeaderCell.Value = guna2DataGridView1.Columns[i].HeaderCell.Value.ToString().ToUpper();

            }
        }
    }

}
