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
            byte[] byteAray = Encoding.UTF8.GetBytes(jsontext);
            using (var stream = new MemoryStream(byteAray))
            {
                var serializer = new DataContractJsonSerializer(typeof(Novel[]));
                var novels = serializer.ReadObject(stream) as Novel[];
                foreach (var novel in novels)
                {
                    Console.WriteLine(novel);
                }
            }
        }

    }

}
