using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MessagesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> nameSent = new Dictionary<string, int>();
            Dictionary<string, int> nameReceived = new Dictionary<string, int>();
            int capacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Statistics")
                {
                    break;
                }
                string[] tokens = input.Split("=");
                string command = tokens[0];

                if(command == "Add")
                {
                    string user = tokens[1];
                    int sent = int.Parse(tokens[2]);
                    int received = int.Parse(tokens[3]);

                    if (!nameSent.ContainsKey(user))
                    {
                        nameSent.Add(user, sent);
                        nameReceived.Add(user, received);
                    }
                }
                else if(command == "Message")
                {
                    string sender = tokens[1];
                    string receiver = tokens[2];

                    if(nameSent.ContainsKey(sender) && nameSent.ContainsKey(receiver))
                    {
                        if(nameSent[sender] + 1 + nameReceived[sender] >= capacity)
                        {
                            nameSent.Remove(sender);
                            nameReceived.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }
                        else
                        {
                            nameSent[sender]++;
                        }
                        if (nameReceived[receiver] + 1 + nameSent[receiver] >= capacity)
                        {
                            nameReceived.Remove(receiver);
                            nameSent.Remove(receiver);
                            Console.WriteLine($"{receiver} reached the capacity!");
                        }
                        else
                        {
                            nameReceived[receiver]++;
                        }
                    }
                }
                else if(command == "Empty")
                {
                    string name = tokens[1];

                    if(name == "All")
                    {
                        nameSent.Clear();
                        nameReceived.Clear();
                    }
                    else if (nameSent.ContainsKey(name))
                    {
                        nameSent.Remove(name);
                        nameReceived.Remove(name);
                    }
                }

            }

            nameReceived = nameReceived.OrderByDescending(c => c.Value).ThenBy(n => n.Key).ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine($"Users count: {nameSent.Count}");
            foreach (var kvp in nameReceived)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value + nameSent[kvp.Key]}");
            }
        }
    }
}
