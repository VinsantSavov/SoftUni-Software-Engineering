using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02.Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> data;
        private int index;

        public ListyIterator(params T[] collection)
        {
            this.data = new List<T>(collection);
            index = 0;
        }

        public bool Move()
        {
            if (index + 1 < data.Count)
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (index + 1 < data.Count)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (data.Any())
            {
                Console.WriteLine(data[index]);
            }
            else
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }

        public IEnumerable<T> PrintAll()
        {
            if (data.Any())
            {
                foreach (var item in data)
                {
                    yield return item;
                }
            }
            else
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
