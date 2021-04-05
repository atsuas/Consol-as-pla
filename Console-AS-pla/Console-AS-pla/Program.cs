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
            //ディクショナリから要素を取り出す
            int price = flowerDict["rose"];

            var employee = employee[125];

            //ディクショナリにキーが存在するか確かめる
            var key = "pansy";
            if (flowerDict.ContainsKey(key))
            {
                var price = flowerDict[key];
                //priceに関する処理

            }

        }

    }
}
