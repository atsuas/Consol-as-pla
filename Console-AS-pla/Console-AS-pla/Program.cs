﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AS
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            int num;
            if (int.TryParse(line, out num))
                Console.WriteLine("{0:#,#}", num);
            else
                Console.WriteLine("数値文字列ではありません");
        }
    }

}
