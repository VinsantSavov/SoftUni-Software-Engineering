using System;
using System.Text.RegularExpressions;

namespace _2.SongEnctyption
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Regex artistRegex = new Regex(@"[A-Z][a-z ']+");
            Regex songRegex = new Regex(@"[A-Z ]+");*/
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

                //Match artMatch = artistRegex.Match(artist);
                //Match songMatch = songRegex.Match(song);
                Match match = regex.Match(input);
                
                if(match.Success)
                {
                    int key = artist.Length;
                    string encrypted = String.Empty;

                    foreach (var letter in input)
                    {

                        if (letter != ' ' && letter != '\'' && letter != ':')
                        {
                            if (letter + key > 122)
                            {
                                int res = 122 - (int)letter;
                                res = key - res;
                                char sym = (char)(96 + res);
                                encrypted += sym;
                            }
                            else if (letter > 96 && letter + key <= 122)
                            {
                                encrypted += (char)(letter + key);
                            }
                            else if (letter + key > 90)
                            {
                                int res = 90 - (int)letter;
                                res = key - res;
                                char sym = (char)(64 + res);
                                encrypted += sym;
                            }
                            else if(letter > 64 && letter + key <= 90)
                            {
                                encrypted += (char)(letter + key);
                            }
                        }
                        else if(letter == ':')
                        {
                            encrypted += '@';
                        }
                        else if(letter == ' ')
                        {
                            encrypted += ' ';
                        }
                        else if(letter == '\'')
                        {
                            encrypted += '\'';
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
