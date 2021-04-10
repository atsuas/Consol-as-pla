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
            var workdir = Directory.GetCurrentDirectory();
            Console.WriteLine(workdir);

            Directory.SetCurrentDirectory(@"C:\TEMP");

            var newWorkdir = Directory.GetCurrentDirectory();
            Console.WriteLine(newWorkdir);
        }

    }
}
