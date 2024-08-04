using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task11
{
    internal class Book
    {
        private string bookName;

        public string BookName
        {
            get => bookName;
        }

        private string bookAuthor;

        public string BookAuthor
        {
            get => bookAuthor;
        }

        private string bookYearPublication;

        public string BookYearPublication
        {
            get => bookYearPublication;
        }

        public Book(string name = "unknown", string author = "unknown", string yearPublication = "unknown")
        {
            bookAuthor = author;
            bookName = name;
            bookYearPublication = yearPublication;
        }
    }
}