using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AS
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>
            {
                "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            //One(names);
            //Console.WriteLine();

            Two(names);
            Console.WriteLine();

            Three(names);
            Console.WriteLine();

            Four(names);
            Console.WriteLine();
        }

        private static void One(List<string> names)
        {
            do
            {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                    break;
                var index = names.FindIndex(s => s == line);
                Console.WriteLine(index);
            } while (true);
            
        }

        private static void Two(List<string> names)
        {
            var count = names.Count(s => s.Contains("o"));
            Console.WriteLine(count);               
        }

        private static void Three(List<string> names)
        {
            var array = names.Where(s => s.Contains("o"))
                             .ToArray();
            foreach (var ar in array)
            {
                Console.WriteLine(ar);
            }
        }

        private static void Four(List<string> names)
        {
            var park = names.Where(n => n.StartsWith("B"))
                            .Select(s => s.Length);
            foreach (var item in park)
            {
                Console.WriteLine(item);
            }
        }
    }

}
