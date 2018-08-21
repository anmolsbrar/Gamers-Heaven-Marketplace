namespace Gamers_Heaven_Marketplace
{
    partial class productControl
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
            this.productName = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.cartButton = new System.Windows.Forms.Button();
            this.descriptionText = new System.Windows.Forms.Label();
            this.prodImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.prodImage)).BeginInit();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(61, 4);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(114, 24);
            this.productName.TabIndex = 1;
            this.productName.Text = "prodName";
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(146)))));
            this.productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice.ForeColor = System.Drawing.Color.IndianRed;
            this.productPrice.Location = new System.Drawing.Point(501, 4);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(92, 24);
            this.productPrice.TabIndex = 2;
            this.productPrice.Text = "prodPrice";
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.buyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.buyButton.FlatAppearance.BorderSize = 0;
            this.buyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.buyButton.Location = new System.Drawing.Point(561, 43);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(41, 21);
            this.buyButton.TabIndex = 4;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // cartButton
            // 
            this.cartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.cartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.cartButton.FlatAppearance.BorderSize = 0;
            this.cartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.cartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cartButton.Location = new System.Drawing.Point(435, 43);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(105, 21);
            this.cartButton.TabIndex = 5;
            this.cartButton.Text = "Add to Favorite";
            this.cartButton.UseVisualStyleBackColor = false;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(65, 33);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(376, 37);
            this.descriptionText.TabIndex = 7;
            this.descriptionText.Text = "label2";
            // 
            // prodImage
            // 
            this.prodImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prodImage.Location = new System.Drawing.Point(3, 3);
            this.prodImage.Name = "prodImage";
            this.prodImage.Size = new System.Drawing.Size(55, 73);
            this.prodImage.TabIndex = 3;
            this.prodImage.TabStop = false;
            // 
            // productControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(146)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.prodImage);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "productControl";
            this.Size = new System.Drawing.Size(634, 80);
            this.Load += new System.EventHandler(this.productControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.PictureBox prodImage;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Label descriptionText;
    }
}
