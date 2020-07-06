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

                    Console.WriteLine(text.Contains(substring));
                }
                else if(command == "Start")
                {
                    string substring = tokens[1];
                    Console.WriteLine(text.StartsWith(substring));
                }
                else if(command == "Lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if(command == "FindIndex")
                {
                    char ch = char.Parse(tokens[1]);
                    int lastIndex = text.LastIndexOf(ch);
                    Console.WriteLine(lastIndex);
                }
                else if(command == "Remove")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int len = int.Parse(tokens[2]);

                    text = text.Remove(startIndex, len);
                    Console.WriteLine(text);
                }
            }
        }
    }
}
