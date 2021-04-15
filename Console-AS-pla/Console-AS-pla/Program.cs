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
            var str1 = "カステラ";
            var str2 = "かすてら";
            var cultureInfo = new CultureInfo("ja-JP");
            if (String.Compare(str1, str2, cultureInfo, CompareOptions.IgnoreKanaType) == 0)
                Console.WriteLine("一致しています");
        }

    }

}
