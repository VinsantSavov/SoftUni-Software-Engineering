using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] text = new string[5];

            text = ArrayCreator.Create(5, "pesho");

            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
        }
    }
}
