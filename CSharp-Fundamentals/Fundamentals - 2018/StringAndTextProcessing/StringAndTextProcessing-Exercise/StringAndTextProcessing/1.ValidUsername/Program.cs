using System;

namespace _1.ValidUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] username = Console.ReadLine().Split(", ");
            bool isValid = false;

            for (int i = 0; i < username.Length; i++)
            {
                string word = username[i];

                if (word.Length > 3 && word.Length < 16)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        char first = word[j];
                        if (char.IsDigit(first) == true || char.IsLetter(first) == true || first == '-' || first == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}
