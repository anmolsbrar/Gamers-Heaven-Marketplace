namespace Gamers_Heaven_Marketplace
{
    partial class passwordReset
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.noUserText = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.invalidEmailAnswer = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.answerTextbox = new System.Windows.Forms.TextBox();
            this.emailHintText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nextButton2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.invalidPass = new System.Windows.Forms.Label();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.pass1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Reset";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.noUserText);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Controls.Add(this.usernameTextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 160);
            this.panel1.TabIndex = 1;
            // 
            // noUserText
            // 
            this.noUserText.AutoSize = true;
            this.noUserText.ForeColor = System.Drawing.Color.Red;
            this.noUserText.Location = new System.Drawing.Point(184, 32);
            this.noUserText.Name = "noUserText";
            this.noUserText.Size = new System.Drawing.Size(100, 13);
            this.noUserText.TabIndex = 3;
            this.noUserText.Text = "User does not exist!";
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.nextButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.SystemColors.Control;
            this.nextButton.Location = new System.Drawing.Point(200, 130);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(79, 27);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextbox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.invalidEmailAnswer);
            this.panel2.Controls.Add(this.emailTextbox);
            this.panel2.Controls.Add(this.answerTextbox);
            this.panel2.Controls.Add(this.emailHintText);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nextButton2);
            this.panel2.Location = new System.Drawing.Point(425, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 160);
            this.panel2.TabIndex = 2;
            // 
            // invalidEmailAnswer
            // 
            this.invalidEmailAnswer.AutoSize = true;
            this.invalidEmailAnswer.ForeColor = System.Drawing.Color.Red;
            this.invalidEmailAnswer.Location = new System.Drawing.Point(117, 112);
            this.invalidEmailAnswer.Name = "invalidEmailAnswer";
            this.invalidEmailAnswer.Size = new System.Drawing.Size(172, 13);
            this.invalidEmailAnswer.TabIndex = 6;
            this.invalidEmailAnswer.Text = "Security answer/email don\'t match!";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(120, 48);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(100, 20);
            this.emailTextbox.TabIndex = 0;
            // 
            // answerTextbox
            // 
            this.answerTextbox.Location = new System.Drawing.Point(120, 77);
            this.answerTextbox.Name = "answerTextbox";
            this.answerTextbox.Size = new System.Drawing.Size(100, 20);
            this.answerTextbox.TabIndex = 1;
            // 
            // emailHintText
            // 
            this.emailHintText.AutoSize = true;
            this.emailHintText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailHintText.Location = new System.Drawing.Point(28, 11);
            this.emailHintText.Name = "emailHintText";
            this.emailHintText.Size = new System.Drawing.Size(67, 13);
            this.emailHintText.TabIndex = 3;
            this.emailHintText.Text = "emailLabel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Please enter the above registered email below";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Security Answer";
            // 
            // nextButton2
            // 
            this.nextButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.nextButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.nextButton2.FlatAppearance.BorderSize = 0;
            this.nextButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.nextButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.nextButton2.Location = new System.Drawing.Point(200, 130);
            this.nextButton2.Name = "nextButton2";
            this.nextButton2.Size = new System.Drawing.Size(75, 23);
            this.nextButton2.TabIndex = 2;
            this.nextButton2.Text = "Next";
            this.nextButton2.UseVisualStyleBackColor = false;
            this.nextButton2.Click += new System.EventHandler(this.nextButton2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.invalidPass);
            this.panel3.Controls.Add(this.pass2);
            this.panel3.Controls.Add(this.pass1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.resetButton);
            this.panel3.Location = new System.Drawing.Point(425, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 160);
            this.panel3.TabIndex = 3;
            // 
            // invalidPass
            // 
            this.invalidPass.AutoSize = true;
            this.invalidPass.ForeColor = System.Drawing.Color.Red;
            this.invalidPass.Location = new System.Drawing.Point(84, 107);
            this.invalidPass.Name = "invalidPass";
            this.invalidPass.Size = new System.Drawing.Size(126, 13);
            this.invalidPass.TabIndex = 8;
            this.invalidPass.Text = "Passwords do not match!";
            // 
            // pass2
            // 
            this.pass2.Location = new System.Drawing.Point(120, 61);
            this.pass2.Name = "pass2";
            this.pass2.PasswordChar = '*';
            this.pass2.Size = new System.Drawing.Size(100, 20);
            this.pass2.TabIndex = 1;
            // 
            // pass1
            // 
            this.pass1.Location = new System.Drawing.Point(120, 24);
            this.pass1.Name = "pass1";
            this.pass1.PasswordChar = '*';
            this.pass1.Size = new System.Drawing.Size(100, 20);
            this.pass1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Confirm password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "New password";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.Control;
            this.resetButton.Location = new System.Drawing.Point(112, 130);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // passwordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(233)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(329, 213);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "passwordReset";
            this.Text = "passwordReset";
            this.Load += new System.EventHandler(this.passwordReset_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label noUserText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button nextButton2;
        private System.Windows.Forms.TextBox answerTextbox;
        private System.Windows.Forms.Label emailHintText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label invalidEmailAnswer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.TextBox pass1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label invalidPass;
    }
}