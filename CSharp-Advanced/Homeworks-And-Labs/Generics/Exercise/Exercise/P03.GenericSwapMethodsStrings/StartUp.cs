using System;
using System.Linq;

namespace P03.GenericSwapMethodsStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SwapTwoElements<string> swapper = new SwapTwoElements<string>();

            for (int i = 0; i < n; i++)
            {
                string currString = Console.ReadLine();
                swapper.Add(currString);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            swapper.Swap(indexes[0], indexes[1]);

            Console.WriteLine(swapper.ToString());
        }
    }
}
