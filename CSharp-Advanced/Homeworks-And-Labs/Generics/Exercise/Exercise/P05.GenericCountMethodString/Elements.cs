
using System;
using System.Collections.Generic;

namespace P05.GenericCountMethodString
{
    public class Elements<T> where T : IComparable
    {
        private List<T> list;

        public Elements()
        {
            list = new List<T>();
        }

        public void Add(T element)
        {
            list.Add(element);
        }

        public int Comparator(T element)
        {
            int count = 0;

            foreach (var el in list)
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
