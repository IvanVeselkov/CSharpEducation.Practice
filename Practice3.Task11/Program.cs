using System;

namespace Practice3.Task11
{
    internal class Program
    {
        public static string GetInformationAboutBook(Book b)
        {
            return string.Format("Название книги: " + b.BookName + "\nАвтор книги: " + b.BookAuthor + "\nГод публикации книги: " + b.BookYearPublication + "\n");
        }

        private static void Main(string[] args)
        {
            Book b = new Book("Book", "DyaDya", "2024");
            Console.WriteLine(GetInformationAboutBook(b));
        }
    }
}