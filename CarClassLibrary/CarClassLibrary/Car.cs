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
        public int Miles { get; set; }

        public Car()
        {
            Make = "nothing yet";
            Model = "nothing yet";
            Price = 0.00M;
            IsNew = true;
            Miles = 0;

        }

        public Car(string a, string b, decimal c, bool d, int e)
        {
            Make = a;
            Model = b;
            Price = c;
            IsNew = d;
            Miles = e;
        }

        override public string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Price: ${Price}, New: {IsNew}, Odometer: {Miles}mi.";
        }
    }
}
