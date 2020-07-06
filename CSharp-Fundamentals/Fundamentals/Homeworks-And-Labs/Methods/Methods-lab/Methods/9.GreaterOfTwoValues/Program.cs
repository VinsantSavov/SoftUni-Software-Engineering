using System;

namespace _9.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            if(type == "int")
            {
                int first = int.Parse(firstValue);
                int second = int.Parse(secondValue);

                Console.WriteLine(MaxInt(first,second));

            }
            else if(type == "char")
            {
                char first = char.Parse(firstValue);
                char second = char.Parse(secondValue);

                Console.WriteLine(MaxChar(first,second));
            }
            else
            {
                Console.WriteLine(MaxString(firstValue,secondValue));
            }
        }

        static public int MaxInt(int firstInt, int secondInt)
        {
            if (firstInt > secondInt)
            {
                return firstInt;
            }
            else
            {
                return secondInt;
            }
        }

        static public char MaxChar(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

        static public string MaxString(string firstString, string secondString)
        {
            if (string.Compare(firstString, secondString) < 0)
            {
                return secondString;
            }
            else
            {
                return firstString;
            }
        }
    }
}
