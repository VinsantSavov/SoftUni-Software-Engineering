using System;

namespace P02.Collection
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] create = Console.ReadLine().Split(new[] { "Create", " " }, StringSplitOptions.RemoveEmptyEntries);

            ListyIterator<string> listyIterator = new ListyIterator<string>(create);

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                if (command == "HasNext")
                {
                    bool hasNext = listyIterator.HasNext();

                    Console.WriteLine(hasNext);
                }
                else if (command == "Move")
                {
                    bool canMove = listyIterator.Move();

                    Console.WriteLine(canMove);
                }
                else if (command == "Print")
                {
                    listyIterator.Print();
                }
                else if(command == "PrintAll")
                {
                    Console.WriteLine(string.Join(" ", listyIterator.PrintAll()));
                }
            }
        }
    }
}
