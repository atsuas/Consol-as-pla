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
            var a = 10;
            var b = 30;
            Console.WriteLine($"{a} {b}");
            var th = a;
            a = b;
            b = th;
            Console.WriteLine($"{a} {b}");


        }

    }
}
