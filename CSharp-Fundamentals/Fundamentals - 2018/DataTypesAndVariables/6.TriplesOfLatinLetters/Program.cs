using System;

namespace _6.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 97; i < 97 + n; i++)
            {
                for(int a = 97; a <97 + n; a++)
                {
                    for(int j = 97; j < 97 + n; j++)
                    {
                        char t = (char)i;
                        char y = (char)a;
                        char u = (char)j;
                        Console.WriteLine($"{t}{y}{u}");
                    }
                }
            }
        }
    }
}
