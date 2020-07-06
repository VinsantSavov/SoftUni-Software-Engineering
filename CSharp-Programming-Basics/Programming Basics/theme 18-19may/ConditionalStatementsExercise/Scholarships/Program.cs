using System;

namespace Scholarships
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double average = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialScholarship = 0;
            double excellentScholarship = 0;
            double maxScholar;

            excellentScholarship = Math.Floor(average * 25);
            socialScholarship = Math.Floor(minSalary * 0.35);

            if (income < minSalary && average >= 5.5)
            {
                if (excellentScholarship >= socialScholarship)
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", excellentScholarship);
                }
                else
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", socialScholarship);
                }
            }

            else if (average >= 5.5 && minSalary > income)
            {

                Console.WriteLine("You get a scholarship for excellent results {0} BGN", excellentScholarship);
            }
            else if (income < minSalary && average > 4.5 && average < 5.5)
            {

                Console.WriteLine("You get a Social scholarship {0} BGN", socialScholarship);
            }
            
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            
        }
    
    }
}
