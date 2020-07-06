using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _8.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> line = Console.ReadLine().Split().ToList();

            while (true)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split();

                if (tokens[0] == "3:1")
                {
                    break;
                }

                if (tokens[0] == "merge")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    if(startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if(endIndex > line.Count - 1)
                    {
                        endIndex = line.Count - 1;
                    }
                    if(startIndex>line.Count-1 || endIndex < 0)
                    {
                        continue;
                    }

                    StringBuilder gh = new StringBuilder();

                    for(int i = startIndex; i < endIndex; i++)
                    {
                        string word = line[i];
                        gh.Append(word);
                    }
                    line.RemoveRange(startIndex, endIndex - startIndex + 1);
                    line.Insert(startIndex,gh.ToString());

                }
                else
                {
                    int index = int.Parse(tokens[1]);
                    int parts = int.Parse(tokens[2]);
                    List<string> newWords = new List<string>();

                    string element = line[index];
                    int partLen = element.Length / parts;

                    for (int i = 0; i < parts; i++)
                    {
                        string newWord = element.Substring(i * partLen, partLen);
                        if(i == parts - 1)
                        {
                            newWord = element.Substring(i * partLen);
                        }

                        newWords.Add(newWord);
                    }

                    line.RemoveAt(index);
                    line.InsertRange(index, newWords);
                }
                
            }
            Console.WriteLine(string.Join(" ",line));
        }
    }
}
