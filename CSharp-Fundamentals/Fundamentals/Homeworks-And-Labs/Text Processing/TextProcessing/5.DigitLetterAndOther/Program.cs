using System;

namespace _5.DigitLetterAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string digits = string.Empty;
            string chars = string.Empty;
            string letters = string.Empty;

            /*for (int i = 0; i < input.Length; i++)
            {
                if(input[i] >= 65 && input[i] <= 90 || input[i] >= 97 && input[i] <= 122)
                {
                    letters += input[i];
                }
                else if(input[i] >= 48 && input[i] <= 57)
                {
                    digits += input[i];
                }
                else
                {
                    chars += input[i];
                }
            }*/

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                if (char.IsDigit(symbol))
                {
                    digits += symbol;
                }
                else if (char.IsLetter(symbol))
                {
                    letters += symbol;
                }
                else
                {
                    chars += symbol;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(chars);
            
        }
    }
}
