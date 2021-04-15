using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.Globalization;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var target = "C# Programming";
            var isExists = target.Any(c => Char.IsLower(c));
            Console.WriteLine(isExists);
        }

    }

}
