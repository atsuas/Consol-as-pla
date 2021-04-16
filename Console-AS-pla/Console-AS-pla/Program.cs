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
            var target = "Novelist=坂本工事;BestWork=三木島さとし";
            var value = "BestWork=";
            var startIndex = target.IndexOf("BestWork=") + value.Length;
            var endIndex = target.IndexOf(";", startIndex);
            var bestWork = target.Substring(startIndex, endIndex - startIndex);
        }

    }

}
