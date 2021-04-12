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

    }

    class MySample
    {
        public IReadOnlyList<int> Mylist { get; private set; }

        public MySample()
        {
            Mylist = new List<int>() { 1, 2, 3, 4, 5 };
        }
    }
}
