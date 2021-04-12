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
            if (args.Length <= 1)
                return;
            var file1 = args[0];
            var file2 = args[1];
            Concat(file1, file2);

            Display(file1);
        }

        private static void Concat(string file1, string file2)
        {
            File.AppendAllLines(file1, File.ReadLines(file2));
        }

        private static void Display(string outputPath)
        {
            var text = File.ReadAllText(outputPath);
            Console.WriteLine(text);
        }
    }

}
