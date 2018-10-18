using System.Collections.Generic;

namespace Books
{
    public interface IBookRepository
    {
        List<Book> RetriveAllBooks();
        List<Book> RetriveAllOrderByPriceAscending();
        List<Book> RetriveAllOrderByPriceDescending();
        List<Book> RetriveAllOrderByYearAscending();
        List<Book> RetriveAllOrderByYearDescending();

    }
}