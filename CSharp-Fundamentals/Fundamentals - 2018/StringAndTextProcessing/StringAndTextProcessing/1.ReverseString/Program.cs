using System;

namespace _1.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string word = Console.ReadLine();

                if (word == "end")
                {
                    break;
                }

                string reversedWord = string.Empty;

                for(int i = word.Length-1; i >= 0; i--)
                {
                    reversedWord += word[i];
                }
                Console.WriteLine($"{word} = {reversedWord}");

            }
        }
    }
}
