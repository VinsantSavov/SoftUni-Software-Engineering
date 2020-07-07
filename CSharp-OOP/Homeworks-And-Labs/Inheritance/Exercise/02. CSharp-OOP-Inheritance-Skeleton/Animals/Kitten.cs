namespace Animals
{
    public class Kitten : Cat
    {
        public const string GENDER = "Female";

        public Kitten(string name, int age, string gender)
            : base(name, age, GENDER)
        {
        }
        public Kitten(string name, int age)
            : base(name, age, GENDER)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
