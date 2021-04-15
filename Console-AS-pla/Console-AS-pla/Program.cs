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
            var novels = new Novel[]
            {
                new Novel
                {
                    Auther = "アイザック",
                    Title = "ロボット",
                    Published = 1950,
                },
                new Novel
                {
                    Auther = "ジョージ",
                    Title = "海賊船",
                    Published = 1947,
                },
            };

            using (var stream = new FileStream("novels.json", FileMode.Create, FileAccess.Write))
            {
                var serializer = new DataContractJsonSerializer(novels.GetType());
                serializer.WriteObject(stream, novels);
            }
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
