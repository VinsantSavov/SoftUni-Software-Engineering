namespace Rabbits
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Cage cage = new Cage("Wildness", 20);

            Rabbit secondRabbit = new Rabbit("Bunny", "Brazilian");
            Rabbit thirdRabbit = new Rabbit("Jumpy", "Cashmere Lop");
            Rabbit fourthRabbit = new Rabbit("Puffy", "Cashmere Lop");
            Rabbit fifthRabbit = new Rabbit("Marlin", "Brazilian");

            cage.Add(secondRabbit);
            cage.Add(thirdRabbit);
            cage.Add(fourthRabbit);
            cage.Add(fifthRabbit);

            cage.SellRabbitsBySpecies("Cashmere Lop");

            Console.WriteLine();
        }
    }
}
