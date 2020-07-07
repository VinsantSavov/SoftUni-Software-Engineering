namespace P04.BorderControl.Models
{
    public class Pet : IBirthdate
    {
        private string name;

        public Pet(string name, string birthday)
        {
            this.name = name;
            this.Birthdate = birthday;
        }

        public string Birthdate { get; private set; }

        public bool CheckYear(string year)
        {
            string[] birthdayInfo = this.Birthdate.Split("/");

            if (year == birthdayInfo[2])
            {
                return true;
            }

            return false;
        }
    }
}
