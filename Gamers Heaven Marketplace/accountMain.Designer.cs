namespace Gamers_Heaven_Marketplace
{
    partial class accountMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accountMain));
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.accControl = new Gamers_Heaven_Marketplace.accountControl();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.accountControl1 = new Gamers_Heaven_Marketplace.accountControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.logoutButton = new Gamers_Heaven_Marketplace.ButtonFlat();
            this.forwardButton1 = new Gamers_Heaven_Marketplace.forwardButton();
            this.backButton = new Gamers_Heaven_Marketplace.backButton();
            this.OrderButton = new Gamers_Heaven_Marketplace.ButtonFlat();
            this.favoritesButton = new Gamers_Heaven_Marketplace.ButtonFlat();
            this.buttonFlat1 = new Gamers_Heaven_Marketplace.ButtonFlat();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextbox
            // 
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.Location = new System.Drawing.Point(12, 62);
            this.searchTextbox.Multiline = true;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(198, 26);
            this.searchTextbox.TabIndex = 5;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(135)))), ((int)(((byte)(21)))));
            this.panel2.Controls.Add(this.accControl);
            this.panel2.Controls.Add(this.logoPicture);
            this.panel2.Location = new System.Drawing.Point(-2, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 79);
            this.panel2.TabIndex = 12;
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
            this.logoPicture.ErrorImage = null;
            this.logoPicture.Image = global::Gamers_Heaven_Marketplace.Properties.Resources.GamersHeavenLogo2;
            this.logoPicture.Location = new System.Drawing.Point(5, 0);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(223, 87);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicture.TabIndex = 11;
            this.logoPicture.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.accountControl1);
            this.panel3.Location = new System.Drawing.Point(224, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 73);
            this.panel3.TabIndex = 13;
            // 
            // accountControl1
            // 
            this.accountControl1.getUserId = 0;
            this.accountControl1.Location = new System.Drawing.Point(389, 11);
            this.accountControl1.Name = "accountControl1";
            this.accountControl1.Size = new System.Drawing.Size(158, 58);
            this.accountControl1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.panel4.Controls.Add(this.logoutButton);
            this.panel4.Controls.Add(this.forwardButton1);
            this.panel4.Controls.Add(this.backButton);
            this.panel4.Controls.Add(this.searchTextbox);
            this.panel4.Controls.Add(this.OrderButton);
            this.panel4.Controls.Add(this.favoritesButton);
            this.panel4.Controls.Add(this.buttonFlat1);
            this.panel4.Location = new System.Drawing.Point(0, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 395);
            this.panel4.TabIndex = 14;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.logoutButton.Location = new System.Drawing.Point(0, 345);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(224, 40);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click_1);
            // 
            // forwardButton1
            // 
            this.forwardButton1.FlatAppearance.BorderSize = 0;
            this.forwardButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardButton1.Image = ((System.Drawing.Image)(resources.GetObject("forwardButton1.Image")));
            this.forwardButton1.Location = new System.Drawing.Point(112, 24);
            this.forwardButton1.Name = "forwardButton1";
            this.forwardButton1.Size = new System.Drawing.Size(23, 23);
            this.forwardButton1.TabIndex = 7;
            this.forwardButton1.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(83, 24);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(23, 23);
            this.backButton.TabIndex = 6;
            this.backButton.UseVisualStyleBackColor = true;
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
            this.OrderButton.Click += new System.EventHandler(this.buttonFlat3_Click);
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
            // buttonFlat1
            // 
            this.buttonFlat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.buttonFlat1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFlat1.Location = new System.Drawing.Point(-1, 97);
            this.buttonFlat1.Name = "buttonFlat1";
            this.buttonFlat1.Size = new System.Drawing.Size(224, 40);
            this.buttonFlat1.TabIndex = 0;
            this.buttonFlat1.Text = "Home";
            this.buttonFlat1.UseVisualStyleBackColor = false;
            this.buttonFlat1.Click += new System.EventHandler(this.buttonFlat1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Gamers_Heaven_Marketplace.Properties.Resources.stripes;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(224, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 392);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // accountMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "accountMain";
            this.Text = "Gamers\' Heaven";
            this.Load += new System.EventHandler(this.accountMain_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchTextbox;
        private accountControl accControl;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private ButtonFlat buttonFlat1;
        private ButtonFlat favoritesButton;
        private ButtonFlat OrderButton;
        private backButton backButton;
        private forwardButton forwardButton1;
        private ButtonFlat logoutButton;
        private accountControl accountControl1;
    }
}