using System;

namespace _7.NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int winner = 0;
            string winner_name = string.Empty;

            while(name != "STOP")
            {
                int sum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    sum += name[i];
                }
                if (sum > winner)
                {
                    winner = sum;
                    winner_name = name;
                }

                name = Console.ReadLine();
            }
            Console.WriteLine("Winner is {0} - {1}!", winner_name, winner);
        }
    }
}
