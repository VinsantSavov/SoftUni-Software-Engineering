using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLen = int.Parse(Console.ReadLine());
            string bestSequence = string.Empty;
            int bestSubsequence = 0;
            int indexOfBestSubsequence = 0;
            int bestSum = 0;
            int counter = 0;
            int bestCounter = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Clone them!")
                {
                    break;
                }

                string DNA = input.Replace("!", "");
                List<int> dnaSequence = DNA.Split(new[] { "0" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                int subsequence = 0;
                int bestSub = 0;
                int bestIndex = 0;
                int sum = 0;
                counter++;

                for (int i = 0; i < dnaSequence.Count; i++)
                {
                    subsequence = dnaSequence[i];
                    sum += subsequence.ToString().Length;

                    if(subsequence > bestSub)
                    {
                        bestSub = subsequence;
                    }
                }
                bestIndex = dnaSequence.IndexOf(bestSub);

                if(bestSub > bestSubsequence
                    || bestSub == bestSubsequence && indexOfBestSubsequence == bestIndex && bestSum < sum
                    || bestSub == bestSubsequence && indexOfBestSubsequence > bestIndex
                    || counter == 1)
                {
                    bestSubsequence = bestSub;
                    indexOfBestSubsequence = bestIndex;
                    bestSequence = DNA;
                    bestSum = sum;
                    bestCounter = counter;
                }

                /* if(counter == 1)
                {
                    bestSubsequence = bestSub;
                    indexOfBestSubsequence = bestIndex;
                    bestSequence = DNA;
                    bestSum = sum;
                    bestCounter = counter;
                }
                if(bestSub > bestSubsequence)
                {
                    bestSubsequence = bestSub;
                    indexOfBestSubsequence = bestIndex;
                    bestSequence = DNA;
                    bestSum = sum;
                    bestCounter = counter;
                }
                else if(bestSub == bestSubsequence)
                {
                    if(indexOfBestSubsequence == bestIndex)
                    {
                        if(bestSum > sum)
                        {
                            continue;
                        }
                        else
                        {
                            bestSequence = DNA;
                            bestSum = sum;
                            bestSubsequence = bestSub;
                            indexOfBestSubsequence = bestIndex;
                            bestCounter = counter;
                        }
                    }
                    if(indexOfBestSubsequence < bestIndex)
                    {
                        continue;
                    }
                    else
                    {
                        bestSubsequence = bestSub;
                        indexOfBestSubsequence = bestIndex;
                        bestSequence = DNA;
                        bestSum = sum;
                        bestCounter = counter;
                    }
                }*/
            }

            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            foreach (var item in bestSequence)
            {
                Console.Write(item + " ");
            }
        }
    }
}
