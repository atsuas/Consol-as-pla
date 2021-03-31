using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Console_AS_pla
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
                return;
            var file = args[0];

            Console.WriteLine($"{Path.GetFullPath(file)}について調べます");
            One(file);
            Two(file);
            Three(file);

        }

        private static void One(string file)
        {
            var count = 0;
            using (var sr = new StreamReader(file))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    if (line.Contains(" class "))
                        count++;
                }
            }
            Console.WriteLine(count);
        }

        private static void Two(string file)
        {
            var count = File.ReadAllLines(file)
                            .Count(s => s.Contains(" class "));
            Console.WriteLine(count);
        }

        private static void Three(string file)
        {
            var count = File.ReadLines(file)
                            .Count(s => s.Contains(" class "));
            Console.WriteLine(count);

        }
    }
}
