using P07.MilitaryElite.Contracts;
using P07.MilitaryElite.Enumerations;
using P07.MilitaryElite.Exceptions;
using P07.MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<ISoldier> soldiers = new List<ISoldier>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    break;
                }

                string[] info = input.Split();
                string type = info[0];
                int id = int.Parse(info[1]);
                string firstName = info[2];
                string lastName = info[3];

                try
                {
                    if (type == "Private")
                    {
                        decimal salary = decimal.Parse(info[4]);
                        IPrivate @private = new Private(id, firstName, lastName, salary);
                        soldiers.Add(@private);
                    }
                    else if (type == "LieutenantGeneral")
                    {
                        decimal salary = decimal.Parse(info[4]);
                        ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

                        for (int i = 5; i < info.Length; i++)
                        {
                            int currentId = int.Parse(info[i]);
                            IPrivate @private = (IPrivate)soldiers.First(p => p.Id == currentId);
                            lieutenantGeneral.AddPrivate(@private);
                        }

                        soldiers.Add(lieutenantGeneral);
                    }
                    else if (type == "Engineer")
                    {
                        decimal salary = decimal.Parse(info[4]);

                        IEngineer engineer = null; 
                        Corps corps;
                        bool validCorps = Enum.TryParse<Corps>(info[5], out corps);

                        if (validCorps)
                        {
                            engineer = new Engineer(id, firstName, lastName, salary, corps);
                        }
                        else
                        {
                            throw new InvalidCorpsException();
                        }

                        for (int i = 6; i < info.Length; i += 2)
                        {
                            string repairPart = info[i];
                            int repairHours = int.Parse(info[i + 1]);

                            IRepair repair = new Repair(repairPart, repairHours);
                            engineer.AddRepair(repair);
                        }

                        soldiers.Add(engineer);
                    }
                    else if (type == "Commando")
                    {
                        decimal salary = decimal.Parse(info[4]);

                        ICommando commando = null;
                        Corps corps;
                        bool validCorps = Enum.TryParse<Corps>(info[5], out corps);

                        if (validCorps)
                        {
                            commando = new Commando(id, firstName, lastName, salary, corps);
                        }
                        else
                        {
                            throw new InvalidCorpsException();
                        }

                        for (int i = 6; i < info.Length; i += 2)
                        {
                            try
                            {
                                string codeName = info[i];
                                MissionState state;
                                bool validMission = Enum.TryParse<MissionState>(info[i + 1], out state);

                                if (validMission)
                                {
                                    IMission mission = new Mission(codeName, state);
                                    commando.AddMission(mission);
                                }
                                else
                                {
                                    throw new InvalidMissionException();
                                }

                            }
                            catch(InvalidMissionException ime)
                            {
                                Console.WriteLine();
                            }
                        }

                        soldiers.Add(commando);
                    }
                    else if (type == "Spy")
                    {
                        int codeNumber = int.Parse(info[4]);

                        ISpy spy = new Spy(id, firstName, lastName, codeNumber);

                        soldiers.Add(spy);
                    }
                }
                catch(InvalidCorpsException ice)
                {
                    Console.WriteLine();
                }
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.ToString());
            }
        }
    }
}
