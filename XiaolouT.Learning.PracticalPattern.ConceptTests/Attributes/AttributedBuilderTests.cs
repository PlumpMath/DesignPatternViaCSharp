using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace XiaolouT.Learning.PracticalPattern.Concept.Attributes.Tests
{
    [TestClass]
    public class AttributedBuilderTests
    {
        [TestMethod]
        public void Test()
        {
            var builder = new AttributedBuilder();
            var director = new Director();
            director.BuildUp(builder);
            Assert.AreEqual("a", builder.Log[1]);
            Assert.AreEqual("b", builder.Log[0]);
        }


    }
}
