using System;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double tables_len = double.Parse(Console.ReadLine());
            double tables_width = double.Parse(Console.ReadLine());

            double cover = tables * (tables_len + 2*0.30) * (tables_width + 2*0.30);
            double square = tables * (tables_len/2) * (tables_len/2);

            double cover_cost = cover * 7;
            double square_cost = square * 9;

            double Cover_in_leva = cover_cost * 1.85;
            double Square_in_leva = square_cost * 1.85;

            Console.WriteLine("{0:F2} USD",cover_cost+square_cost);
            Console.WriteLine("{0:F2} BGN",Cover_in_leva+Square_in_leva);
            
        }
    }
}
