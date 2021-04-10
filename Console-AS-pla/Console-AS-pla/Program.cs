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
            var fi = new FileInfo(@"C:\Example\Greeting.txt");
            if (fi.Exists)
                Console.WriteLine("既に存在しています");
        }

    }
}
