using System;

namespace _4.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            for (int i = 0; i < banWords.Length; i++)
            {
                string asteriks = new string('*', banWords[i].Length);
                text = text.Replace(banWords[i], asteriks);
            }
            Console.WriteLine(text);
        }
    }
}
