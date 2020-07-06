using System;

namespace _5.Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStart = int.Parse(Console.ReadLine());
            int numStations = int.Parse(Console.ReadLine());
            int allPeople = numStart;

            for(int i = 1; i <= numStations; i++)
            {
                int downPeople = int.Parse(Console.ReadLine());
                int increasePeople = int.Parse(Console.ReadLine());

                allPeople = allPeople - downPeople;
                allPeople = allPeople + increasePeople;
                if (i % 2 != 0)
                {
                    allPeople = allPeople  + 2;
                }
                else
                {
                    allPeople = allPeople - 2;
                }
            }
            Console.WriteLine("The final number of passengers is : {0}",allPeople);

        }
    }
}
