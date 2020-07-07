using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallCapacity = int.Parse(Console.ReadLine());
            string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Stack<string> hallsNumbers = new Stack<string>(info);
            Stack<string> halls = new Stack<string>();

            bool beforeHall = false;
            Dictionary<string, List<int>> hallPeople = new Dictionary<string, List<int>>();

            foreach (var hallc in info)
            {
                char currHall;
                if(char.TryParse(hallc, out currHall))
                {
                    if(currHall >= 65 && currHall <= 90 || currHall >= 97 && currHall <= 122)
                    {
                        halls.Push(currHall.ToString());
                    }
                }
            }
            foreach (var hallc in halls)
            {
                hallPeople.Add(hallc, new List<int>());
            }

            string hall = halls.Pop();
            while (hallsNumbers.Count > 0)
            {
                string element = hallsNumbers.Pop();
                int people = 0;
                
                string nextHall = string.Empty;

                if (Int32.TryParse(element, out people) && beforeHall)
                {

                    if(hallPeople[hall].Sum() + people <= hallCapacity)
                    {
                        hallPeople[hall].Add(people);
                    }
                    else if(halls.Count > 0)
                    {
                        nextHall = halls.Pop();
                        if (hallPeople[nextHall].Sum() + people <= hallCapacity)
                        {
                            Console.Write($"{hall} -> ");
                            Console.WriteLine(string.Join(", ", hallPeople[hall.ToString()]));
                            hallPeople.Remove(hall);
                            hallPeople[nextHall].Add(people);
                        }
                        
                        hall = nextHall;
                    }

                }
                else if(hall == element)
                {
                    beforeHall = true;
                }
            }

            if (hallPeople.Any())
            {
                foreach (var h in hallPeople)
                {
                    Console.Write($"{h.Key} -> ");
                    Console.WriteLine(string.Join(", ", hallPeople[h.Key]));
                }
            }
        }
    }
}
