using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Books
{
    public class BookRepositoryMethod : IBookRepository
    {
        private List<Book> _books = new List<Book>();

        public BookRepositoryMethod(List<Book> books)
        {
            _books = books;
        }

        public List<Book> RetriveAllBooks()
        {
            var result = _books.Where(b => true);
            return result.ToList();
        }

        public List<Book> RetriveAllOrderByPriceAscending()
        {
            var result = _books.OrderBy(b => b.Price);
            return result.ToList();
        }

        public List<Book> RetriveAllOrderByPriceDescending()
        {
            var result = _books.OrderByDescending(b => b.Price);
            return result.ToList();
        }

        public List<Book> RetriveAllOrderByYearAscending()
        {
            var result = _books.OrderBy(b => b.Year);
            return result.ToList();
        }

        public List<Book> RetriveAllOrderByYearDescending()
        {
            var result = _books.OrderByDescending(b => b.Year);
            return result.ToList();
        }
        /*
        public List<Book> RetriveAllBooksGroupedByGenre()
        {
            var result = _books.GroupBy(b => b.Genre).Select(b => true);
            return result.ToList();
        }*/
    }
}
