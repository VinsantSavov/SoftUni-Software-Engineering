
using System.Collections.Generic;
using System.Text;

namespace P04.GenericSwapMethodsInts
{
    public class SwapTwoElements<T>
    {
        private List<T> list;

        public SwapTwoElements()
        {
            list = new List<T>();
        }

        public void Add(T element)
        {
            list.Add(element);
        }

        public void Swap(int firstIndex , int secondIndex)
        {
            ListEmpty();
            ValidIndexes(firstIndex, secondIndex);

            T temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in list)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString();
        }

        public void ValidIndexes(int first, int second)
        {
            if(first < 0 || second < 0 || first >= list.Count || second >= list.Count)
            {
                throw new System.Exception("The indexes are invalid!");
            }
        }

        public void ListEmpty()
        {
            if(list.Count < 1)
            {
                throw new System.Exception("The list is empty!");
            }
        }
    }
}
