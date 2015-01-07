using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace XiaolouT.Learning.PracticalPattern.Concept.Delegating.Tests
{
    [TestClass]
    public class InvokeListTests
    {

        [TestMethod]
        public void InvokeTest()
        {
            var message = string.Empty;
            var invokeList = new InvokeList();
            invokeList.Invoke();
            Assert.AreEqual("hello,world", invokeList[0] + invokeList[1] + invokeList[2]);
        }

    }
}
