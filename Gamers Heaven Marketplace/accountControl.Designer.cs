namespace Gamers_Heaven_Marketplace
{
    partial class accountControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.accDetails = new System.Windows.Forms.LinkLabel();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // accDetails
            // 
            this.accDetails.AutoSize = true;
            this.accDetails.Location = new System.Drawing.Point(59, 32);
            this.accDetails.Name = "accDetails";
            this.accDetails.Size = new System.Drawing.Size(82, 13);
            this.accDetails.TabIndex = 3;
            this.accDetails.TabStop = true;
            this.accDetails.Text = "Account Details";
            this.accDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.accDetails_LinkClicked);
            // 
            // profilePicture
            // 
            this.profilePicture.Image = global::Gamers_Heaven_Marketplace.Properties.Resources.profileImage;
            this.profilePicture.Location = new System.Drawing.Point(3, 3);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(50, 50);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(59, 11);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 16);
            this.name.TabIndex = 4;
            this.name.Text = "label1";
            // 
            // accountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.name);
            this.Controls.Add(this.accDetails);
            this.Controls.Add(this.profilePicture);
            this.Name = "accountControl";
            this.Size = new System.Drawing.Size(171, 58);
            this.Load += new System.EventHandler(this.accountControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.LinkLabel accDetails;
        private System.Windows.Forms.Label name;
    }
}
