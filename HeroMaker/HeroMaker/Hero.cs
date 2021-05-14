using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMaker
{
    public class Hero : IComparable
    {
        public Hero(string name, bool [] specialAbilities, List<string> officeLocations, string preferredTransportation, int speed, int stamina, int strength, DateTime birthday, DateTime superPowerDiscoveryDate, DateTime fatefulDay, int yearsExperience, string capeColor, int darkSidePropensity, string portraitPhoto)
        {
            Name = name;
            SpecialAbilities = specialAbilities;
            OfficeLocations = officeLocations;
            PreferredTransportation = preferredTransportation;
            Speed = speed;
            Stamina = stamina;
            Strength = strength;
            Birthday = birthday;
            SuperPowerDiscoveryDate = superPowerDiscoveryDate;
            FatefulDay = fatefulDay;
            YearsExperience = yearsExperience;
            CapeColor = capeColor;
            DarkSidePropensity = darkSidePropensity;
            PortraitPhoto = portraitPhoto;
        }

        public string Name { get; set; }
        public bool[] SpecialAbilities { get; set; }
        public List<string> OfficeLocations { get; set; }
        public string PreferredTransportation { get; set; }
        public int Speed { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime SuperPowerDiscoveryDate { get; set; }
        public DateTime FatefulDay { get; set; }
        public int YearsExperience { get; set; }
        public string CapeColor { get; set; }
        public int DarkSidePropensity { get; set; }
        public string PortraitPhoto { get; set; }

        public int CompareTo(object obj)
        {
            Hero other = (Hero) obj;
            return Name.CompareTo(other.Name);
        }
    }
}
