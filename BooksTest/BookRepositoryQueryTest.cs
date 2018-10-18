using Books;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksTest
{
    [TestClass]
    public class BookRepositoryQueryTest
    {
        private BookRepositoryQuery _sut;

        [TestInitialize]
        public void TestInitialize()
        {
            _sut = new BookRepositoryQuery(new List<Book>
            {
                new Book(new System.Guid(), "Book1", 1990, 200, BookGenre.Fiction),
                new Book(new System.Guid(), "Book2", 1995, 400, BookGenre.NonFiction),
                new Book(new System.Guid(), "Book3", 1993, 300, BookGenre.NonFiction),
                new Book(new System.Guid(), "Book4", 1991, 350, BookGenre.Fiction),
                new Book(new System.Guid(), "Book5", 1997, 100, BookGenre.Fiction)
            });
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _sut = null;
        }

        [TestMethod]
        public void GivenBookRepositoryThenRetriveAllBooks()
        {
            //act
            List<Book> actual = _sut.RetriveAllBooks();

            //assert
            actual.Equals(_sut);
        }

        [TestMethod]
        public void GivenBookRepositoryThenRetriveOrderByYear()
        {
            //act
            List<Book> actual = _sut.RetriveAllOrderByYearAscending();
            Assert.IsTrue(1990 == actual[0].Year);
        }

        [TestMethod]
        public void GivenBookRepositoryThenRetriveOrderByYearDesc()
        {
            //act
            List<Book> actual = _sut.RetriveAllOrderByYearDescending();
            Assert.Equals(1997, actual[0].Year);
        }

        [TestMethod]
        public void GivenBookRepositoryThenRetriveOrderByPrice()
        {
            //act
            List<Book> actual = _sut.RetriveAllOrderByPriceAscending();
            Assert.Equals(100, actual[0].Price);
        }

        [TestMethod]
        public void GivenBookRepositoryThenRetriveOrderByPriceDesc()
        {
            //act
            List<Book> actual = _sut.RetriveAllOrderByPriceDescending();
            Assert.Equals(400, actual[0].Price);
        }
    }
}
