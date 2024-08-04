using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task4
{
    internal class Book
    {
        private string bookName;
        private string bookAuthor;

        public Book(string name = "unknown", string author = "unknown")
        {
            bookAuthor = author;
            bookName = name;
        }

        public void GetInformationAboutBook()
        {
            Console.WriteLine("Название книги: " + bookName + "\nАвтор книги: " + bookAuthor + "\n");
        }
    }
}