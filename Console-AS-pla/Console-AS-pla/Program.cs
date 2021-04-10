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
            var fi = new FileInfo(@"C:\Example\Greeting.txt");
            FileInfo dup = fi.CopyTo(@"C:\Example\Target.txt", overwrite:true);
        }

    }
}
