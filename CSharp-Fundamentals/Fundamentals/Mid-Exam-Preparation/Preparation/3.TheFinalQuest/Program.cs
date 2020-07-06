using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.TheFinalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Stop")
                {
                    break;
                }

                string[] tokens = input.Split().ToArray();
                string command = tokens[0];

                if(command == "Delete")
                {
                    int index = int.Parse(tokens[1]);

                    if(index >= -1 && index < words.Count -1)
                    {
                        words.RemoveAt(index + 1);
                    }
                }
                else if(command == "Swap")
                {
                    string wordOne = tokens[1];
                    string wordTwo = tokens[2];

                    if(words.Contains(wordOne) && words.Contains(wordTwo))
                    {
                        int first = words.IndexOf(wordOne);
                        int second = words.IndexOf(wordTwo);

                        words[first] = wordTwo;
                        words[second] = wordOne;
                    }
                }
                else if(command == "Put")
                {
                    string word = tokens[1];
                    int index = int.Parse(tokens[2]);

                    if(index > 0 && index < words.Count)
                    {
                        words.Insert(index-1, word);
                    }
                    else if(index == words.Count)
                    {
                        words.Add(word);
                    }
                }
                else if(command == "Sort")
                {
                    words.Sort();
                    words.Reverse();
                    //words = words.OrderByDescending(x=>x).ToList();
                }
                else if(command == "Replace")
                {
                    string firstWord = tokens[1];
                    string secondWord = tokens[2];

                    if (words.Contains(secondWord))
                    {
                        int index = words.IndexOf(secondWord);
                        words[index] = firstWord;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",words));
        }
    }
}
