using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.TrojanInvasion
{
    public class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());
            int[] spartanInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> spartanPlates = new Queue<int>(spartanInput);
            List<int> trojansLeft = new List<int>();

            for (int i = 0; i < waves; i++)
            {
                int[] trojansInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                Stack<int> trojans = new Stack<int>(trojansInput);

                if(trojansLeft.Count > 0)
                {
                    List<int> temp = new List<int>(trojans);

                    for (int j = trojansLeft.Count-1; j >= 0; j--)
                    {
                        temp.Insert(0, trojansLeft[j]);
                    }

                    trojans = new Stack<int>(temp);
                }

                if (++i % 3 == 0)
                {
                    int extraPlate = int.Parse(Console.ReadLine());
                    spartanPlates.Enqueue(extraPlate);
                }
                i--;

                while (trojans.Count > 0 && spartanPlates.Count > 0)
                {
                    int trojan = trojans.Pop();
                    int plate = spartanPlates.Peek();

                    if(trojan > plate)
                    {
                        spartanPlates.Dequeue();
                        trojans.Push(trojan - plate);
                    }
                    else if(trojan == plate)
                    {
                        spartanPlates.Dequeue();
                    }
                    else if(trojan < plate)
                    {
                        plate = plate - trojan;
                        spartanPlates.Dequeue();
                        spartanPlates = PuttingPlateInBegining(spartanPlates, plate);
                    }
                }
                
                if(trojans.Count > 0)
                {
                    trojansLeft.AddRange(trojans);
                    trojans.Clear();
                }

                if(spartanPlates.Count <= 0)
                {
                    break;
                }
            }

            if(spartanPlates.Count > 0)
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.Write("Plates left: ");
                Console.WriteLine(string.Join(", ", spartanPlates));
            }
            else
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.Write("Warriors left: ");
                Console.WriteLine(string.Join(", ", trojansLeft));
            }

        }

        public static Queue<int> PuttingPlateInBegining(Queue<int> plates, int plate)
        {
            List<int> platesNum = new List<int>(plates);

            platesNum.Insert(0, plate);

            plates = new Queue<int>(platesNum);

            return plates;
        }
    }
}
