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
using System.Reflection.Emit;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf;
using System.IO;

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

        

        private void btnPurchaseDownload_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            //Add a page
            PdfPage page = document.Pages.Add();
            PdfGraphics graphics = page.Graphics;
            //Set the standard font.
            PdfFont titlefont = new PdfStandardFont(PdfFontFamily.TimesRoman, 20);
            PdfFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 10);
            //Draw the text.
            graphics.DrawString("Medicine Bill", titlefont, PdfBrushes.Black,
                new Syncfusion.Drawing.PointF(160, 10));

            //Create a PdfGrid
            PdfGrid pdfGrid = new PdfGrid();
            //Create a DataTable
            DataTable dataTable = new DataTable();
            //Add columns to the DataTable
            dataTable.Columns.Add("ProductID");
            dataTable.Columns.Add("ProductName");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("UnitPrice");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Price");

            try
            {
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    if (row.Index == guna2DataGridView1.RowCount - 1)
                        break;
                    else
                    {


                        String[] obj = {" "+row.Cells[0].Value.ToString(),
                            " "+row.Cells[1].Value.ToString(),
                            " "+row.Cells[2].Value.ToString(),
                           " "+ row.Cells[3].Value.ToString(),
                            " "+row.Cells[4].Value.ToString(),
                            " "+row.Cells[5].Value.ToString() };

                        MessageBox.Show(obj[0] + obj[1] + obj[2] + obj[3] + obj[4] + obj[5]);
                        dataTable.Rows.Add(new object[] { obj[0], obj[1], obj[2], obj[3], obj[4], obj[5] });


                    }


                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex); };
            pdfGrid.DataSource = dataTable;
            pdfGrid.Draw(page, new Syncfusion.Drawing.PointF(10, 100));

            graphics.DrawString("Total Payable Amount : " + TotalLabel.Text, font, PdfBrushes.Black,
                  new Syncfusion.Drawing.PointF(340, 100 + 20 * guna2DataGridView1.RowCount));
            ;

            Random r = new Random();
            String s = "../../Receipts/Receipt" + r.Next() + ".pdf";
            FileStream stream = new FileStream(s, FileMode.Create);
            document.Save(stream);
            //Close the document.
            document.Close(true);
            MessageBox.Show("Document was saved");

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
                    if (totalPrice>0)
                    totalPrice = totalPrice - valuePrice;
                    TotalLabel.Text = totalPrice.ToString();
                }

                UC_C_BuyMedicine_Load(this, null);
            }
        }

        private void btnPurchasePrint_Click(object sender, EventArgs e)
        {

            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payable Amount : " + TotalLabel.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);
            guna2DataGridView1.DataSource = 0;
            
            totalPrice = 0;
            TotalLabel.Text = "";
   

        }
    }
}
