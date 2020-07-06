using System;

namespace _1.StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    break;
                }

                string[] tokens = input.Split();
                string command = tokens[0];

                if(command == "Translate")
                {
                    char ch = char.Parse(tokens[1]);
                    char replacement = char.Parse(tokens[2]);
                    text = text.Replace(ch, replacement);
                    Console.WriteLine(text);
                }
                else if(command == "Includes")
                {
                    string substring = tokens[1];
                    if (text.Contains(substring) == true)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if(command == "Start")
                {
                    string substring = tokens[1];

                    if (text.StartsWith(substring) == true)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if(command == "Lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if(command == "FindIndex")
                {
                    char ch = char.Parse(tokens[1]);
                    int index = text.LastIndexOf(ch);
                    Console.WriteLine(index);
                }
                else if(command == "Remove")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int count = int.Parse(tokens[2]);

                    text = text.Remove(startIndex, count);
                    Console.WriteLine(text);
                }
            }
        }
    }
}
