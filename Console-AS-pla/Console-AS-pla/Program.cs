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
            if (args.Length <= 1);
            return;
            var file1 = args[0];
            var file2 = args[1];
            One(file1, file2);


        }

        private static void One(string file1, string file2)
        {
            File.AppendAllLines(file1, File.ReadLines(file2));
        }
    }
}
