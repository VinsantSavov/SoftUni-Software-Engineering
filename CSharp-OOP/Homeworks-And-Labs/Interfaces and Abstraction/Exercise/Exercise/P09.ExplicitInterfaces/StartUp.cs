using P09.ExplicitInterfaces.Contracts;
using P09.ExplicitInterfaces.Models;
using System;

namespace P09.ExplicitInterfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    break;
                }

                string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                IResident resident = new Citizen(info[0], info[1], int.Parse(info[2]));
                IPerson person = new Citizen(info[0], info[1], int.Parse(info[2]));

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
            }
        }
    }
}
