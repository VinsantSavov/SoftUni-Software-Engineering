using System;
using System.Linq;

namespace _3.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filePath = Console.ReadLine().Split(new[] { "\\", "." }, StringSplitOptions.RemoveEmptyEntries);

            string fileName = filePath[3];
            string fileExtension = filePath[4];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
