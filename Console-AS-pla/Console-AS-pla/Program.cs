using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Console_AS_pla
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = new string[]
            {
                "ああああああああああ、あああああああ",
                "いいいいいいいいいいいいいいいいいいいいい",
                "ううううううううううううううううううううううううう",
                "ええええええええええええええええええええええええええええ"
            };
            File.WriteAllLines(@"C:\temp\祇園精舎.txt", lines);
        }

    }
}
