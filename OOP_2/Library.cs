using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }

        public Book(string title, string author, int isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}";
        }
    }

    public class EBook : Book
    {
        public double FileSize { get; set; } 

        public EBook(string title, string author, int isbn, double fileSize): base(title, author, isbn)
        {
            FileSize = fileSize;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, File Size: {FileSize} MB";
        }
}

    public class PrintedBook : Book
    {
        public int PageCount { get; set; }

        public PrintedBook(string title, string author, int isbn, int pageCount): base(title, author, isbn)
        {
            PageCount = pageCount;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Page Count: {PageCount}";
        }
    }
}
