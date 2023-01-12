using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace PharmacyStore.CustomerUC
{
    public partial class UC_C_BuyMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_C_BuyMedicine()
        {
            InitializeComponent();
        }

        private void UC_C_BuyMedicine_Load(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "select mname from medicine where eDate >=FORMAT (getdate(), 'dd.MM.yyyy') and quantity > '0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_C_BuyMedicine_Load(this, null);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "select mname from medicine where mname like '" + txtSearch.Text + "%' and eDate FORMAT (getdate(), 'dd.MM.yyyy') and quantity > '0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumberOfUnits.Clear();

            String name = listBoxMedicines.GetItemText(listBoxMedicines.SelectedItem);

            txtMedicineName.Text = name;
            query = "select mid, eDate, perUnit from medicine where mname= '" + name + "'";
            ds = fn.getData(query);
            txtMedicineID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtExpireDate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtNumberOfUnits_TextChanged(object sender, EventArgs e)
        {
            if (txtNumberOfUnits.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txtPricePerUnit.Text);
                Int64 noOfUnit = Int64.Parse(txtNumberOfUnits.Text);
                Int64 totalPrice = unitPrice * noOfUnit;
                txtTotalPrice.Text = totalPrice.ToString();

            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        protected int n, totalPrice = 0;
        protected Int64 quantity, newQuantity;
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (txtMedicineID.Text != "")
            {
                if (txtNumberOfUnits.Text == "")
                    MessageBox.Show("Select desired amount first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity - Int64.Parse(txtNumberOfUnits.Text);
                }

                query = "select quantity from medicine where mid = '" + txtMedicineID.Text + "'";
                ds = fn.getData(query);

                if (newQuantity >= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtMedicineID.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtMedicineName.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txtExpireDate.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtNumberOfUnits.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;

                    totalPrice = totalPrice + int.Parse(txtTotalPrice.Text);
                    TotalLabel.Text = totalPrice.ToString();

                    query = "update medicine set quantity = '" + newQuantity + "' where mid = '" + txtMedicineID.Text + "' ";
                    fn.setData(query, "Medicine Added.");
                }
                else
                {
                    MessageBox.Show("Medicine is out of stock!\n Only " + quantity + " left.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                clearAll();
                UC_C_BuyMedicine_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select Medicine First.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void clearAll()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtExpireDate.ResetText();
            txtPricePerUnit.Clear();
            txtNumberOfUnits.Clear();
        }

        int valuePrice;
        String valueId;
        protected Int64 noOfUnit;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valuePrice = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfUnit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            { }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (valueId != null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch
                {

                }
                
                
                
                
                
                
                
                
                
                
                
                finally
                {
                    query = "select quantity from medicine where mid = '" + valueId + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfUnit;

                    query = "update medicine set quantity = '" + newQuantity + "' where mid = '" + valueId + "'";
                    fn.setData(query, "Medicine removed from cart.");
                    totalPrice = totalPrice - valuePrice;
                    TotalLabel.Text = totalPrice.ToString();
                }

                UC_C_BuyMedicine_Load(this, null);
            }
        }

        private void btnPurchasePrint_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Purchase?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {
                String X = TotalLabel.Text;
                PurchaseForm form = new PurchaseForm(X, guna2DataGridView1);

                form.Show();

                //Some task…
                totalPrice = 0;
                TotalLabel.Text = "";
            }

        }
    }
}
