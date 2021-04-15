﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.Globalization;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

    }

    [XmlRoot("novelist")]
    public class Novelist
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlArray("masterpieces")]
        [XmlArrayItem("title", typeof(string))]
        public string[] Masterpieces { get; set; }
    }

}
