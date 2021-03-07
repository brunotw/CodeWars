using NUnit.Framework;

namespace BreakCamelCase
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
            Assert.AreEqual(BreakCamelCase.BreakCamelCaseString("camelCasing"), "camel Casing");
            Assert.AreEqual(BreakCamelCase.BreakCamelCaseString("camelCasingTest"), "camel Casing Test");
        }
    }
}