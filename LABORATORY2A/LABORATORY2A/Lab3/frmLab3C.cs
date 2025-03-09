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
    public partial class frmLab3C : Form
    {
        public frmLab3C()
        {
            InitializeComponent();
        }

        private void frmLab3C_Load(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            String cart = lstShop.SelectedItem.ToString();
            lstCart.Items.Add(cart);
            lstShop.Items.Remove(cart);
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            String cart = lstCart.SelectedItem.ToString();
            lstShop.Items.Add(cart);
            lstCart.Items.Remove(cart);
        }

        private void btnAddFruit_Click(object sender, EventArgs e)
        {
            String fruit = addFruitTextBox.Text;
            lstShop.Items.Add(fruit);
            addFruitTextBox.Clear();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int shopCount = lstShop.Items.Count;
            int cartCount = lstCart.Items.Count;
            int totalCount = shopCount + cartCount;

            MessageBox.Show($"Total items in shop and cart is {totalCount}\nshop: {shopCount}\ncart: {cartCount}");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            String[] fruits = new String[lstCart.Items.Count];
            lstCart.Items.CopyTo(fruits, 0);
            foreach(String fruit in fruits)
            {
                lstShop.Items.Add(fruit);

            }

            lstCart.Items.Clear();
            }
        }
 
           
        
            
    }

