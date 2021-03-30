﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_AS_pla
{
    class Program
    {
        public class YearMonth
        {
            public int Year { get; private set; }

            public int Month { get; private set; }

            public YearMonth(int year, int month)
            {
                Year = year;
                Month = month;
            }

            // 4.1.2
            public bool Is21Century
            {
                get
                {
                    return 2001 <= Year && Year <= 2100;
                }
            }

            // 4.1.3
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

            // 4.1.4
            public override string ToString()
            {
                return $"{Year}年{Month}月";
            }
        }
    }
}
