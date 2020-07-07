using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> peopleComing = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<string, string, string, bool> myFunc = (criteria, part, person) => criteria switch
            {
                "StartsWith" => person.StartsWith(part),
                "EndsWith" => person.EndsWith(part),
                "Length" => person.Length == int.Parse(part)
            };

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Party!")
                {
                    break;
                }

                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];
                string criteria = commands[1];
                string part = commands[2];

                if(command == "Double")
                {
                    for (int i = 0; i < peopleComing.Count; i++)
                    {
                        if (myFunc(criteria, part, peopleComing[i]))
                        {
                            int counter = countOfPerson(peopleComing, peopleComing[i]);

                            for (int j = 0; j < counter; j++)
                            {
                                peopleComing.Insert(i, peopleComing[i]);
                            }
                            break;
                        }
                    }
                }
                else if(command == "Remove")
                {
                    for(int i = 0; i < peopleComing.Count; i++)
                    {
                        if (myFunc(criteria, part, peopleComing[i]))
                        {
                            peopleComing.Remove(peopleComing[i]);
                            i--;
                        }
                    }
                }
            }

            if (peopleComing.Any())
            {
                Console.Write(string.Join(", ",peopleComing));
                Console.WriteLine(" are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        public static int countOfPerson(List<string> people,string person)
        {
            int result = 0;

            foreach (var p in people)
            {
                if (p == person)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
