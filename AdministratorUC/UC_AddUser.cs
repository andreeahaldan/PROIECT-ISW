﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using Syncfusion.Pdf.Parsing;
using System.Security.Cryptography;

namespace PharmacyStore.AdministratorUC
{
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddUser()
        {
            InitializeComponent();
            txtDateOfBirth.Value = DateTime.Now.AddYears(-18);    
        }
       

        private Boolean Validate_Passwords(String pass)
        {//cel putin 5 caractere
            if (pass.Length < 5)
            {
                MessageBox.Show("Password is too short (min 5 characters)");
                return false;
            }
            else return true;

        }

        private Boolean Validate_username(String username)
        {//cel putin 3 caractere
            if (username.Length < 3)
            {
                MessageBox.Show("Username is too short (min 3 characters)");
                return false;
            }
            else return true;
        }

        private Boolean Validate_email(string email)
        {//sa contina @
            if (!email.Contains("@")) {
                MessageBox.Show("Email is not valid");
                return false;
            }
            else return true;

        }

        private Boolean Validate_mobile(String mobile)
        {
           


          
            if (Regex.Match(mobile, "[0][237][0-9]{8}$").Success)
            {
             
                
            return true; }
            else
            {
                MessageBox.Show("Mobile number is not valid");
                return false; 
            
            }
        }

        public static bool IsAllLetters(string s) { foreach (char c in s) { if (!Char.IsLetter(c)) return false; } return true; }
        private Boolean Validate_name(string name)
        {

            if (IsAllLetters(name) & (name.Length>1))
                return true;
            else
            {
                MessageBox.Show("Name field is not valid, only letters are allowed ");
                return false;

            }
        }
   
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDateOfBirth.Text;
            String mobiletxt = txtMobileNo.Text;
            String email = txtEmail.Text;
            String username = txtUserName.Text;
            String pass = txtPassword.Text;



            
            if(
                Validate_name(name)&
               Validate_email(email) &
               Validate_username(username)&
               Validate_Passwords(pass)&
               Validate_mobile(mobiletxt)
                
                )
            try
            {
                    
                    Haschode hashcoder = new Haschode();
                    String hashpassword = hashcoder.Hashcode(txtPassword.Text);

                 query = "insert into [users] (userRole,name,dob,mobile,email,username,pass) values ('" + role
                    + "' ,'"
                    + name +
                    "','" +
                    dob +
                    "','" +
                    mobiletxt +
                    "','" +
                    email +
                   "','" +
                    username +
                    "','" +
                    hashpassword + "' )";
                fn.setData(query, "Sign Up Succesfull");

            }
            catch (Exception exc)
            {


                MessageBox.Show("'" + exc + "'  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            txtName.Clear();
            txtDateOfBirth.ResetText();
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserRole.SelectedIndex = -1;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {


            query = "select * from [USERS] where username='" + txtUserName.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0 & txtUserName.Text.Length>5)
            {
                pictureBox1.ImageLocation="../.././poze/yes.png";
            }
            else
                pictureBox1.ImageLocation ="../.././poze/no.png";
        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }


        private void txtDateOfBirth_Click(object sender, EventArgs e)
        {
          
            txtDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
            

        }

      
    }
}