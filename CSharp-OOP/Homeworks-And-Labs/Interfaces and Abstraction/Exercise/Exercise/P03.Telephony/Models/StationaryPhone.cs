using System.Collections.Generic;
using System.Linq;

namespace P03.Telephony.Models
{
    public class StationaryPhone : ICallable
    {
        private List<string> numbers;

        public StationaryPhone()
        {
            this.numbers = new List<string>();
        }

        public string Call(string number)
        {
            bool isValid = number.Any(c => char.IsLetter(c));

            if (!isValid)
            {
                this.numbers.Add(number);
                return $"Dialing... {number}";
            }

            return "Invalid number!";
        }
    }
}
