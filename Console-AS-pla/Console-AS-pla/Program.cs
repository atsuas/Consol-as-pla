using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.Text;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Session["MyProduct"] as Product;
            if (product == null)
            {
                //productが取得できなかった時の処理
            }
            else
            {
                //取得できた時の処理
            }
        }

    }

}
