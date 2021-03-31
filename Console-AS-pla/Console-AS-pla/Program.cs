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
            var outputPath = Numberring(file);

            Display(outputPath);

        }

        private static string Numberring(string file)
        {
            var lines = File.ReadLines(file)
                            .Select((s, n) => string.Format("{0,4}{1}", n + 1, s));
            var path = Path.ChangeExtension(file, ".txt");
            File.WriteAllLines(path, lines);
            return path;
        }

        private static void Display(string outputPath)
        {
            var text = File.ReadAllText(outputPath);
            Console.WriteLine(text);
        }
    }
}
