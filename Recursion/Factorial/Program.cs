using System;

namespace Factorial
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Please enter an integer. I will calculate a factorial.");
            long startingNumber = long.Parse(Console.ReadLine());
            Console.WriteLine(factorial(startingNumber));
            Console.ReadLine();
        }

        public static long factorial(long n)
        {
            Console.WriteLine("N = " + n);
            if (n == 1)
            {

                return 1;
            }
            else
            {
                Console.WriteLine($"Caculating the factorial for {n} * factorial ({n-1}).");
                return n * factorial(n - 1);
            }
        }
    }
}
