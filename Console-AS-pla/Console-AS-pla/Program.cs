using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_AS_pla
{
    class Program
    {
        static void Main(string[] args)
        {
            var abbrs = new Abbreviations();

            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPI", "核兵器不拡散条約");

            var names = new[] { "WHO", "FIFA", "NPI", };
            foreach (var name in names)
            {
                var fullname = abbrs[name];
                if (fullname == null)
                    Console.WriteLine($"{name}は見つかりません");
                else
                    Console.WriteLine($"{name}={fullname}");
            }
            Console.WriteLine();

            var japanese = "東南アジア諸国連合";
            var abbreviation = abbrs.ToAbbreviation(japanese);
            if (abbreviation == null)
                Console.WriteLine($"{japanese}は見つかりません");
            else
                Console.WriteLine($"「{japanese}」の略語は{abbreviation}です");
            Console.WriteLine();

            foreach (var item in abbrs.FindAll("国際"))
            {
                Console.WriteLine($"{item.Key}={item.Value}");
            }
            Console.WriteLine();
        }

    }
}
