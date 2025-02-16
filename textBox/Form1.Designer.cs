namespace textBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            txtNum3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtNum2
            // 
            txtNum2.BackColor = SystemColors.Info;
            txtNum2.Font = new Font("Times New Roman", 14F);
            txtNum2.Location = new Point(453, 62);
            txtNum2.Margin = new Padding(5, 4, 5, 4);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(216, 34);
            txtNum2.TabIndex = 1;
            // 
            // txtNum1
            // 
            txtNum1.BackColor = SystemColors.Info;
            txtNum1.Font = new Font("Times New Roman", 14F);
            txtNum1.Location = new Point(52, 62);
            txtNum1.Margin = new Padding(5, 4, 5, 4);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(216, 34);
            txtNum1.TabIndex = 2;
            // 
            // txtNum3
            // 
            txtNum3.BackColor = SystemColors.Info;
            txtNum3.Font = new Font("Times New Roman", 14F);
            txtNum3.Location = new Point(268, 290);
            txtNum3.Margin = new Padding(5, 4, 5, 4);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(216, 34);
            txtNum3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 238);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 33);
            label1.TabIndex = 4;
            label1.Text = "Sum";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 27);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 33);
            label2.TabIndex = 5;
            label2.Text = "Num 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 27);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 33);
            label3.TabIndex = 6;
            label3.Text = "Num 1";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F);
            button1.Location = new Point(297, 150);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1400, 697);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNum3);
            Controls.Add(txtNum1);
            Controls.Add(txtNum2);
            Font = new Font("Comic Sans MS", 14F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNum2;
        private TextBox txtNum1;
        private TextBox txtNum3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
