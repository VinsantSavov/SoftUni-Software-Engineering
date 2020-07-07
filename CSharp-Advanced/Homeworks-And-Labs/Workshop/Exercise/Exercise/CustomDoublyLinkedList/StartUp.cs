using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();

            for (int i = 0; i < 3; i++)
            {
                list.AddFirst(i + 1);
            }

            for (int i = 0; i < 3; i++)
            {
                list.AddLast(i + 1);
            }

            list.ForEach(n => Console.WriteLine(n));

            for (int i = 0; i < 3; i++)
            {
                list.RemoveLast();
            }

            int[] arr = list.ToArray();

            Console.WriteLine(list[0]);
        }
    }
}
