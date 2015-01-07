using System;
using System.Configuration;

namespace XiaolouT.Learning.PracticalPattern.Common
{
    public class ObjectBuilderConfigurationSource : ConfigurationSectionGroup, IConfigurationSource
    {
        public const string ObjectBuilderItem = "objectBuilder";


        [ConfigurationProperty(ObjectBuilderItem, IsRequired = true)]
        public ObjectBuilderConfigurationSection ObjectBuilder
        {
            get
            {
                return Sections[ObjectBuilderItem] as ObjectBuilderConfigurationSection;
            }
        }

        public void Load()
        {
            if (ObjectBuilder != null)
            {
                var type = System.Type.GetType(ObjectBuilder.Type);
                var instance = Activator.CreateInstance(type);
                ConfigurationBroker.Add(typeof(IObjectBuilder), instance);
            }
        }
    }
}
