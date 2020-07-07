using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PartyReservationFilterModel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> invitations = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, List<string>> typeParameter = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Print")
                {
                    break;
                }

                string[] commands = input.Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commands[0];
                string type = commands[1];
                string parameter = commands[2];

                if(command == "Add filter")
                {
                    if (!typeParameter.ContainsKey(type))
                    {
                        typeParameter.Add(type, new List<string>());
                    }
                    typeParameter[type].Add(parameter);
                }
                else if(command == "Remove filter")
                {
                    typeParameter[type].Remove(parameter);
                }
            }

            foreach (var (key, value) in typeParameter)
            {
                if(key == "Contains")
                {
                    foreach (var kvp in value)
                    {
                        if (invitations.Contains(kvp))
                        {
                            invitations.Remove(kvp);
                        }
                    }
                }
                else if(key == "Starts with")
                {
                    List<string> peopleToRemove = new List<string>();

                    foreach (var person in invitations)
                    {
                        foreach (var letter in value)
                        {
                            if (person.StartsWith(letter))
                            {
                                peopleToRemove.Add(person);
                            }
                        }
                    }

                    foreach (var person in peopleToRemove)
                    {
                        invitations.Remove(person);
                    }
                }
                else if(key == "Ends with")
                {
                    List<string> peopleToRemove = new List<string>();

                    foreach (var person in invitations)
                    {
                        foreach (var letter in value)
                        {
                            if (person.EndsWith(letter))
                            {
                                peopleToRemove.Add(person);
                            }
                        }
                    }

                    foreach (var person in peopleToRemove)
                    {
                        invitations.Remove(person);
                    }
                }
                else if(key == "Length")
                {
                    List<string> peopleToRemove = new List<string>();

                    foreach (var person in invitations)
                    {
                        foreach (var length in value)
                        {
                            if(person.Length == int.Parse(length))
                            {
                                peopleToRemove.Add(person);
                            }

                        }
                    }

                    foreach (var person in peopleToRemove)
                    {
                        invitations.Remove(person);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", invitations));
        }
    }
}
