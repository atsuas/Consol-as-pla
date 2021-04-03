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
            var yearMonth = new YearMonth[]
            {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2000, 7),
                new YearMonth(2010, 9),
                new YearMonth(2020, 12),
            };

            //One(yearMonth);
            //Console.WriteLine();

            Two(yearMonth);
            Console.WriteLine();

            Three(yearMonth);
            Console.WriteLine();

        }

        public static void One(YearMonth[] yearMonth)
        {
            foreach (var item in yearMonth)
            {
                Console.WriteLine(item);
            }
        }

        static YearMonth FIrst21(YearMonth[] yearMonths)
        {
            foreach (var item in yearMonths)
            {
                if (item.Is21Century)
                {
                    return item;
                }
            }
            return null;
        }

        public static void Two(YearMonth[] yearMonth)
        {
            var yearmonth = FIrst21(yearMonth);
            if (yearMonth == null)
                Console.WriteLine("データはありません");
            else
                Console.WriteLine(yearmonth);

        }

        private static void Three(YearMonth[] yearMonth)
        {
            var month = yearMonth.Select(x => x.AddOneMonth())
                                 .ToArray();
            foreach (var item in month)
            {
                Console.WriteLine(item);
            }
            
        }

    }

    class YearMonth
    {
        public int Year { get; private set; }
        public int Month { get; private set; }

        public YearMonth(int year, int month)
        {
            Year = year;
            Month = month;
        }

        public bool Is21Century
        {
            get
            {
                return 2001 <= Year && Year <= 2100;
            }
        }

        public YearMonth AddOneMonth()
        {
            if (Month == 12)
            {
                return new YearMonth(this.Year + 1, 1);
            }
            else
            {
                return new YearMonth(this.Year, this.Month + 1);
            }
        }

        public override string ToString()
        {
            return $"{Year}年{Month}月";
        }
    }

}
