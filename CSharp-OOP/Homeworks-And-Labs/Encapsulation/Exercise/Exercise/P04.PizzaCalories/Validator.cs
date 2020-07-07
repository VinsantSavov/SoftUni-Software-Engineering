namespace P04.PizzaCalories
{
    public class Validator
    {
        private const int MIN_WEIGHT = 1;
        private const int MAX_WEIGHT = 200;

        private const int MIN_TOPPING_WEIGHT = 1;
        private const int MAX_TOPPING_WEIGHT = 50;

        public static bool ValidateTypeAndTechique(string type, string technique)
        {
            if(type.ToLower() == "white" || type.ToLower() == "wholegrain" && 
                technique.ToLower() == "crispy" || technique.ToLower() == "chewy" || technique.ToLower() == "homemade")
            {
                return true;
            }

            return false;
        }

        public static bool ValidateWeight(double weight)
        {
            if(weight < MIN_WEIGHT || weight > MAX_WEIGHT)
            {
                return false;
            }

            return true;
        }

        public static bool ValidateToppingType(string type)
        {
            if(type.ToLower() == "meat" || type.ToLower() == "cheese" 
                || type.ToLower() == "veggies" || type.ToLower() == "sauce")
            {
                return true;
            }

            return false;
        }

        public static bool ValidateToppingWeight(double weight)
        {
            if(weight < MIN_TOPPING_WEIGHT || weight > MAX_TOPPING_WEIGHT)
            {
                return false;
            }

            return true;
        }
    }
}
