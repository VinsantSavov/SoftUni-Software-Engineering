using MXGP.Core.Contracts;
using MXGP.IO;
using MXGP.IO.Contracts;
using System;

namespace MXGP.Core
{
    public class Engine : IEngine
    {
        private IReader consoleReader;
        private IWriter consoleWriter;
        private IChampionshipController controller;

        public Engine()
        {
            this.consoleReader = new ConsoleReader();
            this.consoleWriter = new ConsoleWriter();
            this.controller = new ChampionshipController();
        }

        public void Run()
        {
            while (true)
            {
                string command = consoleReader.ReadLine();
                string output = string.Empty;

                if(command == "End")
                {
                    break;
                }

                string[] info = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string method = info[0];

                try
                {
                    if (method == "CreateRider")
                    {
                        string riderName = info[1];

                        output = controller.CreateRider(riderName);
                    }
                    else if (method == "CreateMotorcycle")
                    {
                        string motorcycleType = info[1];
                        string model = info[2];
                        int horsepower = int.Parse(info[3]);

                        output = controller.CreateMotorcycle(motorcycleType, model, horsepower);
                    }
                    else if (method == "AddMotorcycleToRider")
                    {
                        string name = info[1];
                        string motorcycleName = info[2];

                        output = controller.AddMotorcycleToRider(name, motorcycleName);
                    }
                    else if (method == "AddRiderToRace")
                    {
                        string raceName = info[1];
                        string riderName = info[2];

                        output = controller.AddRiderToRace(raceName, riderName);
                    }
                    else if (method == "CreateRace")
                    {
                        string name = info[1];
                        int laps = int.Parse(info[2]);

                        output = controller.CreateRace(name, laps);
                    }
                    else if (method == "StartRace")
                    {
                        string raceName = info[1];

                        output = controller.StartRace(raceName);
                    }

                    consoleWriter.WriteLine(output);
                }
                catch(Exception ex)
                {
                    this.consoleWriter.WriteLine(ex.Message);
                }
            }
        }
    }
}
