using CarClassLibrary;
using System;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store myStore = new Store();
        BindingSource cartBindingSource = new BindingSource();
        BindingSource carInventoryBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            bool isNew;

            if (radioNew.Checked == true)
                isNew = true;
            else
                isNew = false;
            

            if (!string.IsNullOrWhiteSpace(txtMake.Text) && !string.IsNullOrWhiteSpace(txtModel.Text) && !string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                Car c = new Car(txtMake.Text, txtModel.Text, decimal.Parse(txtPrice.Text), isNew);
                myStore.CarList.Add(c);
                carInventoryBindingSource.ResetBindings(false);

                // Reset form fields.
                txtMake.Text = null;
                txtModel.Text = null;
                txtPrice.Text = null;
                radioNew.Checked = true;
            }
            else
            {
                MessageBox.Show("Please complete all fields");
            }
                

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (myStore.CarList.Count < 1)
            {
                MessageBox.Show("There are no cars in your inventory");
            }
            else
            {
                // Get selected item from inventory.
                Car selectedCar = (Car)lstInventory.SelectedItem;
                myStore.ShoppingList.Add(selectedCar);

                // Update shopping list.
                cartBindingSource.ResetBindings(false);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            decimal total = myStore.Checkout();
            lblTotal.Text = "$" + total;

            cartBindingSource.ResetBindings(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize car inventory data source.
            carInventoryBindingSource.DataSource = myStore.CarList;
            lstInventory.DataSource = carInventoryBindingSource;
            lstInventory.DisplayMember = ToString();

            // Initialize shopping cart data source.
            cartBindingSource.DataSource = myStore.ShoppingList;
            lstCart.DataSource = cartBindingSource;
            lstCart.DisplayMember = ToString();

            radioNew.Checked = true;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPrice.Text = txtPrice.Text.Remove(txtPrice.Text.Length - 1);
            }
        }

        private void btnClearInventory_Click(object sender, EventArgs e)
        {
            myStore.CarList.Clear();
            carInventoryBindingSource.ResetBindings(false);
        }
    }
}
