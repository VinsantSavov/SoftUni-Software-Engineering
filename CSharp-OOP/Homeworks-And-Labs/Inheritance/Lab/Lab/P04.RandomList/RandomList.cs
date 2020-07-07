using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random random = new Random();

            int randomNum = random.Next(0, this.Count);
            return this[randomNum];
        }
    }
}
