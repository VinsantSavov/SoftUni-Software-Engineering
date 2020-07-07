using P08.CollectionHierarchy.Contracts;
using System.Collections.Generic;

namespace P08.CollectionHierarchy.Models
{
    public class AddRemoveCollection : IAddRemoveCollection
    {
        private List<string> data;

        public AddRemoveCollection()
        {
            this.data = new List<string>();
        }

        public int Add(string item)
        {
            this.data.Insert(0, item);

            return 0;
        }

        public string Remove()
        {
            string stringToRemove = this.data[this.data.Count - 1];

            this.data.RemoveAt(this.data.Count - 1);

            return stringToRemove;
        }
    }
}
