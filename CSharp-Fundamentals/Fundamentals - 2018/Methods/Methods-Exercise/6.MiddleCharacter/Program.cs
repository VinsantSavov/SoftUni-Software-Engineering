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

        public static void MiddleChar(string text)
        {
            int middle = text.Length / 2;

            for(int i = 0; i < text.Length; i++)
            {
                if (text.Length % 2 == 0)
                {
                    if (i == middle)
                    {
                        Console.Write(text[i - 1]);
                        Console.Write(text[i]);
                        
                    }
                }
                else if (i == middle)
                {
                    Console.WriteLine(text[i]);
                }
                
            }
        }
    }
}
