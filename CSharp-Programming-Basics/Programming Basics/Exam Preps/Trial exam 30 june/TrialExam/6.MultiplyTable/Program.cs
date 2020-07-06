using System;

namespace _6.MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int numOne = 0;
            int numTwo = 0;
            int numThree = 0;
            int result = 0;

            for(int i = 0; i < 3 ; i++)
            {
                char symbol = number[i];

                if (i == 0)
                {
                    numOne = int.Parse(symbol.ToString());
                }
                else if (i == 1)
                {
                    numTwo = int.Parse(symbol.ToString());
                }
                else if (i == 2)
                {
                    numThree = int.Parse(symbol.ToString());
                }
                

            }

            for (int k = 1; k <= numThree; k++)
            {
                for (int l = 1; l <= numTwo; l++)
                {
                    for (int m = 1; m <= numOne; m++)
                    {
                        result = m * l * k;
                        Console.WriteLine($"{k} * {l} * {m} = {result};");
                    }
                }
            }
        }
    }
}
