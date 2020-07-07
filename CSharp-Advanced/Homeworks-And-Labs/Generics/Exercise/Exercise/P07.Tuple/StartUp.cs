using System;

namespace P07.Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string first = firstInput[0] + " " + firstInput[1];
            Tuple<string, string> firstTuple = new Tuple<string, string>(first, firstInput[2]);
            Console.WriteLine(firstTuple.ToString());

            string[] secondInput = Console.ReadLine().Split();
            int litersBeer = int.Parse(secondInput[1]);
            Tuple<string, int> secondTuple = new Tuple<string, int>(secondInput[0], litersBeer);
            Console.WriteLine(secondTuple.ToString());

            string[] thirdInput = Console.ReadLine().Split();
            int integerNum = int.Parse(thirdInput[0]);
            double doubleNum = double.Parse(thirdInput[1]);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(integerNum, doubleNum);
            Console.WriteLine(thirdTuple.ToString());
        }
    }
}
