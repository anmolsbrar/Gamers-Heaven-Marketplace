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
    public partial class productControl : UserControl
    {
        private SqlConnection connection = new SqlConnection(@"workstation id=gamersHeaven.mssql.somee.com;packet size=4096;user id=anmolsbrar_SQLLogin_1;pwd=bfpxou5b3u;data source=gamersHeaven.mssql.somee.com;persist security info=False;initial catalog=gamersHeaven");
        private string addToCart = @"INSERT INTO [dbo].[favorites] (userId, prodId) VALUES (@user, @prod);";
        private string duplicateFav = @"SELECT COUNT (*) FROM [dbo].[favorites]
                                            WHERE userId = @user AND prodId = @prod";
        private string product = @"SELECT prodName, prodPrice, prodImg, prodDesc FROM [dbo].[products] WHERE prodId = @pId";


        private int uId, pId;
        private string pName, pImgUrl, pDesc;
        private float pPrice;

        public productControl()
        {
            InitializeComponent();
        }

        private void productControl_Load(object sender, EventArgs e)
        {
            getProduct();
            if(pDesc.Length > 110)
            {
                descriptionText.Text = pDesc.Substring(0, 110) + "...";
            }
            else
            {
                descriptionText.Text = pDesc;
            }
            //descriptionText.Text = pDesc;
            prodImage.ImageLocation = pImgUrl;
            prodImage.SizeMode = PictureBoxSizeMode.StretchImage;
            productName.Text = pName;
            productPrice.Text = pPrice.ToString("c");
        }

        public int getProdId
        {
            set
            {
                pId = value;
            }
        }

        public int getUserId
        {
            set
            {
                uId = value;
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
                    pImgUrl = (string)reader[2];
                    pDesc = (string)reader[3];
                }
            }
            connection.Close();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            accountMain am = (accountMain)this.ParentForm;
            orderConfirmation o = new orderConfirmation(pId, uId);
            o.Show();
            o.Location = am.Location;
            am.Hide();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand duplicate = new SqlCommand(duplicateFav, connection);
            duplicate.Parameters.AddWithValue("@user", uId);
            duplicate.Parameters.AddWithValue("@prod", pId);
            if (duplicate.ExecuteScalar().ToString() == "1")
            {
                MessageBox.Show("Item is already in the favourites", "Duplicate item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand addCart = new SqlCommand(addToCart, connection);
                addCart.Parameters.AddWithValue("@user", uId);
                addCart.Parameters.AddWithValue("@prod", pId);
                addCart.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Item added to favourites");
            }
            connection.Close();
        }
    }
}