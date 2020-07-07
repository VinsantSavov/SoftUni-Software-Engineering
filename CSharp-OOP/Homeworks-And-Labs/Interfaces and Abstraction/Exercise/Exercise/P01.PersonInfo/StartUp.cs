using System;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IIdentifiable citizen = new Citizen("Gosho", 5, "3444", "13.12.2020");
        }
    }
}
