using System;

namespace Zooshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDogs = int.Parse(Console.ReadLine());
            int rest_animals = int.Parse(Console.ReadLine());

            double dog_food = numDogs * 2.50;
            double rest_food = rest_animals * 4;

            Console.WriteLine("{0:F2} lv.", dog_food + rest_food);
        }
    }
}
