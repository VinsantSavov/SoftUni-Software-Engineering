using System;

namespace _5.InvalidNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool isValid = (100 <= number && number <= 200) || number == 0;

            if(!isValid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
