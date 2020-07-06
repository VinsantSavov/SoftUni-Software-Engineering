using System;

namespace _2.Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double shipWidth = double.Parse(Console.ReadLine());
            double shipLenght = double.Parse(Console.ReadLine());
            double shipHeight = double.Parse(Console.ReadLine());
            double averageHeight = double.Parse(Console.ReadLine());

            double volume = shipWidth * shipLenght * shipHeight;
            double roomVolume = 2 * 2 * (averageHeight + 0.4);

            double astronauts = Math.Floor(volume / roomVolume);

            if(astronauts >=3 && astronauts <= 10)
            {
                Console.WriteLine("The spacecraft holds {0} astronauts.",astronauts);
            }
            else if (astronauts < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (astronauts > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
