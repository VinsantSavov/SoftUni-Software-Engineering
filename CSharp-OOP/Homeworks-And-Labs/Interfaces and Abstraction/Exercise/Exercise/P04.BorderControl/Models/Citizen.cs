using System.Collections.Generic;

namespace P04.BorderControl.Models
{
    public class Citizen : ICheckable, IBirthdate, IBuyer
    {
        private int age;

        public Citizen(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.age = age;
            this.Id = id;
            this.Birthdate = birthday;
            this.Food = 0;
        }

        public string Name { get; private set; }

        public string Id { get; private set; }

        public string Birthdate { get; private set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }

        public string CheckID(string lastDigits)
        {
            if (this.Id.EndsWith(lastDigits))
            {
                return this.Id;
            }

            return null;
        }

        public bool CheckYear(string year)
        {
            string[] birthdayInfo = this.Birthdate.Split("/");

            if(year == birthdayInfo[2])
            {
                return true;
            }

            return false;
        }
    }
}
