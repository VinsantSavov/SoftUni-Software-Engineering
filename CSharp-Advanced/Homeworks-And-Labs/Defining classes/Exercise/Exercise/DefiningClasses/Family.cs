
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            members = new List<Person>();
        }
        public void AddMember(Person member)
        {
            members.Add(member);
        }

        public List<Person> GetMembersWithAgeAbove30()
        {
            return members.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();
        }

    }
}
