using NUnit.Framework;
namespace XiaolouT.Learning.PracticalPattern.Concept.Attributes.Tests
{
    [TestFixture()]
    public class AttributedBuilderTests
    {
        [Test()]
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
