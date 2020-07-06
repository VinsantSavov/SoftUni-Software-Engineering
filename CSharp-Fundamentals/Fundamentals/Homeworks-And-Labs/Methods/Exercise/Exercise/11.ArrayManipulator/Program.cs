using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                string[] numbs = new string[nums.Length];

                if (input[0] == "end")
                {
                    Console.WriteLine($"[{string.Join(", ", numbs)}]");
                    break;
                }

                string command = input[0];

                if(command == "exchange")
                {
                    int index = int.Parse(input[1]);
                    int[] numbers = new int[nums.Length];
                    

                    if (index > nums.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers = ExchangesTheArray(nums, index);

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbs[i] = numbers[i].ToString();
                        }
                    }
                }

                else if(command == "max")
                {
                    string typeNum = input[1];

                    int maxIndex = FindsMaxOddorEvenElement(nums, typeNum);

                    if(maxIndex != int.MinValue)
                    {
                        Console.WriteLine(maxIndex);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                    
                }

                else if(command == "min")
                {
                    string typeNum = input[1];

                    int minIndex = FindsMinOddorEvenElement(nums, typeNum);

                    if(minIndex != int.MaxValue)
                    {
                        Console.WriteLine(minIndex);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                    
                }

                else if(command == "first")
                {
                    int count = int.Parse(input[1]);
                    string typeNum = input[2];
                    int[] numbers = new int[count];
                    string[] numbes = new string[count];

                    numbers = ReturnsTheFirstElements(nums, count, typeNum);

                    if (count>nums.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (numbers[0] == 0 && numbers[1] == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbes[i] = numbers[i].ToString();
                            }

                            Console.WriteLine($"[{string.Join(", ", numbes)}]");
                        }
                    }
                    
                }

                else if (command == "last")
                {
                    int count = int.Parse(input[1]);
                    string typeNum = input[2];
                    int[] numbers = new int[count];
                    string[] numbes = new string[count];

                    numbers = ReturnsTheLastElements(nums, count, typeNum);

                    if (count>nums.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (numbers[0] == 0 && numbers[1] == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbes[i] = numbers[i].ToString();
                            }

                            Console.WriteLine($"[{string.Join(", ", numbes)}]");
                        }
                    }
                }
            }
        }

        static public int[] ExchangesTheArray(int[] nums, int index)
        {
            int lenght = nums.Length;

            for (int i = 0; i < index; i++)
            {
                int temp = nums[lenght-1];

                for (int j = lenght - 1; j > 0; j--)
                { 
                    nums[j] = nums[j - 1];
                }
                nums[0] = temp;
            }

            return nums;
        }
        

        static public int FindsMaxOddorEvenElement(int[] nums, string type)
        {
            int maxIndex = int.MinValue;
            int maxOdd = 0;
            int maxEven = 0;

            if(type == "odd")
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if(nums[i] % 2 != 0)
                    {
                        if (nums[i] > maxOdd)
                        {
                            maxOdd = nums[i];
                            maxIndex = i;
                        }
                        else if (nums[i] == maxOdd)
                        {
                            if (i > maxIndex)
                            {
                                maxIndex = i;
                            }
                        }
                    }
                }
            }
            else if(type == "even")
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        if (nums[i] > maxEven)
                        {
                            maxEven = nums[i];
                            maxIndex = i;
                        }
                        else if (nums[i] == maxEven)
                        {
                            if (i > maxIndex)
                            {
                                maxIndex = i;
                            }
                        }
                    }
                }
            }

            return maxIndex;
        }

        static public int FindsMinOddorEvenElement(int[] nums, string type)
        {
            int minIndex = int.MaxValue;
            int minOdd = int.MaxValue;
            int minEven = int.MaxValue;

            if(type == "odd")
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i]%2!=0)
                    {
                        if (nums[i] < minOdd)
                        {
                            minOdd = nums[i];
                            minIndex = i;
                        }
                        else if (nums[i] == minOdd)
                        {
                            if (i > minIndex)
                            {
                                minIndex = i;
                            }
                        }
                    }
                }
            }
            else if (type == "even")
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        if (nums[i] < minEven)
                        {
                            minEven = nums[i];
                            minIndex = i;
                        }
                        else if (nums[i] == minOdd)
                        {
                            if (i > minIndex)
                            {
                                minIndex = i;
                            }
                        }
                    }
                }
            }

            return minIndex;
        }

        static public int[] ReturnsTheFirstElements(int[] nums, int count, string type)
        {
            int counter = 0;
            int[] firstEl = new int[count];

            if(type == "odd")
            {
                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] % 2 != 0)
                        {
                            firstEl[counter] = nums[i];
                            counter++;
                        }
                        if (counter >= count)
                        {
                            break;
                        }
                    }

                if (counter == 0)
                {
                    for (int i = 0; i < firstEl.Length; i++)
                    {
                        firstEl[i] = 0;
                    }
                }
            }
            else if(type == "even")
            {

                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] % 2 == 0)
                        {
                            firstEl[counter] = nums[i];
                            counter++;
                        }
                        if (counter >= count)
                        {
                            break;
                        }
                    }

                if (counter == 0)
                {
                    for (int i = 0; i < firstEl.Length; i++)
                    {
                        firstEl[i] = 0;
                    }
                }
            }

            return firstEl;
        }

        static public int[] ReturnsTheLastElements(int[] nums, int count, string type)
        {
            int counter = 0;
            int[] firstEl = new int[count];

            if (type == "odd")
            {
                    for (int i = nums.Length - 1; i >= 0; i--)
                    {
                        if (nums[i] % 2 != 0)
                        {
                            firstEl[counter] = nums[i];
                            counter++;
                        }
                        if (counter >= count)
                        {
                            break;
                        }
                    }

                if (counter == 0)
                {
                    for (int i = 0; i < firstEl.Length; i++)
                    {
                        firstEl[i] = 0;
                    }
                }
            }

            else if (type == "even")
            {
                    for (int i = nums.Length - 1; i >= 0; i--)
                    {
                        if (nums[i] % 2 == 0)
                        {
                            firstEl[counter] = nums[i];
                            counter++;
                        }
                        if (counter >= count)
                        {
                            break;
                        }
                    }

                if (counter == 0)
                {
                    for (int i = 0; i < firstEl.Length; i++)
                    {
                        firstEl[i] = 0;
                    }
                }
            }

            return firstEl;
        }
    }
}
