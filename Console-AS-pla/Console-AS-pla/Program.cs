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
            //ディクショナリから全ての要素を取り出す
            foreach (var item in flowerDict)
                Console.WriteLine($"{item.Key} {item.Value}");

            var average = flowerDict.Average(x => x.value);

            foreach (var key in flowerDict.Keys)
            {
                Console.WriteLine(key);
            }


        }

    }
}
