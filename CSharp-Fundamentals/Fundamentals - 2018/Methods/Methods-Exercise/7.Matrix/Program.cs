using System;

namespace _7.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            MakingAMatrix(number);
        }

        public static void MakingAMatrix(int num)
        {
            for(int i = 0; i < num; i++)
            {
                for(int j = 0; j < num; j++)
                {
                    Console.Write(num+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
