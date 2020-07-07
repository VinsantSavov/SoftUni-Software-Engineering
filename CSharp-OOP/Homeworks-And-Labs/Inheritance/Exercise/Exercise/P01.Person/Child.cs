namespace P01.Person
{
    public class Child : Person
    {
        public Child(string name, int age)
            : base(name,age)
        {
            base.Name = name;
            
            if(age <= 15)
            {
                base.Age = age;
            }
        }
    }
}
