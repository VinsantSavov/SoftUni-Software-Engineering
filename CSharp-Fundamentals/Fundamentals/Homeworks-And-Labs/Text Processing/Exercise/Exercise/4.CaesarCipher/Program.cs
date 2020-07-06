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
                int symbol = text[i] + 3;
                encryptedText += (char)symbol;
            }

            Console.WriteLine(encryptedText);
        }
    }
}
