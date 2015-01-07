using System.Configuration;

namespace XiaolouT.Learning.PracticalPattern.Concept.Configurating
{
    public class ChapterConfigurationSectionGroup : ConfigurationSectionGroup
    {
        private const string DelegatingItem = "delegating";
        private const string GenericsItem = "generics";

        [ConfigurationProperty(DelegatingItem, IsRequired = true)]
        public virtual DelegatingParagramConfigurationSection Delegating
        {
            get
            {
                return base.Sections[DelegatingItem] as DelegatingParagramConfigurationSection;
            }
        }

        [ConfigurationProperty(GenericsItem, IsRequired = true)]
        public virtual GenericsParagramConfigurationSection Generics
        {
            get
            {
                return base.Sections[GenericsItem] as GenericsParagramConfigurationSection;
            }
        }
    }
}
