using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace XiaolouT.Learning.PracticalPattern.FactoryMethod.Delegate.Tests
{
    [TestClass()]
    public class CalculateHandlerFactoryTests
    {
        [TestMethod()]
        public void CreateTest()
        {
            var factory = new CalculateHandlerFactory();
            var handler = factory.Create();
            Assert.AreEqual(1 + 2 + 3, handler(1, 2, 3));
        }
    }
}
