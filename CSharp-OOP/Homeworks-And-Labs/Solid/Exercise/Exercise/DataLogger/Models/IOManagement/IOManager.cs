using DataLogger.Models.Contracts;
using System.IO;

namespace DataLogger.Models.IOManagement
{
    public class IOManager : IIOManager
    {
        private string currentPath;

        private string folderName;
        private string fileName;

        public IOManager(string folderName, string fileName)
        {
            this.folderName = folderName;
            this.fileName = fileName;

            this.currentPath = this.GetCurrentPath();
        }

        public string CurrentDirectoryPath => this.currentPath + folderName;

        public string CurrentFilePath => this.currentPath + fileName;

        public void EnsureDirectoryAndFileExist()
        {
            if (!Directory.Exists(this.CurrentDirectoryPath))
            {
                Directory.CreateDirectory(this.CurrentDirectoryPath);
            }

            File.AppendAllText(this.CurrentFilePath, string.Empty);
        }

        public string GetCurrentPath()
        {
            string currentDir = Directory.GetCurrentDirectory();

            return currentDir;
        }
    }
}
