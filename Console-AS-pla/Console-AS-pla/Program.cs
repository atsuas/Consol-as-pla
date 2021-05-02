using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.Globalization;
using System.Runtime.Serialization.Json;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            int num;
            if (int.TryParse(line, out num))
            {
                Console.WriteLine("{0:#,#}", num);
            }
            else
            {
                Console.WriteLine("数値文字列でありません");
            }
        }

    }

}
