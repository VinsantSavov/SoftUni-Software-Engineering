using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.SpaceStationEstablishment
{
    public class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[,] matrix = new string[size, size];
            int[] shipCoordinates = GenerateMatrix(matrix, size);
            List<int> coordinates = FindingBlackHoles(matrix, size);
            int starPower = 0;
            bool isGone = false;
            int firstHoleRow = 0;
            int firstHoleCol = 0;
            int secondHoleRow = 0;
            int secondHoleCol = 0;

            int shipRow = shipCoordinates[0];
            int shipCol = shipCoordinates[1];

            if (coordinates.Any())
            {
                 firstHoleRow = coordinates[0];
                 firstHoleCol = coordinates[1];
                 secondHoleRow = coordinates[2];
                 secondHoleCol = coordinates[3];
            }

            while(shipRow >= 0 && shipRow < size && shipCol >= 0 && shipCol < size && starPower < 50)
            {
                string command = Console.ReadLine();

                if(command == "up")
                {
                    if(shipRow -1 >= 0)
                    {
                        shipRow--;
                        if(matrix[shipRow, shipCol] != "-" && matrix[shipRow, shipCol] != "O")
                        {
                            starPower += int.Parse(matrix[shipRow, shipCol]);
                            matrix[shipRow, shipCol] = "S";
                            matrix[shipRow + 1, shipCol] = "-";
                        }
                        else if(matrix[shipRow, shipCol] == "-")
                        {
                            matrix[shipRow, shipCol] = "S";
                            matrix[shipRow + 1, shipCol] = "-";
                        }
                        else if(matrix[shipRow, shipCol] == "O")
                        {
                            matrix[firstHoleRow, firstHoleCol] = "-";
                            matrix[secondHoleRow, secondHoleCol] = "S";
                            matrix[shipRow + 1, shipCol] = "-";
                            shipRow = secondHoleRow;
                            shipCol = secondHoleCol;
                        }
                    }
                    else
                    {
                        matrix[shipRow, shipCol] = "-";
                        isGone = true;
                        break;
                    }
                }
                else if(command == "down")
                {
                    if (shipRow + 1 <= size-1)
                    {
                        shipRow++;
                        if (matrix[shipRow, shipCol] != "-" && matrix[shipRow, shipCol] != "O")
                        {
                            starPower += int.Parse(matrix[shipRow, shipCol]);
                            matrix[shipRow, shipCol] = "S";
                            matrix[shipRow - 1, shipCol] = "-";
                        }
                        else if (matrix[shipRow, shipCol] == "-")
                        {
                            matrix[shipRow, shipCol] = "S";
                            matrix[shipRow - 1, shipCol] = "-";
                        }
                        else if (matrix[shipRow, shipCol] == "O")
                        {
                            matrix[firstHoleRow, firstHoleCol] = "-";
                            matrix[secondHoleRow, secondHoleCol] = "S";
                            matrix[shipRow - 1, shipCol] = "-";
                            shipRow = secondHoleRow;
                            shipCol = secondHoleCol;
                        }
                    }
                    else
                    {
                        matrix[shipRow, shipCol] = "-";
                        isGone = true;
                        break;
                    }
                }
                else if(command == "left")
                {
                    if(shipCol -1 >= 0)
                    {
                        shipCol--;

                        if(matrix[shipRow,shipCol] != "-" && matrix[shipRow, shipCol] != "O")
                        {
                            starPower += int.Parse(matrix[shipRow, shipCol]);
                            matrix[shipRow, shipCol] = "S";
                            matrix[shipRow, shipCol + 1] = "-";
                        }
                        else if(matrix[shipRow, shipCol] == "-")
                        {
                            matrix[shipRow, shipCol] = "S";
                            matrix[shipRow, shipCol + 1] = "-";
                        }
                        else if(matrix[shipRow, shipCol] == "O")
                        {
                            matrix[secondHoleRow, secondHoleCol] = "S";
                            matrix[shipRow, shipCol] = "-";
                            matrix[shipRow, shipCol + 1] = "-";
                            shipRow = secondHoleRow;
                            shipCol = secondHoleCol;
                        }
                    }
                    else
                    {
                        matrix[shipRow, shipCol] = "-";
                        isGone = true;
                        break;
                    }
                }
                else if(command == "right")
                {
                    if (shipCol + 1 <= size -1)
                    {
                        shipCol++;

                        if (matrix[shipRow, shipCol] != "-" && matrix[shipRow, shipCol] != "O")
                        {
                            starPower += int.Parse(matrix[shipRow, shipCol]);
                            matrix[shipRow, shipCol] = "S";
                            matrix[shipRow, shipCol - 1] = "-";
                        }
                        else if (matrix[shipRow, shipCol] == "-")
                        {
                            matrix[shipRow, shipCol] = "S";
                            matrix[shipRow, shipCol - 1] = "-";
                        }
                        else if (matrix[shipRow, shipCol] == "O")
                        {
                            matrix[secondHoleRow, secondHoleCol] = "S";
                            matrix[shipRow, shipCol] = "-";
                            matrix[shipRow, shipCol - 1] = "-";
                            shipRow = secondHoleRow;
                            shipCol = secondHoleCol;
                        }
                    }
                    else
                    {
                        matrix[shipRow, shipCol] = "-";
                        isGone = true;
                        break;
                    }
                }
            }

            if (isGone)
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }
            else
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }

            Console.WriteLine($"Star power collected: {starPower}");

            Print(matrix, size);
        }

        public static int[] GenerateMatrix(string[,] matrix, int size)
        {
            int[] coordinates = new int[2];

            for (int r = 0; r < size; r++)
            {
                string line = Console.ReadLine();

                for (int c = 0; c < size; c++)
                {
                    matrix[r, c] = line[c].ToString();

                    if(line[c] == 'S')
                    {
                        coordinates[0] = r;
                        coordinates[1] = c;
                    }
                }
            }

            return coordinates;
        }

        public static List<int> FindingBlackHoles(string[,] matrix, int size)
        {
            List<int> coordinates = new List<int>();

            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    if(matrix[r,c] == "O")
                    {
                        coordinates.Add(r);
                        coordinates.Add(c);
                    }
                }
            }

            return coordinates;
        }

        public static void Print(string[,] matrix, int size)
        {
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    Console.Write(matrix[r,c]);
                }
                Console.WriteLine();
            }
        }
    }
}
