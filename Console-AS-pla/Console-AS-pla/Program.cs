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
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            One(numbers);
            Console.WriteLine();

            Two(numbers);
            Console.WriteLine();

            Three(numbers);
            Console.WriteLine();
        }

        private static void One(List<int> numbers) 
        {
            var exist = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);
            if (exist)
                Console.WriteLine("存在します");
            else
                Console.WriteLine("存在していません");
        }

        private static void Two(List<int> numbers)
        {
            var fe = numbers.Select(n => n / 2.0);
            foreach (var number in fe)
            {
                Console.WriteLine(number);
            }
        }

        private static void Three(List<int> numbers)
        {
            var fifth = numbers.Where(n => n >= 50);
            foreach (var number in fifth)
            {
                Console.WriteLine(number);
            }
        }
    }

}
