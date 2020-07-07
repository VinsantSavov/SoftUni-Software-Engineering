using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPresents = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            string[,] matrix = new string[size, size];
            int givenPresents = 0;
            bool haveToStop = false;

            for (int r = 0; r < size; r++)
            {
                string[] row = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int c = 0; c < size; c++)
                {
                    matrix[r, c] = row[c];
                }
            }

            //List<int> locationsOfNaughtyKids = ReturnAllNaughtyKids(matrix, size);
            int kidsCount = CountOfKids(matrix, size);

            while(countOfPresents > 0)
            {
                string command = Console.ReadLine();

                if(command == "Christmas morning")
                {
                    break;
                }

                if(command == "up")
                {
                    for (int r = 0; r < size; r++)
                    {
                        for (int c = 0; c < size; c++)
                        {
                            if(matrix[r,c] == "S")
                            {
                                if(r-1 >= 0)
                                {
                                    if(matrix[r-1,c] == "V")
                                    {
                                        matrix[r, c] = "-";
                                        matrix[r - 1, c] = "S";
                                        countOfPresents--;
                                        givenPresents++;
                                    }
                                    else if(matrix[r - 1, c] == "X")
                                    {
                                        matrix[r, c] = "-";
                                        matrix[r - 1, c] = "S";
                                    }
                                    else if (matrix[r - 1, c] == "-")
                                    {
                                        matrix[r, c] = "-";
                                        matrix[r - 1, c] = "S";
                                    }
                                    else if(matrix[r - 1, c] == "C")
                                    {
                                        List<int> givenPresentsWithCookie = EatingCookie(matrix, r-1, c);
                                        int allKids = givenPresentsWithCookie[0];
                                        int goodKids = givenPresentsWithCookie[1];
                                        countOfPresents -= allKids;
                                        givenPresents += goodKids;
                                        matrix[r, c] = "-";
                                    }
                                    
                                    haveToStop = true;
                                    break;
                                }
                            }
                        }
                        if (haveToStop)
                        {
                            haveToStop = false;
                            break;
                        }
                    }
                }
                else if(command == "down")
                {
                    for (int r = 0; r < size; r++)
                    {
                        for (int c = 0; c < size; c++)
                        {
                            if (matrix[r, c] == "S")
                            {
                                if (r + 1 < size)
                                {
                                    if (matrix[r + 1, c] == "V")
                                    {
                                        matrix[r, c] = "-";
                                        matrix[r + 1, c] = "S";
                                        countOfPresents--;
                                        givenPresents++;
                                    }
                                    else if (matrix[r + 1, c] == "X")
                                    {
                                        matrix[r, c] = "-";
                                        matrix[r + 1, c] = "S";
                                    }
                                    else if (matrix[r + 1, c] == "-")
                                    {
                                        matrix[r, c] = "-";
                                        matrix[r + 1, c] = "S";
                                    }
                                    else if (matrix[r + 1, c] == "C")
                                    {
                                        List<int> givenPresentsWithCookie = EatingCookie(matrix, r + 1, c);
                                        int allKids = givenPresentsWithCookie[0];
                                        int goodKids = givenPresentsWithCookie[1];
                                        countOfPresents -= allKids;
                                        givenPresents += goodKids;
                                        matrix[r, c] = "-";
                                    }
                                    
                                    haveToStop = true;
                                    break;
                                }
                            }
                        }
                        if (haveToStop)
                        {
                            haveToStop = false;
                            break;
                        }
                    }
                }
                else if(command == "left")
                {
                    for (int r = 0; r < size; r++)
                    {
                        for (int c = 0; c < size; c++)
                        {
                            if (matrix[r, c] == "S")
                            {
                                if (c - 1 >= 0)
                                {
                                    if (matrix[r, c-1] == "V")
                                    {
                                        matrix[r, c] = "-";
                                        matrix[r, c-1] = "S";
                                        countOfPresents--;
                                        givenPresents++;
                                    }
                                    else if (matrix[r, c-1] == "X")
                                    {
                                        matrix[r, c] = "-";
                                        matrix[r, c-1] = "S";
                                    }
                                    else if (matrix[r, c - 1] == "-")
                                    {
                                        matrix[r, c] = "-";
                                        matrix[r, c - 1] = "S";
                                    }
                                    else if (matrix[r, c-1] == "C")
                                    {
                                        List<int> givenPresentsWithCookie = EatingCookie(matrix, r, c-1);
                                        int allKids = givenPresentsWithCookie[0];
                                        int goodKids = givenPresentsWithCookie[1];
                                        countOfPresents -= allKids;
                                        givenPresents += goodKids;
                                        matrix[r, c] = "-";
                                    }
                                    
                                    haveToStop = true;
                                    break;
                                }
                            }
                        }
                        if (haveToStop)
                        {
                            haveToStop = false;
                            break;
                        }
                    }
                }
                else if(command == "right")
                {
                    for (int r = 0; r < size; r++)
                    {
                        for (int c = 0; c < size; c++)
                        {
                            if (matrix[r, c] == "S")
                            {
                                if (c + 1 < size)
                                {
                                    if (matrix[r, c + 1] == "V")
                                    {
                                        matrix[r, c] = "-";
                                        matrix[r, c + 1] = "S";
                                        countOfPresents--;
                                        givenPresents++;
                                    }
                                    else if (matrix[r, c + 1] == "X")
                                    {
                                        matrix[r, c] = "-";
                                        matrix[r, c + 1] = "S";
                                    }
                                    else if (matrix[r, c + 1] == "-")
                                    {
                                        matrix[r, c] = "-";
                                        matrix[r, c + 1] = "S";
                                    }
                                    else if (matrix[r, c + 1] == "C")
                                    {
                                        List<int> givenPresentsWithCookie = EatingCookie(matrix, r, c+1);
                                        int allKids = givenPresentsWithCookie[0];
                                        int goodKids = givenPresentsWithCookie[1];
                                        countOfPresents -= allKids;
                                        givenPresents += goodKids;
                                        matrix[r, c] = "-";
                                    }
                                    
                                    haveToStop = true;
                                    break;
                                }
                            }
                        }
                        if (haveToStop)
                        {
                            haveToStop = false;
                            break;
                        }
                    }
                }
            }

            //for (int i = 0; i < locationsOfNaughtyKids.Count; i+=2)
            //{
            //    int row = locationsOfNaughtyKids[i];
            //    int col = locationsOfNaughtyKids[i + 1];
            //    matrix[row, col] = "X";
            //}

            if(countOfPresents == 0)
            {
                Console.WriteLine("Santa ran out of presents!");
            }

            Print(matrix, size);

            if(CountOfKids(matrix,size) == 0)
            {
                Console.WriteLine($"Good job, Santa! {givenPresents} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {kidsCount - givenPresents} nice kid/s.");
            }
        }

        public static List<int> EatingCookie(string[,] matrix, int row, int col)
        {
            int allGivenPresents = 0;
            int toGoodKids = 0;
            List<int> givenPresents = new List<int>();

            matrix[row, col] = "S";

            if(matrix[row-1,col] == "V" || matrix[row - 1, col] == "X")
            {
                allGivenPresents++;
                if(matrix[row - 1, col] == "V")
                {
                    toGoodKids++;
                }
                matrix[row - 1, col] = "-";
            }
            if (matrix[row + 1, col] == "V" || matrix[row + 1, col] == "X")
            {
                allGivenPresents++;
                if (matrix[row + 1, col] == "V")
                {
                    toGoodKids++;
                }
                matrix[row + 1, col] = "-";
            }
            if (matrix[row, col-1] == "V" || matrix[row, col-1] == "X")
            {
                allGivenPresents++;
                if (matrix[row, col-1] == "V")
                {
                    toGoodKids++;
                }
                matrix[row, col-1] = "-";
            }
            if (matrix[row, col+1] == "V" || matrix[row, col+1] == "X")
            {
                allGivenPresents++;
                if (matrix[row, col+1] == "V")
                {
                    toGoodKids++;
                }
                matrix[row, col+1] = "-";
            }

            givenPresents.Add(allGivenPresents);
            givenPresents.Add(toGoodKids);

            return givenPresents;
        }

        //public static List<int> ReturnAllNaughtyKids(string[,] matrix, int size)
        //{
        //    List<int> locations = new List<int>();

        //    for (int r = 0; r < size; r++)
        //    {
        //        for (int c = 0; c < size; c++)
        //        {
        //            if(matrix[r,c] == "X")
        //            {
        //                locations.Add(r);
        //                locations.Add(c);
        //            }
        //        }
        //    }

        //    return locations;
        //}

        public static int CountOfKids(string[,] matrix, int size)
        {
            int count = 0;

            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    if(matrix[r,c] == "V")
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static void Print(string[,] matrix, int size)
        {
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    Console.Write(matrix[r,c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
