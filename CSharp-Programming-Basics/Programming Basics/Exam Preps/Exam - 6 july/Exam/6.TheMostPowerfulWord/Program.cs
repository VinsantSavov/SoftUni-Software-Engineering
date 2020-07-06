using System;

namespace _6.TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            bool isA = false;
            double bestWord = 0;
            string powerfulWord = string.Empty;


            while(word != "End of words")
            {
                int wordLen = word.Length;
                double allPoints = 0;
                double endingPoints = 0;

                for(int i = 0; i < wordLen; i++)
                {
                    int points = word[i];
                    allPoints += points;

                    if (i == wordLen && (points == 'a' || points == 'e' || points == 'i' || points == 'o' || points == 'u' || points == 'y'))
                    {
                        isA = true;
                    }
                    else if(i == wordLen && (points == 'A' || points == 'E' || points == 'I' || points == 'O' || points == 'U' || points == 'Y'))
                    {
                        isA = true;
                    }
                }
                if (isA == true)
                {
                    endingPoints = Math.Floor(allPoints * word.Length);
                }
                else
                {
                    endingPoints = Math.Floor((double)(allPoints / word.Length));
                }

                if (endingPoints > bestWord)
                {
                    bestWord = endingPoints;
                    powerfulWord = word;
                }
                word = Console.ReadLine();
            }
            Console.WriteLine($"The most powerful word is {powerfulWord} - {bestWord}");
        }
    }
}
