﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var di = new DirectoryInfo(@"C:\Windows");
            FileInfo[] files = di.GetFiles();
        }

    }
}
