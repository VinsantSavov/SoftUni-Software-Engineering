using System;
using System.Linq;
using System.Numerics;

namespace _5.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            BigInteger result = firstNum * secondNum;

            Console.WriteLine(result);
            
        }
    }
}
