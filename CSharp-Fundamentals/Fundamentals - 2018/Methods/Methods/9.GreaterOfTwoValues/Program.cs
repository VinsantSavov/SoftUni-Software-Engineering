using System;

namespace _9.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int result = GreaterInt();
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char result = GreaterChar();
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                string result = GreaterString();
                Console.WriteLine(result);
            }

        }

        public static int GreaterInt()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }

        public static char GreaterChar()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            if (firstChar > secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

        public static string GreaterString()
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            int comparison = String.Compare(firstString, secondString);

            if (comparison > 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }
    }
}
