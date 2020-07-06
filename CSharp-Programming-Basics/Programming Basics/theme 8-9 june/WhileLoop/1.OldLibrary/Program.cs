using System;

namespace _1.OldLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int numBooks = int.Parse(Console.ReadLine());

            int count = 0;
            int bookCount = 0;

            bool isHere = false;

            while (count < numBooks)
            {
                string nextBook = Console.ReadLine();
                if(nextBook == book)
                {
                    isHere = true;
                    break;
                }
                
                count++;
                bookCount++;
            }
            if(isHere == false)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine("You checked {0} books.", numBooks);
            }
            if (isHere)
            {
                Console.WriteLine("You checked {0} books and found it.", bookCount);
            }
        }
    }
}
