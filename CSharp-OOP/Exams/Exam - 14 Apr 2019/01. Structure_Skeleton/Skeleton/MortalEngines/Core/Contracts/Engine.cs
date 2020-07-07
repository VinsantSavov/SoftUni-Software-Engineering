using MortalEngines.IO;
using MortalEngines.IO.Contracts;
using System;

namespace MortalEngines.Core.Contracts
{
    public class Engine : IEngine
    {
        private IMachinesManager manager;
        private ConsoleReader reader;
        private ConsoleWriter writer;

        public Engine()
        {
            this.manager = new MachinesManager();
            this.reader = new ConsoleReader();
            this.writer = new ConsoleWriter();
        }

        public void Run()
        {
            while (true)
            {
                string input = reader.Read();
                string output = String.Empty;

                if(input == "Quit")
                {
                    break;
                }

                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (commands[0] == "HirePilot")
                    {
                        output = this.manager.HirePilot(commands[1]);
                    }
                    else if(commands[0] == "PilotReport")
                    {
                        output = this.manager.PilotReport(commands[1]);
                    }
                    else if(commands[0] == "ManufactureTank")
                    {
                        output = this.manager.ManufactureTank(commands[1], double.Parse(commands[2]), double.Parse(commands[3]));
                    }
                    else if(commands[0] == "ManufactureFighter")
                    {
                        output = this.manager.ManufactureFighter(commands[1], double.Parse(commands[2]), double.Parse(commands[3]));
                    }
                    else if(commands[0] == "MachineReport")
                    {
                        output = this.manager.MachineReport(commands[1]);
                    }
                    else if(commands[0] == "AggressiveMode")
                    {
                        output = this.manager.ToggleFighterAggressiveMode(commands[1]);
                    }
                    else if(commands[0] == "DefenseMode")
                    {
                        output = this.manager.ToggleTankDefenseMode(commands[1]);
                    }
                    else if(commands[0] == "Engage")
                    {
                        output = this.manager.EngageMachine(commands[1], commands[2]);
                    }
                    else if(commands[0] == "Attack")
                    {
                        output = this.manager.AttackMachines(commands[1], commands[2]);
                    }

                    writer.WriteLine(output);
                }
                catch(Exception ex)
                {
                    writer.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
