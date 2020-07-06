using System;

namespace _1.SpringVacationTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            double fuelPerKilometer = double.Parse(Console.ReadLine());
            double foodExpensesPerperson = double.Parse(Console.ReadLine());
            double roomPriceOneNightonePerson = double.Parse(Console.ReadLine());

            double allFoodExpense = foodExpensesPerperson * peopleCount * days;
            double roomExpenses = 0;
            if(peopleCount > 10)
            {
                roomExpenses = roomPriceOneNightonePerson * peopleCount * days  - (roomPriceOneNightonePerson * peopleCount * days * 0.25);
            }
            else
            {
                roomExpenses = roomPriceOneNightonePerson * peopleCount * days;
            }
            bool isEnough = true;

            double expenses = allFoodExpense+roomExpenses;

            for (int i = 1; i <= days; i++)
            {
                double distance = double.Parse(Console.ReadLine());
                double fuelExpenses = distance * fuelPerKilometer;
                expenses += fuelExpenses;

                if(i % 3 == 0 || i % 5 == 0)
                {
                    expenses += expenses * 0.4;
                }
                if (i % 7 == 0)
                {
                    expenses -= expenses / peopleCount;
                }
                if (expenses > budget)
                {
                    isEnough = false;
                    Console.WriteLine($"Not enough money to continue the trip. You need {expenses - budget:F2}$ more.");
                    break;
                }

            }

            if (isEnough)
            {
                Console.WriteLine($"You have reached the destination. You have {(budget - expenses):F2}$ budget left.");
            }
        }
    }
}
