using DGVPrinterHelper;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyStore
{
    public partial class PurchaseForm : Form
    {
        String label;
        private Guna2DataGridView guna2DataGridView1;

        public PurchaseForm()
        {
            InitializeComponent();
        }
       public PurchaseForm(String label)
        {
             this.label = label;
            InitializeComponent();
        }

        public PurchaseForm(string label, Guna2DataGridView guna2DataGridView1) : this(label)
        {
            this.guna2DataGridView1 = guna2DataGridView1;

            this.label = label;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
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
    }
}
