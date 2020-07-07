using DataLogger.Enumerations;
using DataLogger.Models.Appenders;
using DataLogger.Models.Contracts;
using DataLogger.Models.Files;
using System;

namespace DataLogger.Factories
{
    public class AppenderFactory
    {
        private LayoutFactory layoutFactory;

        public AppenderFactory()
        {
            this.layoutFactory = new LayoutFactory();
        }

        public IAppender ProduceAppender(string appenderType, string layoutType, string levelStr)
        {
            Level level;

            bool hasParsed = Enum.TryParse<Level>(levelStr, true, out level);

            if (!hasParsed)
            {
                throw new ArgumentException("Invalid level type!");
            }

            ILayout layout = layoutFactory.ProduceLayout(layoutType);

            IAppender appender = null;

            if(appenderType == "ConsoleAppender")
            {
                appender = new ConsoleAppender(layout, level);
            }
            else if(appenderType == "FileAppender")
            {
                IFile file = new LogFile("\\data\\", "logger.txt");

                appender = new FileAppender(layout, level, file);
            }
            else
            {
                throw new ArgumentException("Invalid appender type!");
            }

            return appender;
        }
    }
}
