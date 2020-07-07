using System;
using System.IO.Compression;

namespace _6.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"D:\SoftUni", @"C:\Users\132\Desktop\MyArchive.zip");
            ZipFile.ExtractToDirectory(@"C:\Users\132\Desktop\MyArchive.zip", @"C:\Users\132\Desktop\Zip");
        }
    }
}
