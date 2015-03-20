using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XiaolouT.Learning.PracticalPattern.FactoryMethod.Batch.Tests
{
    [TestClass()]
    public class ClientTests
    {
        [TestMethod()]
        public void ProduceTest()
        {
            var client = new Client();
            var products = client.Produce();
            Assert.AreEqual(2 + 3, products.Length);
            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual("A", products[i].Name);
            }
            for (int i = 2; i < 5; i++)
            {
                Assert.AreEqual("B", products[i].Name);
            }
        }

    }
}
