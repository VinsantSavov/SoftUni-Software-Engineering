using System;

namespace _7.Graduation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int count = 0;
            double sum = 0;
            double average = 0;

            while (count < 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4.00)
                {
                    sum += grade;
                    average = sum / 12;
                    count++;
                }
                else
                {
                    break;
                }
            }
            if (count == 12)
            {
                Console.WriteLine("{0} graduated. Average grade: {1:F2}", name, average);
            }
            else
            {
                Console.WriteLine("{0} has been excluded at {1} grade", name, count+1);
            }
        }
    }
}
