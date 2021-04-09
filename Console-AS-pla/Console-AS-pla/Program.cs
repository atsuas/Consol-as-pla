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
            var filePath = @"C:\Example\Greeting.txt";
            var lines = File.ReadAllLines(filePath, Encoding.UTF8);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
         

        }

    }
}
