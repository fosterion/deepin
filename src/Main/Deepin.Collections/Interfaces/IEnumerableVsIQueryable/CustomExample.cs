using Deepin.Shared.Models.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepin.Collections.Interfaces.IEnumerableVsIQueryable
{
    class CustomExample
    {
        private Book[] _books =
        {
            new Book("Book 1", "Author 1"),
            new Book("Book 2", "Author 1"),
            new Book("Book 3", "Author 2"),
            new Book("Book 4", "Author 2"),
            new Book("Book 5", "Author 2")
        };

        public void GetBooksAsIEnumerable()
        {
            IEnumerable<Book> books = _books;
            var selected = books.Where(p => p.Author == "Author 2").ToList();
        }

        public void GetBooksAsIQueryable()
        {
            IQueryable<Book> books = _books;
            var selected = books.Where(p => p.Author == "Author 2").ToList();
        }
    }
}
