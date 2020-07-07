using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Telephony.Models
{
    public class Smartphone : ICallable, IBrowsable
    {
        private List<string> numbers;
        private List<string> sites;

        public Smartphone()
        {
            this.numbers = new List<string>();
            this.sites = new List<string>();
        }

        public string Browse(string site)
        {
            bool isValid = site.Any(c => char.IsDigit(c));

            if (!isValid)
            {
                this.sites.Add(site);
                return $"Browsing: {site}!";
            }

            return "Invalid URL!";
        }

        public string Call(string number)
        {
            bool isValid = number.Any(c => char.IsLetter(c));

            if (!isValid)
            {
                this.numbers.Add(number);
                return $"Calling... {number}";
            }

            return "Invalid number!";
        }
    }
}
