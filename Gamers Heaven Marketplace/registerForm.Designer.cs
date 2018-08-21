namespace Gamers_Heaven_Marketplace
{
    partial class registerForm
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
            this.registerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fNameTextbox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.pass2TextBox = new System.Windows.Forms.TextBox();
            this.pass1Textbox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.termsCheckbox = new System.Windows.Forms.CheckBox();
            this.takenUserText = new System.Windows.Forms.Label();
            this.takenEmail = new System.Windows.Forms.Label();
            this.securityTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.password2Tick = new System.Windows.Forms.PictureBox();
            this.emailTick = new System.Windows.Forms.PictureBox();
            this.passwordTick = new System.Windows.Forms.PictureBox();
            this.usernameTick = new System.Windows.Forms.PictureBox();
            this.lnameTick = new System.Windows.Forms.PictureBox();
            this.fnametick = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.password2Tick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnameTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnametick)).BeginInit();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.SystemColors.Control;
            this.registerButton.Location = new System.Drawing.Point(218, 302);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // fNameTextbox
            // 
            this.fNameTextbox.Location = new System.Drawing.Point(112, 50);
            this.fNameTextbox.Name = "fNameTextbox";
            this.fNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.fNameTextbox.TabIndex = 0;
            this.fNameTextbox.TextChanged += new System.EventHandler(this.fNameTextbox_TextChanged);
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Location = new System.Drawing.Point(112, 93);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lNameTextBox.TabIndex = 1;
            this.lNameTextBox.TextChanged += new System.EventHandler(this.lNameTextBox_TextChanged);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(112, 136);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(100, 20);
            this.emailTextbox.TabIndex = 2;
            this.emailTextbox.TextChanged += new System.EventHandler(this.emailTextbox_TextChanged);
            // 
            // pass2TextBox
            // 
            this.pass2TextBox.Location = new System.Drawing.Point(372, 136);
            this.pass2TextBox.Name = "pass2TextBox";
            this.pass2TextBox.PasswordChar = '*';
            this.pass2TextBox.Size = new System.Drawing.Size(100, 20);
            this.pass2TextBox.TabIndex = 5;
            this.pass2TextBox.TextChanged += new System.EventHandler(this.pass2TextBox_TextChanged);
            // 
            // pass1Textbox
            // 
            this.pass1Textbox.Location = new System.Drawing.Point(372, 93);
            this.pass1Textbox.Name = "pass1Textbox";
            this.pass1Textbox.PasswordChar = '*';
            this.pass1Textbox.Size = new System.Drawing.Size(100, 20);
            this.pass1Textbox.TabIndex = 4;
            this.pass1Textbox.TextChanged += new System.EventHandler(this.pass1Textbox_TextChanged);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(372, 50);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextbox.TabIndex = 3;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.usernameTextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Username";
            // 
            // termsCheckbox
            // 
            this.termsCheckbox.AutoSize = true;
            this.termsCheckbox.Location = new System.Drawing.Point(164, 279);
            this.termsCheckbox.Name = "termsCheckbox";
            this.termsCheckbox.Size = new System.Drawing.Size(202, 17);
            this.termsCheckbox.TabIndex = 7;
            this.termsCheckbox.Text = "I agree to all the terms and conditions";
            this.termsCheckbox.UseVisualStyleBackColor = true;
            this.termsCheckbox.CheckedChanged += new System.EventHandler(this.termsCheckbox_CheckedChanged);
            // 
            // takenUserText
            // 
            this.takenUserText.AutoSize = true;
            this.takenUserText.BackColor = System.Drawing.SystemColors.Control;
            this.takenUserText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takenUserText.ForeColor = System.Drawing.Color.Red;
            this.takenUserText.Location = new System.Drawing.Point(369, 70);
            this.takenUserText.Name = "takenUserText";
            this.takenUserText.Size = new System.Drawing.Size(114, 12);
            this.takenUserText.TabIndex = 23;
            this.takenUserText.Text = "Username is already taken";
            // 
            // takenEmail
            // 
            this.takenEmail.AutoSize = true;
            this.takenEmail.BackColor = System.Drawing.SystemColors.Control;
            this.takenEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takenEmail.ForeColor = System.Drawing.Color.Red;
            this.takenEmail.Location = new System.Drawing.Point(112, 156);
            this.takenEmail.Name = "takenEmail";
            this.takenEmail.Size = new System.Drawing.Size(87, 12);
            this.takenEmail.TabIndex = 23;
            this.takenEmail.Text = "Email already exists";
            // 
            // securityTextbox
            // 
            this.securityTextbox.Location = new System.Drawing.Point(218, 237);
            this.securityTextbox.Name = "securityTextbox";
            this.securityTextbox.Size = new System.Drawing.Size(100, 20);
            this.securityTextbox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Security Question";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(23, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(489, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Please enter your mother\'s maiden name or your favourite sports team as the answe" +
    "r for the security question";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Answer";
            // 
            // password2Tick
            // 
            this.password2Tick.Location = new System.Drawing.Point(478, 134);
            this.password2Tick.Name = "password2Tick";
            this.password2Tick.Size = new System.Drawing.Size(23, 23);
            this.password2Tick.TabIndex = 22;
            this.password2Tick.TabStop = false;
            // 
            // emailTick
            // 
            this.emailTick.Location = new System.Drawing.Point(218, 134);
            this.emailTick.Name = "emailTick";
            this.emailTick.Size = new System.Drawing.Size(23, 23);
            this.emailTick.TabIndex = 22;
            this.emailTick.TabStop = false;
            // 
            // passwordTick
            // 
            this.passwordTick.Location = new System.Drawing.Point(478, 90);
            this.passwordTick.Name = "passwordTick";
            this.passwordTick.Size = new System.Drawing.Size(23, 23);
            this.passwordTick.TabIndex = 22;
            this.passwordTick.TabStop = false;
            // 
            // usernameTick
            // 
            this.usernameTick.Location = new System.Drawing.Point(478, 47);
            this.usernameTick.Name = "usernameTick";
            this.usernameTick.Size = new System.Drawing.Size(23, 23);
            this.usernameTick.TabIndex = 22;
            this.usernameTick.TabStop = false;
            // 
            // lnameTick
            // 
            this.lnameTick.Location = new System.Drawing.Point(218, 90);
            this.lnameTick.Name = "lnameTick";
            this.lnameTick.Size = new System.Drawing.Size(23, 23);
            this.lnameTick.TabIndex = 22;
            this.lnameTick.TabStop = false;
            // 
            // fnametick
            // 
            this.fnametick.Location = new System.Drawing.Point(218, 47);
            this.fnametick.Name = "fnametick";
            this.fnametick.Size = new System.Drawing.Size(23, 23);
            this.fnametick.TabIndex = 22;
            this.fnametick.TabStop = false;
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(540, 338);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.securityTextbox);
            this.Controls.Add(this.takenEmail);
            this.Controls.Add(this.takenUserText);
            this.Controls.Add(this.password2Tick);
            this.Controls.Add(this.emailTick);
            this.Controls.Add(this.passwordTick);
            this.Controls.Add(this.usernameTick);
            this.Controls.Add(this.lnameTick);
            this.Controls.Add(this.fnametick);
            this.Controls.Add(this.termsCheckbox);
            this.Controls.Add(this.pass2TextBox);
            this.Controls.Add(this.pass1Textbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(this.fNameTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerButton);
            this.Name = "registerForm";
            this.Text = "Gamers\' Heaven";
            this.Load += new System.EventHandler(this.registerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.password2Tick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnameTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnametick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fNameTextbox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox pass2TextBox;
        private System.Windows.Forms.TextBox pass1Textbox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox termsCheckbox;
        private System.Windows.Forms.PictureBox fnametick;
        private System.Windows.Forms.PictureBox lnameTick;
        private System.Windows.Forms.PictureBox emailTick;
        private System.Windows.Forms.PictureBox usernameTick;
        private System.Windows.Forms.PictureBox passwordTick;
        private System.Windows.Forms.PictureBox password2Tick;
        private System.Windows.Forms.Label takenUserText;
        private System.Windows.Forms.Label takenEmail;
        private System.Windows.Forms.TextBox securityTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}