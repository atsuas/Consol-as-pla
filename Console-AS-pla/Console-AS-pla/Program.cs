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

        private static void Four(string file)
        {
            var emps = new Employee2[]
            {
                 new Employee2 {
                    Id = 123,
                    Name = "出井 秀行",
                    HireDate = new DateTime(2001, 5, 10)
                },
                new Employee2 {
                    Id = 139,
                    Name = "大橋 孝仁",
                    HireDate = new DateTime(2004, 12, 1)
                },
            };
            using (var stream = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                var serializer = new DataContractJsonSerializer
                    (emps.GetType(),
                    new DataContractJsonSerializerSettings
                    {
                        DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ssZ")
                    }
                    );
                serializer.WriteObject(stream, emps);
            }
        }

    }

}
