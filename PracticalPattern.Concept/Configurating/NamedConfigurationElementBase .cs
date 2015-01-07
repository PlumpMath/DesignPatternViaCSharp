using System.Configuration;

namespace XiaolouT.Learning.PracticalPattern.Concept.Configurating
{
    public abstract class NamedConfigurationElementBase : ConfigurationElement
    {
        private const string NameItem = "name";
        private const string DescriptionItem = "description";

        [ConfigurationProperty(NameItem, IsKey = true, IsRequired = true)]
        public virtual string Name
        {
            get
            {
                return base[NameItem] as string;
            }
        }

        [ConfigurationProperty(DescriptionItem, IsRequired = false)]
        public virtual string Decription
        {
            get
            {
                return base[DescriptionItem] as string;
            }
        }
    }
}
