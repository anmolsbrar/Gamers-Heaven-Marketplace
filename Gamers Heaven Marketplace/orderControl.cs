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
    public partial class viewOrderDetails : UserControl
    {
        private string order = @"SELECT products.prodName, products.prodPrice, products.prodImg, firstNameShip, lastNameShip, orderDate, products.prodId FROM [dbo].[orders]
                                 INNER JOIN [dbo].[products] ON [dbo].[orders].prodId = [dbo].[products].prodId
                                 WHERE orderId = @order";
        private SqlConnection connection = new SqlConnection(@"workstation id=gamersHeaven.mssql.somee.com;packet size=4096;user id=anmolsbrar_SQLLogin_1;pwd=bfpxou5b3u;data source=gamersHeaven.mssql.somee.com;persist security info=False;initial catalog=gamersHeaven");
        private int orderId, prodId, userId;
        private string pName, pURL, fName, lName;
        private float pPrice;
        private DateTime date, dateOnly;


        public viewOrderDetails()
        {
            InitializeComponent();
        }

        private void keyButton_Click(object sender, EventArgs e)
        {
            keyReveal k = new keyReveal(userId, orderId);
            k.Show();
        }

        private void orderControl_Load(object sender, EventArgs e)
        {
            getOrder();
            dateOnly = date.Date;
            OrderPlaceDate.Text = date.ToString();
            priceTotal.Text = pPrice.ToString();
            shipName.Text = fName + " " + lName;
            orderNumber.Text = orderId.ToString();
            fulfillDate.Text = "Fulfilled " + dateOnly.ToString("d");
            prodTitleText.Text = pName.ToString();
            prodPrice.Text = pPrice.ToString();
            prodImg.SizeMode = PictureBoxSizeMode.StretchImage;
            prodImg.Load(pURL);
        }

        private void getOrder()
        {
            connection.Open();
            SqlCommand orderDetails = new SqlCommand(order, connection);
            orderDetails.Parameters.AddWithValue("@order", orderId);
            using (var reader = orderDetails.ExecuteReader())
            {
                while (reader.Read())
                {
                    pName = (string)reader[0];
                    pPrice = (float)reader[1];
                    pURL = (string)reader[2];
                    fName = (string)reader[3];
                    lName = (string)reader[4];
                    date = (DateTime)reader[5];
                    prodId = (int)reader[6];
                }
            }
            connection.Close();
        }

        public int getOrderId
        {
            set
            {
                orderId = value;
            }
        }

        public int getUserId
        {
            set
            {
                userId = value;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            orders ord = (orders)this.ParentForm;
            ord.orderPanel.Hide();
            ord.orderPanelMain.Show();
            ord.orderDetailPanel.Show();
            ord.orderPanelMain.Location = ord.orderPanel.Location;
            ord.fillOrderDetails(orderId, prodId);
        }

        private void buyAgainButton_Click(object sender, EventArgs e)
        {
            orders o = (orders)this.ParentForm;
            orderConfirmation oc = new orderConfirmation(prodId, userId);
            oc.Location = this.ParentForm.Location;
            oc.Show();
            o.Hide();            
        }
    }
}
