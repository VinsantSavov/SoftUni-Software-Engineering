using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P03.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> data;

        public Stack()
        {
            this.data = new List<T>();
        }

        public void Push(List<T> collection)
        {
            this.data.AddRange(collection);
        }

        public T Pop()
        {

                T element = data.Last();
                data.Remove(element);

                return element;

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = data.Count - 1; i >= 0; i--)
            {
                yield return data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
