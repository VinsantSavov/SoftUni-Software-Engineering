using System;
using System.IO;

namespace _2.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("text.txt");
            using var writer = new StreamWriter("output.txt");

            int counter = 1;

            while (true)
            {
                string line = reader.ReadLine();

                if(line == null)
                {
                    break;
                }

                writer.WriteLine($"{counter}. {line}");
                counter++;
            }
        }
    }
}
