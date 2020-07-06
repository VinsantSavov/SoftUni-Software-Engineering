using System;

namespace _6.BithdayCake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int cakeSize = width * lenght;
            int allSlices = 0;

            bool isOver = false;

            string input = Console.ReadLine();

            while(input != "STOP")
            {
                int slicesNumber = int.Parse(input);
                allSlices += slicesNumber;

                if(allSlices > cakeSize)
                {
                    isOver = true;
                    break;
                }

                input = Console.ReadLine();
            }

            if (isOver)
            {
                Console.WriteLine("No more cake left! You need {0} pieces more.", allSlices - cakeSize);
            }
            else
            {
                Console.WriteLine("{0} pieces are left.", cakeSize - allSlices);
            }
        }
    }
}
