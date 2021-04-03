using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AS
{
    class Program
    {
        static void Main(string[] args)
        {
            var one = Console.ReadLine();
            var two = Console.ReadLine();
            if (string.Compare(one, two, ignoreCase: true) == 0)
                Console.WriteLine("同じです");
            else
                Console.WriteLine("等しくありません");
                
        }
    }

}
