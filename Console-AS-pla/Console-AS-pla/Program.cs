using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"C:\Example\Greeting.txt";
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            {
                using (var reader = new StreamReader(stream))
                using (var writer = new StreamWriter(stream))
                {
                    string texts = reader.ReadToEnd();
                    stream.Position = 0;
                    writer.WriteLine("挿入する新しい行1");
                    writer.WriteLine("挿入する新しい行2");
                    writer.Write(texts);
                }
            }
        }

    }
}
