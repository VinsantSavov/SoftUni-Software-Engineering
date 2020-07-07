using System;
using System.Collections.Generic;
using System.Linq;

namespace P11.PartyReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> invitations = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> removedPeople = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Print")
                {
                    break;
                }

                string[] commands = input.Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commands[0];
                string type = commands[1];
                string parameter = commands[2];

                Func<string, string, bool> filterFunc = GetPredicate(type, parameter);

                if (command == "Add filter")
                {
                    foreach (var person in invitations)
                    {
                        if(filterFunc(person, parameter))
                        {
                            removedPeople.Add(person);
                        }
                    }

                    invitations.RemoveAll(x=>x.)
                }
                else if(command == "Remove filter")
                {

                }
            }

        }

        static Func<string, string, bool> GetPredicate(string type, string parameter)
        {
            Func<string, string, bool> filterFunc = null;

            if (type == "Starts with")
            {
                filterFunc = (person, parameter) => person.StartsWith(parameter);
            }
            else if(type == "Ends with")
            {
                filterFunc = (person, parameter) => person.EndsWith(parameter);
            }
            else if(type == "Length")
            {
                filterFunc = (person, parameter) => person.Length == int.Parse(parameter);
            }
            else if(type == "Contains")
            {
                filterFunc = (person, parameter) => person == parameter;
            }

            return filterFunc;
        }
    }
}
