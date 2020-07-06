using System;

namespace _4.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            for (int i = 0; i < words.Length/2; i++)
            {
                string temp = words[i];
                words[i] = words[words.Length - 1 - i];
                words[words.Length - 1 - i] = temp;
            }
            for (int j = 0; j < words.Length; j++)
            {
                Console.Write($"{words[j]} ");
            }
        }
    }
}
