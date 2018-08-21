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
    public partial class favProduct : UserControl
    {
        private SqlConnection connection = new SqlConnection(@"workstation id=gamersHeaven.mssql.somee.com;packet size=4096;user id=anmolsbrar_SQLLogin_1;pwd=bfpxou5b3u;data source=gamersHeaven.mssql.somee.com;persist security info=False;initial catalog=gamersHeaven");
        private string removeItem = @"DELETE FROM [dbo].[favorites] WHERE userId = @user AND prodId = @prod;";
        private string product = @"SELECT prodName, prodPrice, prodImg, prodDesc FROM [dbo].[products] WHERE prodId = @pId";
        private string imgUrl, pName, pDesc;
        private float pPrice;
        private int uId, pId;
        

        public favProduct()
        {
            InitializeComponent();
        }

        private void cartProduct_Load(object sender, EventArgs e)
        {
            getProduct();
            prodTitle.Text = pName.ToString();
            prodPrice.Text = pPrice.ToString("c");
            prodImg.Load(imgUrl);
            prodImg.SizeMode = PictureBoxSizeMode.StretchImage;
            if (pDesc.Length > 150)
            {
                desc.Text = pDesc.Substring(0, 150) + "...";
            }
            else
            {
                desc.Text = pDesc;
            }

        }

        private void getProduct()
        {
            connection.Open();
            SqlCommand getProd = new SqlCommand(product, connection);
            getProd.Parameters.AddWithValue("@pId", pId);
            using (var reader = getProd.ExecuteReader())
            {
                while (reader.Read())
                {
                    pName = (string)reader[0];
                    pPrice = (float)reader[1];
                    imgUrl = (string)reader[2];
                    pDesc = (string)reader[3];
                }
            }
            connection.Close();
        }

        public float getPrice
        {
            get
            {
                return pPrice;
            }
        }


        private void removeFromCart_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand deleteCart = new SqlCommand(removeItem, connection);
            deleteCart.Parameters.AddWithValue("@prod", pId);
            deleteCart.Parameters.AddWithValue("@user", uId);
            deleteCart.ExecuteNonQuery();
            connection.Close();

            favorites c = (favorites)this.ParentForm;
            this.Parent.Controls.Remove(this);
            c.createFavObjects();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            favorites f = (favorites)this.ParentForm;
            orderConfirmation o = new orderConfirmation(pId, uId);
            o.Location = f.Location;
            f.Hide();
            o.Show();
        }

        public int prodId
        {
            set
            {
                pId = value;
            }
        }

        public int userId
        {
            set
            {
                uId = value;
            }
        }
    }
}
