using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gamers_Heaven_Marketplace
{
    public partial class passwordReset : Form
    {
        private SqlConnection connection = new SqlConnection(@"workstation id=gamersHeaven.mssql.somee.com;packet size=4096;user id=anmolsbrar_SQLLogin_1;pwd=bfpxou5b3u;data source=gamersHeaven.mssql.somee.com;persist security info=False;initial catalog=gamersHeaven");
        private string username = @"SELECT COUNT (*) FROM [dbo].[login] WHERE username = @user";
        private string details = @"SELECT email, secQues FROM [dbo].[login] WHERE username = @user";
        private string newPass = @"UPDATE [dbo].[login] SET password = @newpass WHERE username = @user";

        private string user, email, securityQ;

        public passwordReset()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand checkUser = new SqlCommand(username, connection);
            checkUser.Parameters.AddWithValue("@user", usernameTextbox.Text);
            if(checkUser.ExecuteScalar().ToString() == "1")
            {
                user = usernameTextbox.Text;
                SqlCommand userDetails = new SqlCommand(details, connection);
                userDetails.Parameters.AddWithValue("@user", user);
                using (var reader = userDetails.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        email = (string)reader[0];
                        securityQ = (string)reader[1];
                    }
                }
                emailHintText.Text = emailHint(email);
                panel2.Visible = true;
                panel2.Location = panel1.Location;
                panel1.Visible = false;
            }
            else
            {
                noUserText.Visible = true;
            }
            connection.Close();
        }

        public string getUsername
        {
            set
            {
                user = value;
                usernameTextbox.Text = user;
            }
        }

        private void nextButton2_Click(object sender, EventArgs e)
        {
            if(email == emailTextbox.Text && securityQ == answerTextbox.Text)
            {
                panel3.Visible = true;
                panel3.Location = panel2.Location;
                panel2.Visible = false;
            }
            else
            {
                invalidEmailAnswer.Visible = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if(pass1.Text == pass2.Text)
            {
                connection.Open();
                SqlCommand resetPass = new SqlCommand(newPass, connection);
                resetPass.Parameters.AddWithValue("@user", user);
                resetPass.Parameters.AddWithValue("@newpass", pass1.Text);
                resetPass.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
            else
            {
                invalidPass.Visible = true;
            }
        }

        private void passwordReset_Load(object sender, EventArgs e)
        {
            noUserText.Visible = false;
            invalidEmailAnswer.Visible = false;
            invalidPass.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private string emailHint(string email)
        {
            int index = email.IndexOf('@');
            email = email.Substring(index  - 1).PadLeft(email.Length, '*');
            return email;
        }
    }
}
