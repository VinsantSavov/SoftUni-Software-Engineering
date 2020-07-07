using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace P04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> allNums;
        private List<int> oddNums;
        private List<int> evenNums;

        public Lake(List<int> numbers)
        {
            this.allNums = new List<int>(numbers);
            this.oddNums = new List<int>();
            this.evenNums = new List<int>();
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var num in allNums)
            {
                int index = allNums.IndexOf(num);
                index += 1;
                if(index % 2 == 0)
                {
                    evenNums.Add(num);
                }
                else
                {
                    oddNums.Add(num);
                }
            }
            evenNums.Reverse();
            allNums.Clear();
            allNums.AddRange(oddNums);
            allNums.AddRange(evenNums);

            foreach (var item in allNums)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
