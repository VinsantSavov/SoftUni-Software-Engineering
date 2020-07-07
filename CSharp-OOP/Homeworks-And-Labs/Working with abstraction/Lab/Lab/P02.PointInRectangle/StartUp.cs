using System;
using System.Linq;

namespace P02.PointInRectangle
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] coordinates = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            int topLeftX = coordinates[0];
            int topLeftY = coordinates[1];
            int bottomRightX = coordinates[2];
            int bottomRightY = coordinates[3];

            Point topLeftPoint = new Point(topLeftX, topLeftY);
            Point bottomRightPoint = new Point(bottomRightX, bottomRightY);

            if(topLeftX < bottomRightX && topLeftY < bottomRightY)
            {
                topLeftPoint = new Point(bottomRightX, bottomRightY);
                bottomRightPoint = new Point(topLeftX, topLeftY);
            }

            Rectangle rectangle = new Rectangle(topLeftPoint, bottomRightPoint);

            for (int i = 0; i < n; i++)
            {
                int[] pointCoordinates = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                Point point = new Point(pointCoordinates[0], pointCoordinates[1]);
                Console.WriteLine(rectangle.Contains(point));
            }
        }
    }
}
