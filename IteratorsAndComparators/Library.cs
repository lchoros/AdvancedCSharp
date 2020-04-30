using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library
    {
        private List<Book> books { get; set; }

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        //private class LibraryIterator : IEnumerator<Book>
        //{
        //    private readonly List<Book> books;
        //    private int currentIndex;

        //    public LibraryIterator(IEnumerable<Book> books)
        //    {
        //        this.Reset();
        //    }
        //}
    }
}
