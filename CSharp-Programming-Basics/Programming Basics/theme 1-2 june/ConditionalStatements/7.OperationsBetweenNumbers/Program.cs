using System;

namespace _7.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            double result = 0;

            if(operation =='+')
            {
                result = num1 + num2;
                if(result % 2 == 0)
                {
                    Console.WriteLine("{0} + {1} = {2} - even",num1,num2,result);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2} - odd", num1, num2, result);
                }
            }
            else if(operation == '-')
            {
                result = num1 - num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} - {1} = {2} - even", num1, num2, result);
                }
                else
                {
                    Console.WriteLine("{0} - {1} = {2} - odd", num1, num2, result);
                }
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} * {1} = {2} - even", num1, num2, result);
                }
                else
                {
                    Console.WriteLine("{0} * {1} = {2} - odd", num1, num2, result);
                }
            }
            else if (operation == '/')
            {
                if(num2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine("{0} / {1} = {2:F2}", num1, num2, result);
                }
                
            }
            else if(operation == '%')
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                else
                {
                    result = num1 % num2;
                    Console.WriteLine("{0} % {1} = {2}", num1, num2, result);
                }
            }
        }
    }
}
