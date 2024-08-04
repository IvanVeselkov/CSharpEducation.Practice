using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task5
{
    internal class Book
    {
        private string bookName;
        private string bookAuthor;
        private string bookYearPublication;

        public Book(string name = "unknown", string author = "unknown", string yearPublication = "unknown")
        {
            bookAuthor = author;
            bookName = name;
            bookYearPublication = yearPublication;
        }

        public void GetInformationAboutBook()
        {
            Console.WriteLine("Название книги: " + bookName + "\nАвтор книги: " + bookAuthor + "\nГод публикации книги: " + bookYearPublication + "\n");
        }
    }
}