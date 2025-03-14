using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LABORATORY2A.Lab1;
using LABORATORY2A.lab2;
using LABORATORY2A.Lab3;
using LABORATORY2A.Lab4;
namespace LABORATORY2A
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            cboLabs.Items.Add("Lab1");
            cboLabs.Items.Add("Lab2A");
            cboLabs.Items.Add("Lab2B");
            cboLabs.Items.Add("Lab2C");
            cboLabs.Items.Add("Lab3A");
            cboLabs.Items.Add("Lab3B");
            cboLabs.Items.Add("Lab3C");
            cboLabs.Items.Add("Lab4");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            switch(cboLabs.SelectedItem.ToString())
            {
                case "Lab1":
                    frmLab01 lab1 = new frmLab01();
                    lab1.Show();
                    break;
                case "Lab2A":
                    frmLab2A lab2A = new frmLab2A();
                    lab2A.Show();
                    break;
                case "Lab2B":
                    frmLab2B lab2B = new frmLab2B();
                    lab2B.Show();
                    break;
                case "Lab2C":
                    frmLab2C lab2C = new frmLab2C();
                    lab2C.Show();
                    break;
                case "Lab3A":
                    frmLab3a Lab3a = new frmLab3a();
                    Lab3a.Show();
                    break;
                case "Lab3B":
                    frmLab3B Lab3B = new frmLab3B();
                    Lab3B.Show();
                    break;
                case "Lab3C":
                    frmLab3C Lab3C = new frmLab3C();
                    Lab3C.Show();
                    break;
                case "Lab4":
                    frmLab4 Lab4 = new frmLab4();
                    Lab4.Show();
                    break;
            }
                }
    }
}
