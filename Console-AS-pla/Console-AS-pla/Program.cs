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
            
        }

        public double Median(params double[] args)
        {
            var sorted = args.OrderBy(n => n).ToArray();
            int index = sorted.Length / 2;
            if (sorted.Length % 2 = 0)
                return ()
        }

    }

}
