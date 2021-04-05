using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AS
{
    class Program
    {
        static void Main(string[] args)
        {
            //要素の追加
            flowerDict["violet"] = 600;
            employeeDict = new employee(130, "鈴木敬之");

            //Addでも追加できる
            flowerDict.Add("violet", 600);
            employeeDict.Add(130, "鈴木敬之");

        }

    }
}
