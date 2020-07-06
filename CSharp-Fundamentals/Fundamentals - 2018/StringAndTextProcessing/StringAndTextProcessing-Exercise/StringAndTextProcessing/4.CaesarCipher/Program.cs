using System;

namespace _4.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string encryptedText = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                int sym = symbol+3;
                encryptedText += (char)sym; 
            }
            Console.WriteLine(encryptedText);
        }
    }
}
