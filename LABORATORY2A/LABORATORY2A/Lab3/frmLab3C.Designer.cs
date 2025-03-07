
namespace LABORATORY2A.Lab3
{
    partial class frmLab3C
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
            this.lstShop = new System.Windows.Forms.ListBox();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddFruit = new System.Windows.Forms.Button();
            this.lblAddFruit = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstShop
            // 
            this.lstShop.FormattingEnabled = true;
            this.lstShop.Items.AddRange(new object[] {
            "Apple",
            "banana",
            "grape",
            "orange",
            "peach",
            "pear",
            "pineapple"});
            this.lstShop.Location = new System.Drawing.Point(118, 68);
            this.lstShop.Name = "lstShop";
            this.lstShop.Size = new System.Drawing.Size(120, 108);
            this.lstShop.TabIndex = 0;
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.Location = new System.Drawing.Point(401, 68);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(120, 95);
            this.lstCart.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnAddFruit
            // 
            this.btnAddFruit.Location = new System.Drawing.Point(163, 250);
            this.btnAddFruit.Name = "btnAddFruit";
            this.btnAddFruit.Size = new System.Drawing.Size(75, 23);
            this.btnAddFruit.TabIndex = 3;
            this.btnAddFruit.Text = "Add Fruit";
            this.btnAddFruit.UseVisualStyleBackColor = true;
            // 
            // lblAddFruit
            // 
            this.lblAddFruit.AutoSize = true;
            this.lblAddFruit.Location = new System.Drawing.Point(67, 211);
            this.lblAddFruit.Name = "lblAddFruit";
            this.lblAddFruit.Size = new System.Drawing.Size(49, 13);
            this.lblAddFruit.TabIndex = 4;
            this.lblAddFruit.Text = "Add Fruit";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(279, 78);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "-->";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(279, 140);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFromCart.TabIndex = 6;
            this.btnRemoveFromCart.Text = "<--";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(357, 313);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 7;
            this.btnCount.Text = "Count Shop + Cart";
            this.btnCount.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(467, 313);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // frmLab3C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblAddFruit);
            this.Controls.Add(this.btnAddFruit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.lstShop);
            this.Name = "frmLab3C";
            this.Text = "frmLab3C";
            this.Load += new System.EventHandler(this.frmLab3C_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstShop;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddFruit;
        private System.Windows.Forms.Label lblAddFruit;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnClear;
    }
}