using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];

            foreach (var index in ladyBugIndexes)
            {
                if (index < 0 || index > fieldSize - 1)
                {
                    continue;
                }
                field[index] = 1;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }
                 
                string[] commands = input.Split().ToArray();
                int index = int.Parse(commands[0]);
                string direction = commands[1];
                int flyLen = int.Parse(commands[2]);

                if(direction == "right")
                {
                    if (index >= 0 && index < fieldSize && field[index] == 1 && flyLen >= 0)
                    {
                        field[index] = 0;

                        while (true)
                        {
                            if(index + flyLen < fieldSize)
                            {
                                if (field[index + flyLen] == 1)
                                {
                                        
                                   index = index + flyLen;
                                }
                                else
                                {

                                   field[index + flyLen] = 1;
                                   break;
                                }
                            }
                            else
                            {

                               break;
                            }
                                    
                        }
                    }
                }
                else if (direction == "left")
                {
                    if (index >= 0 && index < fieldSize && field[index] == 1 && flyLen >= 0)
                    {
                        field[index] = 0;

                        while (true)
                        {
                            if (index - flyLen >= 0)
                            {
                                if (field[index - flyLen] == 1)
                                {

                                    index = index - flyLen;
                                }
                                else
                                {
   
                                    field[index - flyLen] = 1;
                                    break;
                                }
                            }
                            else
                            {

                                break;
                            }

                        }
                    }
                }

            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
