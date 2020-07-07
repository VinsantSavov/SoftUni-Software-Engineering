using System;

namespace PersonsInfo
{
    public class ValidationBuilder
    {
        public static bool Validation(decimal value, decimal minValue)
        {
            if(value <= minValue)
            {
                return true;
            }

            return false;
        }
    }
}
