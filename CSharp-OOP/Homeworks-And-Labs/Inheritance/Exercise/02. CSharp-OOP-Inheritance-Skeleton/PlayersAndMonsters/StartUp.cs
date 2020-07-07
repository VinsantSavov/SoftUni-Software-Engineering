namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            BladeKnight knight = new BladeKnight("Sir", 12);
            System.Console.WriteLine(knight.ToString());
        }
    }
}