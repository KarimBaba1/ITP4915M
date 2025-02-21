using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABORATORY2A.lab2
{
    public partial class frmLab2A : Form
    {
        private int price = 0;
        private String paymentMethod = "";
        public frmLab2A()
        {
            InitializeComponent();
            radioButton4.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            paymentMethod = "Visa";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            paymentMethod = "MasterCard";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            price = 250;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            price = 180;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            price = 75;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalprice = price* Convert.ToInt32 (textBox1.Text);
            label3.Text = $"Total Price: {totalprice} Payment Method: {paymentMethod}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
