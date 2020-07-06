using System;

namespace _5.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = string.Empty;
            int count = 1;

            for (int i = username.Length-1; i >= 0; i--)
            {
                pass += username[i];
            }

            while (true)
            {
                string password = Console.ReadLine();
                if (password != pass)
                {
                    if (count >= 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                    count++;
                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
            }
        }
    }
}
