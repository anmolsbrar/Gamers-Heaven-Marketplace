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
using System.Text.RegularExpressions;

namespace Gamers_Heaven_Marketplace
{
    public partial class keyReveal : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anmol Brar\Documents\Visual Studio 2015\Projects\Gamers Heaven Marketplace\Gamers Heaven Marketplace\database\logindb.mdf;Integrated Security=True;Connect Timeout=30");
        private string pass = @"SELECT COUNT (*) FROM [dbo].[login] WHERE id = @user AND password = @pass";
        private string key = @"SELECT productKey FROM [dbo].[orders] WHERE orderId = @order";
        private int userId, orderId;
        private string Prodkey;

        public keyReveal(int user, int order)
        {
            InitializeComponent();
            userId = user;
            orderId = order;
        }

        private void keyReveal_Load(object sender, EventArgs e)
        {
            passMatch.Visible = false;
            copyButton.Enabled = false;
        }

        private void revealButton_Click(object sender, EventArgs e)
        {
            checkUser();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Prodkey);
        }

        private void checkUser()
        {
            connection.Open();
            SqlCommand passCheck = new SqlCommand(pass, connection);
            passCheck.Parameters.AddWithValue("@user", userId);
            passCheck.Parameters.AddWithValue("@pass", passwordTextbox.Text);
            if(passCheck.ExecuteScalar().ToString() == "1")
            {
                SqlCommand getKey = new SqlCommand(key, connection);
                getKey.Parameters.AddWithValue("@order", orderId);
                using (var reader = getKey.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Prodkey = (string)reader[0];
                    }
                }
                keyText.Text = Prodkey;
                passMatch.Visible = false;
                copyButton.Enabled = true;
            }
            else
            {
                passMatch.Visible = true;
            }
            connection.Close();
        }
    }
}
