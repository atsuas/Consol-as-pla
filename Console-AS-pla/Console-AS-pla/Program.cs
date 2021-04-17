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
           
        }

        private static void Three(string file)
        {
            using (XmlReader reader = XmlReader.Create(file))
            {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var emps = serializer.ReadObject(reader) as Employee[];
                foreach (var emp in emps)
                {
                    Console.WriteLine($"{emp.Id} {emp.Name} {emp.HireName}");
                }
            }
        }

    }

}
