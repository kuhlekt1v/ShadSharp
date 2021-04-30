using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public bool IsNew { get; set; }


        public Car()
        {
            Make = "nothing yet";
            Model = "nothing yet";
            Price = 0.00M;
            IsNew = true;

        }

        public Car(string a, string b, decimal c, bool d)
        {
            Make = a;
            Model = b;
            Price = c;
            IsNew = d;
        }

        override public string ToString()
        {
            if (IsNew)
                return $"{Make} - {Model} | Price: ${Price} (NEW)";
            else
                return $"{Make} - {Model} | Price: ${Price} (Used)";
        }
    }
}
