
using DGVPrinterHelper;
using Guna.UI2.WinForms;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using System.Xml.Linq;

using System.Drawing.Printing;
using System.IO;


namespace PharmacyStore
{
    public partial class PurchaseForm : System.Windows.Forms.Form
    {
        String label;
        private Guna2DataGridView guna2DataGridView1;

        public PurchaseForm()
        {
            InitializeComponent();
        }
   
        public PurchaseForm(string label, Guna2DataGridView guna2DataGridView1)
        {
            InitializeComponent();
            this.guna2DataGridView1 = guna2DataGridView1;

            this.label = label;
       
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {


            /*   Syncfusion.Pdf.PdfDocument document = new PdfDocument();
               //Add a page to the document.
               PdfPage page = document.Pages.Add();
               //Create PDF graphics for the page.
               PdfGraphics graphics = page.Graphics;
               //Set the standard font.
               PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);
               //Draw the text.
               graphics.DrawString("Hello World!!!", font, PdfBrushes.Black, new Syncfusion.Drawing.PointF(0, 0));
               //Save the document.*/

            //Create a new PDF document
          

               DGVPrinter print = new DGVPrinter();
                 print.Title = "Medicine Bill";
                  print.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
                  print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                  print.PageNumbers = true;
                  print.PageNumberInHeader = false;
                  print.PorportionalColumns = true;
                  print.HeaderCellAlignment = StringAlignment.Near;
                  print.Footer = "Total Payable Amount : " + label;
                  print.FooterSpacing = 15;
                  print.PrintDataGridView(guna2DataGridView1);
                  guna2DataGridView1.DataSource = 0;
                 this.Close();
           
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Document was saved");

            PdfDocument document = new PdfDocument();
            //Add a page
            PdfPage page = document.Pages.Add();
            PdfGraphics graphics = page.Graphics;
            //Set the standard font.
            PdfFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 20);
            //Draw the text.
            graphics.DrawString("Medicine Bill", font, PdfBrushes.Black,
                new Syncfusion.Drawing.PointF(120, 10));


            //Create a PdfGrid
            PdfGrid pdfGrid = new PdfGrid();
            //Create a DataTable
            DataTable dataTable = new DataTable();
            //Add columns to the DataTable
            dataTable.Columns.Add("ProductID");
            dataTable.Columns.Add("ProductName");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("UnitPrice");
            dataTable.Columns.Add("Price");
            //Add rows to the DataTable
            //dataTable.Rows.Add(new object[] { "CA-1098", "Queso Cabrales", "12", "14", "1", "167" });
            dataTable.Rows.Add(new object[] { "CA-1098", "Queso Cabrales", "12", "14", "1", "167" });
            //Assign data source
            pdfGrid.DataSource = dataTable;
            //Draw grid to the page of PDF document
            pdfGrid.Draw(page, new Syncfusion.Drawing.PointF(10, 100));
            //Save the document

            //Close the document

            FileStream stream = new FileStream("output3.pdf", FileMode.OpenOrCreate);
            document.Save(stream);
            //Close the document.
            document.Close(true);
        }


    }
}
