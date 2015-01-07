using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace XiaolouT.Learning.PracticalPattern.Common.Tests
{
    [TestClass]
    public class ConfigurationBrokerTests
    {
        [TestMethod]
        public void Test()
        {
            var builder= ConfigurationBroker.GetConfigurationObject<IObjectBuilder>();
            Assert.IsNotNull(builder);
        }

        
    }
}
