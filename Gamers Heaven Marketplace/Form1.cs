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
    public partial class loginForm : Form
    {
        private int userId;
        private SqlConnection connection = new SqlConnection(@"workstation id=gamersHeaven.mssql.somee.com;packet size=4096;user id=anmolsbrar_SQLLogin_1;pwd=bfpxou5b3u;data source=gamersHeaven.mssql.somee.com;persist security info=False;initial catalog=gamersHeaven");
        private string loginQuery = "SELECT COUNT (*) FROM [dbo].[login] WHERE username=@user AND password=@pass";
        private string getUser = "SELECT id FROM [dbo].[login] WHERE username=@user";
        public loginForm()
        {
            InitializeComponent();
            invalidCredText.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand login = new SqlCommand(loginQuery, connection);
            login.Parameters.AddWithValue("@user", usernameTextbox.Text);
            login.Parameters.AddWithValue("@pass", passwordTextbox.Text);

            if(login.ExecuteScalar().ToString() == "1")
            {
                SqlCommand loginUser = new SqlCommand(getUser, connection);
                loginUser.Parameters.AddWithValue("@user", usernameTextbox.Text);
                using (var reader = loginUser.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        userId = (int)reader[0];
                    }
                }
                accountMain am = new accountMain(userId);
                am.Location = this.Location;
                am.Show();
                this.Hide();
            }
            else
            {
                invalidCredText.Visible = true;
            }
            connection.Close();
        }

        private void forgotPasswordText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            passwordReset pr = new passwordReset();
            pr.Show();
        }

        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerForm formReg = new registerForm();
            formReg.Show();
        }
    }
}
