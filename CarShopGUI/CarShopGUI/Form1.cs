﻿using CarClassLibrary;
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
            Car c = new Car(txtMake.Text, txtModel.Text, decimal.Parse(txtPrice.Text));
            myStore.CarList.Add(c);
            carInventoryBindingSource.ResetBindings(false);

            // Clear form fields.
            txtMake.Text = null;
            txtModel.Text = null;
            txtPrice.Text = null;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carInventoryBindingSource.DataSource = myStore.CarList;
            lstInventory.DataSource = carInventoryBindingSource;
            lstInventory.DisplayMember = ToString();
        }
    }
}
