using System;

namespace _4.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool first = CorrectNumberOfChars(password);
            bool second = ConsistingLettersAndDigits(password);
            bool third = HavingTwoDigits(password);

            if (first && second && third)
            {
                Console.WriteLine("Password is valid");
            }
        }

        public static bool CorrectNumberOfChars(string pass)
        {
            bool isCorrect = false;
            
            for(int i = 0; i < pass.Length; i++)
            {
                if(i>=6 && i <= 10)
                {
                    isCorrect = true;
                }
               
            }
            if (isCorrect == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            return isCorrect;
        }

        public static bool ConsistingLettersAndDigits(string pass)
        {
            bool isCorrect = false;

            for(int i = 0; i < pass.Length; i++)
            {
                if (!(pass[i] >= 65 && pass[i] <= 90) || !(pass[i] >= 97 && pass[i] <= 122) || !(pass[i] >= 0 && pass[i] <= 9))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    break;
                }
                else
                {
                    isCorrect = true;
                }
            }
            
            return isCorrect;
        }

        public static bool HavingTwoDigits(string pass)
        {
            bool isCorrect = false;
            int digitCounter = 0;

            for(int i = 0; i < pass.Length; i++)
            {
                if (pass[i] >= 0 && pass[i] <= 9)
                {
                    digitCounter++;
                }
            }
            if (digitCounter >= 2)
            {
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            return isCorrect;
        } 
    }
}
