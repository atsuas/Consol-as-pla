using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.Globalization;
using System.Runtime.Serialization.Json;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Jackdaws love my big sphinx of quartz";

            One(text);

            Two(text);

            Three(text);

            Four(text);


        }

        private static void One(string text)
        {
            var non = text.Count(s => s == ' ');
            Console.WriteLine(non);
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
            var four = text.Split(' ')
                           .Where(s => s.Length <= 4);
            foreach (var item in four)
            {
                Console.WriteLine(item);
            }
        }
    }

}
