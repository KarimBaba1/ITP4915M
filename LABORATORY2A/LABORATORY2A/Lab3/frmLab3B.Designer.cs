
namespace LABORATORY2A.Lab3
{
    partial class frmLab3B
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblMillion = new System.Windows.Forms.Label();
            this.lblMillion2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(82, 25);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(82, 83);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(104, 13);
            this.lblRate.TabIndex = 1;
            this.lblRate.Text = "Interest Rate Annual";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(82, 173);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(103, 13);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Value after 10 Years";
            // 
            // lblValue2
            // 
            this.lblValue2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValue2.Location = new System.Drawing.Point(269, 172);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(172, 89);
            this.lblValue2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(269, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(145, 125);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(190, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Start Calculation";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblMillion
            // 
            this.lblMillion.AutoSize = true;
            this.lblMillion.Location = new System.Drawing.Point(82, 295);
            this.lblMillion.Name = "lblMillion";
            this.lblMillion.Size = new System.Drawing.Size(95, 13);
            this.lblMillion.TabIndex = 7;
            this.lblMillion.Text = "Year to reach $1M";
            // 
            // lblMillion2
            // 
            this.lblMillion2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMillion2.Location = new System.Drawing.Point(269, 294);
            this.lblMillion2.Name = "lblMillion2";
            this.lblMillion2.Size = new System.Drawing.Size(172, 89);
            this.lblMillion2.TabIndex = 8;
            // 
            // frmLab3B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMillion2);
            this.Controls.Add(this.lblMillion);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblAmount);
            this.Name = "frmLab3B";
            this.Text = "frmLab3B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblMillion;
        private System.Windows.Forms.Label lblMillion2;
    }
}