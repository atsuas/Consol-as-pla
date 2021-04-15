using System;
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

    [DataContract(Name = "novel")]
    public class Novel
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }
        
        [DataMember(Name = "auther")]
        public string Auther { get; set; }

        [DataMember(Name = "published")]
        public int Published { get; set; }

    }

}
