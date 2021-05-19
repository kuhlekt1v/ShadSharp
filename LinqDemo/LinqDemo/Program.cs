using System;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string [] args)
        {
            int [] scores = { 50, 66, 77, 80, 90, 81, 45, 0, 100, 54, 32, 95, 97, 34, 88, 76, 82, 63, 58, 86 };

            foreach (var item in scores)
            {
                Console.WriteLine("One of the scores was {0}", item);
            }

            // Pause to see output.
            Console.ReadLine();

            // Print only scores above 90.
            var theBestStudents =
                from item in scores
                where item > 90
                select item;

            foreach (var item in theBestStudents)
            {
                Console.WriteLine("One of the highest scores was {0}", item);
            }

            // Pause to see output.
            Console.ReadLine();

            // Show a sorted list
            var sortedScores =
                from item in scores
                orderby item descending
                select item;

            foreach (var item in sortedScores)
            {
                Console.WriteLine("One of the scores was {0}", item);
            }

            // Show sorted list of B students (80-90) in ascending order.
            var bStudents =
                from item in scores
                where item >= 80 && item <= 90
                orderby item
                select item;

            // Pause to see output.
            Console.ReadLine();

            foreach (var item in bStudents)
            {
                Console.WriteLine("One of the B grades was {0}", item);
            }
        }
    }
}
