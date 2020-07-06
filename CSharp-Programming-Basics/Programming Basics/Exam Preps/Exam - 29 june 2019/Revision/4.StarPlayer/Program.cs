using System;

namespace _4.StarPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            string starPlayer = string.Empty;
            int maxGoals = 0;


            while (playerName != "END")
            {
                int goals = int.Parse(Console.ReadLine());

                if (goals > maxGoals)
                {
                    maxGoals = goals;
                    starPlayer = playerName;
                }
                if (maxGoals >= 10)
                {
                    break;
                }
                playerName = Console.ReadLine();
            }
            if (maxGoals >= 3)
            {
                Console.WriteLine($"{starPlayer} is the best player!");
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"{starPlayer} is the best player!");
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
        }
    }
}
