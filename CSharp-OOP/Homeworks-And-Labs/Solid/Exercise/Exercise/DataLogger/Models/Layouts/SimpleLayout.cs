using DataLogger.Models.Contracts;

namespace DataLogger.Models.Layouts
{
    public class SimpleLayout : ILayout
    {
        public string Format => "{0} - {1} - {2}";
    }
}
