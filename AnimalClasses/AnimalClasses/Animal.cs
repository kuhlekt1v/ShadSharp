using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    abstract class Animal
    {
        bool isAlive { get; set; }
        int weight { get; set; }


        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }

        public Animal(bool isAlive, int weight)
        {
            this.isAlive = isAlive;
            this.weight = weight;
            Console.WriteLine("Animal Constructor");
        }

        public void Greet()
        {
            Console.WriteLine("Animal says hello");
        }

        public void Talk()
        {
            Console.WriteLine("Animal is talking");
        }

        public void Sing()
        {
            Console.WriteLine("Animal is singing");
        }

        public override string ToString()
        {
            return $"Status: {isAlive}, Weight: {weight}";
        }
    }
}
