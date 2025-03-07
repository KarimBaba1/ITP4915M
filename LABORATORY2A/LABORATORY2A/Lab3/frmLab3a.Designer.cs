
namespace LABORATORY2A.Lab3
{
    partial class frmLab3a
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
            this.cboMovie = new System.Windows.Forms.ComboBox();
            this.lblCast = new System.Windows.Forms.Label();
            this.btnCast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboMovie
            // 
            this.cboMovie.FormattingEnabled = true;
            this.cboMovie.Items.AddRange(new object[] {
            "The Godfather",
            "Terminator",
            "Back To The Future",
            "Matrix"});
            this.cboMovie.Location = new System.Drawing.Point(120, 108);
            this.cboMovie.Name = "cboMovie";
            this.cboMovie.Size = new System.Drawing.Size(121, 21);
            this.cboMovie.TabIndex = 0;
            // 
            // lblCast
            // 
            this.lblCast.AutoSize = true;
            this.lblCast.Location = new System.Drawing.Point(117, 67);
            this.lblCast.Name = "lblCast";
            this.lblCast.Size = new System.Drawing.Size(163, 13);
            this.lblCast.TabIndex = 1;
            this.lblCast.Text = "My Choicec of Best Movie Series";
            // 
            // btnCast
            // 
            this.btnCast.Location = new System.Drawing.Point(138, 193);
            this.btnCast.Name = "btnCast";
            this.btnCast.Size = new System.Drawing.Size(75, 23);
            this.btnCast.TabIndex = 2;
            this.btnCast.Text = "Cast Your Vote";
            this.btnCast.UseVisualStyleBackColor = true;
            this.btnCast.Click += new System.EventHandler(this.btnCast_Click);
            // 
            // frmLab3a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCast);
            this.Controls.Add(this.lblCast);
            this.Controls.Add(this.cboMovie);
            this.Name = "frmLab3a";
            this.Text = "frmLab3a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMovie;
        private System.Windows.Forms.Label lblCast;
        private System.Windows.Forms.Button btnCast;
    }
}