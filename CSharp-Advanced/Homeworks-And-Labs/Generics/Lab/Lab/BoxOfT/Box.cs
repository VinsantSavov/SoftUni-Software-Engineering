
using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> box; 

        public Box()
        {
            box = new Stack<T>();
        }

        public int Count { get; private set; }

        public void Add(T element)
        {
            box.Push(element);
            this.Count++;
        }

        public T Remove()
        {
            T element = box.Pop();
            this.Count--;

            return element;
        }
    }
}
