using System;

namespace _4.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            bool firstMethod = IsLongEnough(pass);
            bool secondMethod = HasLettersAndDigits(pass);
            bool thirdMethod = HasMoreThanOneDigit(pass);

            if (firstMethod == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if(secondMethod == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if(thirdMethod == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (firstMethod && secondMethod && thirdMethod)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static public bool IsLongEnough(string pass)
        {
            bool isLong = false;

            if (pass.Length >= 6 && pass.Length <= 10)
            {
                isLong = true;
            }

            return isLong;
        }

        static public bool HasLettersAndDigits(string pass)
        {
            bool hasOnlyLettersAndDigits = false;

            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] >= 65 && pass[i] <= 90 || pass[i] >= 97 && pass[i] <= 122 || pass[i] >= 48 && pass[i] <= 57)
                {
                    hasOnlyLettersAndDigits = true;
                }
                else
                {
                    hasOnlyLettersAndDigits = false;
                    break;
                }
            }

            return hasOnlyLettersAndDigits;
        }

        static public bool HasMoreThanOneDigit(string pass)
        {
            bool atLeast2Digits = false;
            int count = 0;

            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] >= 48 && pass[i] <= 57)
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                atLeast2Digits = true;
            }

            return atLeast2Digits;

        }
    }
}
