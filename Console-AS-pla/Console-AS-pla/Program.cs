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
            var abbreviationDict = new AbbreviationDict
            {
                Abbreviations = new Dictionary<string, string>
                {
                    ["ODA"] = "政府開発援助",
                    ["OECD"] = "経済協力開発援助",
                    ["OPEC"] = "石油輸出国機構",
                }
            };
            var settings = new DataContractJsonSerializerSettings
            {
                UseSimpleDictionaryFormat = true,
            };
            using (var stream = new FileStream("abbreviations.json", FileMode.Create, FileAccess.Write))
            {
                var serializer = new DataContractJsonSerializer(abbreviationDict.GetType(), settings);
                serializer.WriteObject(stream, abbreviationDict);
            }
        }

    }

    [DataContract]
    public class AbbreviationDict
    {
        [DataMember(Name = "abbrs")]
        public Dictionary<string, string> Abbreviations { get; set; }
    }

}
