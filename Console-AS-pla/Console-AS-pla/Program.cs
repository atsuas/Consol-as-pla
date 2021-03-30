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

            var count = abbrs.Count;
            Console.WriteLine(count);
            Console.WriteLine();

            if (abbrs.Remove("NPI"))
                Console.WriteLine(count);
            if (!abbrs.Remove("NPI"))
                Console.WriteLine("削除できません");
            Console.WriteLine();

            foreach (var item in abbrs.Where(x => x.Key.Length == 3))
                Console.WriteLine($"{item.Key} = {item.Value}");

        }

    }
}
