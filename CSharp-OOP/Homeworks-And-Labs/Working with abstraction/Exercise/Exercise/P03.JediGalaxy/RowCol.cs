using System;
using System.Linq;

namespace P03.JediGalaxy
{
    public class RowCol
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public void Split(string info)
        {
            int[] evilCoordinates = info.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                         .Select(int.Parse)
                                         .ToArray();

            this.Row = evilCoordinates[0];
            this.Col = evilCoordinates[1];
        }
    }
}
