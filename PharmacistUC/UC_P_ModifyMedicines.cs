 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace PharmacyStore.PharmacistUC
{
    public partial class UC_P_ModifyMedicines : UserControl
    {
        function fn = new function();
        String query;


        public UC_P_ModifyMedicines()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            if (txtMedID.Text!="")
            {
                query = "select * from medicine where mid= '"+txtMedID.Text+"'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count !=0) 
                {
                    txtMedName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMedNr.Text = ds.Tables[0].Rows[0][3].ToString();
                    manDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    expDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtQuan.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPPU.Text = ds.Tables[0].Rows[0][7].ToString();
                   
                }
                else
                {
                    MessageBox.Show("No medicine with that ID exists","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }


        }

        private void clearAll()
        {

            txtMedID.Clear();
            txtMedName.Clear();
            txtMedNr.Clear();
            txtPPU.Clear();
            txtQuan.Clear();
            expDate.ResetText();   
            manDate.ResetText();

            if (txtAddQuan.Text != "0")
            {
                txtAddQuan.Text = "0";
            }
            else
            {
                txtAddQuan.Text = "0";
            }
        }

        Int64 totalQuan;
        private void btn_update_Click(object sender, EventArgs e)
        {
            String medname = txtMedName.Text;
            String mednr = txtMedNr.Text;
            String mdate= manDate.Text;
            String edate = expDate.Text;    
            Int64 quan=Int64.Parse(txtQuan.Text);
            Int64 addquan=Int64.Parse(txtAddQuan.Text);
            Int64 price=Int64.Parse(txtPPU.Text);

            totalQuan = quan + addquan;

            query = "update medicine set mname= '"+medname+ "' , mnumber= '"+mednr+ "', mDate= '"+mdate+ "', eDate= '"+edate+"', quantity=" +totalQuan+", perUnit="+price+" where mid= '"+txtMedID.Text+"'  ";
            fn.setData(query, "Medicine details updated");

        }
    }
}
