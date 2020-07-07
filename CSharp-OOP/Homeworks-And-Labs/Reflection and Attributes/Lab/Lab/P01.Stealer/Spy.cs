using System;
using System.Text;
using System.Reflection;
using System.Linq;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string classToInvestigate, string[] fieldsToInvestigate)
        {
            StringBuilder sb = new StringBuilder();
            Type classType = Type.GetType("Stealer." + classToInvestigate);

            var test = Activator.CreateInstance(classType, new object[] { });
            FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
                                                       | BindingFlags.Static);

            sb.AppendLine($"Class under investigation: {classToInvestigate}");

            foreach (var field in fields.Where(f => fieldsToInvestigate.Contains(f.Name)))
            {
                var value = field.GetValue(test);

                sb.AppendLine($"{field.Name} = {value}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
