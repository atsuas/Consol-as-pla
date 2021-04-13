using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (XmlReader reader = XmlReader.Create("novels.xml"))
            {
                var serializer = new DataContractSerializer(typeof(Novel[]));
                var novels = serializer.ReadObject(reader) as Novel[];
                foreach (var novel in novels)
                {
                    Console.WriteLine(novel);
                }
            }
        }
    }

}
