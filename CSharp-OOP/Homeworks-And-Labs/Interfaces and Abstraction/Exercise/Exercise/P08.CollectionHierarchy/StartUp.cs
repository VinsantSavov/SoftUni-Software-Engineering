using P08.CollectionHierarchy.Contracts;
using P08.CollectionHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.CollectionHierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IAddRemoveCollection myList = new MyList();
            IAddCollection addCollection = new AddCollection();
            IAddRemoveCollection addRemoveCollection = new AddRemoveCollection();

            string[] firstInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            int removeOperations = int.Parse(Console.ReadLine());

            PrintAddOperation(addCollection, firstInput);
            PrintAddOperation(addRemoveCollection, firstInput);
            PrintAddOperation(myList, firstInput);

            PrintRemoveOperation(addRemoveCollection, removeOperations);
            PrintRemoveOperation(myList, removeOperations);
        }

        public static void PrintAddOperation(IAddCollection collection, string[] firstInput)
        {
            List<int> output = new List<int>();

            foreach (var word in firstInput)
            {
                output.Add(collection.Add(word));
            }

            Console.WriteLine(string.Join(" ", output));
        }

        public static void PrintRemoveOperation(IAddRemoveCollection collection, int removeOperations)
        {
            List<string> output = new List<string>();

            for (int i = 0; i < removeOperations; i++)
            {
                output.Add(collection.Remove());
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
