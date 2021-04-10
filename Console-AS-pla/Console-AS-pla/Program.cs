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
            var directories = di.EnumerateDirectories();
            foreach (var dinfo in directories)
            {
                Console.WriteLine(dinfo.FullName);
            }
        }

    }
}
