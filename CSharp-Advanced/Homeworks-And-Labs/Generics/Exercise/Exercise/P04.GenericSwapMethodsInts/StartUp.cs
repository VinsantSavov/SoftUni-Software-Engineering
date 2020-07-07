using System;
using System.Linq;

namespace P04.GenericSwapMethodsInts
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SwapTwoElements<int> swapper = new SwapTwoElements<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                swapper.Add(num);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            swapper.Swap(indexes[0], indexes[1]);

            Console.WriteLine(swapper.ToString());
        }
    }
}
