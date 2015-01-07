using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace XiaolouT.Learning.PracticalPattern.Concept.DependencyInjection.Tests
{
    [TestClass()]
    public class ClientTests
    {
        [TestMethod()]
        public void GetYearTest()
        {
            var client = new Client();
            Assert.IsTrue(client.GetYear() > 0);
        }
    }
}
