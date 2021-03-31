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
            var lines = File.ReadAllLines(@"C:\temp\祇園精舎.txt");
            foreach (var item in lines)
            {
                Console.WriteLine(item);
            }

        }

    }
}
