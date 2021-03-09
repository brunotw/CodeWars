using NUnit.Framework;

namespace EqualSidesOfAnArray
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            //Assert.AreEqual(3, EqualSidesOfAnArrayMain.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            //Assert.AreEqual(1, EqualSidesOfAnArrayMain.FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
            //Assert.AreEqual(-1, EqualSidesOfAnArrayMain.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
            //Assert.AreEqual(3, EqualSidesOfAnArrayMain.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));

            Assert.AreEqual(1, EqualSidesOfAnArrayMain.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1, 1, 100, 50, -51, 1, 1, 1, 2, 3, 4, 5, 6, 20, 10, 30, 10, 10, 15, 35, 8, 8, 8, 0, 0, 8 }));
        }
    }
}