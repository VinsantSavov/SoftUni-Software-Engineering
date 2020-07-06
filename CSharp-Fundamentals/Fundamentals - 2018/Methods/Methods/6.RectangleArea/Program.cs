using System;

namespace _6.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int area = AreaOfRectangle(width, height);
            Console.WriteLine(area);

        }
        
        public static int AreaOfRectangle(int width,int height)
        {
            int area = width * height;
            return area;
        }
    }
}
