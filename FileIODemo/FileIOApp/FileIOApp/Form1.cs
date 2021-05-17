using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIOApp
{
    public partial class Form1 : Form
    {
        BindingSource bs = new BindingSource();

        public Form1()
        {

            InitializeComponent();

        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {

            // Add new person to list.
            Person person = new Person(txtFirstName.Text, txtLastName.Text, txtURL.Text);
            Person.personList.Add(person);

            // Bind people list to 
            bs.DataSource = Person.personList;
            listBox1.DataSource = bs;
            listBox1.DisplayMember = "FirstName";
            bs.ResetBindings(false);
        }
    }
}
