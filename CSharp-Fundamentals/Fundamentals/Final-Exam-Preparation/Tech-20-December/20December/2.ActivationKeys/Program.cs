using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2.ActivationKeys
{
    class Program
    {
        private static object math;

        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("&").ToList();
            List<string> decryptedKeys = new List<string>();
            Regex regex = new Regex(@"[0-9A-Za-z]+");

            for (int i = 0; i < input.Count; i++)
            {
                Match match = regex.Match(input[i]);
                string decrypted = string.Empty;
                if (match.Success)
                {
                    if(input[i].Length == 16)
                    {
                        input[i] = input[i].ToUpper();
                        int count = 0;
                        for (int j = 0; j < input[i].Length; j++)
                        {
                            count++;
                            
                            if(input[i][j] >= '0' && input[i][j] <= '9')
                            {
                                decrypted += Math.Abs(int.Parse(input[i][j].ToString()) - 9);
                            }
                            else
                            {
                                decrypted += input[i][j];
                            }
                            if (count % 4 == 0 && j != input[i].Length-1)
                            {
                                decrypted += '-';
                            }
                        }
                        decryptedKeys.Add(decrypted);
                    }
                    else if (input[i].Length == 25)
                    {
                        input[i] = input[i].ToUpper();
                        int count = 0;
                        for (int j = 0; j < input[i].Length; j++)
                        {
                            count++;
                            
                            if (input[i][j] >= '0' && input[i][j] <= '9')
                            {
                                decrypted += Math.Abs(int.Parse(input[i][j].ToString()) - 9);
                            }
                            else
                            {
                                decrypted += input[i][j];
                            }
                            if (count % 5 == 0 && j != input[i].Length - 1)
                            {
                                decrypted += '-';
                            }
                        }
                        decryptedKeys.Add(decrypted);
                    }
                }
            }

            Console.WriteLine(string.Join(", ",decryptedKeys));
        }
    }
}
