using System;
using System.IO;

namespace _4.CopyBinaryfile
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 4096;

            using FileStream reader = new FileStream("copyMe.png", FileMode.OpenOrCreate);
            using FileStream writer = new FileStream("../../../copied.png", FileMode.OpenOrCreate);

            byte[] buffer = new byte[size];

            while (reader.CanRead)
            {
                int bytesRead = reader.Read(buffer, 0, buffer.Length);

                if(bytesRead == 0)
                {
                    break;
                }

                writer.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
