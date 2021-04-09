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
            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }

        }

    }
}
