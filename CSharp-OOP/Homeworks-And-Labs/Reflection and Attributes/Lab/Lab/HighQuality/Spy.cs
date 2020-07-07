using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Spy
{
    public class Spy
    {
        public string StealFieldInfo(string classToInvestigate, string[] fieldsToInvestigate)
        {
            StringBuilder sb = new StringBuilder();
            Type classType = Type.GetType("P01.Stealer." + classToInvestigate);

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

        public string AnalyzeAcessModifiers(string className)
        {
            StringBuilder sb = new StringBuilder();

            Type classType = Type.GetType("Spy." + className);
            FieldInfo[] fields = classType.GetFields();

            foreach (var field in fields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            MethodInfo[] publicMethods = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] nonPublicMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);


            foreach (var nonPublicMethod in nonPublicMethods)
            {
                if (nonPublicMethod.Name.StartsWith("get"))
                {
                    sb.AppendLine($"{nonPublicMethod.Name} must be public!");
                }
            }

            foreach (var publicMethod in publicMethods)
            {
                if (publicMethod.Name.StartsWith("set"))
                {
                    sb.AppendLine($"{publicMethod.Name} must be private!");
                }
            }

            return sb.ToString().TrimEnd();
        }

        [Author("Pepi")]
        public string RevealPrivateMethods(string className)
        {
            Type classType = Type.GetType("Spy." + className);
            Type baseType = classType.BaseType;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"All Private Methods of Class: {classType.Name}")
                .AppendLine($"Base Class: {baseType.Name}");

            MethodInfo[] nonPublicMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var method in nonPublicMethods)
            {
                sb.AppendLine(method.Name);
            }

            return sb.ToString().TrimEnd();
        }

        [Author("Gosho")]
        public string CollectGettersAndSetters(string className)
        {
            Type classType = Type.GetType("Spy." + className);

            MethodInfo[] methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public
                                                           | BindingFlags.NonPublic | BindingFlags.Static);
            StringBuilder sb = new StringBuilder();

            foreach (var method in methods)
            {
                if (method.Name.StartsWith("get"))
                {
                    sb.AppendLine($"{method.Name} will return {method.ReturnType.FullName}");
                }
                else if (method.Name.StartsWith("set"))
                {
                    sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
