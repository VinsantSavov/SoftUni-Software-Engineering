using System;

namespace _9.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            string text = first.ToString() + second.ToString() + third.ToString();

            Console.WriteLine(text);
        }
    }
}
