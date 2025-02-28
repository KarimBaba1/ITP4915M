namespace LABORATORY2A.lab2
{
    partial class frmLab2B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLab2B));
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdoCloudy = new System.Windows.Forms.RadioButton();
            this.rdoRainy = new System.Windows.Forms.RadioButton();
            this.rdoSnowy = new System.Windows.Forms.RadioButton();
            this.rdoSunny = new System.Windows.Forms.RadioButton();
            this.picRainy = new System.Windows.Forms.PictureBox();
            this.picCloudy = new System.Windows.Forms.PictureBox();
            this.picSnowy = new System.Windows.Forms.PictureBox();
            this.picSunny = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRainy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloudy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnowy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSunny)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name here:";
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Location = new System.Drawing.Point(170, 303);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(357, 104);
            this.lblMessage.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(343, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 20);
            this.txtName.TabIndex = 2;
            // 
            // rdoCloudy
            // 
            this.rdoCloudy.AutoSize = true;
            this.rdoCloudy.Location = new System.Drawing.Point(17, 19);
            this.rdoCloudy.Name = "rdoCloudy";
            this.rdoCloudy.Size = new System.Drawing.Size(57, 17);
            this.rdoCloudy.TabIndex = 3;
            this.rdoCloudy.TabStop = true;
            this.rdoCloudy.Text = "Cloudy";
            this.rdoCloudy.UseVisualStyleBackColor = true;
            this.rdoCloudy.CheckedChanged += new System.EventHandler(this.rdoCloudy_CheckedChanged);
            // 
            // rdoRainy
            // 
            this.rdoRainy.AutoSize = true;
            this.rdoRainy.Location = new System.Drawing.Point(17, 39);
            this.rdoRainy.Name = "rdoRainy";
            this.rdoRainy.Size = new System.Drawing.Size(52, 17);
            this.rdoRainy.TabIndex = 4;
            this.rdoRainy.TabStop = true;
            this.rdoRainy.Text = "Rainy";
            this.rdoRainy.UseVisualStyleBackColor = true;
            this.rdoRainy.CheckedChanged += new System.EventHandler(this.rdoRainy_CheckedChanged);
            // 
            // rdoSnowy
            // 
            this.rdoSnowy.AutoSize = true;
            this.rdoSnowy.Location = new System.Drawing.Point(17, 62);
            this.rdoSnowy.Name = "rdoSnowy";
            this.rdoSnowy.Size = new System.Drawing.Size(57, 17);
            this.rdoSnowy.TabIndex = 5;
            this.rdoSnowy.TabStop = true;
            this.rdoSnowy.Text = "Snowy";
            this.rdoSnowy.UseVisualStyleBackColor = true;
            this.rdoSnowy.CheckedChanged += new System.EventHandler(this.rdoSnowy_CheckedChanged);
            // 
            // rdoSunny
            // 
            this.rdoSunny.AutoSize = true;
            this.rdoSunny.Location = new System.Drawing.Point(17, 85);
            this.rdoSunny.Name = "rdoSunny";
            this.rdoSunny.Size = new System.Drawing.Size(55, 17);
            this.rdoSunny.TabIndex = 6;
            this.rdoSunny.TabStop = true;
            this.rdoSunny.Text = "Sunny";
            this.rdoSunny.UseVisualStyleBackColor = true;
            this.rdoSunny.CheckedChanged += new System.EventHandler(this.rdoSunny_CheckedChanged);
            // 
            // picRainy
            // 
            this.picRainy.Image = ((System.Drawing.Image)(resources.GetObject("picRainy.Image")));
            this.picRainy.Location = new System.Drawing.Point(637, 135);
            this.picRainy.Name = "picRainy";
            this.picRainy.Size = new System.Drawing.Size(64, 64);
            this.picRainy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRainy.TabIndex = 7;
            this.picRainy.TabStop = false;
            // 
            // picCloudy
            // 
            this.picCloudy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCloudy.BackgroundImage")));
            this.picCloudy.Location = new System.Drawing.Point(542, 133);
            this.picCloudy.Name = "picCloudy";
            this.picCloudy.Size = new System.Drawing.Size(66, 66);
            this.picCloudy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCloudy.TabIndex = 8;
            this.picCloudy.TabStop = false;
            // 
            // picSnowy
            // 
            this.picSnowy.Image = ((System.Drawing.Image)(resources.GetObject("picSnowy.Image")));
            this.picSnowy.Location = new System.Drawing.Point(542, 208);
            this.picSnowy.Name = "picSnowy";
            this.picSnowy.Size = new System.Drawing.Size(64, 64);
            this.picSnowy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSnowy.TabIndex = 9;
            this.picSnowy.TabStop = false;
            // 
            // picSunny
            // 
            this.picSunny.Image = ((System.Drawing.Image)(resources.GetObject("picSunny.Image")));
            this.picSunny.Location = new System.Drawing.Point(637, 208);
            this.picSunny.Name = "picSunny";
            this.picSunny.Size = new System.Drawing.Size(64, 64);
            this.picSunny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSunny.TabIndex = 10;
            this.picSunny.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCloudy);
            this.groupBox1.Controls.Add(this.rdoRainy);
            this.groupBox1.Controls.Add(this.rdoSnowy);
            this.groupBox1.Controls.Add(this.rdoSunny);
            this.groupBox1.Location = new System.Drawing.Point(170, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 122);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // frmLab2B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picSunny);
            this.Controls.Add(this.picSnowy);
            this.Controls.Add(this.picCloudy);
            this.Controls.Add(this.picRainy);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label1);
            this.Name = "frmLab2B";
            this.Text = "frmLab2B";
            ((System.ComponentModel.ISupportInitialize)(this.picRainy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloudy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnowy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSunny)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rdoCloudy;
        private System.Windows.Forms.RadioButton rdoRainy;
        private System.Windows.Forms.RadioButton rdoSnowy;
        private System.Windows.Forms.RadioButton rdoSunny;
        private System.Windows.Forms.PictureBox picRainy;
        private System.Windows.Forms.PictureBox picCloudy;
        private System.Windows.Forms.PictureBox picSnowy;
        private System.Windows.Forms.PictureBox picSunny;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}