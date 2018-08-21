using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamers_Heaven_Marketplace
{
    public partial class orderConfirmation : Form
    {
        //Local vars
        private string fName, lName, email;
        private int userId;
        private static DateTime localTime;
        private string sqlFormattedDate;
        private string cardNum, formattedCardNum;
        private int _temp;
        private int orderNumber;
        private string prodKey;
        private bool proceed2Click = false, checkoutClick = false, isValidInfo = false;

        //Sql vars
        private SqlConnection connection = new SqlConnection(@"workstation id=gamersHeaven.mssql.somee.com;packet size=4096;user id=anmolsbrar_SQLLogin_1;pwd=bfpxou5b3u;data source=gamersHeaven.mssql.somee.com;persist security info=False;initial catalog=gamersHeaven");
        private string addToOrder = @"INSERT INTO [dbo].[orders] (userId, prodId, orderDate, paymentMethod, firstNameShip, lastNameShip, streetAddressShip,
                                    cityShip, provinceShip, countryShip, firstNameBill, lastNameBill, streetAddressBill, cityBill, provinceBill, countryBill, productKey) 
                                    VALUES (@uid, @pid, @date, @pay, @fnShip, @lnShip, @addShip, @cityShip, @pShip, @cShip, @fnBill, @lnBill, @addBill, @cityBill, @pBill, @cBill, @key)";
        private string getOrderNumber = @"SELECT orderId FROM [dbo].[orders] WHERE userId = @user";
        private string userInfo = @"SELECT fName, lName, email FROM [dbo].[login] WHERE id = @userId";
        private string product = @"SELECT prodName, prodPrice, prodImg, prodDesc FROM [dbo].[products] WHERE prodId = @pId";
        //Product vars
        private string prodName, prodUrl, prodDesc;
        private int prodId;
        private double prodPrice, prodTax = 12.00, gTotal, taxPrice;

        public orderConfirmation(int pid, int id)
        {
            prodId = pid;
            userId = id;
            InitializeComponent();
            accountControl1.getUserId = userId;
        }

        private void orderConfirmation_Load(object sender, EventArgs e)
        {
            fetchProductDetails();
            fetchUserDetails();
            comboboxFill();
            gTotal = prodPriceCalc(prodPrice, prodTax, ref taxPrice);
            orderPanel3.Visible = false;
            orderPanel2.Visible = false;
            orderPanel4.Visible = false;
            emailTextbox.Text = email;
            prodNameLabel.Text = prodName;
            prodPriceLabel.Text = prodPrice.ToString("c");
            prodDescLabel.Text = prodDesc;
            emailTextbox.Enabled = false;
            correctionLabel.Visible = false;
            invalidCardNameLabel.Visible = false;
            invalidCardNumLabel.Visible = false;
        }

        private void fetchProductDetails()
        {
            connection.Open();
            SqlCommand getProduct = new SqlCommand(product, connection);
            getProduct.Parameters.AddWithValue("@pId", prodId);
            using(var reader = getProduct.ExecuteReader())
            {
                while (reader.Read())
                {
                    prodName = (string)reader[0];
                    prodPrice = (float)reader[1];
                    prodUrl = (string)reader[2];
                    prodDesc = (string)reader[3];
                }
            }
            connection.Close();
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            orderPanel1.Visible = false;
            orderPanel2.Visible = true;
            orderPanel2.Location = orderPanel1.Location;
        }

        private void orderPanel2_Paint(object sender, PaintEventArgs e)
        {
            orderPanel2.Controls.Add(infoInnerPanel);
            orderPanel2.Controls.Add(p2ProdImage);
            p2ProdImage.Load(prodUrl);
            p2ProdImage.SizeMode = PictureBoxSizeMode.StretchImage;
            infoInnerPanel.AutoScroll = true;
            amountText.Text = prodPrice.ToString("c");
            taxText.Text = "+" + taxPrice.ToString("c");
            totalText.Text = gTotal.ToString("c");
            orderPanel2.Controls.Add(backtoOneButton);
        }

        private void orderPanel1_Paint(object sender, PaintEventArgs e)
        {
            orderPanel1.Controls.Add(prodImagebox);
            orderPanel1.Controls.Add(prodNameLabel);
            orderPanel1.Controls.Add(prodPriceLabel);
            orderPanel1.Controls.Add(prodDescLabel);
            paypalRadioButton.Enabled = false;
            orderPanel1.Controls.Add(masterImageBox);
            orderPanel1.Controls.Add(paypalImageBox);

            prodImagebox.Load(prodUrl);
            prodImagebox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                fNameB.Text = fNameS.Text;
                lNameB.Text = lNameS.Text;
                address1B.Text = address1S.Text;
                Address2B.Text = address2S.Text;
                cityB.Text = cityS.Text;
                provinceB.Text = provinceS.Text;
                countryB.Text = countryS.Text;
            }
            else if (!checkBox1.Checked)
            {
                fNameB.Text = "";
                lNameB.Text = "";
                address1B.Text = "";
                Address2B.Text = "";
                cityB.Text = "";
                provinceB.Text = "";
                countryB.Text = "";
            }
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            checkoutClick = true;
            if (!isValidInfo || string.IsNullOrWhiteSpace(cardNameTextbox.Text)
                || Regex.IsMatch(cardNameTextbox.Text, "^[0-9]+$"))
            {
                orderPanel3.Invalidate();
            }
            else
            {
                fillOrderPanel4();
                orderPanel3.Visible = false;
                orderPanel4.Visible = true;
                orderPanel4.Location = orderPanel3.Location;
                prodKey = productKeyGenerator();
                addOrder(addToOrder);
                orderNumber = retireveOrderNumber();
                orderNumberText.Text = orderNumber.ToString();
            }
        }

        private void orderPanel3_Paint(object sender, PaintEventArgs e)
        {
            if (checkoutClick)
            {
                if (cardNameTextbox.Text == "" || string.IsNullOrWhiteSpace(cardNameTextbox.Text)
                    || Regex.IsMatch(cardNameTextbox.Text, "^[0-9]+$"))
                {
                    cardNameTextbox.BorderStyle = BorderStyle.None;
                    textboxBorder(cardNameTextbox, e);
                    invalidCardNameLabel.Visible = true;
                }
                else
                {
                    cardNameTextbox.BorderStyle = BorderStyle.FixedSingle;
                    invalidCardNameLabel.Visible = false;
                }
                if ((cardNumberTextbox.Text.Length != 16) || !Regex.IsMatch(cardNumberTextbox.Text, "^[0-9]+$"))
                {
                    isValidInfo = false;
                    cardNumberTextbox.BorderStyle = BorderStyle.None;
                    cardNumberTextbox.Multiline = true;
                    textboxBorder(cardNumberTextbox, e);
                    invalidCardNumLabel.Visible = true;
                }
                else
                {
                    isValidInfo = true;
                    cardNameTextbox.BorderStyle = BorderStyle.FixedSingle;
                    invalidCardNumLabel.Visible = false;
                }
            }
            orderPanel3.Controls.Add(prodImg3);
            prodImg3.Load(prodUrl);
            prodImg3.SizeMode = PictureBoxSizeMode.StretchImage;
            amountText2.Text = prodPrice.ToString("c");
            taxText2.Text = "+" + taxPrice.ToString("c");
            totalText2.Text = gTotal.ToString("c");
            orderPanel3.Controls.Add(pictureBox1);
            orderPanel3.Controls.Add(backtwoTwoButton);
        }



        private void backtwoOneButton_Click(object sender, EventArgs e)
        {
            orderPanel1.Visible = true;
            orderPanel2.Visible = false;
            orderPanel1.Location = orderPanel2.Location;
        }

        private void backtwoTwoButton_Click(object sender, EventArgs e)
        {
            orderPanel3.Visible = false;
            orderPanel2.Visible = true;
            orderPanel2.Location = orderPanel3.Location;
        }

        private void orderPanel4_Paint(object sender, PaintEventArgs e)
        {
            orderPanel4.Controls.Add(prodImg4);
            prodImg4.SizeMode = PictureBoxSizeMode.StretchImage;
            prodImg4.Load(prodUrl);

            nameShippingS.Text = fNameS.Text + " " + lNameS.Text;
            address1TextS.Text = address1S.Text;
            cityTextS.Text = cityS.Text + ", " + provinceS.Text;
            countryTextS.Text = countryS.Text;

            nameTextB.Text = fNameB.Text + " " + lNameB.Text;
            address1TextB.Text = address1B.Text;
            cityTextB.Text = cityB.Text + ", " + provinceB.Text;
            countryTextB.Text = countryB.Text;

            prodNameFinal.Text = prodName;
            amountTextFinal.Text = prodPrice.ToString("c");
            taxTextFinal.Text = "+" + taxPrice.ToString("c");
            gTotalFinal.Text = gTotal.ToString("c");
        }

        private void revealButton_Click(object sender, EventArgs e)
        {
            keyLabel.Text = prodKey;
            revealButton.Enabled = false;
        }

       
        private void infoInnerPanel_Paint(object sender, PaintEventArgs e)
        {
            if (proceed2Click)
            {
                drawTextboxBorder(fNameS, e);
                drawTextboxBorder(lNameS, e);
                drawTextboxBorder(address1S, e);
                drawTextboxBorder(cityS, e);
                drawTextboxBorder(provinceS, e);
                drawTextboxBorder(countryS, e);
                drawTextboxBorder(fNameB, e);
                drawTextboxBorder(lNameB, e);
                drawTextboxBorder(address1B, e);
                drawTextboxBorder(cityB, e);
                drawTextboxBorder(provinceB, e);
                drawTextboxBorder(countryB, e);
            }
        }

        private bool textboxCheckP2()
        {
            return (string.IsNullOrWhiteSpace(fNameS.Text) || string.IsNullOrWhiteSpace(lNameS.Text) || string.IsNullOrWhiteSpace(address1S.Text) ||
                string.IsNullOrWhiteSpace(cityS.Text) || string.IsNullOrWhiteSpace(provinceS.Text) || string.IsNullOrWhiteSpace(countryS.Text) ||
                string.IsNullOrWhiteSpace(fNameB.Text) || string.IsNullOrWhiteSpace(lNameB.Text) || string.IsNullOrWhiteSpace(address1B.Text) ||
                string.IsNullOrWhiteSpace(cityB.Text) || string.IsNullOrWhiteSpace(provinceB.Text) || string.IsNullOrWhiteSpace(countryB.Text));
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            if (orderPanel1.Visible == true)
            {
                accountMain am = new accountMain(userId);
                am.Show();
                am.Location = this.Location;
                this.Hide();
            }
            if (orderPanel2.Visible == true)
            {
                orderPanel1.Visible = true;
                orderPanel2.Visible = false;
            }
            else if (orderPanel3.Visible == true)
            {
                orderPanel3.Visible = false;
                orderPanel2.Visible = true;
            }
            else if (orderPanel4.Visible == true)
            {
                if (MessageBox.Show("You will be redirected back to Home page", "Redirect", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    accountMain am = new accountMain(userId);
                    am.Show();
                    am.Location = this.Location;
                    this.Hide();
                }
            }
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

        private void proceedButton2_Click(object sender, EventArgs e)
        {
            proceed2Click = true;
            if (textboxCheckP2())
                {
                    infoInnerPanel.Invalidate();
                    correctionLabel.Visible = true;
                }         
            else
            {
                orderPanel2.Visible = false;
                orderPanel3.Visible = true;
                orderPanel3.Location = orderPanel2.Location;
                monthsBox.SelectedIndex = 0;
                yearBox.SelectedIndex = 0;
            }
        }

        private void fillOrderPanel4()
        {
            cardNum = cardNumberTextbox.Text;
            formattedCardNum = cardNum.Substring(cardNum.Length - 4).PadLeft(cardNum.Length, 'X');
            localTime = DateTime.Now;
            sqlFormattedDate = localTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

            orderPlacedText.Text = localTime.ToString();
            cardNumText.Text = formattedCardNum;
            
        }

        private void addOrder(string command)
        {
            connection.Open();
            SqlCommand orders = new SqlCommand(command, connection);
            orders.Parameters.AddWithValue("@uid", userId);
            orders.Parameters.AddWithValue("@pid", prodId);
            orders.Parameters.AddWithValue("@date", sqlFormattedDate);
            orders.Parameters.AddWithValue("@pay", cardNum);
            orders.Parameters.AddWithValue("@fnShip", fNameS.Text);
            orders.Parameters.AddWithValue("@lnShip", lNameS.Text);
            orders.Parameters.AddWithValue("@addShip", address1S.Text);
            orders.Parameters.AddWithValue("@cityShip", cityS.Text);
            orders.Parameters.AddWithValue("@pShip", provinceS.Text);
            orders.Parameters.AddWithValue("@cShip", countryS.Text);
            orders.Parameters.AddWithValue("@fnBill", fNameB.Text);
            orders.Parameters.AddWithValue("@lnBill", lNameB.Text);
            orders.Parameters.AddWithValue("@addBill", address1B.Text);
            orders.Parameters.AddWithValue("@cityBill", cityB.Text);
            orders.Parameters.AddWithValue("@pBill", provinceB.Text);
            orders.Parameters.AddWithValue("@cBill", countryB.Text);
            orders.Parameters.AddWithValue("@key", prodKey);
            orders.ExecuteNonQuery();
            connection.Close();
        }

        private int retireveOrderNumber()
        {
            connection.Open();
            int number = _temp;
            SqlCommand oNum = new SqlCommand(getOrderNumber, connection);
            oNum.Parameters.AddWithValue("@user", userId);
            oNum.Parameters.AddWithValue("@date", sqlFormattedDate);
            using(SqlDataReader reader = oNum.ExecuteReader())
            {
                while (reader.Read())
                {
                     number = (int)reader[0];
                }
            }
            connection.Close();
            return number;
        }

        private double prodPriceCalc(double price, double rate, ref double taxPrice)
        {
            taxPrice = (rate / 100) * price;
            return price * (1 + rate / 100);
        }

        private void textboxBorder(TextBox t, PaintEventArgs e)
        {
            t.Multiline = true;
            Pen p = new Pen(Color.Red, 2);
            Graphics g = e.Graphics;
            g.DrawRectangle(p, new Rectangle(t.Location.X - 1, t.Location.Y - 1, t.Width + 1, t.Height + 1));
        }
        
        private void drawTextboxBorder(TextBox t, PaintEventArgs e)
        {
            if(t.Text == "" || string.IsNullOrWhiteSpace(t.Text))
            {
                t.BorderStyle = BorderStyle.None;
                textboxBorder(t, e);
            }
            else
            {
                t.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private string productKeyGenerator()
        {
            bool isDone = false;
            char[] c = new char[20];
            int count = 0;
            Random rand = new Random();
            while (!isDone)
            {
                int temp = rand.Next(48, 90);
                if(count < 20)
                {
                    isDone = false;
                    if((temp >= 48 && temp <= 57) || (temp >= 65 && temp <= 90))
                    {
                        c[count] = (char)temp;
                        count++;
                    }
                }
                if(count >= 20)
                {
                    isDone = true;
                }
            }
            string key = new string(c);
            key = Regex.Replace(key, ".{4}", "$0-");
            key = key.Remove(key.Length - 1);

            return key;
        }

        private void comboboxFill()
        {
            for (int i = 1; i <= 12; i++)
            {
                var month = i.ToString().PadLeft(2, '0');
                monthsBox.Items.Add(month);
            }

            for (int year = DateTime.Now.Year; year < 2030; year++)
            {
                yearBox.Items.Add(year).ToString();
            }
        }

        private void fetchUserDetails()
        {
            connection.Open();
            SqlCommand userDetails = new SqlCommand(userInfo, connection);
            userDetails.Parameters.AddWithValue("userId", userId);
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
    }
}