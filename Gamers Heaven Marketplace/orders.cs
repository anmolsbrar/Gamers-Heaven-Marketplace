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
    public partial class orders : Form
    {
        private string _orders = @"SELECT orderId FROM [dbo].[orders] WHERE userId = @user ORDER BY orderDate DESC";
        private string _sortOrders = @"SELECT orderId FROM [dbo].[orders] WHERE orderDate >= @date AND userId = @user ORDER BY orderDate DESC";
        private string orderDetails = @"SELECT orderDate, paymentMethod, firstNameShip, lastNameShip, streetAddressShip, cityShip, provinceShip, countryShip, firstNameBill,
                                        lastNameBill,streetAddressBill, cityBill, provinceBill, countryBill 
                                        FROM [dbo].[orders] 
                                        WHERE orderId = @order";
        private string userDetails = @"SELECT fName, lName, username FROM [dbo].[login] WHERE id = @userId";
        private string prodDetails = @"SELECT prodName, prodPrice, prodImg FROM [dbo].[products] WHERE prodId = @prod";
        private string cardNum, imgUrl;
        private SqlConnection connection = new SqlConnection(@"workstation id=gamersHeaven.mssql.somee.com;packet size=4096;user id=anmolsbrar_SQLLogin_1;pwd=bfpxou5b3u;data source=gamersHeaven.mssql.somee.com;persist security info=False;initial catalog=gamersHeaven");
        private int userId, orderId, prodId;
        private float price, rate = 12.00f, rateAmount, grandPrice;
        private viewOrderDetails[] vod = new viewOrderDetails[10];
        private DateTime orderDate;
        private string firstName, lastName, username;

        public orders(int uid)
        {
            InitializeComponent();
            userId = uid;
            accountControl1.getUserId = userId;
            
        }

        private void orders_Load(object sender, EventArgs e)
        {
            getUserDetails();
            orderPanelMain.Visible = false;
            comboBoxfill();
            filterBox.SelectedIndex = 4;
            orderPanel.AutoScroll = true;
            orderPanelMain.Controls.Add(orderDetailPanel);
        }

        private void createFunctions()
        {
            int horizontal = 5, vertical = 5;
            int count = 0;
            orderPanel.Controls.Clear();
            connection.Open();
            SqlCommand orders = new SqlCommand(_orders, connection);
            orders.Parameters.AddWithValue("@user", userId);
            
            using (var reader = orders.ExecuteReader())
            {
                while (reader.Read())
                {
                    vod[count] = new viewOrderDetails();
                    vod[count].Name = count.ToString();
                    vod[count].getOrderId = (int)reader[0];
                    vod[count].getUserId = userId;
                    vod[count].Location = new Point(horizontal, vertical);
                    orderPanel.Controls.Add(vod[count]);
                    vertical += 160;
                    count++;
                }
            }
            connection.Close();
        }

        private void sortedFunctions(DateTime d)
        {
            int horizontal = 8, vertical = 5;
            int count = 0;
            orderPanel.Controls.Clear();
            connection.Open();
            SqlCommand sortOrders = new SqlCommand(_sortOrders, connection);
            sortOrders.Parameters.AddWithValue("@user", userId);
            sortOrders.Parameters.AddWithValue("@date", d);

            using (var reader = sortOrders.ExecuteReader())
            {
                while (reader.Read())
                {
                    vod[count] = new viewOrderDetails();
                    vod[count].Name = count.ToString();
                    vod[count].getOrderId = (int)reader[0];
                    vod[count].getUserId = userId;
                    vod[count].Location = new Point(horizontal, vertical);
                    orderPanel.Controls.Add(vod[count]);
                    vertical += 160;
                    count++;
                }
            }
            connection.Close();
        }

        private void comboBoxfill()
        {
            filterBox.Items.Add("1 week");
            filterBox.Items.Add("1 month");
            filterBox.Items.Add("6 months");
            filterBox.Items.Add("1 year");
            filterBox.Items.Add("All");
        }

        private void keyButton_Click(object sender, EventArgs e)
        {
            keyReveal k = new keyReveal(userId, orderId);
            k.Show();
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
            favorites fav = new favorites(userId);
            fav.Show();
            fav.Location = this.Location;
            this.Hide();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (orderPanelMain.Visible == true)
            {
                orderPanelMain.Visible = false;
                orderPanel.Visible = true;
            }
            else
            {
                accountMain am = new accountMain(userId);
                am.Show();
                am.Location = this.Location;
                this.Hide();
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loginForm lf = new loginForm();
            lf.Show();
            this.Hide();
        }

        private void buyAgainButton_Click(object sender, EventArgs e)
        {
            orderConfirmation oc = new orderConfirmation(prodId, userId);
            oc.Location = this.Location;
            oc.Show();
            this.Hide();
        }

        private void filterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (filterBox.SelectedIndex)
            {
                case 0:
                    sortedFunctions(date(-7, 0, 0));
                    break;
                case 1:
                    sortedFunctions(date(0, -1, 0));
                    break;
                case 2:
                    sortedFunctions(date(0, -6, 0));
                    break;
                case 3:
                    sortedFunctions(date(0, 0, -1));
                    break;
                case 4:
                    createFunctions();
                    break;
            }
        }

        public void fillOrderDetails(int order, int prod)
        {
            filterBox.Visible = false;
            orderId = order;
            prodId = prod;
            orderNumberText.Text = order.ToString();
            fetchOrderDetails(order);
            fetchProdDetails(prod);
            prodImg.SizeMode = PictureBoxSizeMode.StretchImage;
            prodImg.Load(imgUrl);
            fulfillDate.Text = "Fulfilled on " + orderDate.ToString("dd/MM/yyyy");
            orderDateText.Text = orderDate.ToString("dd/MM/yyyy");
            cardNumText.Text = cardNum.Substring(cardNum.Length - 4).PadLeft(cardNum.Length, 'X');
            amountTextFinal.Text = price.ToString("c");
            grandPrice = prodPriceCalc(price, rate, ref rateAmount);
            taxTextFinal.Text = "+" + rateAmount.ToString("c");
            gTotalFinal.Text = grandPrice.ToString("c");
            prodPrice.Text = price.ToString("c");
        }

        private void fetchOrderDetails(int o)
        {
            connection.Open();
            SqlCommand order = new SqlCommand(orderDetails, connection);
            order.Parameters.AddWithValue("order", o);
            using(var reader = order.ExecuteReader())
            {
                while (reader.Read())
                {
                    orderDate = (DateTime)reader[0];
                    cardNum = (string)reader[1];
                    nameShippingS.Text = (string)(reader[2] + " " + reader[3]);
                    address1TextS.Text = (string)reader[4];
                    cityTextS.Text = (string)(reader[5] + ", " + reader[6]);
                    countryTextS.Text = (string)reader[7];
                    nameTextB.Text = (string)(reader[8] + " " + reader[9]);
                    address1TextB.Text = (string)reader[10];
                    cityTextB.Text = (string)(reader[11] + ", " + reader[12]);
                    countryTextB.Text = (string)reader[13];
                }
            }
            connection.Close();
        }

        private void fetchProdDetails(int prod)
        {
            connection.Open();
            SqlCommand product = new SqlCommand(prodDetails, connection);
            product.Parameters.AddWithValue("@prod", prod);
            using(var reader = product.ExecuteReader())
            {
                while (reader.Read())
                {
                    prodTitleText.Text = (string)reader[0];
                    price = (float)reader[1];
                    imgUrl = (string)reader[2];
                }
            }
            connection.Close();
        }

        private DateTime date(int d, int m, int y)
        {
            DateTime today = DateTime.Today;
            DateTime newDate = today.AddDays(d).AddMonths(m).AddYears(y);
            return newDate;
        }

        private float prodPriceCalc(float price, float rate, ref float taxPrice)
        {
            taxPrice = (rate / 100) * price;
            return price * (1 + rate / 100);
        }

        private void getUserDetails()
        {
            connection.Open();
            SqlCommand user = new SqlCommand(userDetails, connection);
            user.Parameters.AddWithValue("@userId", userId);
            using(var reader = user.ExecuteReader())
            {
                while (reader.Read())
                {
                    firstName = (string)reader[0];
                    lastName = (string)reader[1];
                    username = (string)reader[2];
                }
            }
            connection.Close();
        }
    }
}
