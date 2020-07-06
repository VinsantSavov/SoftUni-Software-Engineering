using System;

namespace _9.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double allMoney = 0;
            double saber = studentCount + Math.Ceiling(studentCount * 0.1);
            double saberMoney = saber * saberPrice;

            for (int i = 1; i <= studentCount; i++)
            {
                if (i % 6 == 0)
                {
                    allMoney += robePrice;
                }
                else
                {
                    allMoney += robePrice + beltPrice;
                }
            }
            allMoney += saberMoney;

            if (money >= allMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {allMoney:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {allMoney-money:F2}lv more.");
            }
        }
    }
}
