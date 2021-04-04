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
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            One(numbers);
            Console.WriteLine();

            Two(numbers);
            Console.WriteLine();

            Three(numbers);
            Console.WriteLine();

            Four(numbers);
            Console.WriteLine();

            Five(numbers);

        }

        private static void One(int[] numbers)
        {
            var small = numbers.Max();
            Console.WriteLine(small);
        }

        private static void Two(int[] numbers)
        {
            var skip = numbers.Length - 2;
            foreach (var item in numbers.Skip(skip))
            {
                Console.WriteLine(item);
            }
        }

        private static void Three(int[] numbers)
        {
            var st = numbers.Select(x => x.ToString());
            foreach (var n in st)
            {
                Console.WriteLine(n);
            }
        }

        private static void Four(int[] numbers)
        {
            foreach (var n in numbers.OrderBy(c => c).Take(3))
            {
                Console.WriteLine(n);
            }
        }

        private static void Five(int[] numbers)
        {
            var ten = numbers.Distinct().Count(x => x >= 10);
            Console.WriteLine(ten);
        }
    }

}
