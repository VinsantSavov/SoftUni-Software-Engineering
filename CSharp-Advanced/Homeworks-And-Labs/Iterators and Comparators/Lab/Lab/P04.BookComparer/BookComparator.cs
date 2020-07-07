
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book firstBook, Book secondBook)
        {
            int titleComparator = firstBook.Title.CompareTo(secondBook.Title);

            if(titleComparator == 0)
            {
                return secondBook.Year.CompareTo(firstBook.Year);
            }

            return titleComparator;
        }
    }
}
