
using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class BookEnumerator : IEnumerator<Book>
    {
        private List<Book> books;
        private int index;

        public BookEnumerator(List<Book> books)
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
            this.index = -1;
        }
    }
}
