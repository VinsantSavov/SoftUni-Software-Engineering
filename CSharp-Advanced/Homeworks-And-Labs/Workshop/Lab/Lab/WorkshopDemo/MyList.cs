
using System;

namespace WorkshopDemo
{
    public class MyList
    {
        private int[] data;

        public MyList()
            :this(4)
        {
        }

        public MyList(int size)
        {
            data = new int[size];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if(index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return data[index];
            }
            set
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                data[index] = value;
            }
        }


        public void Add(int number)
        {
            if(Count == data.Length)
            {
                Resize();
            }
            data[Count] = number;
            Count++;
        }

        public int RemoveAt(int index)
        {
            if (ValidIndex(index))
            {
                int result = data[index];
                for (int i = index; i < Count; i++)
                {
                    data[i] = data[i + 1];
                }
                Count--;
                return result;
            }
            else
            {
                throw new System.Exception("The index is invalid");
            }
            
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < Count; i++)
            {
                if(data[i] == element)
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if(ValidIndex(firstIndex) && ValidIndex(secondIndex))
            {
                int temp = data[firstIndex];
                data[firstIndex] = data[secondIndex];
                data[secondIndex] = temp;
            }
        }

        public void Insert(int index, int element)
        {
            if (ValidIndex(index))
            {
                if (Count + 1 >= data.Length)
                {
                    Resize();
                }

                for (int i = Count-1; i >= index; i--)
                {
                    data[i + 1] = data[i];
                }
                data[index] = element;
                Count++;
            }
            else
            {
                throw new Exception("Invalid index.");
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
