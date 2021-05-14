using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroMaker
{
    public partial class Form1 : Form
    {
        // Picture of hero.
        string pictureOfHero = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string heroName = txtName.Text;

            bool [] abilities = { false, false, false, false, false, false, false, false };

            abilities [0] = chkFly.Checked;
            abilities [1] = chkInvincible.Checked;
            abilities [2] = chkVanish.Checked;
            abilities [3] = chkLuck.Checked;
            abilities [4] = chkWater.Checked;
            abilities [5] = chkBlast.Checked;
            abilities [6] = chkSmash.Checked;
            abilities [7] = chkBreakLock.Checked;

            List<String> cities = new List<String>();

            // Add selected items to cities list.
            foreach (string s in lstCities.SelectedItems)
            {
                cities.Add(s);
            }

            // Preferred transport method.
            // Use single string since only one mode can be selected.
            string preferredTransport = "";

            if (rdoFly.Checked)
                preferredTransport = "Flying";
            if (rdoTeleport.Checked)
                preferredTransport = "Teleportation";
            if (rdoBatMobile.Checked)
                preferredTransport = "The Bat Mobile";
            if (rdoMinivan.Checked)
                preferredTransport = "Mom's minivan :/";



            int speed = scrollSpeed.Value;
            int stamina = scrollStamina.Value;
            int strength = scrollStrength.Value;
            int darkSidePropensity = trkDarkside.Value;

            if (speed + stamina + strength > 100)
            {
                MessageBox.Show("You cannot have more than 100 total points for speed, stamina, and strength");
            }

            // Dates.

            DateTime birthday = dateBirthday.Value;
            DateTime discovery = dateDiscovery.Value;
            DateTime fateful = dateFateful.Value;

            // Years experience
            int yearsOfExperience = Convert.ToInt32(numYearsExperience.Value);


            string statusMessage = $"Your new hero is {txtName.Text}. You have selected the following abilities: ";

            if (abilities [0])
                statusMessage += "Fly, ";
            if (abilities [1])
                statusMessage += "Invincibility, ";
            if (abilities [2])
                statusMessage += "Vanish, ";
            if (abilities [3])
                statusMessage += "Increased Luck, ";
            if (abilities [4])
                statusMessage += "Breathe under water, ";
            if (abilities [5])
                statusMessage += "Strong blast, ";
            if (abilities [6])
                statusMessage += "Super smash, ";
            if (abilities [7])
                statusMessage += "Break lock.";


            statusMessage += $"The hero works in these cities: ";

            foreach (string city in cities)
            {
                statusMessage += city + ", ";
            }

            statusMessage += $"\nThe hero's preferred travel method is {preferredTransport}";

            statusMessage += $"\nSpeed: {speed}, Strength: {strength}, Stamina: {stamina}";

            statusMessage += $"\nThe hero was born on: {birthday}, discovered their powers on {discovery}, and died on {fateful}";

            statusMessage += $"\nYears of experience: {yearsOfExperience} years.";

            statusMessage += $"\nThe hero's cape is {picCapeColor.BackColor.ToString()}";

            statusMessage += $"\nDark Side Propensity: {yearsOfExperience}.";

            statusMessage += $"\nThe picture of the hero is {pictureOfHero}";


            Hero hero = new Hero(heroName, abilities, cities, preferredTransport, speed, stamina, strength, birthday, discovery, fateful, yearsOfExperience, picCapeColor.BackColor.ToString(), darkSidePropensity, pictureOfHero);

            HeroList.hallOfFame.Add(hero);

            MessageBox.Show(statusMessage);

            MessageBox.Show("You have made " + HeroList.hallOfFame.Count() + " different heroes.");

            Form2 f2 = new Form2();
            f2.Show();
        }

        private void scrollSpeed_Scroll(object sender, ScrollEventArgs e)
        {
            lblSpeed.Text = scrollSpeed.Value.ToString();
        }

        private void scrollStamina_Scroll(object sender, ScrollEventArgs e)
        {
            lblStamina.Text = scrollStamina.Value.ToString();
        }

        private void scrollStrength_Scroll(object sender, ScrollEventArgs e)
        {
            lblStrength.Text = scrollStrength.Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            
            if(colorPicker.ShowDialog() == DialogResult.OK)
            {
                picCapeColor.BackColor = colorPicker.Color;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog portraitPicker = new OpenFileDialog();

            if(portraitPicker.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(portraitPicker.FileName);

                pictureOfHero = portraitPicker.FileName;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblDarkside.Text = trkDarkside.Value.ToString();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = this.Location;

            newForm.Show();
            this.Dispose(false);
        }
    }
}
