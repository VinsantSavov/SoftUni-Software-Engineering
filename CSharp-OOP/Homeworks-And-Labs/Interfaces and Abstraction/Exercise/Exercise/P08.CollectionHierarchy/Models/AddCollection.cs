using P08.CollectionHierarchy.Contracts;
using System.Collections.Generic;

namespace P08.CollectionHierarchy.Models
{
    public class AddCollection : IAddCollection
    {
        private List<string> collection;
        
        public AddCollection()
        {
            this.collection = new List<string>();
        }

        public int Add(string item)
        {
            this.collection.Add(item);

            return this.collection.Count-1;
        }
    }
}
