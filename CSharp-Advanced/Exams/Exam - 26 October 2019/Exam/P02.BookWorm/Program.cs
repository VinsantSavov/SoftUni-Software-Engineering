using System;
using System.Linq;

namespace P02.BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int size = int.Parse(Console.ReadLine());

            string[,] matrix = new string[size, size];

            int[] playerCoordinates = GenerateMatrix(matrix, size);
            int playerRow = playerCoordinates[0];
            int playerCol = playerCoordinates[1];
            int oldRow = 0;
            int oldCol = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "end")
                {
                    break;
                }

                if(playerRow >=0 && playerRow < size && playerCol >=0 && playerCol < size)
                {
                    oldRow = playerRow;
                    oldCol = playerCol;
                }
                else
                {
                    playerRow = oldRow;
                    playerCol = oldCol;
                }
                
                matrix[oldRow, oldCol] = "-";

                if(command == "up")
                {
                    playerRow--;
                }
                else if(command == "down")
                {
                    playerRow++;
                }
                else if(command == "right")
                {
                    playerCol++;
                }
                else if(command == "left")
                {
                    playerCol--;
                }

                string newText = CheckingCoordinates(text, size, playerRow, playerCol);

                if(text != newText)
                {
                    text = newText;
                    matrix[oldRow, oldCol] = "P";
                    continue;
                }

                text = MovingPlayer(matrix, size, playerRow, playerCol, text); // playerRow, playerCol
            }

            Console.WriteLine(text);
            PrintMatrix(matrix, size);
        }

        public static int[] GenerateMatrix(string[,] matrix, int size)
        {
            int[] playerCoordinates = new int[2];

            for (int r = 0; r < size; r++)
            {
                string line = Console.ReadLine();

                for (int c = 0; c < size; c++)
                {
                    matrix[r, c] = line[c].ToString();

                    if(line[c].ToString() == "P")
                    {
                        playerCoordinates[0] = r;
                        playerCoordinates[1] = c;
                    }
                }
            }

            return playerCoordinates;
        }

        public static string CheckingCoordinates(string text, int size, int row, int col)
        {
            string newText = text;

            if(row > size - 1 || row < 0)
            {
                if(newText.Length > 0)
                {
                    newText = newText.Remove(newText.Length - 1);
                }
            }
            else if(col > size -1 || col < 0)
            {
                if (newText.Length > 0)
                {
                    newText = newText.Remove(newText.Length - 1);
                }
            }

            return newText;
        }

        public static string MovingPlayer(string[,] matrix, int size, int row, int col, string text)
        {
            string newText = text;
            
            if(matrix[row, col] != "-")
            {
                newText += matrix[row, col];
                matrix[row, col] = "P";
            }
            else if(matrix[row, col] == "-")
            {
                matrix[row, col] = "P";
            }

            return newText;
        }

        public static void PrintMatrix(string[,] matrix, int size)
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
