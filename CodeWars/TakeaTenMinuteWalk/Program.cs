using NUnit.Framework;
using System;
using System.Linq;

namespace TakeaTenMinuteWalk
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.AreEqual(true, IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }));
        }

        public static bool IsValidWalk(string[] walk)
        {
            int northBlocks = walk.Where(w => w == "n").Count();
            int southBlocks = walk.Where(w => w == "s").Count();
            int westBlocks = walk.Where(w => w == "w").Count();
            int eastBlocks = walk.Where(w => w == "e").Count();

            if (walk.Length != 10)
                return false;

            return (northBlocks - southBlocks == 0) && (westBlocks - eastBlocks == 0);
        }
    }
}
