using System;

namespace _4.Meter_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double numToConvert = double.Parse(Console.ReadLine());
            string unit = Console.ReadLine();
            string exitUnit = Console.ReadLine();

            if(unit=="m" && exitUnit == "mm")
            {
                numToConvert = numToConvert * 1000;
              
            }
            else if(unit=="m" && exitUnit == "cm")
            {
                numToConvert = numToConvert * 100;
            }
            else if (unit == "mm" && exitUnit == "cm")
            {
                numToConvert = numToConvert / 10;
            }
            else if (unit == "mm" && exitUnit == "m")
            {
                numToConvert = numToConvert / 1000;
            }
            else if (unit == "cm" && exitUnit == "m")
            {
                numToConvert = numToConvert / 100;
            }
            else if (unit == "cm" && exitUnit == "mm")
            {
                numToConvert = numToConvert * 10;
            }
            Console.WriteLine("{0:F3}", numToConvert);
        }
    }
}
