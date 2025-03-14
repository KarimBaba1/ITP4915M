
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
            lstShop = new System.Windows.Forms.ListBox();
            lstCart = new System.Windows.Forms.ListBox();
            addFruitTextBox = new System.Windows.Forms.TextBox();
            btnAddFruit = new System.Windows.Forms.Button();
            lblAddFruit = new System.Windows.Forms.Label();
            btnAddToCart = new System.Windows.Forms.Button();
            btnRemoveFromCart = new System.Windows.Forms.Button();
            btnCount = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            selectAll = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // lstShop
            // 
            lstShop.FormattingEnabled = true;
            lstShop.ItemHeight = 15;
            lstShop.Items.AddRange(new object[] { "Apple", "banana", "grape", "orange", "peach", "pear", "pineapple" });
            lstShop.Location = new System.Drawing.Point(137, 79);
            lstShop.Margin = new System.Windows.Forms.Padding(4);
            lstShop.Name = "lstShop";
            lstShop.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            lstShop.Size = new System.Drawing.Size(140, 124);
            lstShop.TabIndex = 0;
            // 
            // lstCart
            // 
            lstCart.FormattingEnabled = true;
            lstCart.ItemHeight = 15;
            lstCart.Location = new System.Drawing.Point(468, 79);
            lstCart.Margin = new System.Windows.Forms.Padding(4);
            lstCart.Name = "lstCart";
            lstCart.Size = new System.Drawing.Size(140, 109);
            lstCart.TabIndex = 1;
            // 
            // addFruitTextBox
            // 
            addFruitTextBox.Location = new System.Drawing.Point(161, 240);
            addFruitTextBox.Margin = new System.Windows.Forms.Padding(4);
            addFruitTextBox.Name = "addFruitTextBox";
            addFruitTextBox.Size = new System.Drawing.Size(116, 23);
            addFruitTextBox.TabIndex = 2;
            // 
            // btnAddFruit
            // 
            btnAddFruit.Location = new System.Drawing.Point(190, 289);
            btnAddFruit.Margin = new System.Windows.Forms.Padding(4);
            btnAddFruit.Name = "btnAddFruit";
            btnAddFruit.Size = new System.Drawing.Size(88, 26);
            btnAddFruit.TabIndex = 3;
            btnAddFruit.Text = "Add Fruit";
            btnAddFruit.UseVisualStyleBackColor = true;
            btnAddFruit.Click += btnAddFruit_Click;
            // 
            // lblAddFruit
            // 
            lblAddFruit.AutoSize = true;
            lblAddFruit.Location = new System.Drawing.Point(78, 244);
            lblAddFruit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAddFruit.Name = "lblAddFruit";
            lblAddFruit.Size = new System.Drawing.Size(56, 15);
            lblAddFruit.TabIndex = 4;
            lblAddFruit.Text = "Add Fruit";
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new System.Drawing.Point(326, 90);
            btnAddToCart.Margin = new System.Windows.Forms.Padding(4);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new System.Drawing.Size(88, 26);
            btnAddToCart.TabIndex = 5;
            btnAddToCart.Text = "-->";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Location = new System.Drawing.Point(326, 161);
            btnRemoveFromCart.Margin = new System.Windows.Forms.Padding(4);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new System.Drawing.Size(88, 26);
            btnRemoveFromCart.TabIndex = 6;
            btnRemoveFromCart.Text = "<--";
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            // 
            // btnCount
            // 
            btnCount.Location = new System.Drawing.Point(392, 361);
            btnCount.Margin = new System.Windows.Forms.Padding(4);
            btnCount.Name = "btnCount";
            btnCount.Size = new System.Drawing.Size(122, 26);
            btnCount.TabIndex = 7;
            btnCount.Text = "Count Shop + Cart";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(545, 361);
            btnClear.Margin = new System.Windows.Forms.Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(88, 26);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear Data";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // selectAll
            // 
            selectAll.AutoSize = true;
            selectAll.Location = new System.Drawing.Point(137, 53);
            selectAll.Name = "selectAll";
            selectAll.Size = new System.Drawing.Size(74, 19);
            selectAll.TabIndex = 9;
            selectAll.Text = "Select All";
            selectAll.UseVisualStyleBackColor = true;
            selectAll.CheckedChanged += selectAll_CheckedChanged;
            // 
            // frmLab3C
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(934, 519);
            Controls.Add(selectAll);
            Controls.Add(btnClear);
            Controls.Add(btnCount);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(btnAddToCart);
            Controls.Add(lblAddFruit);
            Controls.Add(btnAddFruit);
            Controls.Add(addFruitTextBox);
            Controls.Add(lstCart);
            Controls.Add(lstShop);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "frmLab3C";
            Text = "frmLab3C";
            Load += frmLab3C_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.CheckBox selectAll;
    }
}