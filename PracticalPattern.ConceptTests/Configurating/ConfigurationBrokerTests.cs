using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace XiaolouT.Learning.PracticalPattern.Concept.Configurating.Tests
{
    [TestClass()]
    public class ConfigurationBrokerTests
    {
        [TestMethod()]
        public void Test()
        {
            var s1 = ConfigurationBroker.Delegating;

            Assert.IsTrue(s1.Pictures["EventHandler"].Colorized);
        }
    }
}
