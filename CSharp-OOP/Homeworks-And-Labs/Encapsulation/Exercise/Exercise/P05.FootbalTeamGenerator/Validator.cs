namespace P05.FootbalTeamGenerator
{
    public class Validator
    {
        public static bool ValidateStats(int stat)
        {
            if (stat < 0 || stat > 100)
            {
                return false;
            }

            return true;
        }

        public static bool ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            return true;
        }
    }
}
