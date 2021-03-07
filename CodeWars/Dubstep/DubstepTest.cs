using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dubstep
{
    [TestClass]
    public class DubstepTest
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual("ABC", DubstepMain.SongDecoder("WUBWUBABCWUB"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual("R L", DubstepMain.SongDecoder("RWUBWUBWUBLWUB"));
        }
    }
}
