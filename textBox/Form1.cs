namespace textBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtNum1.Text) + 
                Convert.ToInt32(txtNum2.Text);
            txtNum3.Text = Convert.ToString(x);
        }
    }
}
