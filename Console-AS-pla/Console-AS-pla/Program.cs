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
            using (var reader = XmlReader.Create("novels.xml"))
            {
                var serializer = new XmlSerializer(typeof(NovelCollection));
                var novels = serializer.Deserialize(reader) as NovelCollection;
                foreach (var novel in novels.Novels)
                {
                    Console.WriteLine(novel);
                }
            }
        }

    }

}
