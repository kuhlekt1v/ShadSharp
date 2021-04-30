using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Hawk : Animal, IPredator
    {
        public Hawk(bool isAlive, int weight) : base(isAlive, weight)
        {
        }

        public void Hunt()
        {
            Console.WriteLine("Out looking for food");
        }

        public void Sing()
        {
            Console.WriteLine("Kawwwwww");
        }
    }
}
