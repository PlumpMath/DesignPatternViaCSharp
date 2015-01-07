using System.Configuration;

namespace XiaolouT.Learning.PracticalPattern.Concept.Configurating
{
    public class PictureConfigurationElement : NamedConfigurationElementBase
    {
        private const string ColorizedItem = "colorized";

        [ConfigurationProperty(ColorizedItem, IsRequired = true)]
        public bool Colorized
        {
            get
            {
                return (bool)base[ColorizedItem];
            }
        }
    }
}