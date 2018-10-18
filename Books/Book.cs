using System;

namespace Books
{
    public enum BookGenre
    {
        Fiction,
        NonFiction
    }

    public class Book
    {
        public Book(Guid id, string title, int year, int price, BookGenre genre)
        {
            Id = id;
            Title = title;
            Year = year;
            Price = price;
            Genre = genre;
        }

        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public int Year { get; private set; }
        public int Price { get; private set; }
        public BookGenre Genre { get; private set; }
    }
}
