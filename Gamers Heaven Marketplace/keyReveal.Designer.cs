namespace Gamers_Heaven_Marketplace
{
    partial class keyReveal
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
            this.revealButton = new System.Windows.Forms.Button();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.keyText = new System.Windows.Forms.Label();
            this.passMatch = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your password to reveal the key:";
            // 
            // revealButton
            // 
            this.revealButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.revealButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.revealButton.FlatAppearance.BorderSize = 0;
            this.revealButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.revealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revealButton.ForeColor = System.Drawing.SystemColors.Control;
            this.revealButton.Location = new System.Drawing.Point(159, 48);
            this.revealButton.Name = "revealButton";
            this.revealButton.Size = new System.Drawing.Size(75, 23);
            this.revealButton.TabIndex = 1;
            this.revealButton.Text = "Reveal";
            this.revealButton.UseVisualStyleBackColor = false;
            this.revealButton.Click += new System.EventHandler(this.revealButton_Click);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(234, 6);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(129, 20);
            this.passwordTextbox.TabIndex = 2;
            // 
            // keyText
            // 
            this.keyText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyText.Location = new System.Drawing.Point(37, 85);
            this.keyText.Name = "keyText";
            this.keyText.Size = new System.Drawing.Size(254, 20);
            this.keyText.TabIndex = 3;
            this.keyText.Text = "XXXX-XXXX-XXXX-XXXX-XXXX";
            // 
            // passMatch
            // 
            this.passMatch.AutoSize = true;
            this.passMatch.ForeColor = System.Drawing.Color.Red;
            this.passMatch.Location = new System.Drawing.Point(231, 28);
            this.passMatch.Name = "passMatch";
            this.passMatch.Size = new System.Drawing.Size(129, 13);
            this.passMatch.TabIndex = 4;
            this.passMatch.Text = "Password does not match";
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.copyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.copyButton.FlatAppearance.BorderSize = 0;
            this.copyButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.copyButton.Location = new System.Drawing.Point(300, 82);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(117, 23);
            this.copyButton.TabIndex = 5;
            this.copyButton.Text = "Copy to Clipboard";
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // keyReveal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(233)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(439, 121);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.passMatch);
            this.Controls.Add(this.keyText);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.revealButton);
            this.Controls.Add(this.label1);
            this.Name = "keyReveal";
            this.Text = "keyReveal";
            this.Load += new System.EventHandler(this.keyReveal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button revealButton;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label keyText;
        private System.Windows.Forms.Label passMatch;
        private System.Windows.Forms.Button copyButton;
    }
}