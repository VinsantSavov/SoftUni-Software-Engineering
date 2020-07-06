using System;

namespace _8.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int volume = width * lenght * height;
            int freeMeters = 0;
            int occupiedSpace = 0;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int cartons = int.Parse(input);
                occupiedSpace += cartons;

                if (occupiedSpace > volume)
                {
                    int diffSpace = Math.Abs(occupiedSpace - volume);
                    Console.WriteLine("No more free space! You need {0} Cubic meters more.", diffSpace);
                    break;
                   
                }
                input = Console.ReadLine();
               
            }
            if (input == "Done")
            {

                freeMeters = volume - occupiedSpace;
                Console.WriteLine("{0} Cubic meters left.", freeMeters);
               
            }

        }
    }
}
