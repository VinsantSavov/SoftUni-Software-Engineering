using System;

namespace _2.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            text = text.ToLower();

            FindsVowelsInString(text);
        }

        static public void FindsVowelsInString(string text)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'i' || text[i] == 'e' || text[i] == 'o' || text[i] == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
