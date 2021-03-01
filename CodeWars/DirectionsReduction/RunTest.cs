using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DirectionsReduction
{
    [TestClass]
    public class RunTest
    {
        [TestMethod]
        public void Test1()
        {
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            string[] b = new string[] { "WEST" };

            CollectionAssert.AreEqual(b, DirReduction.DirReduc(a));
        }

        [TestMethod]
        public void Test2()
        {
            string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };

            CollectionAssert.AreEqual(b, DirReduction.DirReduc(a));
        }

        [TestMethod]
        public void Test3()
        {
            string[] a = new string[] { "NORTH", "EAST", "NORTH", "EAST", "SOUTH", "NORTH", "EAST", "NORTH", "NORTH", "SOUTH", "SOUTH", "EAST", "SOUTH", "NORTH", "EAST", };
            string[] b = new string[] { "NORTH", "EAST", "NORTH", "EAST", "EAST", "EAST", "EAST" };

            CollectionAssert.AreEqual(b, DirReduction.DirReduc(a));
        }




    }
}
