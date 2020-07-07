using System;

namespace WorkshopDemo
{
    class StartUp
    {
        static void Main(string[] args)
        {
            MyList list = new MyList(2);
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Add(60);


            //int num = list.RemoveAt(2);
            //int num1 = list.RemoveAt(4);
            list.Insert(1, 500);
            Console.WriteLine(list.Contains(20));
            Console.WriteLine(list.Contains(100));
            Console.WriteLine(list.Count);
            Console.WriteLine(list[1]);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            MyStack stack = new MyStack(5);
            stack.Push(1);
            stack.Push(3);
            stack.Push(4);
            int item = stack.Pop();
            int other = stack.Peek();
            Console.WriteLine(item);
            Console.WriteLine(other);
        }
    }
}
