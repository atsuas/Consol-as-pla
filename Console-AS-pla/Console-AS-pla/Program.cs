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
            var text = "Jackdaws love my big sphinx of quartz";

            One(text);
            Console.WriteLine();

            Two(text);
            Console.WriteLine();

            Three(text);
            Console.WriteLine();

            Four(text);
            Console.WriteLine();
        }

        private static void One(string text)
        {
            int space = text.Count(s => s == ' ');
            Console.WriteLine(space);
        }

        private static void Two(string text)
        {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Three(string text)
        {
            var count = text.Split(' ').Length;
            Console.WriteLine(count);
        }

        private static void Four(string text)
        {
            var word = text.Split(' ')
                           .Where(s => s.Length <= 4);
            foreach (var item in word)
            {
                Console.WriteLine(item);
            }
        }

        private static void Five(string text)
        {

        }
    }

}
