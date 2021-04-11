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
            var path = @"C:\Program Files\Microsoft Office\Office16\EXCEL.EXE";
            var directoryName = Path.GetDirectoryName(path);
            var fileName = Path.GetFileName(path);
            var exetension = Path.GetExtension(path);
            var filenameWithoutExetension = Path.GetFileNameWithoutExtension(path);
            var pathRoot = Path.GetPathRoot(path);

            Console.WriteLine($"DirectionName: {directoryName}");
            Console.WriteLine($"FileName: {fileName}");
            Console.WriteLine($"Extension: {exetension}");
            Console.WriteLine($"FilenameWithoutExteinsion: {filenameWithoutExetension}");
            Console.WriteLine($"PathRoot: {pathRoot}");
        }

    }
}
