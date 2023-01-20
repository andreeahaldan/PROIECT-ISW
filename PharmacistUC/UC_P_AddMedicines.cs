using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Text.RegularExpressions;
using static System.Windows.Forms.AxHost;

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
                String quan = txtQuan.Text;
                String ppu = txtPPU.Text;
               
             if (ValidatePricePerUnit(ppu)&
                ValidateID(mid)&
                ValidateName(mname)&
                ValidateNumber(mnr)&
                ValidateQuantity(quan)
                    
                    ){
                    
                    query = "INSERT INTO medicine (mid,mname,mnumber,mDate,eDate,quantity,perUnit)" +
                        " values ('" + mid + "','" + mname + "','" + mnr + "','" + mdate + "','" + mexp + "'," + quan + "," + ppu + ")";
                    fn.setData(query, "Medicine added to database.");
                }


                
            }
            else 
            {
                 MessageBox.Show("Enter all Data.","Info",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        public static bool IsNumber(string s) 
        { foreach (char c in s) { if (!Char.IsDigit(c)) return false; } return true; }
        private Boolean ValidatePricePerUnit(String ppu)
        {
            if (IsNumber(ppu))
            {
                
                
                return true; 
            }
            else
            {
                MessageBox.Show("Price per unit not valid, enter a number");
                return false;
            }

        }
    

        private Boolean ValidateQuantity(String quan)
        {
            if (IsNumber(quan))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Quantity not valid, enter a number");
                return false;
            }

        }

        private Boolean ValidateNumber(String mnr)
        {
            if (IsNumber(mnr))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Medicine Number not valid, enter a number");
                return false;
            }
        }

        private Boolean ValidateName(string mname)
        {
            if (mname.Length > 1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Name is not valid,at least two characters are allowed");
                return false;
            }
        }

        private Boolean ValidateID(string mid)
        {
            if (IsNumber(mid))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Medicine Id not valid, enter a number");
                return false;
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

        private void txtManDate_MouseClick(object sender, MouseEventArgs e)
        {
            
            txtManDate.MaxDate = DateTime.Today;
         
        }

        private void txtExpDate_Click(object sender, EventArgs e)
        {
            txtExpDate.MinDate = DateTime.Today;
        }
    }
}
