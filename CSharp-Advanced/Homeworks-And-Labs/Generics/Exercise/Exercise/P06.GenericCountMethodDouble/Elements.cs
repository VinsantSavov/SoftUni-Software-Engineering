
using System;
using System.Collections.Generic;

namespace P06.GenericCountMethodDouble
{
    public class Elements<T> where T : IComparable
    {
        private List<T> elements;

        public Elements()
        {
            this.elements = new List<T>();
        }

        public void Add(T element)
        {
            this.elements.Add(element);
        }

        public int Comparator(T element)
        {
            int count = 0;

            foreach (var el in elements)
            {
                if(el.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
