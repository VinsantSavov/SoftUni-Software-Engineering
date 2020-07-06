using System;

namespace _6.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int result = RectangleArea(width, height);
            Console.WriteLine(result);
        }

        static public int RectangleArea(int width, int height)
        {
            return width * height;
        }
    }
}
