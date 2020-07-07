using DataLogger.Core;
using DataLogger.Factories;
using DataLogger.Models;
using DataLogger.Models.Contracts;
using System;
using System.Collections.Generic;

namespace DataLogger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int appendersCount = int.Parse(Console.ReadLine());

            ICollection<IAppender> appenders = new List<IAppender>();

            AppenderFactory appenderFactory = new AppenderFactory();

            for (int i = 0; i < appendersCount; i++)
            {
                string[] appendersArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string appenderType = appendersArgs[0];
                string layoutType = appendersArgs[1];
                string level = "INFO";

                if(appendersArgs.Length == 3)
                {
                    level = appendersArgs[2];
                }

                try
                {
                    IAppender appender = appenderFactory.ProduceAppender(appenderType, layoutType, level);
                    appenders.Add(appender);
                }
                catch(ArgumentException aex)
                {
                    Console.WriteLine(aex.Message);
                }
                
            }

            ILogger logger = new Logger(appenders);

            IEngine engine = new Engine(logger);

            engine.Run();
        }
    }
}
