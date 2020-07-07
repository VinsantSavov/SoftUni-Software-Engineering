using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = new List<string>(authors);
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public int CompareTo(Book other)
        {
            int yearComparison = this.Year.CompareTo(other.Year);

            if (yearComparison == 0)
            {
                return this.Title.CompareTo(other.Title);
            }

            return yearComparison;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
