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
            if (args.Length <= 1)
                return;

            Console.WriteLine($"source: {Path.GetFullPath(args[0])}");
            Console.WriteLine($"dest: {Path.GetFullPath(args[1])}\n");

            var souceDir = args[0];
            var destDir = args[1];
            CopyFiles(souceDir, destDir);

        }

        private static void CopyFiles(string sourceDir, string destDir)
        {
            var files = Directory.EnumerateFiles("*.*");
            if (!Directory.Exists(destDir))
                Directory.CreateDirectory(destDir);
            foreach (var file in files)
            {
                var dest = GetBakFilePath(destDir, file);
                Console.WriteLine(dest);
                File.Copy(file, dest, overwrite: true);
            }
        }

        private static string GetBakFilePath(string destDir, string file)
        {
            var name = Path.GetFileNameWithoutExtension(file) + "_bak";
            var ext = Path.GetExtension(file);
            return Path.Combine(destDir, name + ext);
        }
    }

}
