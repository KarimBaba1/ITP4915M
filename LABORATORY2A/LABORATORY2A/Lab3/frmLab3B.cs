using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABORATORY2A.Lab3
{
    public partial class frmLab3B : Form
    {
        public frmLab3B()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Retrieve user inputs
            if (double.TryParse(textBox1.Text, out double principal) &&
                double.TryParse(textBox2.Text, out double annualRate))
            {
                // Calculate compound interest for 10 years
                double rate = annualRate / 100;
                double amountAfter10Years = principal * Math.Pow(1 + rate, 10);
                lblValue2.Text = $"${amountAfter10Years:F2}";

                // Calculate the number of years to reach $1 million
                const double targetAmount = 1000000;
                int yearsToMillion = (int)Math.Ceiling(Math.Log(targetAmount / principal) / Math.Log(1 + rate));

                lblMillion2.Text = yearsToMillion.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numerical values for Amount and Interest Rate.");
            }
        }
    }
}