using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string firstName = string.Empty;

            Func<string, int, bool> myFunc = (name, n) => sumOfChars(name) >= n;

            foreach (var name in names)
            {
                if(myFunc(name, n))
                {
                    firstName = name;
                    break;
                }
            }

            Console.WriteLine(firstName);
        }

        public static int sumOfChars(string name)
        {
            int result = 0;

            for (int i = 0; i < name.Length; i++)
            {
                result += (int)name[i];
            }

            return result;
        }
    }
}
