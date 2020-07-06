using System;

namespace _3.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintsTheCharsInRange(firstChar, secondChar);
        }

        static public void PrintsTheCharsInRange(char first, char second)
        {
            if (first > second)
            {
                for (int i = second + 1; i < first; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = first + 1; i < second; i++)
                {
                    Console.Write((char)i + " ");
                }
                
            }

            
        }
    }
}
