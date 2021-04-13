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
            var novel = new Novel
            {
                Auther = "ジェイムズ",
                Title = "星の砂",
                Published = 1977,
            };
            var settings = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };
           using (var writer = XmlWriter.Create("novel.xml", settings))
            {
                var serializer = new DataContractSerializer(novel.GetType());
                serializer.WriteObject(writer, novel);
            }
        }

    }

    public class Novel
    {
        public string Title { get; set; }
        public string Auther { get; set; }
        public int Published { get; set; }
        public override string ToString()
        {
            return string.Format($"[Title={Title}, Auther:{Auther}, Published:{Published}]");
        }
    }

}
