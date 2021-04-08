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
            var line = Console.ReadLine();
            var price = int.Parse(line);
            if (price >= 0)
            {
                var totalprice = price * 1.1;
                Console.WriteLine($"{totalprice:0}");
            }

        }

    }
}
