using System;

namespace _3.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char startingChar = char.Parse(Console.ReadLine());
            char endingChar = char.Parse(Console.ReadLine());
            BetweenChars(startingChar, endingChar);
        }

        public static void BetweenChars(char starting,char ending)
        {
            int begin = starting + 1;
            int end = ending + 1;
            if (starting < ending)
            {
                for (char i = (char)begin; i < ending; i++)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                for (char i = (char)end; i < starting; i++)
                {
                    Console.Write(i + " ");
                }
            }
            
            Console.WriteLine();
        }
    }
}
