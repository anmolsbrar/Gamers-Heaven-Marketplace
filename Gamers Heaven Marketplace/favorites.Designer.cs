namespace Gamers_Heaven_Marketplace
{
    partial class favorites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(favorites));
            this.favPanel = new System.Windows.Forms.Panel();
            this.accountControl1 = new Gamers_Heaven_Marketplace.accountControl();
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
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // favPanel
            // 
            this.favPanel.BackColor = System.Drawing.SystemColors.Control;
            this.favPanel.BackgroundImage = global::Gamers_Heaven_Marketplace.Properties.Resources.stripes;
            this.favPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.favPanel.Location = new System.Drawing.Point(224, 71);
            this.favPanel.Name = "favPanel";
            this.favPanel.Size = new System.Drawing.Size(663, 392);
            this.favPanel.TabIndex = 0;
            this.favPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.favPanel_Paint);
            // 
            // accountControl1
            // 
            this.accountControl1.getUserId = 0;
            this.accountControl1.Location = new System.Drawing.Point(409, 7);
            this.accountControl1.Name = "accountControl1";
            this.accountControl1.Size = new System.Drawing.Size(158, 63);
            this.accountControl1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.panel4.Controls.Add(this.logoutButton);
            this.panel4.Controls.Add(this.forwardButton);
            this.panel4.Controls.Add(this.backButton);
            this.panel4.Controls.Add(this.OrderButton);
            this.panel4.Controls.Add(this.favoritesButton);
            this.panel4.Controls.Add(this.homeButton);
            this.panel4.Location = new System.Drawing.Point(0, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 395);
            this.panel4.TabIndex = 20;
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
            this.panel3.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(135)))), ((int)(((byte)(21)))));
            this.panel5.Controls.Add(this.accControl);
            this.panel5.Controls.Add(this.logoPicture);
            this.panel5.Location = new System.Drawing.Point(-2, -8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 79);
            this.panel5.TabIndex = 18;
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
            // favorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.favPanel);
            this.Name = "favorites";
            this.Text = "Gamers\' Heaven";
            this.Load += new System.EventHandler(this.favorites_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel favPanel;
        private accountControl accountControl1;
        private System.Windows.Forms.Panel panel4;
        private forwardButton forwardButton;
        private backButton backButton;
        private ButtonFlat OrderButton;
        private ButtonFlat favoritesButton;
        private ButtonFlat homeButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private accountControl accControl;
        private System.Windows.Forms.PictureBox logoPicture;
        private ButtonFlat logoutButton;
    }
}