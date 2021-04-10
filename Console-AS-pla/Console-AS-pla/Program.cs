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
            var di = new DirectoryInfo(@"C:\Example");
            FileSystemInfo[] fileSystems = di.GetFileSystemInfos();
            foreach (var item in fileSystems)
            {
                if ((item.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                    Console.WriteLine($"ディレクトリ:{item.Name} {item.CreationTime}");
                else
                    Console.WriteLine($"ファイル:{item.Name} {item.CreationTime}");
            }
        }

    }
}
