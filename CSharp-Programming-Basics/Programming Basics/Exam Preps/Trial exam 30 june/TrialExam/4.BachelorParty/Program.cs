using System;

namespace _4.BachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneySinger = int.Parse(Console.ReadLine());
            string numberOfPeople = Console.ReadLine();
            int allmoney = 0;
            int numPeople = 0;

            while(numberOfPeople!="The restaurant is full")
            {

                int people = int.Parse(numberOfPeople);
                numPeople += people;
                if (people < 5)
                {

                    allmoney += people * 100;
                }
                else if(people >= 5)
                {
                    allmoney += people * 70;
                }
                numberOfPeople = people.ToString();
                numberOfPeople = Console.ReadLine();
            }
            if (allmoney >= moneySinger)
            {
                Console.WriteLine("You have {0} guests and {1} leva left.", numPeople, allmoney-moneySinger);
            }
            else
            {
                Console.WriteLine("You have {0} guests and {1} leva income, but no singer.",numPeople,allmoney);
            }
        }
    }
}
