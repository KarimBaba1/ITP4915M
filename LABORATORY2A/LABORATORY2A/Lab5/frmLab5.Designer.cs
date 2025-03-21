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
            ((System.ComponentModel.ISupportInitialize)dgvCustomerDetails).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerDetails
            // 
            lblCustomerDetails.AutoSize = true;
            lblCustomerDetails.Font = new System.Drawing.Font("Segoe UI Symbol", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblCustomerDetails.Location = new System.Drawing.Point(13, 9);
            lblCustomerDetails.Name = "lblCustomerDetails";
            lblCustomerDetails.Size = new System.Drawing.Size(775, 128);
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
            // frmLab5
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
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
    }
}