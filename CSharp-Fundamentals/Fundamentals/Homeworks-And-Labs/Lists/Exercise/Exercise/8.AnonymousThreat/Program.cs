using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine().Split().ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if(line == "3:1")
                {
                    break;
                }
                List<string> input = line.Split().ToList();

                if (input[0] == "merge")
                {
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if(startIndex > strings.Count - 1)
                    {
                        continue;
                    }
                    if(endIndex > strings.Count - 1)
                    {
                        endIndex = strings.Count - 1;
                    }
                    if (endIndex < 0)
                    {
                        continue;
                    }

                    string mergedString = string.Empty;

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        mergedString += strings[i];
                    }
                    strings.RemoveRange(startIndex, endIndex - startIndex + 1);
                    strings.Insert(startIndex, mergedString);
                }
                else if(input[0] == "divide")
                {
                    int index = int.Parse(input[1]);
                    int parts = int.Parse(input[2]);
                    string element = strings[index];
                    List<string> newWords = new List<string>();
                    strings.RemoveAt(index);

                    int partLen = element.Length / parts;

                    for (int i = 0; i < parts; i++)
                    {
                        string newWord = element.Substring(i*partLen,partLen);
                        if (i == parts - 1)
                        {
                            newWord = element.Substring(i * partLen);
                        }
                        newWords.Add(newWord);
                    }

                    strings.InsertRange(index, newWords);
                }
            }
            Console.WriteLine(string.Join(" ",strings));
        }
    }
}
