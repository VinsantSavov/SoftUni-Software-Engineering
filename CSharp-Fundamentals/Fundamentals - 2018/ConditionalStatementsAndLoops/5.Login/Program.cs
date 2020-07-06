using System;

namespace _5.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            int counter = 1;
            string pass = string.Empty;
            

            for(int i = username.Length-1; i >= 0; i--)
            {
                pass += username[i];
            }
            while (password != pass)
            {
                Console.WriteLine("Incorrect password. Try again.");
                counter++;
                if(counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                password = Console.ReadLine();
            }
            if(password == pass)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
