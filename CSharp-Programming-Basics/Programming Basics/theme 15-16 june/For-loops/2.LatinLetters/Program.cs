using System;

namespace _2.LatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstLetter = 'a';
            int lastLetter = 'z';

            for(int i = firstLetter; i <= lastLetter; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
