using System;

namespace _7.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string another = ReturnsNewString(name, n);
            Console.WriteLine(another);
        }

        public static string ReturnsNewString(string name,int n)
        {
            string newString = string.Empty;

            for(int i = 0; i < n; i++)
            {
                newString += name;
            }
            return newString;
        }
    }
}
