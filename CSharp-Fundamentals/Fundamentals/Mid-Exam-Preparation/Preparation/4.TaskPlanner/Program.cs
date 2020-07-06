using System;
using System.Linq;

namespace _4.TaskPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hoursOfTasks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            


            while (true)
            {
                string input = Console.ReadLine();
                int countCompleted = 0;
                int countIncompleted = 0;
                int countDropped = 0;

                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split().ToArray();
                string command = tokens[0];

                if(command == "Complete")
                {
                    int index = int.Parse(tokens[1]);
                    if(index >= 0 && index < hoursOfTasks.Length)
                    {
                        hoursOfTasks[index] = 0;
                    }
                }
                else if(command == "Change")
                {
                    int index = int.Parse(tokens[1]);
                    int time = int.Parse(tokens[2]);

                    if (index >= 0 && index < hoursOfTasks.Length)
                    {
                        hoursOfTasks[index] = time;
                    }
                }
                else if(command == "Drop")
                {
                    int index = int.Parse(tokens[1]);

                    if (index >= 0 && index < hoursOfTasks.Length)
                    {
                        hoursOfTasks[index] = -1;
                    }
                }
                else if(command == "Count")
                {
                    string type = tokens[1];

                    if(type == "Completed")
                    {
                        foreach (var task in hoursOfTasks)
                        {
                            if(task == 0)
                            {
                                countCompleted++;
                            }
                        }
                        Console.WriteLine(countCompleted);
                    }
                    else if(type == "Incomplete")
                    {
                        foreach (var task in hoursOfTasks)
                        {
                            if (task > 0)
                            {
                                countIncompleted++;
                            }
                        }
                        Console.WriteLine(countIncompleted);
                    }
                    else if (type == "Dropped")
                    {
                        foreach (var task in hoursOfTasks)
                        {
                            if (task < 0)
                            {
                                countDropped++;
                            }
                        }
                        Console.WriteLine(countDropped);
                    }
                }
            }
            foreach (var task in hoursOfTasks)
            {
                if (task > 0)
                {
                    Console.Write(task + " ");
                }
            }
        }
    }
}
