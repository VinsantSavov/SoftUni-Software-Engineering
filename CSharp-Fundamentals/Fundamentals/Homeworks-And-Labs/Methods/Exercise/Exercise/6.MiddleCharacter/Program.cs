using System;

namespace _6.MiddleCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            MiddleChar(text);
        }

        static public void MiddleChar(string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.WriteLine($"{text[text.Length/2-1]}{text[text.Length/2]}");
            }
            else
            {
                Console.WriteLine(text[text.Length/2]);
            }
        }
    }
}
