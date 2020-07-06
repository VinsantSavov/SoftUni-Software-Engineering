using System;

namespace _3.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());

            int daysSpendingMoney = 0;
            int daysgone = 0;
            double savedMoney = currentMoney;

            bool isSpendAllMoney = false;

            while (true)
            {
                string spendOrsave = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                daysgone++;
                if (spendOrsave == "spend")
                {
                    daysSpendingMoney++;
                    if (money >= savedMoney)
                    {
                        savedMoney = 0;
                    }
                    else
                    {
                        savedMoney = savedMoney - money;
                    }
                    if (daysSpendingMoney >= 5)
                    {
                        isSpendAllMoney = true;
                        break;
                    }
                }
                
                if(spendOrsave == "save")
                {
                    savedMoney += money;
                    daysSpendingMoney = 0;
                    if (savedMoney >= neededMoney)
                    {
                        break;
                    }
                }
                
                
            }
            if (isSpendAllMoney)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine("{0}", daysgone);
            }
            if(isSpendAllMoney == false)
            {
                Console.WriteLine("You saved the money for {0} days.", daysgone);
            }
        }
    }
}
