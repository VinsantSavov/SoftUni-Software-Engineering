using System;
using System.Text.RegularExpressions;

namespace _2.SongEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^[A-Z][a-z ']+:[A-Z ]+$");

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "end")
                {
                    break;
                }

                string[] tokens = input.Split(":");
                string artist = tokens[0];
                string song = tokens[1];
                Match match = regex.Match(input);

                if (match.Success)
                {
                    int key = artist.Length;
                    string encrypted = string.Empty;

                    for (int i = 0; i < input.Length; i++)
                    {
                        if(input[i] == ':')
                        {
                            encrypted += '@';
                        }
                        else if (input[i] == '\'')
                        {
                            encrypted += '\'';
                        }
                        else if (input[i] == ' ')
                        {
                            encrypted += ' ';
                        }
                        else if (input[i] + key > 122)
                        {
                            int temp = 122 - (int)input[i];
                            temp = key - temp;
                            encrypted += (char)(96 + temp);
                        }
                        else if (input[i] > 96 && input[i] + key <= 122)
                        {
                            encrypted += (char)(input[i] + key);
                        }
                        else if (input[i] + key > 90)
                        {
                            int temp = 90 - (int)input[i];
                            temp = key - temp;
                            encrypted += (char)(64 + temp);
                        }
                        else if (input[i] > 64 && input[i] + key <= 90)
                        {
                            encrypted += (char)(input[i] + key);
                        }

                    }
                    Console.WriteLine($"Successful encryption: {encrypted}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
        }
    }
}
