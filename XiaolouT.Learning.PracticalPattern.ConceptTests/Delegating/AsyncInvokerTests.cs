using System.Threading;
using NUnit.Framework;
namespace XiaolouT.Learning.PracticalPattern.Concept.Delegating.Tests
{
    [TestFixture]
    public class AsyncInvokerTests
    {
        [Test]
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
