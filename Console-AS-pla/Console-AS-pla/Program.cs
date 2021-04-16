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

        private static void One(string outfile)
        {
            var emp = new Employee
            {
                Id = 123,
                Name = "出井 秀行",
                HireDate = new DateTime(2001, 5, 10)
            };
            using (var writter = XmlWriter.Create("employee.xml"))
            {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writter, emp);
            }
        }

        private static void Two(string outfile)
        {
            var emp = new Employee[]
            {
                new Employee
                {
                     Id = 123,
                    Name = "出井 秀行",
                    HireDate = new DateTime(2001, 5, 10)
                },
                new Employee {
                    Id = 139,
                    Name = "大橋 孝仁",
                    HireDate = new DateTime(2004, 12, 1)
                },
            };
            var settings = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };
            using (var writter = XmlWriter.Create("employee.xml", settings))
            {
                var serializer = new DataContractSerializer(emp.GetType());
                serializer.WriteObject(writter, emp);
            }
        }



    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HireDate { get; set; }

    }

}
