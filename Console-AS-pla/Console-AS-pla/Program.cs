using System;
using System.Linq;

namespace Console_AS_pla
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            One(numbers);
            Console.WriteLine("-----");

            Two(numbers);
            Console.WriteLine("-----");

            Three(numbers);
            Console.WriteLine("-----");

            Four(numbers);
            Console.WriteLine("-----");

            Five(numbers);
            Console.WriteLine("-----");
        }

        private static void One(int[] numbers)
        {
            var max = numbers.Max();
            Console.WriteLine(max);
        }

        private static void Two(int[] numbers)
        {
            var skip = numbers.Length - 2;
            foreach (var n in numbers.Skip(skip))
                Console.WriteLine(n);
        }

        private static void Three(int[] numbers)
        {
            var str = numbers.Select(n => n.ToString());
            foreach (var s in str)
            {
                Console.WriteLine(s);
            }
        }

        private static void Four(int[] numbers)
        {
            foreach (var num in numbers.OrderBy(n => n).Take(3))
            {
                Console.WriteLine(num);
            }
        }

        private static void Five(int[] numbers)
        {
            var num = numbers.Distinct().Count(n => n > 10);
            Console.WriteLine(num);

        }
    }
}
