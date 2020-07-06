using System;

namespace _9.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string number = Console.ReadLine();

                if(number == "END")
                {
                    break;
                }

                bool isPalindrome = PalindromeNumbers(number);

                if (isPalindrome)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

            }
        }

        static public bool PalindromeNumbers(string num)
        {
            bool isPalindrome = false;

            for (int i = 0; i < num.Length/2; i++)
            {
                if (num[i] == num[num.Length - 1 - i])
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }
            
            return isPalindrome;
        }
    }
}
