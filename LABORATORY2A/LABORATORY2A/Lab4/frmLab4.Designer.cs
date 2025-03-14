namespace LABORATORY2A.Lab4
{
    partial class frmLab4
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
            httpGet = new System.Windows.Forms.Button();
            lblResult = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // httpGet
            // 
            httpGet.Location = new System.Drawing.Point(117, 170);
            httpGet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            httpGet.Name = "httpGet";
            httpGet.Size = new System.Drawing.Size(453, 27);
            httpGet.TabIndex = 0;
            httpGet.Text = "HTTP GET";
            httpGet.UseVisualStyleBackColor = true;
            httpGet.Click += httpGet_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblResult.Location = new System.Drawing.Point(117, 210);
            lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(453, 212);
            lblResult.TabIndex = 1;
            // 
            // frmLab4
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(lblResult);
            Controls.Add(httpGet);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmLab4";
            Text = "frmLab4";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button httpGet;
        private System.Windows.Forms.Label lblResult;
    }
}