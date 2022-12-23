using System;
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
    public partial class UC_P_AddMedicines : UserControl
    {

        function fn = new function();
        String query;
        public UC_P_AddMedicines()
        {
            InitializeComponent();
        }
        //ADD medicine
        private void btn_AddMedicine_Click(object sender, EventArgs e)
        {
            if(txtMID.Text!="" && txtMName.Text!="" && txtMNr.Text!="" && txtQuan.Text!="" && txtPPU.Text !="")
            {
                String mid = txtMID.Text;
                String mname= txtMName.Text;
                String mnr = txtMNr.Text;
                String mdate = txtManDate.Text;
                String mexp = txtExpDate.Text;
                Int64 quan = Int64.Parse(txtQuan.Text);
                Int64 ppu = Int64.Parse(txtPPU.Text);
                    
                query = "INSERT INTO medicine (mid,mname,mnumber,mDate,eDate,quantity,perUnit)" +
                    " values ('"+mid+"','"+mname+ "','"+mnr+ "','"+mdate+"','"+mexp+"',"+quan+","+ppu+")";

                fn.setData(query, "Medicine added to database.");
            }
            else 
            {
                 MessageBox.Show("Enter all Data.","Info",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            txtMID.Clear();
            txtMName.Clear();
            txtMNr.Clear();
            txtQuan.Clear();
            txtPPU.Clear();
                   
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            clearAll(); 
        }

        private void UC_P_AddMedicines_Load(object sender, EventArgs e)
        {

        }
    }
}
