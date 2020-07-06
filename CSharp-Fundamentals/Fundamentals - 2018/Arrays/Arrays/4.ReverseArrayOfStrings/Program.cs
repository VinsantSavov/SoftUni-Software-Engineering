using System;

namespace _4.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letters = Console.ReadLine().Split();

            for(int i = 0; i < letters.Length /2; i++)
            {
                string firstLetter = letters[i];
                int lastElement = letters.Length - i - 1;
                letters[i] = letters[lastElement];
                letters[lastElement] = firstLetter;

            }
            
        }
    }
}
