using System;

namespace _8.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];

                for (int j = 0; j < word.Length; j++)
                {
                    char firstLetter = word[j];
                    char lastLetter = word[word.Length - 1];

                    if (firstLetter >= 65 || firstLetter <= 90)
                    {
                        int fIndex = char.ToUpper(firstLetter) - 64;
                    }
                }
            }
        }
    }
}
