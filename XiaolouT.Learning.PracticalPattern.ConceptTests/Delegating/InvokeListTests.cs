using NUnit.Framework;
namespace XiaolouT.Learning.PracticalPattern.Concept.Delegating.Tests
{
    [TestFixture]
    public class InvokeListTests
    {

        [Test]
        public void InvokeTest()
        {
            var message = string.Empty;
            var invokeList = new InvokeList();
            invokeList.Invoke();
            Assert.AreEqual("hello,world", invokeList[0] + invokeList[1] + invokeList[2]);
        }

    }
}
