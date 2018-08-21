namespace Gamers_Heaven_Marketplace
{
    partial class AccountDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.changePass = new System.Windows.Forms.LinkLabel();
            this.lNameTextbox = new System.Windows.Forms.TextBox();
            this.passTextbox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.fNameTextbox = new System.Windows.Forms.TextBox();
            this.userTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Gamers_Heaven_Marketplace.Properties.Resources.stripes;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(224, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 392);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(146)))));
            this.panel2.Controls.Add(this.profilePicture);
            this.panel2.Controls.Add(this.changePass);
            this.panel2.Controls.Add(this.lNameTextbox);
            this.panel2.Controls.Add(this.passTextbox);
            this.panel2.Controls.Add(this.emailTextbox);
            this.panel2.Controls.Add(this.fNameTextbox);
            this.panel2.Controls.Add(this.userTextbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(49, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 355);
            this.panel2.TabIndex = 4;
            // 
            // profilePicture
            // 
            this.profilePicture.BackgroundImage = global::Gamers_Heaven_Marketplace.Properties.Resources.profileImage;
            this.profilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePicture.Location = new System.Drawing.Point(188, 21);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(150, 150);
            this.profilePicture.TabIndex = 15;
            this.profilePicture.TabStop = false;
            // 
            // changePass
            // 
            this.changePass.AutoSize = true;
            this.changePass.Location = new System.Drawing.Point(459, 200);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(93, 13);
            this.changePass.TabIndex = 14;
            this.changePass.TabStop = true;
            this.changePass.Text = "Change Password";
            // 
            // lNameTextbox
            // 
            this.lNameTextbox.Location = new System.Drawing.Point(320, 238);
            this.lNameTextbox.Name = "lNameTextbox";
            this.lNameTextbox.Size = new System.Drawing.Size(133, 20);
            this.lNameTextbox.TabIndex = 9;
            // 
            // passTextbox
            // 
            this.passTextbox.Location = new System.Drawing.Point(320, 197);
            this.passTextbox.Name = "passTextbox";
            this.passTextbox.PasswordChar = '*';
            this.passTextbox.Size = new System.Drawing.Size(133, 20);
            this.passTextbox.TabIndex = 10;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(83, 279);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(133, 20);
            this.emailTextbox.TabIndex = 11;
            // 
            // fNameTextbox
            // 
            this.fNameTextbox.Location = new System.Drawing.Point(83, 238);
            this.fNameTextbox.Name = "fNameTextbox";
            this.fNameTextbox.Size = new System.Drawing.Size(133, 20);
            this.fNameTextbox.TabIndex = 12;
            // 
            // userTextbox
            // 
            this.userTextbox.Location = new System.Drawing.Point(83, 197);
            this.userTextbox.Name = "userTextbox";
            this.userTextbox.Size = new System.Drawing.Size(133, 20);
            this.userTextbox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
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
            // AccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "AccountDetails";
            this.Text = "AccountDetails";
            this.Load += new System.EventHandler(this.AccountDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private ButtonFlat logoutButton;
        private forwardButton forwardButton;
        private backButton backButton;
        private ButtonFlat OrderButton;
        private ButtonFlat favoritesButton;
        private ButtonFlat homeButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private accountControl accControl;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel changePass;
        private System.Windows.Forms.TextBox lNameTextbox;
        private System.Windows.Forms.TextBox passTextbox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox fNameTextbox;
        private System.Windows.Forms.TextBox userTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox profilePicture;
    }
}