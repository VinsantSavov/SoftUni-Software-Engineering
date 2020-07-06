using System;
using System.Linq;

namespace _9.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            while (true)
            {
                string dna = Console.ReadLine();
                if(dna=="Clone them!")
                {
                    break;
                }
                int[] DNA = dna.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int sum = 0;

            }
        }
    }
}
