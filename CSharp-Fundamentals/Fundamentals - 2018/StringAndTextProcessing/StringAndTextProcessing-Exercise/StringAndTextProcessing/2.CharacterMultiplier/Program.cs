using System;

namespace _2.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            int sum = 0;

            string firstWord = words[0];
            string secondWord = words[1];

            if (firstWord.Length == secondWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    char symbolFirst = firstWord[i];
                    char symbolSecond = secondWord[i];

                    sum += symbolFirst * symbolSecond;
                }
            }
            else
            {
                if (firstWord.Length > secondWord.Length)
                {
                    for (int i = 0; i < secondWord.Length; i++)
                    {
                        char symbolFirst = firstWord[i];
                        char symbolSecond = secondWord[i];

                        sum += symbolSecond * symbolFirst;
                    }
                    for (int i = secondWord.Length; i < firstWord.Length; i++)
                    {
                        char sym = firstWord[i];
                        sum += sym;
                    }
                }
                else if (secondWord.Length > firstWord.Length)
                {
                    for (int i = 0; i < firstWord.Length; i++)
                    {
                        char symbolFirst = firstWord[i];
                        char symbolSecond = secondWord[i];

                        sum += symbolSecond * symbolFirst;
                    }
                    for (int i = firstWord.Length; i < secondWord.Length; i++)
                    {
                        char sym = secondWord[i];
                        sum += sym;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
