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
            var path = @"C:\temp\祇園精舎.txt";
            CreatePath(path);


            static void CreatePath(string path)
            {
                var lines = new string[]
                {
                    "祇園精舍の鐘の声、諸行無常の響きあり。",
                    "娑羅双樹の花の色、盛者必衰の理をあらはす。",
                    "奢れる人も久しからず、ただ春の夜の夢のごとし。",
                    "猛き者もつひにはほろびぬ、ひとへに風の前の塵に同じ。"
                };
                File.WriteAllLines(path, lines);
            }
        }

    }
}
