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
            var dict = new Dictionary<MonthDay, string>
            {
                { new MonthDay(3, 5), "珊瑚の日" },
                { new MonthDay(8, 4), "箸の日" },
                { new MonthDay(10, 3), "登山の日" },
            };

            var md = new MonthDay(8, 4);
            var s = dict[md];
            Console.WriteLine(s);

        }

    }

    class MonthDay
    {
        public int Day { get; private set; }
        public int Month { get; private set; }
        public MonthDay(int month, int day)
        {
            this.Month = month;
            this.Day = day;
        }


        public override bool Equals(object obj)
        {
            var other = obj as MonthDay;
            if (other == null)
                throw new ArgumentException();
            return this.Day == other.Day && this.Month == other.Month;
        }

        public override int GetHashCode()
        {
            return Month.GetHashCode() * 31 + Day.GetHashCode();
        }
    }
}
