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
            var lines = new[] { "=====", "今日の夢", "大阪の夢", };
            var filePath = @"C:\Example\Greeting.txt";
            using (var writer = new StreamWriter(filePath, append:true))
            {
                foreach (var item in lines)
                {
                    writer.WriteLine(item);
                }
            }
         

        }

    }
}
