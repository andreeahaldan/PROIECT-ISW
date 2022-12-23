﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyStore.PharmacistUC
{
    public partial class UC_P_ViewMedicines : UserControl
    {
        function fn = new function();
        String query;

        public UC_P_ViewMedicines()
        {
            InitializeComponent();
        }

        private void UC_P_ViewMedicines_Load(object sender, EventArgs e)
        {
            query = "select * from medicine";
            setDataGridView(query);

        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medicine where mname like '" + txtSeach.Text + "%'";
            setDataGridView(query);
        }

        private void setDataGridView(String query)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        String medicineid;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineid = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); 
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?","Delete confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from medicine where mid = '" + medicineid + "'";
                fn.setData(query, "Medicine record deleted");
                UC_P_ViewMedicines_Load(this, null);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_ViewMedicines_Load(this, null);

        }
    }
}
