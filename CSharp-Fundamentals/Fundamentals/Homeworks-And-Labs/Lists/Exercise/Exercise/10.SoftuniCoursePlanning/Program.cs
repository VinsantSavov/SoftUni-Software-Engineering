using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftuniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "course start")
                {
                    break;
                }

                List<string> commands = input.Split(":").ToList();

                if (commands[0] == "Add")
                {
                    string title = commands[1];
                    if (!schedule.Contains(title))
                    {
                        schedule.Add(title);
                    }
                }
                else if (commands[0] == "Insert")
                {
                    string title = commands[1];
                    int index = int.Parse(commands[2]);
                    if (!schedule.Contains(title))
                    {
                        schedule.Insert(index, title);
                    }
                }
                else if (commands[0] == "Remove")
                {
                    string title = commands[1];
                    string exercise = title + "-Exercise";

                    if (schedule.Contains(title) && schedule.Contains(exercise))
                    {
                        schedule.Remove(title);
                        schedule.Remove(exercise);
                    }
                    else if (schedule.Contains(title))
                    {
                        schedule.Remove(title);
                    }
                }
                else if(commands[0] == "Swap")
                {
                    string firstTitle = commands[1];
                    string secondTitle = commands[2];
                    string firstExercise = firstTitle + "-Exercise";
                    string secondExercise = secondTitle + "-Exercise";

                    if (schedule.Contains(firstTitle) && schedule.Contains(secondTitle) && !schedule.Contains(firstExercise) && !schedule.Contains(secondExercise))
                    {
                        int first = schedule.IndexOf(firstTitle);
                        int second = schedule.IndexOf(secondTitle);
                        schedule[first] = secondTitle;
                        schedule[second] = firstTitle;
                    }
                    else if (schedule.Contains(firstTitle) && schedule.Contains(secondTitle) && schedule.Contains(firstExercise) && !schedule.Contains(secondExercise))
                    {
                        int first = schedule.IndexOf(firstTitle);
                        int second = schedule.IndexOf(secondTitle);
                        int firstIn = schedule.IndexOf(firstExercise);
                        schedule[first] = secondTitle;
                        schedule[second] = firstTitle;
                        schedule.Insert(second + 1, firstExercise);
                        schedule.RemoveAt(firstIn);
                    }
                    else if (schedule.Contains(firstTitle) && schedule.Contains(secondTitle) && !schedule.Contains(firstExercise) && schedule.Contains(secondExercise))
                    {
                        int first = schedule.IndexOf(firstTitle);
                        int second = schedule.IndexOf(secondTitle);
                        int secondIn = schedule.IndexOf(secondExercise);
                        schedule[first] = secondTitle;
                        schedule[second] = firstTitle;
                        schedule.Insert(first + 1, secondExercise);
                        schedule.RemoveAt(secondIn);
                    }
                    else if (schedule.Contains(firstTitle) && schedule.Contains(secondTitle) && schedule.Contains(firstExercise) && schedule.Contains(secondExercise))
                    {
                        int first = schedule.IndexOf(firstTitle);
                        int second = schedule.IndexOf(secondTitle);
                        int firstIn = schedule.IndexOf(firstExercise);
                        int secondIn = schedule.IndexOf(secondExercise);
                        schedule[first] = secondTitle;
                        schedule[second] = firstTitle;
                        schedule.Insert(first + 1, secondExercise);
                        schedule.Insert(second + 1, firstExercise);
                        schedule.RemoveAt(secondIn);
                        schedule.RemoveAt(firstIn);
                    }

                }
                else if (commands[0] == "Exercise")
                {
                    string title = commands[1];
                    string exercise = title + "-Exercise";

                    if (schedule.Contains(title))
                    {
                        int index = schedule.IndexOf(title);
                        schedule.Insert(index + 1, exercise);
                    }
                    else
                    {
                        schedule.Add(title);
                        schedule.Add(exercise);
                    }
                }
            }

            int num = 1;

            foreach (var lesson in schedule)
            {
                Console.WriteLine($"{num}.{lesson}");
                num++;
            }
        }
    }
}
