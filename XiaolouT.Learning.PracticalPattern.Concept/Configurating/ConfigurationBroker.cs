using System.Configuration;

namespace XiaolouT.Learning.PracticalPattern.Concept.Configurating
{
    public static class ConfigurationBroker
    {
        private static readonly ChapterConfigurationSectionGroup group;

        static ConfigurationBroker()
        {
            Configuration conifig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            group = (ChapterConfigurationSectionGroup)conifig.GetSectionGroup("practicalPattern.concept");
        }

        public static DelegatingParagramConfigurationSection Delegating
        {
            get
            {
                return group.Delegating;
            }
        }

        public static GenericsParagramConfigurationSection Generics
        {
            get
            {
                return group.Generics;
            }
        }
    }
}
