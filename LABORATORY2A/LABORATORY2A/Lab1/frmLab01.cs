﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABORATORY2A.Lab1
{
    public partial class frmLab01: Form
    {
        public frmLab01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textNum1.Text, out int num1) && int.TryParse(textNum2.Text, out int num2)){
                textNum3.Text =( num1 + num2).ToString();

            }
            else
            {
                MessageBox.Show("Please Enter A Number");
            }
            //int x = Convert.ToInt32(textBox1.Text) +
            //    Convert.ToInt32(textBox2.Text);
            //textBox3.Text = Convert.ToString(x);

        }
    }
}
