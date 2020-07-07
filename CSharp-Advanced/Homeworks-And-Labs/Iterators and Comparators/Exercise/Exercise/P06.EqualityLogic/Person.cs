using System;
using System.Diagnostics.CodeAnalysis;

namespace P06.EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            int nameComp = this.Name.CompareTo(other.Name);

            if(nameComp == 0)
            {
                int ageComp = this.Age.CompareTo(other.Age);

                return ageComp;
            }

            return nameComp;
        }

        public override bool Equals(object obj)
        {
            if(obj is Person person)
            {
                return this.Name == person.Name && this.Age == person.Age;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Age.GetHashCode();
        }
    }
}
