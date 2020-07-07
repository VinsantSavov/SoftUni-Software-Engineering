using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _1.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("text.txt");
            int count = 0;

            while (true)
            {
                string line = reader.ReadLine();

                if(line == null)
                {
                    break;
                }

                if(count % 2 == 0)
                {
                    line = line.Replace(',', '@');
                    line = line.Replace('.', '@');
                    line = line.Replace('-', '@');
                    line = line.Replace('!', '@');
                    line = line.Replace('?', '@');

                    line = string.Join(" ", line.Split().Reverse());

                    Console.WriteLine(line);
                }
                count++;
            }

            //string reversedLine = string.Empty;

            //for (int i = 0; i < lines.Count; i++)
            //{
            //    string currentLine = lines[i];
            //   string[] words = currentLine.Split();

            //   for (int j = words.Length-1; j >= 0; j--)
            //    {
            //        if (words[j].Contains(',') || words[j].Contains('.')
            //           || words[j].Contains('-') || words[j].Contains('|')
            //           || words[j].Contains('?'))
            //        {
            //            words[j] = words[j].Replace(',', '@');
            //            words[j] = words[j].Replace('.', '@');
            //            words[j] = words[j].Replace('-', '@');
            //            words[j] = words[j].Replace('!', '@');
            //            words[j] = words[j].Replace('?', '@');
            //        }
                    
            //        reversedLine += words[j];
            //       if(j != 0)
            //       {
            //           reversedLine += ' ';
            //       }
            //   }

            //    Console.WriteLine(reversedLine);
            //    reversedLine = string.Empty;
            //}
        }
    }
}
