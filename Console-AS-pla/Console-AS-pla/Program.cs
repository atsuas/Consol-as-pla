using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_AS_pla
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            One(text);
            Console.WriteLine();
            Two(text);

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

        static void Two(string text)
        {
            var dict = new SortedDictionary<Char, int>();
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
            foreach (var item in dict)
                Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
}
