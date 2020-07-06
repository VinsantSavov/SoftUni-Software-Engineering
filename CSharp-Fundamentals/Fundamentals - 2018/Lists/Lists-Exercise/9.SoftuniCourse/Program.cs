using System;
using System.Linq;
using System.Collections.Generic;

namespace _9.SoftuniCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split(':');

                if(tokens[0]=="course start")
                {
                    break;
                }
                else if (tokens[0] == "Add")
                {
                    string title = tokens[1];
                    if (lessons.Contains(title) == false)
                    {
                        lessons.Add(title);
                    }
                }
                else if (tokens[0] == "Insert")
                {
                    string title = tokens[1];
                    int index = int.Parse(tokens[2]);

                    if (lessons.Contains(title) == false)
                    {
                        lessons.Insert(index, title);
                    }
                }
                else if (tokens[0] == "Remove")
                {
                    string title = tokens[1];
                    if (lessons.Contains(title) == true)
                    {
                        int index = lessons.IndexOf(title);
                        if(lessons.Contains($"{title}-Exercise"))
                        {
                            lessons.RemoveAt(index + 1);
                        }
                        lessons.Remove(title);
                    }
                }
                else if(tokens[0] == "Swap")
                {
                    string firstTitle = tokens[1];
                    string secondTitle = tokens[2];
                    int firstIndex = lessons.IndexOf(firstTitle);
                    int secondIndex = lessons.IndexOf(secondTitle);

                    if(firstIndex == -1 || secondIndex == -1)
                    {
                        continue;
                    }
                    else
                    {
                        lessons[firstIndex] = secondTitle;
                        lessons[secondIndex] = firstTitle;

                        if (lessons.Contains($"{firstTitle}-Exercise"))
                        {
                            lessons.RemoveAt(firstIndex + 1);
                            lessons.Insert(secondIndex + 1, $"{firstTitle}-Exercise");
                        }
                        if (lessons.Contains($"{secondTitle}-Exercise"))
                        {
                            lessons.RemoveAt(secondIndex + 1);
                            lessons.Insert(firstIndex + 1, $"{secondTitle}-Exercise");
                        }
                    }
                }
                else if (tokens[0] == "Exercise")
                {
                    string title = tokens[1];
                    int index = 0;

                    if (lessons.Contains(title) == true)
                    {
                        for(int i = 0; i < lessons.Count; i++)
                        {
                            if (title == lessons[i])
                            {
                                index = i;
                            }
                        }
                        lessons.Insert(index, title + "-Exercise");
                    }
                    else
                    {
                        lessons.Add(title);
                        lessons.Add(title + "-Exercise");
                    }
                }
            }
            for(int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i+1}.{lessons[i]}");
            }
        }
    }
}
