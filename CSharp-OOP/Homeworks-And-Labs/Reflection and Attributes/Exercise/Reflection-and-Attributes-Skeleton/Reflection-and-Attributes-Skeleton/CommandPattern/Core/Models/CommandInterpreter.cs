using System;
using System.Linq;
using System.Reflection;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Models
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] argsInfo = args.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string className = argsInfo[0] + "Command";

            Assembly assembly = Assembly.GetCallingAssembly();

            Type commandType = assembly.GetTypes().FirstOrDefault(a => a.Name == className);

            if (commandType == null)
            {
                throw new ArgumentException("Invalid type!");
            }

            var command = (ICommand)Activator.CreateInstance(commandType);
            //MethodInfo method = commandType.GetMethods().First();
            //string result = (string) method.Invoke(command, new object[] { argsInfo.Skip(1).ToArray() });
            string result = command.Execute(argsInfo.Skip(1).ToArray());

            return result;
        }
    }
}
