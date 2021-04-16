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
            var nums = new List<int> { 1, 2, 3, 4, 5 };
            nums.ForEach(n => Console.WriteLine($"{n}"));
        }

    }

}
