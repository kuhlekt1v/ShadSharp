using System;

namespace AnimalClasses
{
    class Program
    {
        static void Main(string [] args)
        {
            Dog fido = new Dog(false, 25);
            fido.Greet();
            fido.Talk();
            fido.Sing();
            fido.Fetch("stick");

            fido.FeedMe();
            fido.TouchMe();
            Console.WriteLine(fido.ToString());


            Robin red = new Robin();
            red.Talk();
            red.Sing();

            Console.WriteLine("------- Challenge after this line -------");
            Console.ReadLine();

            Hawk hawk = new Hawk(true, 15);
            hawk.Talk();
            hawk.Sing();
            hawk.Hunt();
            Console.WriteLine(hawk.ToString());

        }
    }
}
