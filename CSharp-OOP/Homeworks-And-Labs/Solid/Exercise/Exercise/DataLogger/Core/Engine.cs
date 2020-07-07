using DataLogger.Factories;
using DataLogger.Models.Contracts;
using System;

namespace DataLogger.Core
{
    public class Engine : IEngine
    {
        private ILogger logger;
        private ErrorFactory errorFactory;

        public Engine(ILogger logger)
        {
            this.logger = logger;

            this.errorFactory = new ErrorFactory();
        }

        public void Run()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                string[] inputInfo = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string level = inputInfo[0];
                string dateTime = inputInfo[1];
                string message = inputInfo[2];

                try
                {
                    IError error = errorFactory.ProduceError(dateTime, message, level);

                    this.logger.Log(error);
                }
                catch(ArgumentException aex)
                {
                    Console.WriteLine(aex.Message);
                }
            }

            Console.WriteLine(this.logger);
        }
    }
}
