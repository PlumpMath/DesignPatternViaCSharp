
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XiaolouT.Learning.PracticalPattern.Concept.Generics.Tests
{
    [TestClass]
    public class RawGenericFactoryTests
    {
        interface IProduct
        {

        }

        class ConcreteProduct : IProduct
        {

        }

        [TestMethod]
        public void CreateTest()
        {
            var typeName = typeof(ConcreteProduct).AssemblyQualifiedName;
            var product = RawGenericFactory.Create<IProduct>(typeName);
            Assert.AreEqual(typeName, product.GetType().AssemblyQualifiedName);
        }
    }
}
