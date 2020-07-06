using System;

namespace _8.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = ReturnsNumberRaisedByPower(number, power);

            Console.WriteLine(result);
        }

        public static double ReturnsNumberRaisedByPower(int number,int power)
        {
            double result = 1;
            
            if(power>0)
            {
                for (int i = power; i > 0; i--)
                {
                    result *= number;
                }
            }
            else if (power == 0)
            {
                result = 1;
            }


            return result;
        }
    }
}
