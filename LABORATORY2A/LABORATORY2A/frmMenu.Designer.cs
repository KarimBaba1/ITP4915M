
namespace LABORATORY2A
{
    partial class frmMenu
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
            this.cboLabs = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblLabs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboLabs
            // 
            this.cboLabs.FormattingEnabled = true;
            this.cboLabs.Location = new System.Drawing.Point(241, 184);
            this.cboLabs.Name = "cboLabs";
            this.cboLabs.Size = new System.Drawing.Size(121, 21);
            this.cboLabs.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(241, 276);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblLabs
            // 
            this.lblLabs.AutoSize = true;
            this.lblLabs.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabs.Location = new System.Drawing.Point(247, 107);
            this.lblLabs.Name = "lblLabs";
            this.lblLabs.Size = new System.Drawing.Size(109, 48);
            this.lblLabs.TabIndex = 2;
            this.lblLabs.Text = "SDP";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLabs);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cboLabs);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLabs;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblLabs;
    }
}