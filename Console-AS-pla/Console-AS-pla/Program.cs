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
            using (var reader = XmlReader.Create("novel.xml"))
            {
                var serializer = new XmlSerializer(typeof(Novel));
                var novel = serializer.Deserialize(reader) as Novel;
                Console.WriteLine(novel);
            }

        }
    }

}
