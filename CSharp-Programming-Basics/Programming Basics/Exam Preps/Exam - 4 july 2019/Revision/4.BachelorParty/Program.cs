using System;

namespace _4.BachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int singerBudget = int.Parse(Console.ReadLine());
            string peopleNum = Console.ReadLine();
            int money = 0;
            int allPeople = 0;

            while(peopleNum != "The restaurant is full")
            {
                int people = int.Parse(peopleNum);
                allPeople += people;

                if (people < 5)
                {
                    money += people * 100;
                }
                else if(people >= 5)
                {
                    money += people * 70;
                }
                peopleNum = Console.ReadLine();
            }
            if (money >= singerBudget)
            {
                Console.WriteLine($"You have {allPeople} guests and {money-singerBudget} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {allPeople} guests and {money} leva income, but no singer.");
            }
        }
    }
}
