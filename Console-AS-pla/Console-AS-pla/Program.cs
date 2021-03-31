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
            var s = Console.ReadLine();
            var t = Console.ReadLine();
            if (s == "Y")
                Console.WriteLine(t.ToUpper());
            else
                Console.WriteLine(t);
        }

    }
}
