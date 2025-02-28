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
    public partial class frmLab2C : Form
    {
        public frmLab2C()
        {
            InitializeComponent();
        }

        private void frmLab2C_Load(object sender, EventArgs e)
        {
            lstStudents.Items.Add("Mary Chu");
            lstStudents.Items.Add("Peter Lee");
            lstStudents.Items.Add("Johnson Chan");
            lstStudents.Items.Add("Alex Leung");

        }
        private void lstStudents_DoubleClick(object sender, EventArgs e)
        {
            lstStudents.Items.Remove(lstStudents.SelectedItem);
        }
    }
}
