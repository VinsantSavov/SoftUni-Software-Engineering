using System.Linq;
using System.Reflection;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            var objType = obj.GetType();

            var properties = objType.GetProperties();

            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes().Where(a => a is MyValidationAttribute)
                    .Cast<MyValidationAttribute>().ToArray();

                foreach (var attribute in attributes)
                {
                    if (!attribute.IsValid(property.GetValue(obj)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
