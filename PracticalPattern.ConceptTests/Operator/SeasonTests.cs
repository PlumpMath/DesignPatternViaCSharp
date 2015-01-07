//using Microsoft.VisualStudio.TestTools.UnitTesting;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XiaolouT.Learning.PracticalPattern.Concept.Operator.Tests
{
    [TestClass]
    public class SeasonTests
    {
        [TestMethod]
        public void SeasonTest()
        {
            var season = new Season();
            Assert.AreEqual<string>(Season.Seasons[0], season);
            season++;
            season++;
            Assert.AreEqual<string>(Season.Seasons[2], season);

        }
    }
}
