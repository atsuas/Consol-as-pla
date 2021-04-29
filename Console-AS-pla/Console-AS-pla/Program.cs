using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.Globalization;
using System.Runtime.Serialization.Json;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tw = new TimeWatch();
            tw.Start();
            Thread.Sleep(1000);
            TimeSpan duration = tw.Stop();
            Console.WriteLine("処理時間は{0}ミリ秒でした", duration.TotalMilliseconds);
        }

    }

    class TimeWatch
    {
        private DateTime _time;
        public void Start()
        {
            _time = DateTime.Now;
        }

        public TimeSpan Stop()
        {
            return DateTime.Now - _time;
        }
    }

}
