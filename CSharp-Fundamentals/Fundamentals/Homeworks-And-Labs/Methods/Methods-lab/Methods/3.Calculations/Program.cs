using System;

namespace _3.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                Add(firstNum, secondNum);
            }
            else if(command == "subtract")
            {
                Subtract(firstNum, secondNum);
            }
            else if(command == "multiply")
            {
                Multiply(firstNum, secondNum);
            }
            else if(command == "divide")
            {
                Divide(firstNum, secondNum);
            }

        }

        static public void Add(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum+secondNum);
        }

        static public void Subtract(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum-secondNum);
        }

        static public void Multiply(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum*secondNum);
        }

        static public void Divide(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum/secondNum);
        }


    }
}
