using System;

namespace _6.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string text = string.Empty;

            for (int i = 0; i < input.Length-1; i++)
            {
                if(input[i] == input[i + 1])
                {
                    continue;
                }
                else
                {
                    text += input[i];
                }
            }
            text += input[input.Length - 1];

            Console.WriteLine(text);

            
        }
    }
}
