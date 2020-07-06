using System;

namespace _1.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            bool isValid = false;

            foreach (var username in usernames)
            {
                if(username.Length >= 3 && username.Length <= 16)
                {
                    for (int i = 0; i < username.Length; i++)
                    {
                        char sym = username[i];
                        if (char.IsDigit(sym) || char.IsLetter(sym) || sym == '-' || sym == '_')
                        {
                            if (i == username.Length - 1)
                            {
                                isValid = true;
                            }
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}
