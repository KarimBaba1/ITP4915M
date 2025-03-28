namespace LABORATORY2A.Lab5
{
    partial class frmLab5
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
            lblCustomerDetails = new System.Windows.Forms.Label();
            dgvCustomerDetails = new System.Windows.Forms.DataGridView();
            txt_Customer_Name = new System.Windows.Forms.TextBox();
            btn_search = new System.Windows.Forms.Button();
            lbl_customerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerDetails).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerDetails
            // 
            lblCustomerDetails.AutoSize = true;
            lblCustomerDetails.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblCustomerDetails.Location = new System.Drawing.Point(12, 9);
            lblCustomerDetails.Name = "lblCustomerDetails";
            lblCustomerDetails.Size = new System.Drawing.Size(155, 25);
            lblCustomerDetails.TabIndex = 0;
            lblCustomerDetails.Text = "Customer Details";
            // 
            // dgvCustomerDetails
            // 
            dgvCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerDetails.Location = new System.Drawing.Point(81, 140);
            dgvCustomerDetails.Name = "dgvCustomerDetails";
            dgvCustomerDetails.Size = new System.Drawing.Size(559, 185);
            dgvCustomerDetails.TabIndex = 1;
            // 
            // txt_Customer_Name
            // 
            txt_Customer_Name.Location = new System.Drawing.Point(169, 65);
            txt_Customer_Name.Name = "txt_Customer_Name";
            txt_Customer_Name.Size = new System.Drawing.Size(206, 23);
            txt_Customer_Name.TabIndex = 2;
            txt_Customer_Name.TextChanged += txt_Customer_Name_TextChanged;
            // 
            // btn_search
            // 
            btn_search.Location = new System.Drawing.Point(442, 60);
            btn_search.Name = "btn_search";
            btn_search.Size = new System.Drawing.Size(75, 23);
            btn_search.TabIndex = 3;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // lbl_customerName
            // 
            lbl_customerName.AutoSize = true;
            lbl_customerName.Location = new System.Drawing.Point(39, 68);
            lbl_customerName.Name = "lbl_customerName";
            lbl_customerName.Size = new System.Drawing.Size(94, 15);
            lbl_customerName.TabIndex = 4;
            lbl_customerName.Text = "Customer Name";
            // 
            // frmLab5
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lbl_customerName);
            Controls.Add(btn_search);
            Controls.Add(txt_Customer_Name);
            Controls.Add(dgvCustomerDetails);
            Controls.Add(lblCustomerDetails);
            Name = "frmLab5";
            Text = "frmLab5";
            Load += frmLab5_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCustomerDetails;
        private System.Windows.Forms.DataGridView dgvCustomerDetails;
        private System.Windows.Forms.TextBox txt_Customer_Name;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_customerName;
    }
}