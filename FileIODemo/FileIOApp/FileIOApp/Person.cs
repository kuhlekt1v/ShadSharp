using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOApp
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

        static public List<Person> personList = new List<Person>();

    }
}
