using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public void writeLog(string fotmat, params object[] args)
        {
            var s = String.Format(fotmat, args);
            //ログファイルへ出力する
            WriteLine(s);
        }

    }

}
