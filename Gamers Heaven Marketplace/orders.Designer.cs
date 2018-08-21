namespace Gamers_Heaven_Marketplace
{
    partial class orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orders));
            this.orderPanel = new System.Windows.Forms.Panel();
            this.accountControl1 = new Gamers_Heaven_Marketplace.accountControl();
            this.filterBox = new System.Windows.Forms.ComboBox();
            this.orderDetailPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fulfillDate = new System.Windows.Forms.Label();
            this.keyButton = new System.Windows.Forms.Button();
            this.buyAgainButton = new System.Windows.Forms.Button();
            this.prodPrice = new System.Windows.Forms.Label();
            this.prodTitleText = new System.Windows.Forms.Label();
            this.prodImg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cardNumText = new System.Windows.Forms.Label();
            this.gTotalFinal = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.taxTextFinal = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.amountTextFinal = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.countryTextB = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.countryTextS = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cityTextB = new System.Windows.Forms.Label();
            this.nameShippingS = new System.Windows.Forms.Label();
            this.cityTextS = new System.Windows.Forms.Label();
            this.nameTextB = new System.Windows.Forms.Label();
            this.address1TextB = new System.Windows.Forms.Label();
            this.address1TextS = new System.Windows.Forms.Label();
            this.orderDateText = new System.Windows.Forms.Label();
            this.orderNumberText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.logoutButton = new Gamers_Heaven_Marketplace.ButtonFlat();
            this.forwardButton = new Gamers_Heaven_Marketplace.forwardButton();
            this.backButton = new Gamers_Heaven_Marketplace.backButton();
            this.OrderButton = new Gamers_Heaven_Marketplace.ButtonFlat();
            this.favoritesButton = new Gamers_Heaven_Marketplace.ButtonFlat();
            this.homeButton = new Gamers_Heaven_Marketplace.ButtonFlat();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.accControl = new Gamers_Heaven_Marketplace.accountControl();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.orderPanelMain = new System.Windows.Forms.Panel();
            this.orderDetailPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.orderPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderPanel
            // 
            this.orderPanel.BackgroundImage = global::Gamers_Heaven_Marketplace.Properties.Resources.stripes;
            this.orderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orderPanel.Location = new System.Drawing.Point(224, 71);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(660, 392);
            this.orderPanel.TabIndex = 0;
            // 
            // accountControl1
            // 
            this.accountControl1.getUserId = 0;
            this.accountControl1.Location = new System.Drawing.Point(407, 7);
            this.accountControl1.Name = "accountControl1";
            this.accountControl1.Size = new System.Drawing.Size(158, 63);
            this.accountControl1.TabIndex = 4;
            // 
            // filterBox
            // 
            this.filterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBox.FormattingEnabled = true;
            this.filterBox.Location = new System.Drawing.Point(12, 62);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(198, 26);
            this.filterBox.TabIndex = 1;
            this.filterBox.SelectedIndexChanged += new System.EventHandler(this.filterBox_SelectedIndexChanged);
            // 
            // orderDetailPanel
            // 
            this.orderDetailPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(146)))));
            this.orderDetailPanel.Controls.Add(this.panel2);
            this.orderDetailPanel.Controls.Add(this.panel1);
            this.orderDetailPanel.Controls.Add(this.orderDateText);
            this.orderDetailPanel.Controls.Add(this.orderNumberText);
            this.orderDetailPanel.Controls.Add(this.label4);
            this.orderDetailPanel.Controls.Add(this.label3);
            this.orderDetailPanel.Controls.Add(this.label2);
            this.orderDetailPanel.Location = new System.Drawing.Point(10, 34);
            this.orderDetailPanel.Name = "orderDetailPanel";
            this.orderDetailPanel.Size = new System.Drawing.Size(640, 310);
            this.orderDetailPanel.TabIndex = 3;
            this.orderDetailPanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.fulfillDate);
            this.panel2.Controls.Add(this.keyButton);
            this.panel2.Controls.Add(this.buyAgainButton);
            this.panel2.Controls.Add(this.prodPrice);
            this.panel2.Controls.Add(this.prodTitleText);
            this.panel2.Controls.Add(this.prodImg);
            this.panel2.Location = new System.Drawing.Point(3, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 105);
            this.panel2.TabIndex = 3;
            // 
            // fulfillDate
            // 
            this.fulfillDate.AutoSize = true;
            this.fulfillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fulfillDate.Location = new System.Drawing.Point(85, 59);
            this.fulfillDate.Name = "fulfillDate";
            this.fulfillDate.Size = new System.Drawing.Size(50, 13);
            this.fulfillDate.TabIndex = 16;
            this.fulfillDate.Text = "fulfillDate";
            // 
            // keyButton
            // 
            this.keyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.keyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.keyButton.FlatAppearance.BorderSize = 0;
            this.keyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.keyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.keyButton.Location = new System.Drawing.Point(511, 49);
            this.keyButton.Name = "keyButton";
            this.keyButton.Size = new System.Drawing.Size(75, 23);
            this.keyButton.TabIndex = 15;
            this.keyButton.Text = "Show Key";
            this.keyButton.UseVisualStyleBackColor = false;
            this.keyButton.Click += new System.EventHandler(this.keyButton_Click);
            // 
            // buyAgainButton
            // 
            this.buyAgainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.buyAgainButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.buyAgainButton.FlatAppearance.BorderSize = 0;
            this.buyAgainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.buyAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyAgainButton.ForeColor = System.Drawing.SystemColors.Control;
            this.buyAgainButton.Location = new System.Drawing.Point(511, 14);
            this.buyAgainButton.Name = "buyAgainButton";
            this.buyAgainButton.Size = new System.Drawing.Size(75, 23);
            this.buyAgainButton.TabIndex = 14;
            this.buyAgainButton.Text = "Buy Again";
            this.buyAgainButton.UseVisualStyleBackColor = false;
            this.buyAgainButton.Click += new System.EventHandler(this.buyAgainButton_Click);
            // 
            // prodPrice
            // 
            this.prodPrice.AutoSize = true;
            this.prodPrice.ForeColor = System.Drawing.Color.IndianRed;
            this.prodPrice.Location = new System.Drawing.Point(85, 75);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(52, 13);
            this.prodPrice.TabIndex = 13;
            this.prodPrice.Text = "prodPrice";
            // 
            // prodTitleText
            // 
            this.prodTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodTitleText.Location = new System.Drawing.Point(85, 14);
            this.prodTitleText.Name = "prodTitleText";
            this.prodTitleText.Size = new System.Drawing.Size(431, 36);
            this.prodTitleText.TabIndex = 12;
            this.prodTitleText.Text = "prodTitle";
            // 
            // prodImg
            // 
            this.prodImg.Location = new System.Drawing.Point(16, 14);
            this.prodImg.Name = "prodImg";
            this.prodImg.Size = new System.Drawing.Size(61, 74);
            this.prodImg.TabIndex = 11;
            this.prodImg.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cardNumText);
            this.panel1.Controls.Add(this.gTotalFinal);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.taxTextFinal);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Controls.Add(this.label42);
            this.panel1.Controls.Add(this.amountTextFinal);
            this.panel1.Controls.Add(this.label44);
            this.panel1.Controls.Add(this.countryTextB);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.countryTextS);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.cityTextB);
            this.panel1.Controls.Add(this.nameShippingS);
            this.panel1.Controls.Add(this.cityTextS);
            this.panel1.Controls.Add(this.nameTextB);
            this.panel1.Controls.Add(this.address1TextB);
            this.panel1.Controls.Add(this.address1TextS);
            this.panel1.Location = new System.Drawing.Point(3, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 128);
            this.panel1.TabIndex = 3;
            // 
            // cardNumText
            // 
            this.cardNumText.AutoSize = true;
            this.cardNumText.Location = new System.Drawing.Point(467, 26);
            this.cardNumText.Name = "cardNumText";
            this.cardNumText.Size = new System.Drawing.Size(50, 13);
            this.cardNumText.TabIndex = 14;
            this.cardNumText.Text = "cardNum";
            // 
            // gTotalFinal
            // 
            this.gTotalFinal.AutoSize = true;
            this.gTotalFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTotalFinal.ForeColor = System.Drawing.Color.IndianRed;
            this.gTotalFinal.Location = new System.Drawing.Point(522, 105);
            this.gTotalFinal.Name = "gTotalFinal";
            this.gTotalFinal.Size = new System.Drawing.Size(38, 16);
            this.gTotalFinal.TabIndex = 31;
            this.gTotalFinal.Text = "total";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(462, 10);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(100, 13);
            this.label31.TabIndex = 9;
            this.label31.Text = "Payment method";
            // 
            // taxTextFinal
            // 
            this.taxTextFinal.AutoSize = true;
            this.taxTextFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxTextFinal.Location = new System.Drawing.Point(522, 89);
            this.taxTextFinal.Name = "taxTextFinal";
            this.taxTextFinal.Size = new System.Drawing.Size(24, 13);
            this.taxTextFinal.TabIndex = 32;
            this.taxTextFinal.Text = "tax";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(439, 105);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(79, 16);
            this.label41.TabIndex = 28;
            this.label41.Text = "Grand total: ";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(477, 89);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(39, 13);
            this.label42.TabIndex = 29;
            this.label42.Text = "Taxes:";
            // 
            // amountTextFinal
            // 
            this.amountTextFinal.AutoSize = true;
            this.amountTextFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextFinal.Location = new System.Drawing.Point(522, 73);
            this.amountTextFinal.Name = "amountTextFinal";
            this.amountTextFinal.Size = new System.Drawing.Size(27, 13);
            this.amountTextFinal.TabIndex = 33;
            this.amountTextFinal.Text = "amt";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(462, 73);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(56, 13);
            this.label44.TabIndex = 30;
            this.label44.Text = "Item total: ";
            // 
            // countryTextB
            // 
            this.countryTextB.AutoSize = true;
            this.countryTextB.Location = new System.Drawing.Point(225, 75);
            this.countryTextB.Name = "countryTextB";
            this.countryTextB.Size = new System.Drawing.Size(42, 13);
            this.countryTextB.TabIndex = 17;
            this.countryTextB.Text = "country";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(14, 10);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(105, 13);
            this.label28.TabIndex = 12;
            this.label28.Text = "Shipping Address";
            // 
            // countryTextS
            // 
            this.countryTextS.AutoSize = true;
            this.countryTextS.Location = new System.Drawing.Point(14, 75);
            this.countryTextS.Name = "countryTextS";
            this.countryTextS.Size = new System.Drawing.Size(42, 13);
            this.countryTextS.TabIndex = 18;
            this.countryTextS.Text = "country";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(462, 56);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(92, 13);
            this.label30.TabIndex = 10;
            this.label30.Text = "Order Summary";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(225, 10);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(90, 13);
            this.label29.TabIndex = 11;
            this.label29.Text = "Billing Address";
            // 
            // cityTextB
            // 
            this.cityTextB.AutoSize = true;
            this.cityTextB.Location = new System.Drawing.Point(225, 59);
            this.cityTextB.Name = "cityTextB";
            this.cityTextB.Size = new System.Drawing.Size(23, 13);
            this.cityTextB.TabIndex = 19;
            this.cityTextB.Text = "city";
            // 
            // nameShippingS
            // 
            this.nameShippingS.AutoSize = true;
            this.nameShippingS.Location = new System.Drawing.Point(14, 26);
            this.nameShippingS.Name = "nameShippingS";
            this.nameShippingS.Size = new System.Drawing.Size(74, 13);
            this.nameShippingS.TabIndex = 16;
            this.nameShippingS.Text = "nameShipping";
            // 
            // cityTextS
            // 
            this.cityTextS.AutoSize = true;
            this.cityTextS.Location = new System.Drawing.Point(14, 59);
            this.cityTextS.Name = "cityTextS";
            this.cityTextS.Size = new System.Drawing.Size(23, 13);
            this.cityTextS.TabIndex = 20;
            this.cityTextS.Text = "city";
            // 
            // nameTextB
            // 
            this.nameTextB.AutoSize = true;
            this.nameTextB.Location = new System.Drawing.Point(225, 26);
            this.nameTextB.Name = "nameTextB";
            this.nameTextB.Size = new System.Drawing.Size(60, 13);
            this.nameTextB.TabIndex = 15;
            this.nameTextB.Text = "nameBilling";
            // 
            // address1TextB
            // 
            this.address1TextB.AutoSize = true;
            this.address1TextB.Location = new System.Drawing.Point(225, 42);
            this.address1TextB.Name = "address1TextB";
            this.address1TextB.Size = new System.Drawing.Size(50, 13);
            this.address1TextB.TabIndex = 21;
            this.address1TextB.Text = "address1";
            // 
            // address1TextS
            // 
            this.address1TextS.AutoSize = true;
            this.address1TextS.Location = new System.Drawing.Point(14, 42);
            this.address1TextS.Name = "address1TextS";
            this.address1TextS.Size = new System.Drawing.Size(50, 13);
            this.address1TextS.TabIndex = 22;
            this.address1TextS.Text = "address1";
            // 
            // orderDateText
            // 
            this.orderDateText.AutoSize = true;
            this.orderDateText.Location = new System.Drawing.Point(188, 30);
            this.orderDateText.Name = "orderDateText";
            this.orderDateText.Size = new System.Drawing.Size(54, 13);
            this.orderDateText.TabIndex = 2;
            this.orderDateText.Text = "orderDate";
            // 
            // orderNumberText
            // 
            this.orderNumberText.AutoSize = true;
            this.orderNumberText.Location = new System.Drawing.Point(58, 30);
            this.orderNumberText.Name = "orderNumberText";
            this.orderNumberText.Size = new System.Drawing.Size(53, 13);
            this.orderNumberText.TabIndex = 2;
            this.orderNumberText.Text = "orderNum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ordered on";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Order #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order Details";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.panel4.Controls.Add(this.logoutButton);
            this.panel4.Controls.Add(this.forwardButton);
            this.panel4.Controls.Add(this.backButton);
            this.panel4.Controls.Add(this.OrderButton);
            this.panel4.Controls.Add(this.favoritesButton);
            this.panel4.Controls.Add(this.filterBox);
            this.panel4.Controls.Add(this.homeButton);
            this.panel4.Location = new System.Drawing.Point(0, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 395);
            this.panel4.TabIndex = 17;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.logoutButton.Location = new System.Drawing.Point(0, 345);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(224, 40);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.FlatAppearance.BorderSize = 0;
            this.forwardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.forwardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.forwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardButton.Image")));
            this.forwardButton.Location = new System.Drawing.Point(112, 24);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(23, 23);
            this.forwardButton.TabIndex = 7;
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(83, 24);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(23, 23);
            this.backButton.TabIndex = 6;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.OrderButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OrderButton.Location = new System.Drawing.Point(-1, 189);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(224, 40);
            this.OrderButton.TabIndex = 0;
            this.OrderButton.Text = "Orders";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // favoritesButton
            // 
            this.favoritesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.favoritesButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.favoritesButton.Location = new System.Drawing.Point(-1, 143);
            this.favoritesButton.Name = "favoritesButton";
            this.favoritesButton.Size = new System.Drawing.Size(224, 40);
            this.favoritesButton.TabIndex = 0;
            this.favoritesButton.Text = "Favorites";
            this.favoritesButton.UseVisualStyleBackColor = false;
            this.favoritesButton.Click += new System.EventHandler(this.favoritesButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.homeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeButton.Location = new System.Drawing.Point(-1, 97);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(224, 40);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.accountControl1);
            this.panel3.Location = new System.Drawing.Point(224, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 73);
            this.panel3.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(135)))), ((int)(((byte)(21)))));
            this.panel5.Controls.Add(this.accControl);
            this.panel5.Controls.Add(this.logoPicture);
            this.panel5.Location = new System.Drawing.Point(-2, -8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 79);
            this.panel5.TabIndex = 15;
            // 
            // accControl
            // 
            this.accControl.getUserId = 0;
            this.accControl.Location = new System.Drawing.Point(646, 17);
            this.accControl.Name = "accControl";
            this.accControl.Size = new System.Drawing.Size(158, 61);
            this.accControl.TabIndex = 9;
            // 
            // logoPicture
            // 
            this.logoPicture.Image = global::Gamers_Heaven_Marketplace.Properties.Resources.GamersHeavenLogo2;
            this.logoPicture.Location = new System.Drawing.Point(5, 0);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(223, 87);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicture.TabIndex = 11;
            this.logoPicture.TabStop = false;
            // 
            // orderPanelMain
            // 
            this.orderPanelMain.BackgroundImage = global::Gamers_Heaven_Marketplace.Properties.Resources.stripes;
            this.orderPanelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orderPanelMain.Controls.Add(this.orderDetailPanel);
            this.orderPanelMain.Location = new System.Drawing.Point(946, 71);
            this.orderPanelMain.Name = "orderPanelMain";
            this.orderPanelMain.Size = new System.Drawing.Size(660, 392);
            this.orderPanelMain.TabIndex = 18;
            // 
            // orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.orderPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.orderPanelMain);
            this.Name = "orders";
            this.Text = "orders";
            this.Load += new System.EventHandler(this.orders_Load);
            this.orderDetailPanel.ResumeLayout(false);
            this.orderDetailPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.orderPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox filterBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label orderDateText;
        private System.Windows.Forms.Label orderNumberText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label countryTextB;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label countryTextS;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label cityTextB;
        private System.Windows.Forms.Label nameShippingS;
        private System.Windows.Forms.Label cityTextS;
        private System.Windows.Forms.Label nameTextB;
        private System.Windows.Forms.Label address1TextB;
        private System.Windows.Forms.Label address1TextS;
        private System.Windows.Forms.Label cardNumText;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label gTotalFinal;
        private System.Windows.Forms.Label taxTextFinal;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label amountTextFinal;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label prodPrice;
        private System.Windows.Forms.Label prodTitleText;
        private System.Windows.Forms.PictureBox prodImg;
        private System.Windows.Forms.Button keyButton;
        private System.Windows.Forms.Button buyAgainButton;
        private System.Windows.Forms.Label fulfillDate;
        public System.Windows.Forms.Panel orderPanel;
        private accountControl accountControl1;
        private System.Windows.Forms.Panel panel4;
        private ButtonFlat OrderButton;
        private ButtonFlat favoritesButton;
        private ButtonFlat homeButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private accountControl accControl;
        private System.Windows.Forms.PictureBox logoPicture;
        private forwardButton forwardButton;
        private backButton backButton;
        private ButtonFlat logoutButton;
        public System.Windows.Forms.Panel orderPanelMain;
        public System.Windows.Forms.Panel orderDetailPanel;
    }
}