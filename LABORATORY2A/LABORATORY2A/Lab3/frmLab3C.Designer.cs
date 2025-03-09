
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
            this.addFruitTextBox = new System.Windows.Forms.TextBox();
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
            this.lstShop.ItemHeight = 16;
            this.lstShop.Items.AddRange(new object[] {
            "Apple",
            "banana",
            "grape",
            "orange",
            "peach",
            "pear",
            "pineapple"});
            this.lstShop.Location = new System.Drawing.Point(157, 84);
            this.lstShop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstShop.Name = "lstShop";
            this.lstShop.Size = new System.Drawing.Size(159, 132);
            this.lstShop.TabIndex = 0;
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 16;
            this.lstCart.Location = new System.Drawing.Point(535, 84);
            this.lstCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(159, 116);
            this.lstCart.TabIndex = 1;
            // 
            // addFruitTextBox
            // 
            this.addFruitTextBox.Location = new System.Drawing.Point(184, 256);
            this.addFruitTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addFruitTextBox.Name = "addFruitTextBox";
            this.addFruitTextBox.Size = new System.Drawing.Size(132, 22);
            this.addFruitTextBox.TabIndex = 2;
            // 
            // btnAddFruit
            // 
            this.btnAddFruit.Location = new System.Drawing.Point(217, 308);
            this.btnAddFruit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddFruit.Name = "btnAddFruit";
            this.btnAddFruit.Size = new System.Drawing.Size(100, 28);
            this.btnAddFruit.TabIndex = 3;
            this.btnAddFruit.Text = "Add Fruit";
            this.btnAddFruit.UseVisualStyleBackColor = true;
            this.btnAddFruit.Click += new System.EventHandler(this.btnAddFruit_Click);
            // 
            // lblAddFruit
            // 
            this.lblAddFruit.AutoSize = true;
            this.lblAddFruit.Location = new System.Drawing.Point(89, 260);
            this.lblAddFruit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddFruit.Name = "lblAddFruit";
            this.lblAddFruit.Size = new System.Drawing.Size(60, 16);
            this.lblAddFruit.TabIndex = 4;
            this.lblAddFruit.Text = "Add Fruit";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(372, 96);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(100, 28);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "-->";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(372, 172);
            this.btnRemoveFromCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(100, 28);
            this.btnRemoveFromCart.TabIndex = 6;
            this.btnRemoveFromCart.Text = "<--";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(448, 385);
            this.btnCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(139, 28);
            this.btnCount.TabIndex = 7;
            this.btnCount.Text = "Count Shop + Cart";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(623, 385);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmLab3C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblAddFruit);
            this.Controls.Add(this.btnAddFruit);
            this.Controls.Add(this.addFruitTextBox);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.lstShop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLab3C";
            this.Text = "frmLab3C";
            this.Load += new System.EventHandler(this.frmLab3C_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstShop;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.TextBox addFruitTextBox;
        private System.Windows.Forms.Button btnAddFruit;
        private System.Windows.Forms.Label lblAddFruit;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnClear;
    }
}