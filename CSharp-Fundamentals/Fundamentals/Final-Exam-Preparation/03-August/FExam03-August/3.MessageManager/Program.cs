using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MessageManager
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            Dictionary<string, int> nameSent = new Dictionary<string, int>();
            Dictionary<string, int> nameReceived = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Statistics")
                {
                    break;
                }

                string[] tokens = input.Split('=');
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

                    if (nameSent.ContainsKey(sender) && nameSent.ContainsKey(receiver))
                    {
                        nameSent[sender]++;
                        nameReceived[receiver]++;

                        if (nameSent[sender] + nameReceived[sender] >= capacity)
                        {
                            nameSent.Remove(sender);
                            nameReceived.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }
                        if (nameReceived[receiver] + nameSent[receiver] >= capacity)
                        {
                            nameReceived.Remove(receiver);
                            nameSent.Remove(receiver);
                            Console.WriteLine($"{receiver} reached the capacity!");
                        }
                    }
                }
                else if(command == "Empty")
                {
                    string user = tokens[1];

                    if(user == "All")
                    {
                        nameSent.Clear();
                        nameReceived.Clear();
                    }
                    else
                    {
                        nameSent.Remove(user);
                        nameReceived.Remove(user);
                    }
                }
            }

            Console.WriteLine($"Users count: {nameSent.Count}");
            foreach (var user in nameReceived.OrderByDescending(x => x.Value).ThenBy(u => u.Key))
            { 
                Console.WriteLine($"{user.Key} - {user.Value + nameSent[user.Key]}");
            }
        }
    }
}
