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
            //指定したファイルがあるかどうか調べる
            if (File.Exists(@"C:\Example\Greeting.txt"))
            {
                Console.WriteLine("既に存在しています");
            }
        }

    }
}
