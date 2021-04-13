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
    public class Novel
    {
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "auther")]
        public string Auther { get; set; }

        [XmlElement(ElementName ="published")]
        public int Published { get; set; }
        
    }

}
