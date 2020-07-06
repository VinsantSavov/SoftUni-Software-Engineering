using System;

namespace _2.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            FindingVowelsInString(text);
        }

        public static void FindingVowelsInString(string text)
        {
            int vowelsCounter = 0;

            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'o' || text[i] == 'e' || text[i] == 'i' || text[i] == 'u'|| text[i] == 'A' || text[i] == 'O' || text[i] == 'E' || text[i] == 'I' || text[i] == 'U')
                {
                    vowelsCounter++;
                }
            }
            Console.WriteLine(vowelsCounter);
        }
    }
}
