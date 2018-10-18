using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Books
{
    public class BookRepositoryQuery : IBookRepository
    {
        private List<Book> _books = new List<Book>();

        public BookRepositoryQuery(List<Book> books)
        {
            _books = books;
        }

        public List<Book> RetriveAllBooks()
        {
            var books = from b in _books
                        select b;
            return books.ToList();
        }

        public List<Book> RetriveAllOrderByYearDescending()
        {
            var books = from b in _books
                        orderby b.Year descending
                        select b;
            return books.ToList();
        }

        public List<Book> RetriveAllOrderByYearAscending()
        {
            var books = from b in _books
                        orderby b.Year ascending
                        select b;
            return books.ToList();
        }

        public List<Book> RetriveAllOrderByPriceDescending()
        {
            var books = from b in _books
                        orderby b.Price descending
                        select b;
            return books.ToList();
        }

        public List<Book> RetriveAllOrderByPriceAscending()
        {
            var books = from b in _books
                        orderby b.Price ascending
                        select b;
            return books.ToList();
        }

        //public RetriveAllBooksGroupedByGenre()

    }
}
