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
            using (var reader = XmlReader.Create(new StringReader(xmlText)))
            {
                var serializer = new XmlSerializer(typeof(Novel));
                var novel = serializer.Deserialize(reader) as Novel;
                Console.WriteLine(novel);
            }

        }
    }

    public class Novel
    {
        public string Title { get; set; }
        public string Auther { get; set; }
        [XmlIgnore]
        public int Published { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }

}
