using System;

namespace _2.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if(type == "Premiere")
            {
                Console.WriteLine("{0:F2} leva", r * c * 12);
            }
            else if(type == "Normal")
            {
                Console.WriteLine("{0:F2} leva", r * c * 7.5);
            }
            else if (type == "Discount")
            {
                Console.WriteLine("{0:F2} leva", r * c * 5);
            }
        }
    }
}
