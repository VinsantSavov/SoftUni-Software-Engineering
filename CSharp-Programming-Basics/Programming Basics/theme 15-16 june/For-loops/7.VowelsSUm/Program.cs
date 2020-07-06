using System;

namespace _7.VowelsSUm
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int stringLength = text.Length;
            int sum = 0;

            for(int i = 0; text[i] < stringLength; i++)
            {
                if (text[i] == 'a')
                {
                    sum += 1;
                }
                else if (text[i] == 'e')
                {
                    sum += 2;
                }
                else if (text[i] == 'i')
                {
                    sum += 3;
                }
                else if (text[i] == 'o')
                {
                    sum += 4;
                }
                else if (text[i] == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
