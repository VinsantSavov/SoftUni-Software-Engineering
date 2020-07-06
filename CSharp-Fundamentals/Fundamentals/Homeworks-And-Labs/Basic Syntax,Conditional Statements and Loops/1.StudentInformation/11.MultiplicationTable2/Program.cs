using System;

namespace _11.MultiplicationTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int mul = int.Parse(Console.ReadLine());

            if (mul > 10)
            {
                Console.WriteLine($"{num} X {mul} = {num*mul}");
            }
            else
            {
                for (int i = mul; i <= 10; i++)
                {
                    Console.WriteLine($"{num} X {i} = {num*i}");
                }
            }
        }
    }
}
