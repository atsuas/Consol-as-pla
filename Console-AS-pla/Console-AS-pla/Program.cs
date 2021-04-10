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
            if (Directory.Exists(@"C:\Example"))
            {
                Console.WriteLine("存在しています");
            }
            else
            {
                Console.WriteLine("存在していません");
            }
        }

    }
}
