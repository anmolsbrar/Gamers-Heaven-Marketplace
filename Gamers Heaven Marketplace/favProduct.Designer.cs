namespace Gamers_Heaven_Marketplace
{
    partial class favProduct
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
            this.prodImg = new System.Windows.Forms.PictureBox();
            this.prodTitle = new System.Windows.Forms.Label();
            this.prodPrice = new System.Windows.Forms.Label();
            this.removeFromCart = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.desc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).BeginInit();
            this.SuspendLayout();
            // 
            // prodImg
            // 
            this.prodImg.Location = new System.Drawing.Point(5, 5);
            this.prodImg.Name = "prodImg";
            this.prodImg.Size = new System.Drawing.Size(52, 65);
            this.prodImg.TabIndex = 0;
            this.prodImg.TabStop = false;
            // 
            // prodTitle
            // 
            this.prodTitle.AutoSize = true;
            this.prodTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodTitle.Location = new System.Drawing.Point(68, 8);
            this.prodTitle.Name = "prodTitle";
            this.prodTitle.Size = new System.Drawing.Size(42, 24);
            this.prodTitle.TabIndex = 1;
            this.prodTitle.Text = "title";
            // 
            // prodPrice
            // 
            this.prodPrice.AutoSize = true;
            this.prodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodPrice.ForeColor = System.Drawing.Color.IndianRed;
            this.prodPrice.Location = new System.Drawing.Point(396, 8);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(45, 18);
            this.prodPrice.TabIndex = 2;
            this.prodPrice.Text = "price";
            // 
            // removeFromCart
            // 
            this.removeFromCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.removeFromCart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.removeFromCart.FlatAppearance.BorderSize = 0;
            this.removeFromCart.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.removeFromCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeFromCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFromCart.ForeColor = System.Drawing.SystemColors.Control;
            this.removeFromCart.Location = new System.Drawing.Point(546, 8);
            this.removeFromCart.Name = "removeFromCart";
            this.removeFromCart.Size = new System.Drawing.Size(68, 23);
            this.removeFromCart.TabIndex = 3;
            this.removeFromCart.Text = "Remove";
            this.removeFromCart.UseVisualStyleBackColor = false;
            this.removeFromCart.Click += new System.EventHandler(this.removeFromCart_Click);
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.buyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.buyButton.FlatAppearance.BorderSize = 0;
            this.buyButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(35)))));
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.buyButton.Location = new System.Drawing.Point(467, 8);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(57, 23);
            this.buyButton.TabIndex = 4;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(69, 34);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(507, 37);
            this.desc.TabIndex = 5;
            this.desc.Text = "label1";
            // 
            // favProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(224)))), ((int)(((byte)(146)))));
            this.Controls.Add(this.desc);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.removeFromCart);
            this.Controls.Add(this.prodPrice);
            this.Controls.Add(this.prodTitle);
            this.Controls.Add(this.prodImg);
            this.Name = "favProduct";
            this.Size = new System.Drawing.Size(640, 75);
            this.Load += new System.EventHandler(this.cartProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox prodImg;
        private System.Windows.Forms.Label prodTitle;
        private System.Windows.Forms.Label prodPrice;
        private System.Windows.Forms.Button removeFromCart;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label desc;
    }
}
