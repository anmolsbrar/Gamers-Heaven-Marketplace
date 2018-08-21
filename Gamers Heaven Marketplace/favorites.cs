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
    public partial class favorites : Form
    {
        private string cartString = @"SELECT prodId FROM [dbo].[favorites] WHERE userId = @uId";
        private SqlConnection connection = new SqlConnection(@"workstation id=gamersHeaven.mssql.somee.com;packet size=4096;user id=anmolsbrar_SQLLogin_1;pwd=bfpxou5b3u;data source=gamersHeaven.mssql.somee.com;persist security info=False;initial catalog=gamersHeaven");
        private favProduct[] favProd = new favProduct[5];
        private int userId;
        private float totalPrice;

        public favorites(int uid)
        {
            InitializeComponent();
            userId = uid;
            accountControl1.getUserId = userId;
        }

        public void createFavObjects()
        {
            int horizontal = 9, vertical = 5;
            connection.Open();
            SqlCommand favFill = new SqlCommand(cartString, connection);
            favFill.Parameters.AddWithValue("@uId", userId);
            favPanel.Controls.Clear();
            totalPrice = 0.0f;
            int count = 0;
            using (var reader = favFill.ExecuteReader())
            {
                while (reader.Read())
                {
                    favProd[count] = new favProduct();
                    favProd[count].Name = count.ToString();
                    favProd[count].userId = userId;
                    favProd[count].prodId = (int)reader[0];
                    favProd[count].Location = new Point(horizontal, vertical);
                    favPanel.Controls.Add(favProd[count]);
                    vertical += 80;
                    totalPrice += favProd[count].getPrice;
                    count++;
                }
            }
            connection.Close();
            //totalPriceText.Text = totalPrice.ToString("c");
        }

        private void favPanel_Paint(object sender, PaintEventArgs e)
        {
            favPanel.AutoScroll = true;
        }


        private void roundButton1_Click(object sender, EventArgs e)
        {
            accountMain am = new accountMain(userId);
            am.Show();
            am.Location = this.Location;
            this.Hide();
        }

        private void favorites_Load(object sender, EventArgs e)
        {
            createFavObjects();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            accountMain am = new accountMain(userId);
            am.Show();
            am.Location = this.Location;
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

        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            orders o = new orders(userId);
            o.Show();
            o.Location = this.Location;
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loginForm lf = new loginForm();
            lf.Show();
            this.Hide();
        }
    }
}
