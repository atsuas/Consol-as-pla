using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "C#", "Ruby", "Kotlin", "Swift", "Python", "Java", "PHP" };

            One(names);
            
        }

        public static void One(string[] names)
        {
            var name = names.Max(x => x.Length);
            Console.WriteLine(name);
        }

    }
}
