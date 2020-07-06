using System;
using System.Text;

namespace _7.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int strenght = 0;


            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '>')
                {
                    int num = int.Parse(input[i + 1].ToString());
                    strenght += num;

                }
                else
                {
                    if (strenght > 0)
                    {
                        input = input.Remove(i, 1);
                        i--;
                        strenght--;
                    }
                }

            }

            Console.WriteLine(input);

        }
    }
}
