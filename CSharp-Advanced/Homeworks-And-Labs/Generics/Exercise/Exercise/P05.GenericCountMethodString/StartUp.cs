using System;

namespace P05.GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Elements<string> elements = new Elements<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                elements.Add(input);
            }

            string element = Console.ReadLine();

            int count = elements.Comparator(element);

            Console.WriteLine(count);
        }
    }
}
