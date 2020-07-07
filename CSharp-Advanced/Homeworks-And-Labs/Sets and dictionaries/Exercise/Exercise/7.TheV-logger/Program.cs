using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.TheV_logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, Dictionary<string, List<string>>>();
            string followers = "followers";
            string following = "following";

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Statistics")
                {
                    break;
                }

                string[] inputInfo = input.Split().ToArray();
                string vloggerName = inputInfo[0];

                if (inputInfo.Contains("joined"))
                {
                    if (!dictionary.ContainsKey(vloggerName))
                    {
                        dictionary.Add(vloggerName, new Dictionary<string, List<string>>());
                        dictionary[vloggerName].Add(followers, new List<string>());
                        dictionary[vloggerName].Add(following, new List<string>());
                    }
                }
                else if (inputInfo.Contains("followed"))
                {
                    string vlogger = inputInfo[2];

                    if(dictionary.ContainsKey(vloggerName) 
                        && dictionary.ContainsKey(vlogger)
                        && vlogger != vloggerName 
                        && !dictionary[vloggerName][following].Contains(vlogger))
                    {
                        dictionary[vloggerName][following].Add(vlogger);
                        dictionary[vlogger][followers].Add(vloggerName);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {dictionary.Count} vloggers in its logs.");

            string mostFamous = string.Empty;
            int maxFollowers = int.MinValue;

            foreach (var kvp in dictionary)
            {
                var temp = kvp.Value;

                foreach (var (key, value) in temp)
                {
                    if(key == "followers")
                    {
                        if(value.Count > maxFollowers)
                        {
                            maxFollowers = value.Count;
                            mostFamous = kvp.Key;
                        }
                        else if(value.Count == maxFollowers)
                        {
                            if(dictionary[mostFamous][following].Count > dictionary[kvp.Key][following].Count)
                            {
                                maxFollowers = dictionary[kvp.Key][followers].Count;
                                mostFamous = kvp.Key;
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"1. {mostFamous} : {dictionary[mostFamous][followers].Count} followers, {dictionary[mostFamous][following].Count} following");

            foreach (var kvp in dictionary[mostFamous][followers].OrderBy(x=>x))
            {
                Console.WriteLine($"*  {kvp}");
            }
            dictionary.Remove(mostFamous);
            int count = 2;

            foreach (var kvp in dictionary.OrderByDescending(x=>x.Value[followers].Count).ThenBy(n=>n.Value[following].Count))
            {
                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value[followers].Count} followers, {kvp.Value[following].Count} following");
                count++;
            }
        }
    }
}
