
using System.Configuration;

namespace XiaolouT.Learning.PracticalPattern.Common
{
    public class ObjectBuilderConfigurationSection : ConfigurationSection
    {
        public const string TypeItem = "type";

        [ConfigurationProperty(TypeItem, IsRequired = true)]
        public string Type
        {
            get
            {
                return base[TypeItem].ToString();
            }
        }
    }
}
