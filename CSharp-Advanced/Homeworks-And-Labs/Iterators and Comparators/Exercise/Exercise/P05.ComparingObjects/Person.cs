using System;
using System.Diagnostics.CodeAnalysis;

namespace P05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            int nameCompare = this.Name.CompareTo(other.Name);

            if(nameCompare == 0)
            {
                int ageCompare = this.Age.CompareTo(other.Age);

                if(ageCompare == 0)
                {
                    int townCompare = this.Town.CompareTo(other.Town);

                    return townCompare;
                }

                return ageCompare;
            }

            return nameCompare;
        }
    }
}
