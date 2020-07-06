using System;

namespace _2.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badMarks = int.Parse(Console.ReadLine());

            int badMarksCount = 0;
            int marksCount = 0;
            bool isBadStudent = false;
            double averageScore = 0;

            string exName = Console.ReadLine();
            string lastExName=exName;

            while (exName != "Enough")
            {
                int mark = int.Parse(Console.ReadLine());
                averageScore += mark;
                marksCount++;

                lastExName = exName;

                if (mark <= 4)
                {
                    badMarksCount++;
                }
                if(badMarksCount >= badMarks)
                {
                    isBadStudent = true;
                    break;
                }
               
                exName = Console.ReadLine();
            }
            if (isBadStudent)
            {
                Console.WriteLine("You need a break, {0} poor grades.", badMarksCount);
            }
            if(isBadStudent == false)
            {
                Console.WriteLine("Average score: {0:F2}", averageScore / marksCount);
                Console.WriteLine("Number of problems: {0}",marksCount);
                Console.WriteLine("Last problem: {0}", lastExName);
            }
        }
    }
}
