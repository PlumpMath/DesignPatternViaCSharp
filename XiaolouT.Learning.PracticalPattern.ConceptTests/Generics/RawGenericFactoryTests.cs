using NUnit.Framework;
namespace XiaolouT.Learning.PracticalPattern.Concept.Generics.Tests
{
    [TestFixture]
    public class RawGenericFactoryTests
    {
        interface IProduct
        {

        }

        class ConcreteProduct : IProduct
        {

        }

        [Test]
        public void CreateTest()
        {
            var typeName = typeof(ConcreteProduct).AssemblyQualifiedName;
            var product = RawGenericFactory.Create<IProduct>(typeName);
            Assert.AreEqual(typeName, product.GetType().AssemblyQualifiedName);
        }
    }
}
