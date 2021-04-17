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
            var min = Library.Books
                             .Min(x => x.Title.Length);
            var book = Library.Books
                              .First(b => b.Title.Length == min);
            Console.WriteLine(book);
        }

    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Id:{Id}, カテゴリ名:{Name}";
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public int CategoriId { get; set; }
        public int PublishedYear { get; set; }
        public override string ToString()
        {
            return $"発行年:{PublishedYear}, カテゴリ:{CategoriId}, 価格:{Price}, タイトル:{Title}";
        }
    }

    public static class Library
    {
        public static IEnumerable<Category> Categories { get; private set; }
        public static IEnumerable<Book> Books { get; private set; }

        static Library()
        {

        }
    }

}
