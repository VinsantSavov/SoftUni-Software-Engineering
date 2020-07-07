using System;
using System.Linq;

namespace P08.Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string first = firstInput[0] + " " + firstInput[1];
            string adress = firstInput[2];
            string town = string.Empty;
            for (int i = 3; i < firstInput.Length; i++)
            {
                town += firstInput[i] + " ";
            }
            Threeuple<string, string, string> firstthreeuple = new Threeuple<string, string, string>(first, adress, town);
            Console.WriteLine(firstthreeuple.ToString());

            string[] secondInput = Console.ReadLine().Split();
            string name = secondInput[0];
            int litersBeer = int.Parse(secondInput[1]);
            string info = secondInput[2];
            bool type = false;
            if(info == "drunk")
            {
                type = true;
            }
            Threeuple<string, int, bool> secondTuple = new Threeuple<string, int, bool>(name, litersBeer, type);
            Console.WriteLine(secondTuple.ToString());

            string[] thirdInput = Console.ReadLine().Split();
            string firstName = thirdInput[0];
            double balance = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];
            Threeuple<string, double, string> thirdTuple = new Threeuple<string, double, string>(firstName, balance, bankName);
            Console.WriteLine(thirdTuple.ToString());
        }
    }
}
