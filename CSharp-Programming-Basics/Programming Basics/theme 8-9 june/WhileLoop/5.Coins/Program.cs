using System;

namespace _5.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());

            double leva = 0;
            double coins = 0;
            int num = 0;

            coins = change % 1;
            leva = change - coins;

            while (true)
            {
                if (leva - 5 >= 0)
                {
                    leva = leva - 5;
                    num++;
                }
               if(leva - 2 >= 0)
                {
                    leva = leva - 2;
                    num++;
                }
               if(leva - 1 >= 0)
                {
                    leva = leva - 1;
                    num++;
                }
               if(coins - 0.5 >= 0)
                {
                    coins = coins - 0.5;
                    num++;
                }
               if(coins - 0.2 >= 0)
                {
                    coins = coins - 0.2;
                    num++;
                }
               if(coins - 0.1 >= 0)
                {
                    coins = coins - 0.1;
                    num++;
                }
                if (coins - 0.05 >= 0)
                {
                    coins = coins - 0.05;
                    num++;
                }
                if (coins - 0.02 >= 0)
                {
                    coins = coins - 0.02;
                    num++;
                }
                if (coins - 0.01 >= 0)
                {
                    coins = coins - 0.01;
                    num++;
                }
                if (leva + coins == 0)
                {
                    break;
                }
            }
            Console.WriteLine(num);
        }
    }
}
