using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.ContactList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();
                string command = tokens[0];

                if(command == "Add")
                {
                    string contact = tokens[1];
                    int index = int.Parse(tokens[2]);

                    if(index >= 0 && index < contacts.Count)
                    {
                        if (contacts.Contains(contact))
                        {
                            contacts.Insert(index, contact);
                        }
                        else
                        {
                            contacts.Add(contact);
                        }
                    }

                }
                else if(command == "Remove")
                {
                    int index = int.Parse(tokens[1]);

                    if(index >= 0 && index < contacts.Count)
                    {
                        contacts.RemoveAt(index);
                    }
                }
                else if(command == "Export")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int count = int.Parse(tokens[2]);

                    if(startIndex >= 0 && startIndex < contacts.Count)
                    {
                        if(count > contacts.Count-startIndex)
                        {
                            count = contacts.Count-startIndex;
                            for (int i = startIndex; i < startIndex+count; i++)
                            {
                                Console.Write(contacts[i] + " ");
                            }
                        }
                        else
                        {
                            for (int i = startIndex; i < startIndex + count; i++)
                            {
                                Console.Write(contacts[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else if(command == "Print")
                {
                    Console.Write("Contacts: ");

                    if (tokens[1] == "Normal")
                    {
                        Console.WriteLine(string.Join(" ", contacts));
                        break;
                    }
                    else
                    {
                        contacts.Reverse();
                        foreach (var contact in contacts)
                        {
                            Console.Write(contact + " ");
                        }
                        break;
                    }
                }
            }
        }
    }
}
