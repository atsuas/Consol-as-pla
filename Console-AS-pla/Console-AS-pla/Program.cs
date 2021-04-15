using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.Text;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = "wow";
            var str2 = "WOW";
            if (String.Compare(str1, str2, true) == 0)
                Console.WriteLine("等しい");
            else
                Console.WriteLine("違う");
        }

    }

}
