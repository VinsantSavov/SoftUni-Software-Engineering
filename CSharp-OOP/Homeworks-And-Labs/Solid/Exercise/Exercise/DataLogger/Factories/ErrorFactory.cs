using DataLogger.Enumerations;
using DataLogger.Models.Contracts;
using DataLogger.Models.Errors;
using System;
using System.Globalization;

namespace DataLogger.Factories
{
    public class ErrorFactory
    {
        private const string DATE_FORMAT = "M/dd/yyyy h:mm:ss tt";

        public IError ProduceError(string date, string message, string levelStr)
        {
            DateTime dateTime;

            try
            {
                dateTime = DateTime.ParseExact(date, DATE_FORMAT, CultureInfo.InvariantCulture);
            }
            catch(Exception e)
            {
                throw new ArgumentException("Invalid date format!", e);
            }

            Level level;

            bool hasParsed = Enum.TryParse<Level>(levelStr, true, out level);

            if (!hasParsed)
            {
                throw new ArgumentException("Invalid level type!");
            }

            IError error = new Error(dateTime, message, level);

            return error;
        }
    }
}
