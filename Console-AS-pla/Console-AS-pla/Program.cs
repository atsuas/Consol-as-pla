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
            var di = new DirectoryInfo(@"C:\Example");
            var files = di.EnumerateFiles("*.txt", SearchOption.AllDirectories)
                          .Take(20);
            foreach (var item in files)
            {
                Console.WriteLine($"{item.Name} {item.CreationTime}");
            }
        }

    }
}
