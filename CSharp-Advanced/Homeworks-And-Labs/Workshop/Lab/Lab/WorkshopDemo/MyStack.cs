
using System;

namespace WorkshopDemo
{
    public class MyStack
    {
        private int[] data;

        public MyStack()
            : this(4)
        {
        }

        public MyStack(int size)
        {
            data = new int[size];
        }

        public int Count { get; private set; }

        public void Push(int element)
        {
            if(Count >= data.Length)
            {
                Resize();
            }
            data[Count] = element;
            Count++;
        }

        public int Pop()
        {
            if(Count >= 1)
            {
                Count--;
                return data[Count];
            }
            else
            {
                throw new System.Exception("The stack is empty.");
            }
        }

        public int Peek()
        {
            if (Count >= 1)
            {
                return data[Count - 1];
            }
            else
            {
                throw new System.Exception("The stack is empty.");
            }
        }

        public void ForEach(Action<int> action)
        {
            for (int i = Count-1; i >= 0; i--)
            {
                action(data[i]);
            }
        }

        public void Resize()
        {
            int newSize = data.Length * 2;
            int[] newData = new int[newSize];

            for (int i = 0; i < Count; i++)
            {
                newData[i] = data[i];
            }

            data = newData;
        }

        public bool ValidIndex(int index)
        {
            if (index >= 0 && index < Count)
            {
                return true;
            }

            return false;
        }
    }
}
