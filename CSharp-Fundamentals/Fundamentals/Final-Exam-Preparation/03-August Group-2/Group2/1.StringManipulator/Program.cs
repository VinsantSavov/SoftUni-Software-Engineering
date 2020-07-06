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

                if(input == "Done")
                {
                    break;
                }
                string[] tokens = input.Split();
                string command = tokens[0];

                if(command == "Change")
                {
                    char ch = char.Parse(tokens[1]);
                    char replacement = char.Parse(tokens[2]);
                    text = text.Replace(ch, replacement);
                    Console.WriteLine(text);
                }
                else if(command == "Includes")
                {
                    string subString = tokens[1];

                    if (text.Contains(subString))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if(command == "End")
                {
                    string subString = tokens[1];

                    if (text.EndsWith(subString))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if(command == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if(command == "FindIndex")
                {
                    char ch = char.Parse(tokens[1]);
                    int index = text.IndexOf(ch);
                    Console.WriteLine(index);
                }else if(command == "Cut")
                {
                    int starstIndex = int.Parse(tokens[1]);
                    int len = int.Parse(tokens[2]);
                    text = text.Substring(starstIndex, len);
                    Console.WriteLine(text);
                }
            }
        }
    }
}
