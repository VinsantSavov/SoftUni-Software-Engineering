using System;

namespace _1.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }

                string reversedWord = string.Empty;

                for (int i = input.Length-1; i >= 0; i--)
                {
                    reversedWord += input[i];
                }

                Console.WriteLine($"{input} = {reversedWord}");
            }
        }
    }
}
