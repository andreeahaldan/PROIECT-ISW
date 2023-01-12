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

            if (txtCheckbox.SelectedIndex == 0)
            {
                query = "select * from medicine where eDate >=FORMAT (getdate(), 'dd.MM.yyyy')";
                setDataGridView(query, "Valid medicines", Color.Green);

            }
            else if (txtCheckbox.SelectedIndex == 1)
            {
                query = "select * from medicine where eDate <= FORMAT (getdate(), 'dd.MM.yyyy')";
                setDataGridView(query, "Expired medicines", Color.Red);

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

    }

}
