using System;

namespace _7.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double marks = 0;
            double allAverage = 0;
            int counter = 0;

            while (presentation != "Finish")
            {
                double averageMark = 0;

                for (int i = 0; i < jury; i++)
                {
                    marks = double.Parse(Console.ReadLine());
                    averageMark += marks;
                }
                averageMark = averageMark / jury;
                allAverage += averageMark;
                Console.WriteLine($"{presentation} - {averageMark:F2}.");
                counter++;
                presentation = Console.ReadLine();
            }
            Console.WriteLine("Student's final assessment is {0:F2}.", allAverage / counter);
        }
    }
}
