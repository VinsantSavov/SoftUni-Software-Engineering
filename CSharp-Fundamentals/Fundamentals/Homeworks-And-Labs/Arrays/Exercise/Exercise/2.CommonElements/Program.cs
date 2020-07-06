using System;

namespace _2.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int k = 0; k < firstArray.Length; k++)
                {
                    if (firstArray[k] == secondArray[i])
                    {
                        Console.Write(firstArray[k]+" ");
                    }
                }
            }
        }
    }
}
