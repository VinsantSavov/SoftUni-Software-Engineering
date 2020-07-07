
using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class Library:IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
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

                if(index < books.Count)
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
