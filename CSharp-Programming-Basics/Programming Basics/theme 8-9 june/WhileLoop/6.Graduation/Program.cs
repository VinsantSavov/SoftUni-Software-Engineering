using System;

namespace _6.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int count = 0;
            double sum = 0;
            double average = 0;

            while(count < 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if(grade >= 4.00)
                {
                    sum += grade;
                    average = sum / 12;
                    count++;
                }
            }
            Console.WriteLine("{0} graduated. Average grade: {1:F2}", name,average);
        }
    }
}
