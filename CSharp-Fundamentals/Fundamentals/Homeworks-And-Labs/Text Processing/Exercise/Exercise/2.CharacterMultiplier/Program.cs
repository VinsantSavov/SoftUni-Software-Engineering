using System;

namespace _2.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            int result = Multiply(words[0], words[1]);

            Console.WriteLine(result);

        }

        static public int Multiply(string first, string second)
        {
            int sum = 0;
            if (first.Length > second.Length)
            {
                for (int i = 0; i < second.Length; i++)
                {
                    sum += second[i] * first[i];
                }
                for (int i = second.Length; i < first.Length; i++)
                {
                    sum += first[i];
                }
            }
            else
            {
                for (int i = 0; i < first.Length; i++)
                {
                    sum += second[i] * first[i];
                }
                for (int i = first.Length; i < second.Length; i++)
                {
                    sum += second[i];
                }
            }

            return sum;
        }
    }
}
