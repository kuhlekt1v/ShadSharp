using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    class Person
    {
        public Person(string firstName, string lastName, string uRL)
        {
            FirstName = firstName;
            LastName = lastName;
            URL = uRL;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string URL { get; set; }

        public override string ToString()
        {
            return "First Name: " + FirstName + " Last Name: " + LastName + " URL: " + URL;
        }

    }
}
