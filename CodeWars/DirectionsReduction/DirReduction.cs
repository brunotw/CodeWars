using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectionsReduction
{
    public class DirReduction
    {
        private static readonly string south = "SOUTH";
        private static readonly string north = "NORTH";
        private static readonly string east = "EAST";
        private static readonly string west = "WEST";
        private static List<string> bestPath = new List<string>();

        public static string[] DirReduc(String[] directions)
        {
            foreach (var item in directions)
            {
                Console.WriteLine(item);
            }

            bestPath = directions.ToList();
            RemoveNeedlessMove();
            return bestPath.ToArray<string>();
        }


        public static void RemoveNeedlessMove()
        {
            if (bestPath.Count < 2)
                return;

            for (int i = 0; i < bestPath.Count - 1; i++)
            {
                string current = bestPath[i];
                string next = bestPath[i + 1];

                if (AreOposite(current, next))
                {
                    bestPath.RemoveRange(i, 2);
                    RemoveNeedlessMove();
                }
            }
        }

        private static bool AreOposite(string current, string next)
        {
            string[] oposites = new string[] { current, next };

            if (oposites.Contains(north) && oposites.Contains(south))
                return true;

            if (oposites.Contains(west) && oposites.Contains(east))
                return true;

            return false;
        }
    }
}













//int south = directionsrr.Where(c => c.Equals("SOUTH")).Count();
//int north = directions.Where(c => c.Equals("NORTH")).Count();
//int east = directions.Where(c => c.Equals("EAST")).Count();
//int west = directions.Where(c => c.Equals("WEST")).Count();


//private static void ShouldMove(string current, string next)
//{
//    if (current == north && next == south)
//        return;

//    if (current == south && next == north)
//        return;

//    if (current == east && next == west)
//        return;

//    if (current == west && next == east)
//        return;

//    bestPath.Add(current);
//}