using System;
using System.Linq;

namespace _9.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int MAXSequence = 0;
            int indexOfSequence = 0;
            int otherIndex = 0;
            int counter = 0;
            int biggestCounter = 0;
            int maxSum = 0;
            string bestSequence = string.Empty;

            while (true)
            {
                string input = Console.ReadLine();
                int sum = 0;
                int biggestSequence = 0;
                counter++;

                if (input=="Clone them!")
                {
                    break;
                }
                string dna = input.Replace("!", "");
                string[] sequence = dna.Split(new[] { '0' } ,StringSplitOptions.RemoveEmptyEntries);

                foreach (var longestOnes in sequence)
                {
                    int len = longestOnes.Length;
                    int index = Array.IndexOf(sequence, longestOnes);
                    if(len > biggestSequence)
                    {
                        biggestSequence = len;
                        indexOfSequence = index;
                    }
                    
                    sum += len;
                }
                if(biggestSequence>MAXSequence 
                    || biggestSequence==MAXSequence && indexOfSequence < otherIndex
                    || biggestSequence == MAXSequence && otherIndex == indexOfSequence && sum > maxSum
                    || counter == 1)
                {
                    MAXSequence = biggestSequence;
                    maxSum = sum;
                    otherIndex = indexOfSequence;
                    biggestCounter = counter;
                    bestSequence = dna;
                }

            }
            char[] arrRes = bestSequence.ToCharArray();
            Console.WriteLine($"Best DNA sample {biggestCounter} with sum: {maxSum}.");
            Console.WriteLine(string.Join(" ",arrRes));
        }
    }
}
