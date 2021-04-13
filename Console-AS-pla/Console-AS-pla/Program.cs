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
            
        }
    }

    [XmlRoot("novel")]
    public class NovelCollection
    {
        [XmlElement(Type = typeof(Novel), ElementName = "novel")]
        public Novel[] Novels { get; set; }

    }

}
