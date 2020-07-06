using System;

namespace _3.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            string text = Console.ReadLine();

            while (text.Contains(word))
            {
                int index = text.IndexOf(word);
                text = text.Remove(index, word.Length);
            }

            Console.WriteLine(text);
        }
    }
}
