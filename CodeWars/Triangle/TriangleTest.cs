using NUnit.Framework;

namespace Triangle
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
            Assert.IsTrue(Triangle.IsTriangle(5, 7, 10));
        }
    }
}