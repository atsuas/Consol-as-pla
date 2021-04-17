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
            var novelist = One("sample.xml");
            Two(novelist, "novelist.json");

            Console.WriteLine($"{novelist.Name} {novelist.Birth}");
            foreach (var title in novelist.Masterpieces)
            {
                Console.WriteLine(title);
            }

            Console.WriteLine(File.ReadAllText("novelist.json"));

        }

        static Novelist One(string file)
        {
            using (var reader = XmlReader.Create(file))
            {
                var serializer = new XmlSerializer(typeof(Novelist));
                var novelist = (Novelist)serializer.Deserialize(reader);

                return novelist;
            }
        }

        static void Two(Novelist novelist, string outfile)
        {
            using (var stream = new FileStream(outfile, FileMode.Create, FileAccess.Write))
            {
                var serializer = new DataContractJsonSerializer(novelist.GetType(),
                    new DataContractJsonSerializerSettings
                    {
                        DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ssZ")
                    });
                serializer.WriteObject(stream, novelist);
            }
        }

    }

    [XmlRoot("novelist")]
    [DataContract]
    public class Novelist
    {
        [XmlElement(ElementName = "name")]
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "birth")]
        [DataMember(Name = "birth")]
        public DateTime Birth { get; set; }

        [XmlArray("masterpieces")]
        [XmlArrayItem("title", typeof(string))]
        [DataMember(Name = "masterpieces")]
        public string[] Masterpieces { get; set; }


    }

}
