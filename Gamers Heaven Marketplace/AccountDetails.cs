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
    public partial class AccountDetails : Form
    {
        private int userId;
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anmol Brar\Documents\Visual Studio 2015\Projects\Gamers Heaven Marketplace\Gamers Heaven Marketplace\database\logindb.mdf;Integrated Security=True;Connect Timeout=30");
        private string userDetail = @"SELECT username, password, fName, lName, email FROM [dbo].[login] WHERE id = @userId";
        private string username, password, fName, lName, email;

        private void changePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            passwordReset pr = new passwordReset();
            pr.getUsername = username;
            pr.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loginForm lf = new loginForm();
            lf.Show();
            this.Hide();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            accountMain am = new accountMain(userId);
            am.Show();
            am.Location = this.Location;
            this.Hide();
        }

        private void favoritesButton_Click(object sender, EventArgs e)
        {
            favorites c = new favorites(userId);
            c.Show();
            c.Location = this.Location;
            this.Hide();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            orders o = new orders(userId);
            o.Show();
            o.Location = this.Location;
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            accountMain am = new accountMain(userId);
            am.Show();
            am.Location = this.Location;
            this.Hide();
        }

        private void AccountDetails_Load(object sender, EventArgs e)
        {
            userTextbox.Enabled = false;
            emailTextbox.Enabled = false;
            userTextbox.Text = username;
            passTextbox.Text = password;
            fNameTextbox.Text = fName;
            lNameTextbox.Text = lName;
            emailTextbox.Text = email;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public AccountDetails(int id)
        {
            InitializeComponent();
            userId = id;
            getUserDetails();
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, profilePicture.Width, profilePicture.Height);
            profilePicture.Region = new Region(path);
        }

        private void getUserDetails()
        {
            connection.Open();
            SqlCommand user = new SqlCommand(userDetail, connection);
            user.Parameters.AddWithValue("@userId", userId);
            using(var reader = user.ExecuteReader())
            {
                while (reader.Read())
                {
                    username = (string)reader[0];
                    password = (string)reader[1];
                    fName = (string)reader[2];
                    lName = (string)reader[3];
                    email = (string)reader[4];
                }
            }
        }
    }
}
