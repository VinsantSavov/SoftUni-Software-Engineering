using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.SoftuniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var listVip = new HashSet<string>();
            var listRegular = new HashSet<string>();
            bool haveToBreak = false;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "PARTY")
                {
                    while (true)
                    {
                        string command = Console.ReadLine();

                        if(command == "END")
                        {
                            haveToBreak = true;
                            break;
                        }

                        if (listVip.Contains(command))
                        {
                            listVip.Remove(command);
                        }

                        if (listRegular.Contains(command))
                        {
                            listRegular.Remove(command);
                        }
                    }
                }
                if(input == "END" || haveToBreak)
                {
                    break;
                }

                if (char.IsDigit(input[0]))
                {
                    listVip.Add(input);
                }
                else
                {
                    listRegular.Add(input);
                }
            }

            Console.WriteLine(listVip.Count + listRegular.Count);

            if (listVip.Any())
            {
                foreach (var guest in listVip)
                {
                    Console.WriteLine(guest);
                }
            }
            foreach (var guest in listRegular)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
