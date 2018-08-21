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
    public partial class accountMain : Form
    {
        public static string fName, lName, email;
        public static int userId;

        productControl[] p = new productControl[100];
        private SqlConnection connection = new SqlConnection(@"workstation id=gamersHeaven.mssql.somee.com;packet size=4096;user id=anmolsbrar_SQLLogin_1;pwd=bfpxou5b3u;data source=gamersHeaven.mssql.somee.com;persist security info=False;initial catalog=gamersHeaven");
        private string productRetriever = @"SELECT prodId, prodName, prodPrice, prodImg, prodDesc FROM [dbo].[products]";
        private string searchString = @"SELECT prodId FROM [dbo].[products] where prodName LIKE @prod";
        private string userInfo = @"SELECT fName, lName, email FROM [dbo].[login] WHERE id = @uid";
        

        public accountMain(int id)
        {
            InitializeComponent();
            userId = id;
            accountControl1.getUserId = userId;

        }

        private void fetchUser()
        {
            connection.Open();
            SqlCommand userDetails = new SqlCommand(userInfo, connection);
            userDetails.Parameters.AddWithValue("@uid", userId);
            using (var reader = userDetails.ExecuteReader())
            {
                while (reader.Read())
                {
                    fName = (string)reader[0];
                    lName = (string)reader[1];
                    email = (string)reader[2];
                }
            }
            connection.Close();
        }

        private void accountMain_Load(object sender, EventArgs e)
        {
            fetchUser();
            createFunctions();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.AutoScroll = true;
        }


        private void buttonFlat3_Click(object sender, EventArgs e)
        {
            orders o = new orders(userId);
            o.Show();
            o.Location = this.Location;
            this.Hide();
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            int horizontal = 8, vertical = 5;
            connection.Open();
            SqlCommand search = new SqlCommand(searchString, connection);
            search.Parameters.AddWithValue("@prod", "%" + searchTextbox.Text + "%");
            using (var reader = search.ExecuteReader())
            {
                int count = 0;
                while (reader.Read())
                {
                    p[count] = new productControl();
                    p[count].Name = count.ToString();
                    p[count].getProdId = (int)reader[0];
                    p[count].getUserId = (int)userId;
                    p[count].Location = new Point(horizontal, vertical);
                    panel1.Controls.Add(p[count]);
                    vertical += 90;
                    count++;
                }
            }
            connection.Close();
        }

        private void buttonFlat1_Click(object sender, EventArgs e)
        {
            
        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            loginForm lf = new loginForm();
            lf.Show();
            this.Hide();
        }

        private void favoritesButton_Click(object sender, EventArgs e)
        {
            favorites c = new favorites(userId);
            c.Show();
            c.Location = this.Location;
            this.Hide();
        }

        private void createFunctions()
        {
            int horizontal = 8, vertical = 5;
            connection.Open();
            SqlCommand retProduct = new SqlCommand(productRetriever, connection);
            panel1.Controls.Clear();

            using (var reader = retProduct.ExecuteReader())
            {
                int count = 0;
                while(reader.Read())
                {
                    p[count] = new productControl();
                    p[count].Name = count.ToString();
                    p[count].getProdId = (int)reader[0];
                    p[count].getUserId = (int)userId;
                    p[count].Location = new Point(horizontal, vertical);
                    panel1.Controls.Add(p[count]);
                    vertical += 90;
                    count++;
                }
            } 
            connection.Close();
        }
    }
}
