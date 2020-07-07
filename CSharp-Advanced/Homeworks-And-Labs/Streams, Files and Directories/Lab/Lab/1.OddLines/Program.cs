using System;
using System.IO;

namespace _1.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("text.txt", FileMode.OpenOrCreate);
            using StreamReader reader = new StreamReader("OddLines.txt");
            using StreamWriter writer = new StreamWriter(file);
            int counter = 0;

            while (true)
            {
                string line = reader.ReadLine();

                if(line == null)
                {
                    break;
                }

                if(counter % 2 != 0)
                {
                    writer.WriteLine(line);
                }
                counter++;
            }
        }
    }
}
