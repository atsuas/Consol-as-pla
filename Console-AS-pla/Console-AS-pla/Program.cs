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
            var books = new List<Book>
            {
                new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            One(books);
            Console.WriteLine();

            Two(books);
            Console.WriteLine();

            Three(books);
            Console.WriteLine();

            Four(books);
            Console.WriteLine();

            Five(books);
            Console.WriteLine();

            Six(books);
            Console.WriteLine();

            Seven(books);

        }

        public static void One(List<Book> books)
        {
            var book = books.FirstOrDefault(x => x.Title == "ワンダフル・C#ライフ");
            if (book != null)
                Console.WriteLine($"{book.Price} {book.Pages}");
        }

        public static void Two(List<Book> books)
        {
            var count = books.Count(x => x.Title.Contains("C#"));
            Console.WriteLine(count);
        }

        public static void Three(List<Book> books)
        {
            var book = books.Where(x => x.Title.Contains("C#"))
                            .Average(x => x.Pages);
            Console.WriteLine(book);
        }

        public static void Four(List<Book> books)
        {
            var book = books.First(x => x.Price >= 4000);
            Console.WriteLine($"{book.Title}");
        }

        public static void Five(List<Book> books)
        {
            var book = books.Where(x => x.Price <= 4000)
                            .Max(x => x.Pages);
            Console.WriteLine(book);
        }

        public static void Six(List<Book> books)
        {
            var book = books.Where(x => x.Pages >= 400)
                            .OrderByDescending(x => x.Price);
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Title} {item.Price}");
            }
        }

        public static void Seven(List<Book> books)
        {
            var book = books.Where(x => x.Title.Contains("C#") && x.Pages <= 500);
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Title}");
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }

}
