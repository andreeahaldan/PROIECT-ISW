using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace PharmacyStore
{
    public partial class Form2 : Form
    {
        function fn = new function();
        String username;
        int code;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }
    private void SendCode(object sender, EventArgs e)
        {
            if (Email.Text != "" & Email.Text.Contains("@"))
            {

                String query = "Select * from users where email='" + Email.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count == 0)
                { 
                fn.setData(query, "This email is not registred in our database");
                }
                else
                {
                    username = ds.Tables[0].Rows[0][6].ToString();
                    try
                    {

                        Random rnd = new Random();
                        code = rnd.Next();
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("claudiu.andronache7@gmail.com");
                        mail.To.Add(new MailAddress(Email.Text));
                        mail.Subject = "Pharmacy Store Password Reset";
                      
                
                        mail.Body = @"
<!DOCTYPE html>
<html>
<head>
    <title>Reset Password</title>
    <style>
        /* Set a background color for the entire email */
        body {
            background-color: #f5f5f5;
        }

        /* Center the text and set a font */
        h1, p {
            text-align: center;
            font-family: Arial, sans-serif;
        }
        p {
  font-size: 1.1em;
}
        /* Add a container for the email content */
        .container {
            max-width: 600px;
            margin: 0 auto;
            background-color: #fff;
            padding: 20px;
            box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
        }

        /* Style the reset code */
        .reset-code {
            font-size: 1.5em;
            font-weight: bold;
            color: #0077c9;
            margin: 20px 0;
        }

        
        .contact-us {
            margin-top: 20px;
            text-align: center;
        }
        .contact-us a {
            color: #0077c9;
            text-decoration: none;
        }
        .contact-us a:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <div class='container'>
        <h1>Reset Password</h1>
        <p>Hi "+ username+@",</p>
        <p>We received a request to reset your password. If you did not make this request, please ignore this email.</p>
        <p>To reset your password, please use the following code: </p>
        <p class='reset-code'>"+ code + @"</p>
        <div class='contact-us'>
            <p>If you have any questions or concerns, please contact us at pharmacy@yahoo.com.</p>
            <p>Best,</p>
            <p>Pharma</p>
        </div>
    </div>
</body>
</html>
"
        ;



                        mail.IsBodyHtml = true;


                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.UseDefaultCredentials = false;
                            smtp.Credentials = new NetworkCredential("claudiu.andronache7@gmail.com", "smodkatzocxzaehc");
                            smtp.EnableSsl = true;

                            smtp.Send(mail);

                        }
                        //  smtpClient.Send(mailMessage);
                    }
                    catch (Exception EX)
                    {
                        MessageBox.Show("" + EX);
                    }
                }
         
            }
            else
            {
                MessageBox.Show("Enter a valid email");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (reset_code.Text == code.ToString())  
            {
                if (pass.Text == c_pass.Text)
                {
                    if(pass.Text.Length >= 5)
                    {
                        Haschode h=new Haschode();
                        String hash_pass=h.Hashcode(pass.Text);
                       String query = "update users set pass= '" + hash_pass + "' where username= '" + username + "' ";
                        fn.setData(query, "Password was updated");
                    }
                    else MessageBox.Show("Password must have at least 5 characters");
                }
                else MessageBox.Show("Passwords doesn't match");

            }
            else MessageBox.Show("Reset Code is invalid");
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
           Form1 form= new Form1();
            form.Show();
            this.Hide();
        }
    }
}
