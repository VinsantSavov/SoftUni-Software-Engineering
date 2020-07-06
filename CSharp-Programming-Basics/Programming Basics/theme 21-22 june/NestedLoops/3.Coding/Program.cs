using System;

namespace _3.Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int numLen = number.Length;

           
           for (int i = numLen-1; i >= 0; i--)
           {
                char currentDigit = number[i];
                int currentDigitToNum = int.Parse(currentDigit.ToString());

                if(currentDigitToNum == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }
                for(int j = 1; j <= currentDigitToNum; j++)
                {
                    Console.Write((char)(currentDigitToNum+33));
                }
                Console.WriteLine();
           }
            
        }
    }
}


