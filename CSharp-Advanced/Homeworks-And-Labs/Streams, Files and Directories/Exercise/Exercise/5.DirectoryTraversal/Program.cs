using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _5.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var dirInfo = new Dictionary<string, Dictionary<string, double>>();
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"/report.txt");

            DirectoryInfo di = new DirectoryInfo(".");
            FileInfo[] files = di.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                string fileName = files[i].ToString();
                string name = files[i].Name;
                string extension = files[i].Extension;

                if (!dirInfo.ContainsKey(extension))
                {
                    dirInfo.Add(extension, new Dictionary<string, double>());
                }

                if (!dirInfo[extension].ContainsKey(fileName))
                {
                    dirInfo[extension].Add(fileName, files[i].Length / 1024);
                }
            }

            foreach (var kvp in dirInfo.OrderByDescending(c => c.Value.Values.Count).ThenBy(n => n.Key))
            {
                File.AppendAllText(path, kvp.Key + Environment.NewLine);

                foreach (var (key, value) in kvp.Value.OrderBy(f => f.Value))
                {
                    File.AppendAllText(path, $"-- {key} - {Math.Round(value, 3)}kb" + Environment.NewLine);
                }
            }
        }
    }
}
