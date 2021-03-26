using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_AS_pla
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            One(books);
            Console.WriteLine("-----");

            Two(books);
            Console.WriteLine("-----");

            Three(books);
            Console.WriteLine("-----");

            Four(books);
            Console.WriteLine("-----");

            Fifth(books);
            Console.WriteLine("-----");
        }

        private static void One(List<Book> books)
        {
            var pl = books.FirstOrDefault(n => n.Title == "ワンダフル・C#ライフ");
            if (pl != null)
            {
                Console.WriteLine("{0} {1}", pl.Price, pl.Pages);
            }
        }

        private static void Two(List<Book> books)
        {
            int count = books.Count(n => n.Title.Contains("C#"));
            Console.WriteLine(count);
        }

        private static void Three(List<Book> books)
        {
            var contain = books.Where(n => n.Title.Contains("C#"))
                               .Average(n => n.Pages);
            Console.WriteLine(contain);
        }

        private static void Four(List<Book> books)
        {
            var title = books.FirstOrDefault(n => n.Price >= 4000);
            Console.WriteLine("{0}", title.Title);
        }

        private static void Fifth(List<Book> books)
        {
            var page = books.Where(n => n.Price <= 4000)
                            .Max(n => n.Pages);
            Console.WriteLine("{0}", page);
        }


    }

    class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }
}
