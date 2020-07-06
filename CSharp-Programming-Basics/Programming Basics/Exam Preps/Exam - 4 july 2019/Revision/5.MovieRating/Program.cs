using System;

namespace _5.MovieRating
{
    class Program
    {
        static void Main(string[] args)
        {
            int moviesNum = int.Parse(Console.ReadLine());
            double maxRating = 0;
            double minRating = 10;
            string topMovie = string.Empty;
            string worstMovie = string.Empty;
            double averageRating = 0;

            for(int i = 0; i < moviesNum; i++)
            {
                string name = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());

                if(rating > maxRating)
                {
                    maxRating = rating;
                    topMovie = name;
                }
                if(rating < minRating)
                {
                    minRating = rating;
                    worstMovie = name;
                }
                averageRating += rating;
            }
            Console.WriteLine($"{topMovie} is with highest rating: {maxRating:F1}");
            Console.WriteLine($"{worstMovie} is with lowest rating: {minRating:F1}");
            Console.WriteLine("Average rating: {0:F1}",averageRating/moviesNum);
        }
    }
}
