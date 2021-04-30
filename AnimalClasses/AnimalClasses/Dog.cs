using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Dog : Animal, IDomesticated
    {
        public Dog(bool isAlive, int weight) : base(isAlive, weight)
        {
        }

        public void Talk()
        {
            Console.WriteLine("Bark bark bark!");
        }

        public void Sing()
        {
            Console.WriteLine("OWWWWWWWWWwwwwwwwwoooo");
        }

        public void Fetch(string thing)
        {
            Console.WriteLine("Here you go. Here is your " + thing + ". Let's do it again!");
        }

        public void TouchMe()
        {
            Console.WriteLine("Please scratch behind my ears.");
        }

        public void FeedMe()
        {
            Console.WriteLine("Woof. Feed me woof.");
        }
    }
}
