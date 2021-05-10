using System;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter 2 numbers. I will calculate the greatest common divisor.");
            Console.WriteLine("First integer: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Second integer: ");
            int number2 = int.Parse(Console.ReadLine());

            int answer = gcd(number1, number2);
            Console.WriteLine("The GCD of {0} and {1} is {2}", number1, number2, answer);
            Console.ReadLine();
        }

        static int gcd(int n1, int n2)
        {
            if(n2 == 0)
            {
                return n1;
            }
            else
            {
                Console.WriteLine("Not yet. {0} / {1} has a remainder of {2}", n1, n2, n1 % n2);
                return gcd(n2, n1 % n2);
            }
        }
    }
}
