using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.SeizeTheFire
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fireCells = Console.ReadLine().Split("#").ToList();
            int water = int.Parse(Console.ReadLine());
            double effortNeeded = 0;
            List<int> puttedOutCells = new List<int>();
            double totalFire = 0;

            for (int i = 0; i < fireCells.Count; i++)
            {
                string[] fire = fireCells[i].Split(" = ").ToArray();
                string typeOfFire = fire[0];
                int cellValue = int.Parse(fire[1]);

                if(typeOfFire == "High")
                {
                    if(cellValue >= 81 && cellValue <= 125)
                    {
                        if(water >= cellValue)
                        {
                            puttedOutCells.Add(cellValue);
                            water -= cellValue;
                            effortNeeded += cellValue * 0.25;
                            totalFire += cellValue;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if(typeOfFire == "Medium")
                {
                    if(cellValue >= 51 && cellValue <= 80)
                    {
                        if (water >= cellValue)
                        {
                            puttedOutCells.Add(cellValue);
                            water -= cellValue;
                            effortNeeded += cellValue * 0.25;
                            totalFire += cellValue;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if (typeOfFire == "Low")
                {
                    if (cellValue >= 1 && cellValue <= 50)
                    {
                        if (water >= cellValue)
                        {
                            puttedOutCells.Add(cellValue);
                            water -= cellValue;
                            effortNeeded += cellValue * 0.25;
                            totalFire += cellValue;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            Console.WriteLine("Cells:");
            foreach (var cell in puttedOutCells)
            {
                Console.WriteLine($" - {cell}");
            }
            Console.WriteLine($"Effort: {effortNeeded:F2}");
            Console.WriteLine($"Total Fire: {totalFire}");

        }
    }
}
