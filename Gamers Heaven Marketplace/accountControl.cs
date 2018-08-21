using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gamers_Heaven_Marketplace
{
    public partial class accountControl : UserControl
    {
        private SqlConnection connection = new SqlConnection(@"workstation id=gamersHeaven.mssql.somee.com;packet size=4096;user id=anmolsbrar_SQLLogin_1;pwd=bfpxou5b3u;data source=gamersHeaven.mssql.somee.com;persist security info=False;initial catalog=gamersHeaven");
        private string userDetails = @"SELECT fName, lName, username FROM [dbo].[login] WHERE id = @user";
        private int userId;
        private string fName, lName, username;
        public accountControl()
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, profilePicture.Width, profilePicture.Height);
            profilePicture.Region = new Region(path);
        }

        private void accountControl_Load(object sender, EventArgs e)
        {
            getUserInfo();
            string n = fName + " " + lName;
            name.Text = n;
        }


        private void accDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var f = this.ParentForm;
            AccountDetails ad = new AccountDetails(userId);
            ad.Show();
            ad.Location = f.Location;
            f.Hide();
        }

        public int getUserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
            }
        }
        
        private void getUserInfo()
        {
            connection.Open();
            SqlCommand user = new SqlCommand(userDetails, connection);
            user.Parameters.AddWithValue("@user", userId);
            using(var reader = user.ExecuteReader())
            {
                while (reader.Read())
                {
                    fName = (string)reader[0];
                    lName = (string)reader[1];
                    username = (string)reader[2];
                }
            }
            connection.Close();
        }
    }
}
