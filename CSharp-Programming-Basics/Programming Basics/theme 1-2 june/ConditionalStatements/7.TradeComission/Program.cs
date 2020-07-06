using System;

namespace _7.TradeComission
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            if(town == "Sofia")
            {
                if(0 <= sales && sales <= 500)
                {
                    Console.WriteLine("{0:F2}",sales * 5 / 100);
                }
                else if (500 < sales && sales <= 1000)
                {
                    Console.WriteLine("{0:F2}", sales * 7 / 100);
                }
                else if (1000 <= sales && sales <= 10000)
                {
                    Console.WriteLine("{0:F2}", sales * 8 / 100);
                }
                else if (sales > 10000)
                {
                    Console.WriteLine("{0:F2}", sales * 12 / 100);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
            {
                if (0 <= sales && sales <= 500)
                {
                    Console.WriteLine("{0:F2}", sales * 4.5 / 100);
                }
                else if (500 < sales && sales <= 1000)
                {
                    Console.WriteLine("{0:F2}", sales * 7.5 / 100);
                }
                else if (1000 <= sales && sales <= 10000)
                {
                    Console.WriteLine("{0:F2}", sales * 10 / 100);
                }
                else if (sales > 10000)
                {
                    Console.WriteLine("{0:F2}", sales * 13 / 100);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv")
            {
                if (0 <= sales && sales <= 500)
                {
                    Console.WriteLine("{0:F2}", sales * 5.5 / 100);
                }
                else if (500 < sales && sales <= 1000)
                {
                    Console.WriteLine("{0:F2}", sales * 8 / 100);
                }
                else if (1000 <= sales && sales <= 10000)
                {
                    Console.WriteLine("{0:F2}", sales * 12 / 100);
                }
                else if (sales > 10000)
                {
                    Console.WriteLine("{0:F2}", sales * 14.5 / 100);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
