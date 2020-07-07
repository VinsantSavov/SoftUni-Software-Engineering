using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private SortedSet<Book> books;

        public Library(params Book[] books)
        {
            this.books = new SortedSet<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books.ToList());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private int index;
            private List<Book> books;

            public LibraryIterator(List<Book> books)
            {
                this.Reset();
                this.books = books;
            }
            public Book Current => books[index];

            object IEnumerator.Current => throw new System.NotImplementedException();

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                index++;

                if (index < books.Count)
                {
                    return true;
                }

                return false;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
