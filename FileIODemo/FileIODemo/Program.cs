using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileIODemo
{
    class Program
    {
        static void Main(string [] args)
        {
            // Sample file path location
            string filePath = @"c:\SheridanC\Git\ShadSharp\FileIODemo\test.txt";
            List<string> lines = new List<string>();
            List<Person> people = new List<Person>();

            lines = File.ReadAllLines(filePath).ToList();

            foreach(string line in lines)
            {
                string [] items = line.Split(',');
                Person p = new Person(items [0], items [1], items [2]);

                people.Add(p);
            }

            List<string> outContents = new List<string>();
            foreach (Person p in people)
            {
                Console.WriteLine(p);
                outContents.Add(p.ToString());
            }

            string outFile = @"c:\SheridanC\Git\ShadSharp\FileIODemo\outFile.txt";
            File.WriteAllLines(outFile, outContents);
            Console.ReadLine();
        }
    }
}
