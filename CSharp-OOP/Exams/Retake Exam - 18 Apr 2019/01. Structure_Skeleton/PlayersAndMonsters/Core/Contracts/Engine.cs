using PlayersAndMonsters.IO.Contracts;
using System;

namespace PlayersAndMonsters.Core.Contracts
{
    public class Engine : IEngine
    {
        private IManagerController controller;
        private IWriter writer;
        private IReader reader;

        public Engine()
        {
            this.controller = new ManagerController();
            this.writer = new ConsoleWriter();
            this.reader = new ConsoleReader();
        }

        public void Run()
        {
            while (true)
            {
                string input = reader.ReadLine();
                string output = String.Empty;

                if(input == "Exit")
                {
                    break;
                }

                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if(commands[0] == "AddPlayer")
                    {
                        output = this.controller.AddPlayer(commands[1], commands[2]);
                    }
                    else if(commands[0] == "AddCard")
                    {
                        output = this.controller.AddCard(commands[1], commands[2]);
                    }
                    else if(commands[0] == "AddPlayerCard")
                    {
                        output = this.controller.AddPlayerCard(commands[1], commands[2]);
                    }
                    else if(commands[0] == "Fight")
                    {
                        output = this.controller.Fight(commands[1], commands[2]);
                    }
                    else if(commands[0] == "Report")
                    {
                        output = this.controller.Report();
                    }

                    writer.WriteLine(output);
                }
                catch(Exception ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }
        }
    }
}
