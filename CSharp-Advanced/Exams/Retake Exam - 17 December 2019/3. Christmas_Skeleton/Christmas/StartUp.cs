namespace Christmas
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            Present present1 = new Present("Doll", 16, "male");
            Present present2 = new Present("Brick", 32, "female");
            Present present3 = new Present("Truck", 12, "male");
            Present present4 = new Present("Truck", 21, "female");
            Present present5 = new Present("Printer", 45, "male");


            Bag bag = new Bag("red", 5);
            bag.Add(present1);
            bag.Add(present2);
            bag.Add(present3);
            bag.Add(present4);
            bag.Add(present5);

            bag.Remove("Coal");
            Present newPresent = bag.GetPresent("Brick");
            Present heaviest = bag.GetHeaviestPresent();

            Console.WriteLine(bag.Report());
            Console.WriteLine(heaviest);
            Console.WriteLine(newPresent);
            Console.WriteLine(bag.Count);
        }
    }
}
