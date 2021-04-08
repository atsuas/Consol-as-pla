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
            var text = "Cozy lummox gives smart squid who asks for job pen";
            One(text);
            Console.WriteLine();


        }

        static void One(string text)
        {
            var dict = new Dictionary<Char, int>();
            foreach (var c in text)
            {
                var uc = char.ToUpper(c);
                if ('A' <= uc && uc <= 'Z')
                {
                    if (dict.ContainsKey(uc))
                        dict[uc]++;
                    else
                        dict[uc] = 1;
                }
            }
            foreach (var item in dict.OrderBy(x => x.Key))
            Console.WriteLine($"{item.Key} : {item.Value}");
            
        }
    }
}
