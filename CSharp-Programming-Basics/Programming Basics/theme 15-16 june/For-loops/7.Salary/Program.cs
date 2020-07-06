using System;

namespace _7.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int restSalary = salary;

            for(int i = 0; i < openTabs; i++)
            {
                string website = Console.ReadLine();

                if(website == "Facebook")
                {
                    restSalary -= 150;
                }
                else if (website == "Instagram")
                {
                    restSalary -= 100;
                }
                else if (website == "Reddit")
                {
                    restSalary -= 50;
                }

                if (restSalary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (restSalary > 0)
            {
                Console.WriteLine($"{restSalary}");
            }
        }
    }
}
