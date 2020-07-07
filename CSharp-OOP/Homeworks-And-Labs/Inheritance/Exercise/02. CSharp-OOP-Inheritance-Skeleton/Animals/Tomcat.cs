namespace Animals
{
    public class Tomcat : Cat
    {
        public const string GENDER = "Male";

        public Tomcat(string name, int age, string gender)
            : base(name, age, GENDER)
        {
        }
        public Tomcat(string name, int age)
            : base(name, age, GENDER)
        {
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
