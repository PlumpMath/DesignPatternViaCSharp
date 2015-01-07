using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace XiaolouT.Learning.PracticalPattern.Concept.Delegating.Tests
{
    [TestClass]
    public class AsyncInvokerTests
    {
        [TestMethod]
        public void AsyncInvokerTest()
        {
            var asyncInvoker = new AsyncInvoker();
            Thread.Sleep(3000);
            Assert.AreEqual("method", asyncInvoker.Output[0]);
            Assert.AreEqual("fast", asyncInvoker.Output[1]);
            Assert.AreEqual("slow", asyncInvoker.Output[2]);
        }
    }
}
