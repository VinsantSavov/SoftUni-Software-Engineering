using P08.CollectionHierarchy.Contracts;
using System.Collections.Generic;

namespace P08.CollectionHierarchy.Models
{
    public class MyList : IMyList
    {
        private List<string> data;

        public MyList()
        {
            this.data = new List<string>();
        }

        public int Used
        {
            get
            {
                return this.data.Count;
            }
        }

        public int Add(string item)
        {
            this.data.Insert(0, item);

            return 0;
        }

        public string Remove()
        {
            string stringToRemove = this.data[0];

            this.data.RemoveAt(0);

            return stringToRemove;
        }
    }
}
