using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileIOApp
{
    public partial class Form1 : Form
    {
        BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            // Bind person list to listBox1.
            bs.DataSource = Person.personList;
            listBox1.DataSource = bs;
            listBox1.DisplayMember = "PersonDisplay";
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            // Add new person to list.
            Person person = new Person(txtFirstName.Text, txtLastName.Text, txtURL.Text);
            Person.personList.Add(person);

            // Bind people list to 

            bs.ResetBindings(false);

            // Reset form.
            ClearForm();
        }

        private void ClearForm()
        {
            // Clear text inputs.
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtURL.Text = "";

            // Focus on first field.
            txtFirstName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Add items from person list to outContents.
            List<string> outContents = new List<string>();

            foreach(Person p in Person.personList)
            {
                outContents.Add($"{p.FirstName},{p.LastName},{p.URL}");
            }

            // Display save file dialog and save outContents to file.
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outFile = saveFileDialog.FileName;
                File.WriteAllLines(outFile, outContents);
            }
        }

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            // Display open file dialog.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Text File";
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();

                // Parse input file for display in listBox1.
                foreach (string line in lines)
                {
                    string [] items = line.Split(',');
                    Person p = new Person(items [0], items [1], items [2]);

                    Person.personList.Add(p);
                }
            }

            bs.ResetBindings(false);
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            // Delete selected item from list.
            Person.personList.Remove((Person)listBox1.SelectedItem);
            bs.ResetBindings(false);
        }
    }
}
