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
    public partial class frmLab2B : Form
    {
        public frmLab2B()
        {
            InitializeComponent();
        }

        private void rdoCloudy_CheckedChanged(object sender, EventArgs e)
        {
            updateWeather(picCloudy, "cloudy");
        }

        private void rdoRainy_CheckedChanged(object sender, EventArgs e)
        {
            updateWeather(picRainy, "rainy");
        }

        private void rdoSnowy_CheckedChanged(object sender, EventArgs e)
        {
            updateWeather(picSnowy, "snowy");
        }

        private void rdoSunny_CheckedChanged(object sender, EventArgs e)
        {
            updateWeather(picSunny, "sunny");
        }
        private void updateWeather(PictureBox pb, string weather)
        {
            picCloudy.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            picSunny.Visible = false;
            pb.Visible = true;
            lblMessage.Text = $"It’s going to be a {weather} day today, {txtName.Text}";

        }
    }
}
