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
            var filePath = @"C:\Example\Greeting.txt";
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("いろはにほへと　ちりぬるを");
                writer.WriteLine("わがよたれぞ　つねならむ");
            }
         

        }

    }
}
