using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = File.ReadAllLines("text.txt").ToList();
            char[] marks = { '.', ',', '?', '-','!'};

            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];
                int letters = 0;
                int marksCount = 0;

                for (int j = 0; j < line.Length; j++)
                {
                    if (char.IsLetter(line[j]))
                    {
                        letters++;
                    }
                    else if (marks.Contains(line[j]))
                    {
                        marksCount++;
                    }
                }

                lines[i] = $"Line {i + 1} :{line} ({letters})({marksCount})";
            }

            File.WriteAllLines("output.txt", lines);
        }
    }
}
