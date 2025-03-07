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
    public partial class frmLab3a : Form
    {
        public frmLab3a()
        {
            InitializeComponent();
        }

        private void btnCast_Click(object sender, EventArgs e)
        {
            if (cboMovie.SelectedItem == null)
            {
                MessageBox.Show("Please select a movie");
                return;
            }

            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                // do something
                MessageBox.Show($"You voted for:\n{cboMovie.SelectedItem.ToString()}");
            }
            else if (dialogResult == DialogResult.No)
            {
                // do something else
                MessageBox.Show("Cancel Voting");
            }
        }
    }
    }


