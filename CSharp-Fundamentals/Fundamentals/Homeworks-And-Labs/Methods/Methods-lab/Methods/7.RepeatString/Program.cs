using System;
using System.Text;

namespace _7.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            StringBuilder newString = NewString(text, count);

            Console.WriteLine(newString);
        }

        static public StringBuilder NewString(string text, int count)
        {
            StringBuilder newString = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                newString.Append(text);
            }

            return newString;
        }

    }
}
