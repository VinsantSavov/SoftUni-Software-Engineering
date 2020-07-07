
using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.ListyIterator
{
    public class ListyIterator<T>
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
            if(index+1 < data.Count)
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if(index + 1 < data.Count)
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
    }
}
