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
            var settings = new DataContractJsonSerializerSettings
            {
                UseSimpleDictionaryFormat = true,
            };
            using (var stream = new FileStream("abbreviations.json", FileMode.Open, FileAccess.Read))
            {
                var serializer = new DataContractJsonSerializer(typeof(Abbreviation.Dict), settings);
                var dict = serializer.ReadObject(stream) as AbbreviationDict;
                foreach (var item in dict.Abbreviations)
                {
                    Console.WriteLine($"{item.key} {item.value}");
                }
            }
        }

    }

}
