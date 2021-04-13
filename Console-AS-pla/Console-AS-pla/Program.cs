﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var writer = XmlWriter.Create("novel.xml"))
            {
                var serializer = new XmlSerializer(novel.GetType());
                serializer.Serialize(writer, novel);
            }
        }
    }

}
