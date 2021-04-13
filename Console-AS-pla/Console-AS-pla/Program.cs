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
            using (var reader = XmlReader.Create("novel.xml"))
            {


                using (var writer = XmlWriter.Create("novel.xml"))
                {
                    var serializer = new DataContractSerializer(novels.GetType());
                    serializer.WriteObject(writer, novels);
                }
            }
        }

    }

}
